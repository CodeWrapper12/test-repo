using DelegateExample;
class Program
{
  delegate void MyDelegate(string message);

  public static void Main(string[] args)
  {
    MyDelegate del = Console.WriteLine;

    del("Hello, world!");

    Test.Execute();
  }
}

