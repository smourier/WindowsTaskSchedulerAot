#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/nn-taskschd-iexecaction
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("4c3d624d-fd6b-49a3-b9b7-09cb3cd3f047")]
public partial interface IExecAction : IAction
{
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iexecaction-get_path
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Path(out BSTR pPath);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iexecaction-put_path
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Path(BSTR path);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iexecaction-get_arguments
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Arguments(out BSTR pArgument);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iexecaction-put_arguments
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Arguments(BSTR argument);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iexecaction-get_workingdirectory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_WorkingDirectory(out BSTR pWorkingDirectory);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iexecaction-put_workingdirectory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_WorkingDirectory(BSTR workingDirectory);
}
