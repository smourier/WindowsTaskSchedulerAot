#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/nn-taskschd-irunningtaskcollection
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("6a67614b-6828-4fec-aa54-6d52e8f1f2db")]
public partial interface IRunningTaskCollection : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-irunningtaskcollection-get_count
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(out int pCount);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-irunningtaskcollection-get_item
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Item(VARIANT index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IRunningTask>))] out IRunningTask ppRunningTask);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-irunningtaskcollection-get__newenum
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__NewEnum(out nint ppEnum);
}
