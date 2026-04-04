#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/nn-taskschd-iregisteredtask
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("9c86f320-dee3-4dd1-b972-a303f26b061e")]
public partial interface IRegisteredTask : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iregisteredtask-get_name
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Name(out BSTR pName);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iregisteredtask-get_path
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Path(out BSTR pPath);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iregisteredtask-get_state
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_State(out TASK_STATE pState);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iregisteredtask-get_enabled
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Enabled(out VARIANT_BOOL pEnabled);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iregisteredtask-put_enabled
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Enabled(VARIANT_BOOL enabled);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iregisteredtask-run
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Run(VARIANT @params, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IRunningTask>))] out IRunningTask ppRunningTask);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iregisteredtask-runex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RunEx(VARIANT @params, int flags, int sessionID, BSTR user, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IRunningTask>))] out IRunningTask ppRunningTask);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iregisteredtask-getinstances
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInstances(int flags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IRunningTaskCollection>))] out IRunningTaskCollection ppRunningTasks);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iregisteredtask-get_lastruntime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_LastRunTime(out double pLastRunTime);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iregisteredtask-get_lasttaskresult
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_LastTaskResult(out int pLastTaskResult);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iregisteredtask-get_numberofmissedruns
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_NumberOfMissedRuns(out int pNumberOfMissedRuns);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iregisteredtask-get_nextruntime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_NextRunTime(out double pNextRunTime);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iregisteredtask-get_definition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Definition([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITaskDefinition>))] out ITaskDefinition ppDefinition);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iregisteredtask-get_xml
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Xml(out BSTR pXml);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iregisteredtask-getsecuritydescriptor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSecurityDescriptor(int securityInformation, out BSTR pSddl);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iregisteredtask-setsecuritydescriptor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSecurityDescriptor(BSTR sddl, int flags);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iregisteredtask-stop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Stop(int flags);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iregisteredtask-getruntimes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRunTimes(in SYSTEMTIME pstStart, in SYSTEMTIME pstEnd, ref uint pCount, out nint pRunTimes);
}
