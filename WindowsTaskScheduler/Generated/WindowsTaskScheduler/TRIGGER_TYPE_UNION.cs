#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/mstask/ns-mstask-trigger_type_union
[StructLayout(LayoutKind.Explicit)]
public partial struct TRIGGER_TYPE_UNION
{
    [FieldOffset(0)]
    public DAILY Daily;
    
    [FieldOffset(0)]
    public WEEKLY Weekly;
    
    [FieldOffset(0)]
    public MONTHLYDATE MonthlyDate;
    
    [FieldOffset(0)]
    public MONTHLYDOW MonthlyDOW;
}
