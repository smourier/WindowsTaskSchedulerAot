#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/nn-taskschd-imonthlytrigger
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("97c45ef1-6b02-4a1a-9c0e-1ebfba1500ac")]
public partial interface IMonthlyTrigger : ITrigger
{
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-imonthlytrigger-get_daysofmonth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DaysOfMonth(ref int pDays);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-imonthlytrigger-put_daysofmonth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DaysOfMonth(int days);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-imonthlytrigger-get_monthsofyear
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MonthsOfYear(ref short pMonths);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-imonthlytrigger-put_monthsofyear
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_MonthsOfYear(short months);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-imonthlytrigger-get_runonlastdayofmonth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RunOnLastDayOfMonth(ref VARIANT_BOOL pLastDay);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-imonthlytrigger-put_runonlastdayofmonth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_RunOnLastDayOfMonth(VARIANT_BOOL lastDay);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-imonthlytrigger-get_randomdelay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RandomDelay(out BSTR pRandomDelay);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-imonthlytrigger-put_randomdelay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_RandomDelay(BSTR randomDelay);
}
