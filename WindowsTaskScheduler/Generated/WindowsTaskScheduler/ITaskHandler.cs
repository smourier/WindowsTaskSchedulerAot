#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/nn-taskschd-itaskhandler
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("839d7762-5121-4009-9234-4f0d19394f04")]
public partial interface ITaskHandler
{
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskhandler-start
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Start(nint pHandlerServices, BSTR data);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskhandler-stop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Stop(out HRESULT pRetCode);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskhandler-pause
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Pause();
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskhandler-resume
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Resume();
}
