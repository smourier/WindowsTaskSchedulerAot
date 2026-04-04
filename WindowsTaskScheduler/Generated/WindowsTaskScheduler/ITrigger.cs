#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/nn-taskschd-itrigger
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("09941815-ea89-4b5b-89e0-2a773801fac3")]
public partial interface ITrigger : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itrigger-get_type
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Type(ref TASK_TRIGGER_TYPE2 pType);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itrigger-get_id
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Id(out BSTR pId);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itrigger-put_id
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Id(BSTR id);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itrigger-get_repetition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Repetition([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IRepetitionPattern>))] out IRepetitionPattern ppRepeat);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itrigger-put_repetition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Repetition([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IRepetitionPattern>))] IRepetitionPattern pRepeat);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itrigger-get_executiontimelimit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ExecutionTimeLimit(out BSTR pTimeLimit);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itrigger-put_executiontimelimit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ExecutionTimeLimit(BSTR timelimit);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itrigger-get_startboundary
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_StartBoundary(out BSTR pStart);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itrigger-put_startboundary
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_StartBoundary(BSTR start);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itrigger-get_endboundary
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_EndBoundary(out BSTR pEnd);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itrigger-put_endboundary
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_EndBoundary(BSTR end);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itrigger-get_enabled
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Enabled(ref VARIANT_BOOL pEnabled);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itrigger-put_enabled
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Enabled(VARIANT_BOOL enabled);
}
