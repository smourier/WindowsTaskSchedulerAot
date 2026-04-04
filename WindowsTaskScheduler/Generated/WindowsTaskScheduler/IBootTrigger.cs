#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/nn-taskschd-iboottrigger
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("2a9c35da-d357-41f4-bbc1-207ac1b1f3cb")]
public partial interface IBootTrigger : ITrigger
{
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iboottrigger-get_delay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Delay(out BSTR pDelay);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iboottrigger-put_delay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Delay(BSTR delay);
}
