namespace C0_Fundamentals.Enums;

[Flags]
public enum FileAccess
{
    None = 0,
    Read = 1,
    Write = 2,
    Execute = 4,
    
}