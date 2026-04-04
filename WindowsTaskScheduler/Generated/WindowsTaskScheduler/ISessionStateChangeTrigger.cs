#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/nn-taskschd-isessionstatechangetrigger
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("754da71b-4385-4475-9dd9-598294fa3641")]
public partial interface ISessionStateChangeTrigger : ITrigger
{
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-isessionstatechangetrigger-get_delay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Delay(out BSTR pDelay);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-isessionstatechangetrigger-put_delay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Delay(BSTR delay);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-isessionstatechangetrigger-get_userid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_UserId(out BSTR pUser);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-isessionstatechangetrigger-put_userid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_UserId(BSTR user);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-isessionstatechangetrigger-get_statechange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_StateChange(ref TASK_SESSION_STATE_CHANGE_TYPE pType);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-isessionstatechangetrigger-put_statechange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_StateChange(TASK_SESSION_STATE_CHANGE_TYPE type);
}
