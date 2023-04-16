using System;
using System.Collections.Generic;

namespace DelegateExample
{
  class Calculator
  {
    // public delegate int MathOperation(int x, int y);

    public int Operate(Func<int, int, int> op, int x, int y)
    {
      return op(x, y);
    }
  }

  class Test
  {
    public static void Execute()
    {
      Calculator calculator = new Calculator();

      // Pass a lambda expression as a MathOperation delegate into the Operate method
      calculator.Operate((x, y) => { return x + y; }, 10, 20);
      calculator.Operate((x, y) => x + y, 10, 20);
      calculator.Operate(Add, 10, 20);
    }

    public static int Add(int x, int y)
    {
      return x + y;
    }
  }
}
