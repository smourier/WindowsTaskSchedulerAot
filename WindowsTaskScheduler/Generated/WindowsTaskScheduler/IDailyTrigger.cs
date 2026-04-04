#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/nn-taskschd-idailytrigger
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("126c5cd8-b288-41d5-8dbf-e491446adc5c")]
public partial interface IDailyTrigger : ITrigger
{
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-idailytrigger-get_daysinterval
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DaysInterval(ref short pDays);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-idailytrigger-put_daysinterval
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DaysInterval(short days);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-idailytrigger-get_randomdelay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RandomDelay(out BSTR pRandomDelay);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-idailytrigger-put_randomdelay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_RandomDelay(BSTR randomDelay);
}
