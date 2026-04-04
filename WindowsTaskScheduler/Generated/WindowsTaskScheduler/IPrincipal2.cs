#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/nn-taskschd-iprincipal2
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("248919ae-e345-4a6d-8aeb-e0d3165c904e")]
public partial interface IPrincipal2 : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iprincipal2-get_processtokensidtype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ProcessTokenSidType(ref TASK_PROCESSTOKENSID_TYPE pProcessTokenSidType);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iprincipal2-put_processtokensidtype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ProcessTokenSidType(TASK_PROCESSTOKENSID_TYPE processTokenSidType);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iprincipal2-get_requiredprivilegecount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RequiredPrivilegeCount(ref int pCount);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iprincipal2-get_requiredprivilege
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RequiredPrivilege(int index, out BSTR pPrivilege);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iprincipal2-addrequiredprivilege
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddRequiredPrivilege(BSTR privilege);
}
