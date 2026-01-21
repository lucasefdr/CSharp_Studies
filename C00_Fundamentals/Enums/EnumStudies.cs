using System.Globalization;

namespace C00_Fundamentals.Enums;

public class EnumStudies
{
    public static void Run()
    {
        var enumStudies = new EnumStudies();

        /* === Conversão de enums === */
        const string entrada = "finaLIZADO";

        // TryParse: tenta converter para enum; se sucesso, cria uma nova variável (enum) statusPedido
        Console.WriteLine(Enum.TryParse<StatusPedido>(entrada, true, out var statusPedido)
            ? $"Status encontrado: {statusPedido}"
            : "Status inválido");

        /* === Iteração nos valores de um enum === */
        var listaStatus = Enum.GetValues<StatusPedido>();
        foreach (var status in listaStatus)
        {
            Console.WriteLine($"Status: {status.ToString()}");
        }

        /* === Enum com switch === */
        const StatusPedido statusNovoPedido = StatusPedido.Finalizado;
        var valSwitch = statusNovoPedido switch
        {
            StatusPedido.Cancelado => 0,
            StatusPedido.Processando => 1,
            StatusPedido.Finalizado => 2,
            _ => throw new ArgumentOutOfRangeException(nameof(statusNovoPedido), statusNovoPedido, null)
        };
        
        /* === Bitwise enum + Flags === */
        const Permissoes acessoExecucao = Permissoes.Execucao;
        const Permissoes acessoTotal = Permissoes.Tudo;

        Console.WriteLine(acessoExecucao);
        Console.WriteLine(acessoTotal);
        
        // Adicionar permissão 
        var minhasPermissoes = Permissoes.Leitura | Permissoes.Escrita;
        Console.WriteLine(minhasPermissoes);
        
        // Verificar permissão 
        var podeLer = (minhasPermissoes & Permissoes.Leitura) == Permissoes.Leitura;
        var podeLerFlag = minhasPermissoes.HasFlag(Permissoes.Leitura);
        
        // Remover permissão
        minhasPermissoes = minhasPermissoes & ~Permissoes.Leitura;

        enumStudies.FileAccessRun();

        /* === Validação defensiva com IsDefined === */
        const byte novoStatusId1 = 1;
        const byte novoStatusId99 = 99;

        var novoStatusPedido = enumStudies.AlterarStatusPedido(novoStatusId1);

        Console.WriteLine($"Status pedido: {novoStatusPedido.ToString()}");

        // Lança exceção por conta do IsDefined
        enumStudies.AlterarStatusPedido(novoStatusId99);
    }

    private StatusPedido AlterarStatusPedido(byte novoStatusId)
    {
        // IsDefined: verifica se o inteiro existe dentro da definição do enum
        if (!Enum.IsDefined(typeof(StatusPedido), novoStatusId))
        {
            throw new ArgumentException("Status ID não existe");
        }

        return (StatusPedido)novoStatusId;
    }

    private string ProximaAcao(Semaforo semaforo) => semaforo switch
    {
        Semaforo.Vermelho => "Pare",
        Semaforo.Amarelo => "Atenção",
        Semaforo.Verde => "Siga",
        _ => throw new ArgumentOutOfRangeException(nameof(semaforo), semaforo, "Estado Inválido")
    };

    private void FileAccessRun()
    {
        var userPermissions = FileAccess.Read; // Cria com Read
        userPermissions = userPermissions | FileAccess.Write; // Adiciona Write
        var canExecute = userPermissions.HasFlag(FileAccess.Execute); // Valida Execute
        var canWrite = userPermissions.HasFlag(FileAccess.Write); // Valida Write
        userPermissions = userPermissions & ~FileAccess.Read; // Remove Read
        Console.WriteLine($"Permissions: {userPermissions}");
    }
}