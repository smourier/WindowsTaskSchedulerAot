#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/nn-taskschd-itaskfolder
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("8cfac062-a080-4c15-9a88-aa7c2af80dfc")]
public partial interface ITaskFolder : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskfolder-get_name
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Name(out BSTR pName);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskfolder-get_path
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Path(out BSTR pPath);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskfolder-getfolder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFolder(BSTR path, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITaskFolder>))] out ITaskFolder ppFolder);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskfolder-getfolders
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFolders(int flags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITaskFolderCollection>))] out ITaskFolderCollection ppFolders);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskfolder-createfolder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFolder(BSTR subFolderName, VARIANT sddl, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITaskFolder>))] out ITaskFolder ppFolder);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskfolder-deletefolder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteFolder(BSTR subFolderName, int flags);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskfolder-gettask
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTask(BSTR path, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IRegisteredTask>))] out IRegisteredTask ppTask);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskfolder-gettasks
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTasks(int flags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IRegisteredTaskCollection>))] out IRegisteredTaskCollection ppTasks);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskfolder-deletetask
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteTask(BSTR name, int flags);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskfolder-registertask
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterTask(BSTR path, BSTR xmlText, int flags, VARIANT userId, VARIANT password, TASK_LOGON_TYPE logonType, VARIANT sddl, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IRegisteredTask>))] out IRegisteredTask ppTask);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskfolder-registertaskdefinition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterTaskDefinition(BSTR path, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITaskDefinition?>))] ITaskDefinition? pDefinition, int flags, VARIANT userId, VARIANT password, TASK_LOGON_TYPE logonType, VARIANT sddl, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IRegisteredTask>))] out IRegisteredTask ppTask);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskfolder-getsecuritydescriptor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSecurityDescriptor(int securityInformation, out BSTR pSddl);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskfolder-setsecuritydescriptor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSecurityDescriptor(BSTR sddl, int flags);
}
