public class Program
{
  public static int Add(int a, int b) { return a + b; }
  public static string Add(string a, string b) { return a + b; }

  public static void Main(string[] args)
  {
    var r1 = Add(2, 3);
    var r2 = Add("a", "b");

    System.Console.WriteLine($"{r1}, {r2}");
  }
}
