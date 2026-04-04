#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/nn-taskschd-iregisteredtaskcollection
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("86627eb4-42a7-41e4-a4d9-ac33a72f2d52")]
public partial interface IRegisteredTaskCollection : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iregisteredtaskcollection-get_count
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(out int pCount);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iregisteredtaskcollection-get_item
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Item(VARIANT index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IRegisteredTask>))] out IRegisteredTask ppRegisteredTask);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iregisteredtaskcollection-get__newenum
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__NewEnum(out nint ppEnum);
}
