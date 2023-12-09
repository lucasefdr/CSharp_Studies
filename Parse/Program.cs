using Parse;

Console.WriteLine("Studies");
Studies.ParseStudies(strNumber: "70");
Studies.TryParseStudies(strDate: "31-12-1997");
Studies.TryParseEnumStudies(strAnimalEnum: "Cat");

Console.WriteLine("\nExercises");
Exercises.NumericParsing();
Exercises.DateParsing();
Exercises.DayOfWeekParsing();