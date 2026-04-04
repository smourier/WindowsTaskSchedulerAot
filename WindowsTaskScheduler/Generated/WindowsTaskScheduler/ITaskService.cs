#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/nn-taskschd-itaskservice
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("2faba4c7-4da9-4013-9697-20cc3fd40f85")]
public partial interface ITaskService : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskservice-getfolder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFolder(BSTR path, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITaskFolder>))] out ITaskFolder ppFolder);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskservice-getrunningtasks
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRunningTasks(int flags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IRunningTaskCollection>))] out IRunningTaskCollection ppRunningTasks);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskservice-newtask
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NewTask(uint flags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITaskDefinition>))] out ITaskDefinition ppDefinition);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskservice-connect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Connect(VARIANT serverName, VARIANT user, VARIANT domain, VARIANT password);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskservice-get_connected
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Connected(out VARIANT_BOOL pConnected);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskservice-get_targetserver
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_TargetServer(out BSTR pServer);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskservice-get_connecteduser
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ConnectedUser(out BSTR pUser);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskservice-get_connecteddomain
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ConnectedDomain(out BSTR pDomain);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskservice-get_highestversion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_HighestVersion(out uint pVersion);
}
