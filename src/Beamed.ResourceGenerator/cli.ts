import { promisify } from 'util'
import { JSDOM, DOMWindow } from 'jsdom'
import * as fs from 'fs'
import * as minimist from 'minimist'
import axios from 'axios'

import { Resource, Field } from './Resource'

const getMixerDocs = async () =>
  (await axios('https://dev.mixer.com/rest.html')).data

function scrapResources (document: Document): any {
  const result: Resource[] = [ ]

  const panels = Array.from(document.querySelectorAll('.panel .panel-heading'))
    .filter((heading) => !heading.firstElementChild.innerHTML.startsWith('/'))
    .map((heading) => heading.parentElement)

  function getFieldsFor (panel: HTMLElement): Field[] {
    return Array.from(panel.querySelectorAll('.panel-body > ul > li'))
      .map((prop) => {
        console.log(prop.querySelector('.title small').textContent)

        return <Field>{
          name: prop.querySelector('.title span').innerHTML,
          type: prop.querySelector('.title small').textContent
        }
      })
  }

  const resources = panels
    .map((panel) => <Resource>{
      name: panel.firstElementChild.id,
      fields: getFieldsFor(panel),
      extends: panel.querySelector('.panel-title').childElementCount ?
        panel.querySelector('.panel-title small a').innerHTML :
        null
    })

  // console.log(resources.map((r) => r.fields))
}

async function main () {
  const args = minimist(process.argv.slice(2))

  console.log('* getting Mixer docs')

  const docsHtml = await getMixerDocs()

  console.log('* got Mixer docs\' HTML, loading DOM')

  const { window } = new JSDOM(docsHtml)
  const { document } = window

  console.log('* DOM loaded, scrapping resources')

  const resources: Resource[] = scrapResources(document)

  console.log('* resources scrapped, generating code')
}

main()

process.on('unhandledRejection', (error) => {
  console.log(error)
})
