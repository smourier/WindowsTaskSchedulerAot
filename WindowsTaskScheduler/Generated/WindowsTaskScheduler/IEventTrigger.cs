#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/nn-taskschd-ieventtrigger
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("d45b0167-9653-4eef-b94f-0732ca7af251")]
public partial interface IEventTrigger : ITrigger
{
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-ieventtrigger-get_subscription
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Subscription(out BSTR pQuery);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-ieventtrigger-put_subscription
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Subscription(BSTR query);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-ieventtrigger-get_delay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Delay(out BSTR pDelay);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-ieventtrigger-put_delay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Delay(BSTR delay);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-ieventtrigger-get_valuequeries
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ValueQueries([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITaskNamedValueCollection>))] out ITaskNamedValueCollection ppNamedXPaths);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-ieventtrigger-put_valuequeries
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ValueQueries([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITaskNamedValueCollection>))] ITaskNamedValueCollection pNamedXPaths);
}
