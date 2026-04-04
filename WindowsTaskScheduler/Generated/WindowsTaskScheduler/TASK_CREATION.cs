#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/ne-taskschd-task_creation
public enum TASK_CREATION
{
    TASK_VALIDATE_ONLY = 1,
    TASK_CREATE = 2,
    TASK_UPDATE = 4,
    TASK_CREATE_OR_UPDATE = 6,
    TASK_DISABLE = 8,
    TASK_DONT_ADD_PRINCIPAL_ACE = 16,
    TASK_IGNORE_REGISTRATION_TRIGGERS = 32,
}
