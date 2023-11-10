#region VARIABLES

string name = "Lucas";
int age = 25;
bool isAlive = true;
double height = 1.75;
double weight = 84.5;

// out var
if (int.TryParse("1997", out var parsedValue)) Console.WriteLine($"Parsed value: {parsedValue}");

// dynamic var
dynamic dynamicVar;
dynamicVar = 1;
Console.WriteLine($"Dynamic var: {dynamicVar}");

// const
const double PI = 3.1415;
Console.WriteLine($"PI: {PI}");
#endregion

#region STRINGS

// verbatim string
string verbatimString = @"This is a verbatim string. It can span multiple lines and escape characters like \n are ignored.";
Console.WriteLine(verbatimString);

// string interpolation
string stringInterpolation = $"My name is {name} and I am {age} years old. I am {(isAlive ? "alive" : "dead")} and I am {height}m tall and weigh {weight}kg.";
Console.WriteLine(stringInterpolation);

#endregion