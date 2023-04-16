int Add(int a, int b)
{
  System.Console.WriteLine("Named method called");
  return a + b;
}

Func<int, int, int> anonymousMethod =
  (int a, int b) =>
  {
    System.Console.WriteLine("Anonymous method called");
    return a + b;
  };

var addMethod = Add;


var result1 = addMethod(3, 2);
var result2 = anonymousMethod(3, 2);
var result3 = Add(3, 2);

System.Console.WriteLine($"{result1}, {result2}");
