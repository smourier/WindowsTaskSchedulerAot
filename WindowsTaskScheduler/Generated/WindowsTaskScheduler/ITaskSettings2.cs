#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/nn-taskschd-itasksettings2
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("2c05c3f0-6eed-4c05-a15f-ed7d7a98a369")]
public partial interface ITaskSettings2 : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings2-get_disallowstartonremoteappsession
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DisallowStartOnRemoteAppSession(ref VARIANT_BOOL pDisallowStart);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings2-put_disallowstartonremoteappsession
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DisallowStartOnRemoteAppSession(VARIANT_BOOL disallowStart);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings2-get_useunifiedschedulingengine
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_UseUnifiedSchedulingEngine(ref VARIANT_BOOL pUseUnifiedEngine);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings2-put_useunifiedschedulingengine
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_UseUnifiedSchedulingEngine(VARIANT_BOOL useUnifiedEngine);
}
