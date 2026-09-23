#nullable enable
namespace WindowsTaskScheduler;

public static partial class Constants
{
    public static Guid CLSID_CTask => new(0x148bd520, 0xa2ab, 0x11ce, 0xb1, 0x1f, 0x00, 0xaa, 0x00, 0x53, 0x05, 0x03);
    
    public static Guid CLSID_CTaskScheduler => new(0x148bd52a, 0xa2ab, 0x11ce, 0xb1, 0x1f, 0x00, 0xaa, 0x00, 0x53, 0x05, 0x03);
    
    public static Guid LIBID_TaskScheduler => new(0x0f87369f, 0xa4e5, 0x4cfc, 0xbd, 0x3e, 0x73, 0xe6, 0x15, 0x45, 0x72, 0xdd);
    
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
    
    public static Guid TaskHandlerPS => new(0xf2a69db7, 0xda2c, 0x4352, 0x90, 0x66, 0x86, 0xfe, 0xe6, 0xda, 0xca, 0xc9);
    
    public static Guid TaskHandlerStatusPS => new(0x9f15266d, 0xd7ba, 0x48f0, 0x93, 0xc1, 0xe6, 0x89, 0x5f, 0x6f, 0xe5, 0xac);
    
    public static Guid TaskScheduler => new(0x0f87369f, 0xa4e5, 0x4cfc, 0xbd, 0x3e, 0x73, 0xe6, 0x15, 0x45, 0x72, 0xdd);
}
