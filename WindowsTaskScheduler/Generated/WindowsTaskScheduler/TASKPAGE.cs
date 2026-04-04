#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/mstask/ne-mstask-taskpage
public enum TASKPAGE
{
    TASKPAGE_TASK = 0,
    TASKPAGE_SCHEDULE = 1,
    TASKPAGE_SETTINGS = 2,
}
