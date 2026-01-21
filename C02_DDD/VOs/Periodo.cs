namespace C02_DDD.VOs;

public record Periodo
{
    public DateTime DataInicio { get; }
    public DateTime DataFim { get; }

    private Periodo(DateTime dataInicio, DateTime dataFim)
    {
        DataInicio = dataInicio;
        DataFim = dataFim;
    }

    // Factory Method
    public static Periodo Create(DateTime dataInicio, DateTime dataFim)
    {
        if (dataInicio > dataFim)
            throw new ArgumentException("Data fim não pode ser maior que a data início.");

        return new Periodo(dataInicio, dataFim);
    }

    public int DuracaoEmDias() => DataFim.Subtract(DataInicio).Days;

    public bool Contem(DateTime data) => (data >= DataInicio && data <= DataFim);
}