using System.Runtime.Serialization;

namespace C0_Fundamentals.Enums;

[Flags] // Obrigatório para o C# tratar como combinação
public enum Permissoes
{
    Nenhuma = 0, // 0000
    Leitura = 1, // 0001 (2ˆ0)
    Escrita = 2, // 0010 (2ˆ1)
    Exclusao = 4, // 0100 (2ˆ2)
    Execucao = 8, // 1000 (2ˆ3)
    // O próximo seria 16, 32, 64...
    
    // Atalhos comuns (Combos)
    Tudo = Leitura | Escrita | Exclusao | Execucao,
}