#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/nn-taskschd-irunningtask
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("653758fb-7b9a-4f1e-a471-beeb8e9b834e")]
public partial interface IRunningTask : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-irunningtask-get_name
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Name(out BSTR pName);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-irunningtask-get_instanceguid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_InstanceGuid(out BSTR pGuid);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-irunningtask-get_path
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Path(out BSTR pPath);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-irunningtask-get_state
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_State(out TASK_STATE pState);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-irunningtask-get_currentaction
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CurrentAction(out BSTR pName);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-irunningtask-stop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Stop();
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-irunningtask-refresh
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Refresh();
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-irunningtask-get_enginepid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_EnginePID(out uint pPID);
}
