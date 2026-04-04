#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/nn-taskschd-imonthlydowtrigger
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("77d025a3-90fa-43aa-b52e-cda5499b946a")]
public partial interface IMonthlyDOWTrigger : ITrigger
{
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-imonthlydowtrigger-get_daysofweek
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DaysOfWeek(ref short pDays);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-imonthlydowtrigger-put_daysofweek
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DaysOfWeek(short days);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-imonthlydowtrigger-get_weeksofmonth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_WeeksOfMonth(ref short pWeeks);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-imonthlydowtrigger-put_weeksofmonth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_WeeksOfMonth(short weeks);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-imonthlydowtrigger-get_monthsofyear
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MonthsOfYear(ref short pMonths);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-imonthlydowtrigger-put_monthsofyear
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_MonthsOfYear(short months);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-imonthlydowtrigger-get_runonlastweekofmonth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RunOnLastWeekOfMonth(ref VARIANT_BOOL pLastWeek);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-imonthlydowtrigger-put_runonlastweekofmonth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_RunOnLastWeekOfMonth(VARIANT_BOOL lastWeek);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-imonthlydowtrigger-get_randomdelay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RandomDelay(out BSTR pRandomDelay);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-imonthlydowtrigger-put_randomdelay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_RandomDelay(BSTR randomDelay);
}
