namespace CSh10.MethodsProps;

public class SaleList
{
  private List<Sale> _sales = new();

  // public (string CustomerName, decimal TotalSpent, int NSales) GetHighestValueCustomer()
  // {
  //   var customersBySpend = from transaction in _sales
  //                          group transaction by transaction.Customer into grouping
  //                          let totalValue = grouping.Select(x => x.Value).Sum()
  //                          let salesCount = grouping.Count()
  //                          orderby totalValue descending
  //                          select (grouping.Key.Name, totalValue, salesCount);
  //   return customersBySpend.First();
  // }
  public string GetHighestValueCustomer(out decimal totalSpent, out int nTransactions) 
  {
    var customersBySpend = from transaction in _sales
                           group transaction by transaction.Customer into grouping
                           let totalValue = grouping.Select(x => x.Value).Sum()
                           let salesCount = grouping.Count()
                           orderby totalValue descending
                           select (grouping.Key.Name, totalValue, salesCount);
          var result = customersBySpend.First();
          totalSpent = result.totalValue;
          nTransactions = result.salesCount;
          return result.Name;
  }

  public IEnumerable<Sale> EnumerateItems()
  {
    foreach (var item in _sales)
      yield return item;
  }

  public SaleList AddSale(Sale item)
  {
    _sales.Add(item);
    return this;
  }
}