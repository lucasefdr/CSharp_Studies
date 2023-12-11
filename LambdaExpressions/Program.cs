var people = new List<Person> {
    new("John", 48),
    new("Bob", 14),
    new("Lucas", 25)
};

/* using func */
Func<Person, bool> IsAdultFunc = person => person.Age >= 18;
// var adults = people.Where(IsAdultFunc);

/* using delegate */
var isAdultDelegate = new IsAdultDelegate(IsAdult);
// var isAdultDelegate = (Person person) => person.Age >= 18;
// var adults = people.Where(person => isAdultDelegate(person));

/* using lambda expression */
// var adults = people.Where(person => IsAdult(person));
// var adults = people.Where(person => person.Age >= 18);
var adults = people.Where(IsAdult);

// --------------------------------------------------
// var canDrink = CanDrink(IsAdultFunc, people[0]);
var canDrink = CanDrink(IsAdult, people[0]);

Console.WriteLine(canDrink);


/* Classes and methods */
bool IsAdult(Person person) => person.Age >= 18;
bool CanDrink(Func<Person, bool> isAdult, Person person) => isAdult(person);

delegate bool IsAdultDelegate(Person person);

class Person(string name, int age)
{
    public string Name { get; set; } = name;
    public int Age { get; set; } = age;
}