#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/nn-taskschd-ilogontrigger
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("72dade38-fae4-4b3e-baf4-5d009af02b1c")]
public partial interface ILogonTrigger : ITrigger
{
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-ilogontrigger-get_delay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Delay(out BSTR pDelay);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-ilogontrigger-put_delay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Delay(BSTR delay);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-ilogontrigger-get_userid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_UserId(out BSTR pUser);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-ilogontrigger-put_userid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_UserId(BSTR user);
}
