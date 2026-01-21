namespace C00_Fundamentals.Switch;

public class SwitchPatternMatching
{
    public static void RunTypePattern(Forma forma)
    {
        var area = CalcularArea(forma);
        Console.WriteLine($"Área calculada: {area}");
    }

    public static void RunWhenCondition(Forma forma)
    {
        var descricao = DescreverForma(forma);
        Console.WriteLine(descricao);
    }

    public static void RunPropertyPattern(Pessoa pessoa)
    {
        var frete = CalcularFrete(pessoa);
        Console.WriteLine($"O valor do frete para {pessoa.Endereco.Estado} é {frete:C}");
    }

    public static void RunTuplePattern(Jogada jogador1, Jogada jogador2)
    {
        var resultado = AvaliarResultado(jogador1, jogador2);
        Console.WriteLine(resultado);
    }

    public static void RunRelationalPattern(double temperaturaCelsius)
    {
        var avaliacao = AvaliarTemperatura(temperaturaCelsius);
        Console.WriteLine($"O clima está {avaliacao}");
    }

    public static void RunListPattern(string[] args)
    {
        var processamento = ProcessarComandos(args);
        Console.WriteLine(processamento);
    }

    // === Type Pattern ===
    private static double CalcularArea(Forma forma) => forma switch
    {
        Retangulo r => r.Altura * r.Largura,
        Circulo c => Math.PI * c.Raio * c.Raio,
        Quadrado q => q.Base * q.Altura / 2,
        _ => throw new ArgumentOutOfRangeException(nameof(forma), "Forma desconhecida")
    };

    // === Condicionais com when ===
    private static string DescreverForma(Forma forma) => forma switch
    {
        Circulo c when c.Raio == 0 => "É um ponto",
        Circulo c => $"É um círculo com raio {c.Raio}",

        Retangulo r when Math.Abs(r.Altura - r.Largura) < 0.1 => $"É um quadrado de lado {r.Largura}",
        Retangulo r => $"É um retângulo com largura {r.Largura} por {r.Altura} de altura",

        null => "A forma é nula",
        _ => throw new ArgumentOutOfRangeException(nameof(forma), "Forma desconhecida")
    };

    // === Property Pattern ===
    private static decimal CalcularFrete(Pessoa pessoa) => pessoa switch
    {
        { Endereco.Estado: "SP" } => 10.0m,
        { Endereco.Estado: "RJ" } => 12.0m,
        { Endereco.Estado: "MG" } => 15.0m,
        _ => 20.0m
    };

    // === Tuple Pattern ===
    private static string AvaliarResultado(Jogada jogador1, Jogada jogador2) => (jogador1, jogador2) switch
    {
        (Jogada.Pedra, Jogada.Tesoura)
            or (Jogada.Papel, Jogada.Pedra)
            or (Jogada.Tesoura, Jogada.Papel) => "Jogador 1 venceu",

        (Jogada.Pedra, Jogada.Papel)
            or (Jogada.Papel, Jogada.Tesoura)
            or (Jogada.Tesoura, Jogada.Pedra)
            => "Jogador 2 venceu",

        var (j1, j2) when j1 == j2 => "Empate",

        _ => "Jogada inesperada"
    };

    // === Relational Pattern ===
    private static string AvaliarTemperatura(double temperaturaCelsius) => temperaturaCelsius switch
    {
        < 0 => "Congelante",
        0 => "Ponto de congelamento",
        > 0 and <= 15 => "Frio",
        > 15 and <= 25 => "Agradável",
        > 25 and <= 35 => "Quente",
        > 35 => "Muito quente",
        double.NaN => "Inválido"
    };

    // === List Pattern ===
    private static string ProcessarComandos(string[] args) => args switch
    {
        [] => "Nenhum comando fornecido",
        ["--help"] => "Exibindo ajuda...",
        ["--version", ..] => "Versão 1.0", // Ignora o resto dos argumentos
        ["commit", var mensagem] => $"Commitando com a mensagem '{mensagem}'",
        ["clone", var url, var dir] => $"Clonando de {url} para {dir}",
        [var primeiro, ..] when primeiro.StartsWith("-") => "Opção inválida: {primeiro}",
        _ => "Comando desconhecido"
    };
}

public abstract class Forma
{
}

public sealed class Retangulo : Forma
{
    public double Altura { get; set; }
    public double Largura { get; set; }
}

public sealed class Circulo : Forma
{
    public double Raio { get; set; }
}

public sealed class Quadrado : Forma
{
    public double Base { get; set; }
    public double Altura { get; set; }
}

public class Endereco
{
    public required string Estado { get; set; }
}

public sealed class Pessoa
{
    public required string Nome { get; set; }
    public required Endereco Endereco { get; set; }
}

public enum Jogada
{
    Pedra,
    Papel,
    Tesoura
}