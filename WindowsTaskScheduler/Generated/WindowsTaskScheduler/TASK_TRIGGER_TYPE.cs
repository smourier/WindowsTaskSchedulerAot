#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/mstask/ne-mstask-task_trigger_type
public enum TASK_TRIGGER_TYPE
{
    TASK_TIME_TRIGGER_ONCE = 0,
    TASK_TIME_TRIGGER_DAILY = 1,
    TASK_TIME_TRIGGER_WEEKLY = 2,
    TASK_TIME_TRIGGER_MONTHLYDATE = 3,
    TASK_TIME_TRIGGER_MONTHLYDOW = 4,
    TASK_EVENT_TRIGGER_ON_IDLE = 5,
    TASK_EVENT_TRIGGER_AT_SYSTEMSTART = 6,
    TASK_EVENT_TRIGGER_AT_LOGON = 7,
}
