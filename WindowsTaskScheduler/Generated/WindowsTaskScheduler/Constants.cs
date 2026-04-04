#nullable enable
namespace WindowsTaskScheduler;

public static partial class Constants
{
    public static readonly Guid CLSID_CTask = new("148bd520-a2ab-11ce-b11f-00aa00530503");
    
    public static readonly Guid CLSID_CTaskScheduler = new("148bd52a-a2ab-11ce-b11f-00aa00530503");
    
    public const uint TASK_APRIL = 8;
    
    public const uint TASK_AUGUST = 128;
    
    public const uint TASK_DECEMBER = 2048;
    
    public const uint TASK_FEBRUARY = 2;
    
    public const uint TASK_FIRST_WEEK = 1;
    
    public const uint TASK_FLAG_DELETE_WHEN_DONE = 2;
    
    public const uint TASK_FLAG_DISABLED = 4;
    
    public const uint TASK_FLAG_DONT_START_IF_ON_BATTERIES = 64;
    
    public const uint TASK_FLAG_HIDDEN = 512;
    
    public const uint TASK_FLAG_INTERACTIVE = 1;
    
    public const uint TASK_FLAG_KILL_IF_GOING_ON_BATTERIES = 128;
    
    public const uint TASK_FLAG_KILL_ON_IDLE_END = 32;
    
    public const uint TASK_FLAG_RESTART_ON_IDLE_RESUME = 2048;
    
    public const uint TASK_FLAG_RUN_IF_CONNECTED_TO_INTERNET = 1024;
    
    public const uint TASK_FLAG_RUN_ONLY_IF_DOCKED = 256;
    
    public const uint TASK_FLAG_RUN_ONLY_IF_LOGGED_ON = 8192;
    
    public const uint TASK_FLAG_START_ONLY_IF_IDLE = 16;
    
    public const uint TASK_FLAG_SYSTEM_REQUIRED = 4096;
    
    public const uint TASK_FOURTH_WEEK = 4;
    
    public const uint TASK_FRIDAY = 32;
    
    public const uint TASK_JANUARY = 1;
    
    public const uint TASK_JULY = 64;
    
    public const uint TASK_JUNE = 32;
    
    public const uint TASK_LAST_WEEK = 5;
    
    public const uint TASK_MARCH = 4;
    
    public const uint TASK_MAX_RUN_TIMES = 1440;
    
    public const uint TASK_MAY = 16;
    
    public const uint TASK_MONDAY = 2;
    
    public const uint TASK_NOVEMBER = 1024;
    
    public const uint TASK_OCTOBER = 512;
    
    public const uint TASK_SATURDAY = 64;
    
    public const uint TASK_SECOND_WEEK = 2;
    
    public const uint TASK_SEPTEMBER = 256;
    
    public const uint TASK_SUNDAY = 1;
    
    public const uint TASK_THIRD_WEEK = 3;
    
    public const uint TASK_THURSDAY = 16;
    
    public const uint TASK_TRIGGER_FLAG_DISABLED = 4;
    
    public const uint TASK_TRIGGER_FLAG_HAS_END_DATE = 1;
    
    public const uint TASK_TRIGGER_FLAG_KILL_AT_DURATION_END = 2;
    
    public const uint TASK_TUESDAY = 4;
    
    public const uint TASK_WEDNESDAY = 8;
    
    public static readonly Guid TaskHandlerPS = new("f2a69db7-da2c-4352-9066-86fee6dacac9");
    
    public static readonly Guid TaskHandlerStatusPS = new("9f15266d-d7ba-48f0-93c1-e6895f6fe5ac");
    
    public static readonly Guid TaskScheduler = new("0f87369f-a4e5-4cfc-bd3e-73e6154572dd");
}
