/* This example shows how to use delegates in C#. */
static double AverageCalculator(double a, double b) => (a + b) / 2;

static double MultiplyCalculator(double a, double b) => a * b;

double result;

// Delegate instantiation
Calculator calculator = new Calculator(AverageCalculator);
result = calculator(10, 20);
Console.WriteLine("Average: {0}", result);

// Delegate instantiation
calculator = MultiplyCalculator;
result = calculator(10, 20);
Console.WriteLine("Multiply: {0}", result);

// Multicast delegate
Calculator multicastCalculator = (a, b) => a + b;
result = multicastCalculator(10, 20);
Console.WriteLine("Sum: {0}", result);

// Add method to invocation list
multicastCalculator += (a, b) => a - b;
result = multicastCalculator(20, 10);
Console.WriteLine("Subtract: {0}", result);

multicastCalculator.GetInvocationList().ToList().ForEach(x =>
{
    Console.WriteLine("Method: {0}", x.Method);
    Console.WriteLine("Target: {0}", x.Target);
    Console.WriteLine("Result: {0}", x.DynamicInvoke(10, 20));
});


// Delegate declaration
delegate double Calculator(double a, double b);
