#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/mstask/ns-mstask-monthlydow
public partial struct MONTHLYDOW
{
    public ushort wWhichWeek;
    public ushort rgfDaysOfTheWeek;
    public ushort rgfMonths;
}
