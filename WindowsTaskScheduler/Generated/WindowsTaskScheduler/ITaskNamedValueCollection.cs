#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/nn-taskschd-itasknamedvaluecollection
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("b4ef826b-63c3-46e4-a504-ef69e4f7ea4d")]
public partial interface ITaskNamedValueCollection : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasknamedvaluecollection-get_count
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(ref int pCount);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasknamedvaluecollection-get_item
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Item(int index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITaskNamedValuePair>))] out ITaskNamedValuePair ppPair);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasknamedvaluecollection-get__newenum
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__NewEnum(out nint ppEnum);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasknamedvaluecollection-create
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Create(BSTR name, BSTR value, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITaskNamedValuePair>))] out ITaskNamedValuePair ppPair);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasknamedvaluecollection-remove
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Remove(int index);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasknamedvaluecollection-clear
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clear();
}
