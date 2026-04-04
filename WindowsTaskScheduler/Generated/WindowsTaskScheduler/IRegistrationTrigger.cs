#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/nn-taskschd-iregistrationtrigger
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("4c8fec3a-c218-4e0c-b23d-629024db91a2")]
public partial interface IRegistrationTrigger : ITrigger
{
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iregistrationtrigger-get_delay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Delay(out BSTR pDelay);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iregistrationtrigger-put_delay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Delay(BSTR delay);
}
