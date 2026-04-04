#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/mstask/nn-mstask-itaskscheduler
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("148bd527-a2ab-11ce-b11f-00aa00530503")]
public partial interface ITaskScheduler
{
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-itaskscheduler-settargetcomputer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTargetComputer(PWSTR pwszComputer);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-itaskscheduler-gettargetcomputer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTargetComputer(out PWSTR ppwszComputer);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-itaskscheduler-enum
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Enum([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumWorkItems>))] out IEnumWorkItems ppEnumWorkItems);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-itaskscheduler-activate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Activate(PWSTR pwszName, in Guid riid, out nint ppUnk);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-itaskscheduler-delete
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Delete(PWSTR pwszName);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-itaskscheduler-newworkitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NewWorkItem(PWSTR pwszTaskName, in Guid rclsid, in Guid riid, out nint ppUnk);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-itaskscheduler-addworkitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddWorkItem(PWSTR pwszTaskName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IScheduledWorkItem>))] IScheduledWorkItem pWorkItem);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-itaskscheduler-isoftype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsOfType(PWSTR pwszName, in Guid riid);
}
