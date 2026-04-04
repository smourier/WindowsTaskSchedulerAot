#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/nn-taskschd-iactioncollection
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("02820e19-7b98-4ed2-b2e8-fdccceff619b")]
public partial interface IActionCollection : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iactioncollection-get_count
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(ref int pCount);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iactioncollection-get_item
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Item(int index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAction>))] out IAction ppAction);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iactioncollection-get__newenum
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__NewEnum(out nint ppEnum);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iactioncollection-get_xmltext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_XmlText(out BSTR pText);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iactioncollection-put_xmltext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_XmlText(BSTR text);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iactioncollection-create
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Create(TASK_ACTION_TYPE type, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAction>))] out IAction ppAction);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iactioncollection-remove
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Remove(VARIANT index);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iactioncollection-clear
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clear();
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iactioncollection-get_context
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Context(out BSTR pContext);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iactioncollection-put_context
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Context(BSTR context);
}
