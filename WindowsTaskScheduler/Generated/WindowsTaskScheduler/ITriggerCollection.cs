#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/nn-taskschd-itriggercollection
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("85df5081-1b24-4f32-878a-d9d14df4cb77")]
public partial interface ITriggerCollection : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itriggercollection-get_count
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(ref int pCount);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itriggercollection-get_item
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Item(int index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITrigger>))] out ITrigger ppTrigger);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itriggercollection-get__newenum
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__NewEnum(out nint ppEnum);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itriggercollection-create
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Create(TASK_TRIGGER_TYPE2 type, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITrigger>))] out ITrigger ppTrigger);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itriggercollection-remove
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Remove(VARIANT index);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itriggercollection-clear
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clear();
}
