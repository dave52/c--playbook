using System.Reflection;
using CSh10.ControlFlow;
using CSh10.MethodsProps;


// ControlFlow - 1 - Sequences
// List<string> languages = new() {"C#", "F#", "VB", "C++", "Python" };
// Sequences.DisplayListWithIndex_ForEach(languages);
// Sequences.DisplaySequence_ForEach(languages);

// ControlFLow - 2 - FolderProcessor
// string filePath = Assembly.GetEntryAssembly()!.Location;
// FolderProcessor.DisplayParentNames_While(filePath);

// foreach(string folder in FolderProcessor.EnumParentNames_While(filePath).Reverse())
// {
//   Console.WriteLine(folder);
// }
// foreach(string folder in FolderProcessor.EnumParentNames_For(filePath).Reverse())
// {
//   Console.WriteLine(folder);
// }
// foreach(string folder in FolderProcessor.EnumParentNames_Do(filePath).Reverse())
// {
//   Console.WriteLine(folder);
// }


// MethodsProps - 1 - CookieCustomer
// CookieCustomer customer = new (0, "");
// char firstChar = customer.NameFirstChar;
// Console.Write(firstChar);

// MethodsProps - 2 - Sales
CookieCustomer pluralsight = new(1, "Pluralsight");
var simon = new CookieCustomer(2, "Simon the soon-to-be-overweight");
CookieCustomer browserRobot = new(3, "Browser Robot");

SaleList sales = new();
sales.AddSale(new(simon, 200))
  .AddSale(new(pluralsight, 80))
  .AddSale(new(browserRobot, 500))
  .AddSale(new(pluralsight, 1000))
  .AddSale(new(simon, 200));

// var highValueSales = sales.EnumerateItems()
//     .Where(sale => sale.Value > 100)
//     .OrderBy(sale => sale.Customer.Name);

// value tuple consumption destructuring
// (string thing, decimal totalValue, int nSales) = sales.GetHighestValueCustomer();
// Console.WriteLine($"{thing} spent {totalValue} in {nSales} purchases");

// value tuple consumption returning a ValueTuple type set to a var
// var highest = sales.GetHighestValueCustomer();
// Console.WriteLine($"{highest.CustomerName} spent {highest.TotalSpent} in {highest.NSales} purchases");

// out value consumption
// var name = sales.GetHighestValueCustomer(out decimal totalValue, out int nSales);
// Console.WriteLine($"{name} spent {totalValue} in {nSales} purchases");
// int.TryParse("32", out int myNewVar);
// Console.WriteLine(myNewVar);

// bool eligible = BusinessRules.EligibleForVoucher(nSales, in totalValue);
// Console.WriteLine($"Is {name} eligible for voucher? {eligible}");

Console.WriteLine("IntPtr.Size = ", IntPtr.Size);
Console.WriteLine("sizeof(int) = ", sizeof(int));
Console.WriteLine("sizeof(decimal) = ", sizeof(decimal));
