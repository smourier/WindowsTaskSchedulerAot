#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/ne-taskschd-task_run_flags
public enum TASK_RUN_FLAGS
{
    TASK_RUN_NO_FLAGS = 0,
    TASK_RUN_AS_SELF = 1,
    TASK_RUN_IGNORE_CONSTRAINTS = 2,
    TASK_RUN_USE_SESSION_ID = 4,
    TASK_RUN_USER_SID = 8,
}
