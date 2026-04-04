#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/mstask/ns-mstask-monthlydate
public partial struct MONTHLYDATE
{
    public uint rgfDays;
    public ushort rgfMonths;
}
