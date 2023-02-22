namespace CSh10.ControlFlow;

public static class Sequences
{
  public static void DisplayListWithIndex_ForEach(IReadOnlyList<string> strings)
  {
    int i = 1;
    foreach (string s in strings)
    {
      Console.WriteLine($"{i++}: {s}");
    }
  }

  public static void DisplaySequence_ForEach(IEnumerable<string> strings)
  {
    foreach (string s in strings)
    {
      Console.WriteLine($"{s}...");
    }
  }
}