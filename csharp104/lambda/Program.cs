#region simple lambda
// Define a lambda expression that doubles an integer
Func<int, int> doubleFunc = x => x * 2;

// Use the lambda expression to double a number
int num = 5;
int doubledNum = doubleFunc(num);

// Print the results
Console.WriteLine($"The double of {num} is {doubledNum}.");
#endregion

#region lambda for sort
int[] numbers = { 5, 2, 8, 1, 9, 4 };

// Sort the numbers array using a lambda expression
Array.Sort(numbers, (x, y) => x.CompareTo(y));

// Print the sorted array
Console.WriteLine("Sorted array:");
foreach (int number in numbers)
{
  Console.WriteLine(number);
}
#endregion

#region getters, setters
Person person = new Person();

// Set the person's name using the property
person.Name = "Alice";

// Print the person's name using the property
Console.WriteLine($"Person's name is {person.Name}.");
#endregion

#region lambda without return
List<string> fruits = new List<string> { "apple", "banana", "cherry" };

// Use a lambda expression to specify an action to perform on each element
fruits.ForEach(fruit => Console.WriteLine(fruit));
#endregion

#region lambda with a return
List<int> empids = new List<int> { 1001, 1052, 1032, 5020, 1080 };

// Use a lambda expression to specify a condition for finding an element
int intern = empids.Find(num => num > 5000);

Console.WriteLine($"The first intern in the list is: {intern}");
#endregion
