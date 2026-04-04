#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/mstask/ns-mstask-task_trigger
public partial struct TASK_TRIGGER
{
    public ushort cbTriggerSize;
    public ushort Reserved1;
    public ushort wBeginYear;
    public ushort wBeginMonth;
    public ushort wBeginDay;
    public ushort wEndYear;
    public ushort wEndMonth;
    public ushort wEndDay;
    public ushort wStartHour;
    public ushort wStartMinute;
    public uint MinutesDuration;
    public uint MinutesInterval;
    public uint rgFlags;
    public TASK_TRIGGER_TYPE TriggerType;
    public TRIGGER_TYPE_UNION Type;
    public ushort Reserved2;
    public ushort wRandomMinutesInterval;
}
