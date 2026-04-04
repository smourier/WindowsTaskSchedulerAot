#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/nn-taskschd-itimetrigger
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("b45747e0-eba7-4276-9f29-85c5bb300006")]
public partial interface ITimeTrigger : ITrigger
{
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itimetrigger-get_randomdelay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RandomDelay(out BSTR pRandomDelay);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itimetrigger-put_randomdelay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_RandomDelay(BSTR randomDelay);
}
