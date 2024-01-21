using Collections;

Console.WriteLine("What do you want to test?");
Console.WriteLine("1 - Generics");
var option = Console.ReadLine();

switch (option)
{
    case "1":
        Generics.Compare(10, 10);
        Generics.Compare("string", "string");
        Generics.Compare(true, true);
        Generics.Compare(10.78852, 10.78852);
        Generics.CompareTypeSafety(10, 10);
        Generics.CompareTypeSafety(10.78852, 10.78852);
        Generics.CompareTypeSafety(true, true);
        // Generics.CompareTypeSafety("string", "string"); // Error CS0453  The type 'string' must be a non-nullable value type in order to use it as parameter 'TParam' in the generic type or method 'Generics.CompareTypeSafety<TParam>(TParam, TParam)'
        break;
    default:
        Console.WriteLine("Invalid option.");
        break;
}