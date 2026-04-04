#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/ne-taskschd-task_runlevel_type
public enum TASK_RUNLEVEL_TYPE
{
    TASK_RUNLEVEL_LUA = 0,
    TASK_RUNLEVEL_HIGHEST = 1,
}
