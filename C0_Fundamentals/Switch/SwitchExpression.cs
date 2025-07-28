namespace C0_Fundamentals.Switch;

public class SwitchExpression
{
    public static string Run(StatusPedido status) => status switch
    {
        StatusPedido.Processando => "Seu pedido está em processamento.",
        StatusPedido.Enviado => "Pedido enviado.",
        StatusPedido.Entregue => "Pedido entregue.",
        StatusPedido.Cancelado => "Pedido cancelado.",
        _ => "Status desconhecido."
    };

    public static string Run2(StatusPedido status)
    {
        var response = status switch
        {
            StatusPedido.Processando => "Seu pedido está em processamento.",
            StatusPedido.Enviado => "Pedido enviado.",
            StatusPedido.Entregue => "Pedido entregue.",
            StatusPedido.Cancelado => "Pedido cancelado.",
            _ => "Status desconhecido."
        };

        return response;
    }
}

public enum StatusPedido
{
    Processando,
    Enviado,
    Entregue,
    Cancelado
}