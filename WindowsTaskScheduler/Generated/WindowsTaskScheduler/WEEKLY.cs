#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/mstask/ns-mstask-weekly
public partial struct WEEKLY
{
    public ushort WeeksInterval;
    public ushort rgfDaysOfTheWeek;
}
