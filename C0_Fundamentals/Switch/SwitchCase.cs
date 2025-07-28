namespace C0_Fundamentals.Switch;

public class SwitchCase
{
    public static void Run(string option)
    {
        /*
         * 1 - Ver Saldo
         * 2 - Fazer Depósito
         * 3 - Fazer Saque
         */
        switch (option)
        {
            case "1":
                Console.WriteLine("Seu saldo é de R$ 1.000,00.");
                break;
            case "2":
                Console.WriteLine("Depósito realizado com sucesso!");
                break;
            case "3":
                Console.WriteLine("Saque realizado com sucesso!");
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
}