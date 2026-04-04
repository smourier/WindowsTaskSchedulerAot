#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/mstask/ns-mstask-daily
public partial struct DAILY : IEquatable<DAILY>, IValueGet<ushort>
{
    public static readonly DAILY Null = new();
    
    public ushort DaysInterval;
    
    public DAILY(ushort value) => this.DaysInterval = value;
    public override readonly string ToString() => $"0x{DaysInterval:x}";
    
    public override readonly bool Equals(object? obj) => obj is DAILY value && Equals(value);
    public readonly bool Equals(DAILY other) => other.DaysInterval == DaysInterval;
    public override readonly int GetHashCode() => DaysInterval.GetHashCode();
    public static bool operator ==(DAILY left, DAILY right) => left.Equals(right);
    public static bool operator !=(DAILY left, DAILY right) => !left.Equals(right);
    public static implicit operator ushort(DAILY value) => value.DaysInterval;
    public static implicit operator DAILY(ushort value) => new(value);
    
    readonly ushort IValueGet<ushort>.GetValue() => DaysInterval;
    readonly object? IValueGet.GetValue() => DaysInterval;
}
