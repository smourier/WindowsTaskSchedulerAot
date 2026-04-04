#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/mstask/nn-mstask-ischeduledworkitem
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("a6b952f0-a4b1-11d0-997d-00aa006887ec")]
public partial interface IScheduledWorkItem
{
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-ischeduledworkitem-createtrigger
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateTrigger(out ushort piNewTrigger, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITaskTrigger>))] out ITaskTrigger ppTrigger);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-ischeduledworkitem-deletetrigger
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteTrigger(ushort iTrigger);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-ischeduledworkitem-gettriggercount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTriggerCount(out ushort pwCount);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-ischeduledworkitem-gettrigger
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTrigger(ushort iTrigger, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITaskTrigger>))] out ITaskTrigger ppTrigger);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-ischeduledworkitem-gettriggerstring
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTriggerString(ushort iTrigger, out PWSTR ppwszTrigger);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-ischeduledworkitem-getruntimes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRunTimes(in SYSTEMTIME pstBegin, in SYSTEMTIME pstEnd, ref ushort pCount, out nint rgstTaskTimes);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-ischeduledworkitem-getnextruntime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNextRunTime(ref SYSTEMTIME pstNextRun);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-ischeduledworkitem-setidlewait
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetIdleWait(ushort wIdleMinutes, ushort wDeadlineMinutes);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-ischeduledworkitem-getidlewait
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIdleWait(out ushort pwIdleMinutes, out ushort pwDeadlineMinutes);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-ischeduledworkitem-run
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Run();
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-ischeduledworkitem-terminate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Terminate();
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-ischeduledworkitem-editworkitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EditWorkItem(HWND hParent, uint dwReserved);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-ischeduledworkitem-getmostrecentruntime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMostRecentRunTime(out SYSTEMTIME pstLastRun);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-ischeduledworkitem-getstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStatus(out HRESULT phrStatus);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-ischeduledworkitem-getexitcode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetExitCode(out uint pdwExitCode);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-ischeduledworkitem-setcomment
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetComment(PWSTR pwszComment);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-ischeduledworkitem-getcomment
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetComment(out PWSTR ppwszComment);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-ischeduledworkitem-setcreator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCreator(PWSTR pwszCreator);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-ischeduledworkitem-getcreator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCreator(out PWSTR ppwszCreator);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-ischeduledworkitem-setworkitemdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetWorkItemData(ushort cbData, nint /* byte array */ rgbData);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-ischeduledworkitem-getworkitemdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetWorkItemData(out ushort pcbData, out nint /* byte array */ prgbData);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-ischeduledworkitem-seterrorretrycount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetErrorRetryCount(ushort wRetryCount);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-ischeduledworkitem-geterrorretrycount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetErrorRetryCount(out ushort pwRetryCount);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-ischeduledworkitem-seterrorretryinterval
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetErrorRetryInterval(ushort wRetryInterval);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-ischeduledworkitem-geterrorretryinterval
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetErrorRetryInterval(out ushort pwRetryInterval);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-ischeduledworkitem-setflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFlags(uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-ischeduledworkitem-getflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFlags(out uint pdwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-ischeduledworkitem-setaccountinformation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAccountInformation(PWSTR pwszAccountName, PWSTR pwszPassword);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-ischeduledworkitem-getaccountinformation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAccountInformation(out PWSTR ppwszAccountName);
}
