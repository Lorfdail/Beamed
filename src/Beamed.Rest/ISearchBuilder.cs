namespace Beamed.Rest {
  public interface ISearchBuilder {
    string BuildQuery();
    string GetOrderQuery();
    string GetWhereQuery();
    string GetFieldsQuery();
  }
}