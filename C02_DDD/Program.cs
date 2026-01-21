using C02_DDD.VOs;

// VO with factory method
var email = Email.Create("lucas@email.com");
var cpf = CPF.Create("12345678900");
Console.WriteLine(email);

var money1 = new Money(100, "BRL");
var money2 = new Money(300, "BRL");
var newMoney = Money.Sum(money1, money2);
Console.WriteLine(newMoney.Amount);
Console.WriteLine(newMoney.Currency);

var periodo = Periodo.Create(DateTime.Now, DateTime.Now.AddDays(10));
Console.WriteLine(periodo.DuracaoEmDias());

