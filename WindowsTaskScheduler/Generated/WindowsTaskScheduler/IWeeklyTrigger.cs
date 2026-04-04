#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/nn-taskschd-iweeklytrigger
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("5038fc98-82ff-436d-8728-a512a57c9dc1")]
public partial interface IWeeklyTrigger : ITrigger
{
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iweeklytrigger-get_daysofweek
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DaysOfWeek(ref short pDays);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iweeklytrigger-put_daysofweek
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DaysOfWeek(short days);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iweeklytrigger-get_weeksinterval
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_WeeksInterval(ref short pWeeks);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iweeklytrigger-put_weeksinterval
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_WeeksInterval(short weeks);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iweeklytrigger-get_randomdelay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RandomDelay(out BSTR pRandomDelay);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iweeklytrigger-put_randomdelay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_RandomDelay(BSTR randomDelay);
}
