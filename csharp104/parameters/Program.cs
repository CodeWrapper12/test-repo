#region Positional parameters
void DoSomething1(int x, string y, bool z)
{
  // method body
}

// calling the method with positional parameters
DoSomething1(42, "hello", true);
#endregion 

#region Named parameters
void DoSomething2(int x, string y, bool z)
{
  // method body
}

// calling the method with named parameters
DoSomething2(x: 42, y: "hello", z: true);
#endregion

#region Optional parameters
void DoSomething3(int x, string y = "world", bool z = false)
{
  // method body
}

// calling the method with optional parameters
DoSomething3(42); // y will be "world" and z will be false
DoSomething3(42, "hello"); // z will be false
DoSomething3(42, z: true); // y will be "world"
#endregion

#region Variable-length parameter list
void DoSomething4(params int[] values)
{
  // method body
}

// calling the method with variable-length parameter lists
DoSomething4(1, 2, 3); // values will be an array of [1, 2, 3]
DoSomething4(); // values will be an empty array
#endregion

#region ref parameters
void DoSomething5(ref int x)
{
  x = x * 2;
}

// calling the method with ref parameters
int y = 10;
DoSomething5(ref y); // y will now be 20
#endregion

#region out parameters
bool TryParse(string input, out int result)
{
  if (int.TryParse(input, out result))
  {
    return true;
  }
  else
  {
    result = 0;
    return false;
  }
}

// calling the method with out parameters
string input = "42";
if (TryParse(input, out int value))
{
  Console.WriteLine($"The parsed value is {value}");
}
else
{
  Console.WriteLine("Invalid input");
}
#endregion

#region in parameters
void DoSomething6(in int x)
{
  // can't modify x inside this method
}

// calling the method with in parameters
int z = 42;
DoSomething6(in z);
#endregion

#region pointer parameters
// unsafe
// {
//   void DoSomething7(int* x)
//   {
//     *x = *x * 2;
//   }

//   // calling the method with pointer parameters
//   int a = 10;
//   DoSomething7(&a); // y will now be 20
// }
#endregion

#region tuple parameters
void DoSomething8((int x, int y) values)
{
  int sum = values.x + values.y;
  Console.WriteLine($"The sum of {values.x} and {values.y} is {sum}");
}

// calling the method with tuple parameters
DoSomething8((3, 4)); // prints "The sum of 3 and 4 is 7"
#endregion

#region Delegate parameters
void DoSomething11(int x, int y, Func<int, int, int> operation)
{
  int result = operation(x, y);
  Console.WriteLine($"The result of the operation is {result}");
}

// calling the method with a delegate parameter
DoSomething11(3, 4, (a, b) => a + b); // prints "The result of the operation is 7"
#endregion

#region extension method parameters
// calling the extension method
string inputPalindrome = "racecar";
if (inputPalindrome.IsPalindrome())
{
  Console.WriteLine("The input is a palindrome");
}
else
{
  Console.WriteLine("The input is not a palindrome");
}

public static class StringExtensions
{
  public static bool IsPalindrome(this string s)
  {
    return s.SequenceEqual(s.Reverse());
  }
}
#endregion