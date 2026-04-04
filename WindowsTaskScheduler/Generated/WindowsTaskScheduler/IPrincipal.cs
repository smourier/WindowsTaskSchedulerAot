#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/nn-taskschd-iprincipal
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("d98d51e5-c9b4-496a-a9c1-18980261cf0f")]
public partial interface IPrincipal : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iprincipal-get_id
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Id(out BSTR pId);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iprincipal-put_id
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Id(BSTR Id);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iprincipal-get_displayname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DisplayName(out BSTR pName);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iprincipal-put_displayname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DisplayName(BSTR name);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iprincipal-get_userid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_UserId(out BSTR pUser);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iprincipal-put_userid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_UserId(BSTR user);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iprincipal-get_logontype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_LogonType(ref TASK_LOGON_TYPE pLogon);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iprincipal-put_logontype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_LogonType(TASK_LOGON_TYPE logon);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iprincipal-get_groupid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_GroupId(out BSTR pGroup);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iprincipal-put_groupid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_GroupId(BSTR group);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iprincipal-get_runlevel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RunLevel(ref TASK_RUNLEVEL_TYPE pRunLevel);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iprincipal-put_runlevel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_RunLevel(TASK_RUNLEVEL_TYPE runLevel);
}
