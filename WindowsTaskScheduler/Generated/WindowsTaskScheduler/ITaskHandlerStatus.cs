#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/nn-taskschd-itaskhandlerstatus
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("eaec7a8f-27a0-4ddc-8675-14726a01a38a")]
public partial interface ITaskHandlerStatus
{
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskhandlerstatus-updatestatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateStatus(short percentComplete, BSTR statusMessage);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskhandlerstatus-taskcompleted
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TaskCompleted(HRESULT taskErrCode);
}
