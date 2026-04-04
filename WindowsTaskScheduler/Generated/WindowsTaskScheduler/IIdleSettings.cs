#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/nn-taskschd-iidlesettings
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("84594461-0053-4342-a8fd-088fabf11f32")]
public partial interface IIdleSettings : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iidlesettings-get_idleduration
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IdleDuration(out BSTR pDelay);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iidlesettings-put_idleduration
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_IdleDuration(BSTR delay);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iidlesettings-get_waittimeout
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_WaitTimeout(out BSTR pTimeout);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iidlesettings-put_waittimeout
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_WaitTimeout(BSTR timeout);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iidlesettings-get_stoponidleend
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_StopOnIdleEnd(ref VARIANT_BOOL pStop);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iidlesettings-put_stoponidleend
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_StopOnIdleEnd(VARIANT_BOOL stop);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iidlesettings-get_restartonidle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RestartOnIdle(ref VARIANT_BOOL pRestart);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iidlesettings-put_restartonidle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_RestartOnIdle(VARIANT_BOOL restart);
}
