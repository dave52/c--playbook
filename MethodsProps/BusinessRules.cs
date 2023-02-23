namespace CSh10.MethodsProps;

public class BusinessRules
{
  public static bool EligibleForVoucher(int nPurchases, in decimal biggestPurchases)
    => nPurchases > 5 && biggestPurchases > 100m;
  // public static bool EligibleForVoucher(int nPurchases, in decimal biggestPurchases)
  // {
  //   biggestPurchases = 900;
  //   return nPurchases > 5 && biggestPurchases > 100m;
  // }
  // public static bool EligibleForVoucher(int nPurchases, ref decimal biggestPurchases)
  // {
  //   biggestPurchases = 900;
  //   return nPurchases > 5 && biggestPurchases > 100m;
  // }
}