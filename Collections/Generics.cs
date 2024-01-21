namespace Collections;

public class Generics
{
  /// <summary>
  /// Compares two parameters of the same type and checks if they are equal.
  /// </summary>
  /// <typeparam name="TParam">The type of the parameters.</typeparam>
  /// <param name="param1">The first parameter to compare.</param>
  /// <param name="param2">The second parameter to compare.</param>
  /// <exception cref="ArgumentException">Thrown when either <paramref name="param1"/> or <paramref name="param2"/> is null.</exception>
  public static void Compare<TParam>(TParam param1, TParam param2)
  {
    if (param1 is null || param2 is null) throw new ArgumentException("Argument exception error.");

    var result = param1.Equals(param2);

    Console.WriteLine($"Data types: {param1.GetType()} - {param2.GetType()}");
    Console.WriteLine(result ? $"{param1} is equals {param2}." : $"{param1} is not equals {param2}.");
  }

  /// <summary>
  /// Compares two parameters of the same value type and checks if they are equal.
  /// </summary>
  /// <typeparam name="TParam">The value type of the parameters.</typeparam>
  /// <param name="param1">The first parameter to compare.</param>
  /// <param name="param2">The second parameter to compare.</param>
  public static void CompareTypeSafety<TParam>(TParam param1, TParam param2) where TParam : struct
  {
    var result = param1.Equals(param2);

    Console.WriteLine($"Data types: {param1.GetType()} - {param2.GetType()}");
    Console.WriteLine(result ? $"{param1} is equals {param2}." : $"{param1} is not equals {param2}.");
  }
}