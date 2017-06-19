export class Field {
  name: string
  type: string
}

export class Resource {
  name: string
  fields: Field[] = [ ]
  extends?: Resource | string
}
