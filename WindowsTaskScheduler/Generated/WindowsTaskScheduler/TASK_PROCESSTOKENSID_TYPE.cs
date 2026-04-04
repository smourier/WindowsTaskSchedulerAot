#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/ne-taskschd-task_processtokensid_type
public enum TASK_PROCESSTOKENSID_TYPE
{
    TASK_PROCESSTOKENSID_NONE = 0,
    TASK_PROCESSTOKENSID_UNRESTRICTED = 1,
    TASK_PROCESSTOKENSID_DEFAULT = 2,
}
