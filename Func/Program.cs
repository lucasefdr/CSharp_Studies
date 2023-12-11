/* Func = Generic delegate */
double DoubleAverage(double a, double b) => (a + b) / 2;
int IntAverage(int a, int b) => (a + b) / 2;

// Func delegate
Func<double, double, double> doubleAverage = DoubleAverage;
double resultDouble = doubleAverage(10.77, 20.25);
Console.WriteLine("Double sum: {0}", resultDouble);

Func<int, int, int> intAverage = IntAverage;
int resultInt = intAverage(1550, 200);
Console.WriteLine("Int sum: {0}", resultInt);

// Func delegate 
Func<double, double> square = x => x * x;
Console.WriteLine("Square: {0}", square(10));
