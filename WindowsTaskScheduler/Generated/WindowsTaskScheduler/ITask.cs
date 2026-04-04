#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/mstask/nn-mstask-itask
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("148bd524-a2ab-11ce-b11f-00aa00530503")]
public partial interface ITask : IScheduledWorkItem
{
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-itask-setapplicationname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetApplicationName(PWSTR pwszApplicationName);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-itask-getapplicationname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetApplicationName(out PWSTR ppwszApplicationName);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-itask-setparameters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetParameters(PWSTR pwszParameters);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-itask-getparameters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetParameters(out PWSTR ppwszParameters);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-itask-setworkingdirectory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetWorkingDirectory(PWSTR pwszWorkingDirectory);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-itask-getworkingdirectory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetWorkingDirectory(out PWSTR ppwszWorkingDirectory);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-itask-setpriority
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPriority(uint dwPriority);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-itask-getpriority
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPriority(out uint pdwPriority);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-itask-settaskflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTaskFlags(uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-itask-gettaskflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTaskFlags(out uint pdwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-itask-setmaxruntime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMaxRunTime(uint dwMaxRunTimeMS);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-itask-getmaxruntime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMaxRunTime(out uint pdwMaxRunTimeMS);
}
