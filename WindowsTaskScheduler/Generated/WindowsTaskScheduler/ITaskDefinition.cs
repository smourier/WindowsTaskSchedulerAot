#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/nn-taskschd-itaskdefinition
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("f5bc8fc5-536d-4f77-b852-fbc1356fdeb6")]
public partial interface ITaskDefinition : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskdefinition-get_registrationinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RegistrationInfo([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IRegistrationInfo>))] out IRegistrationInfo ppRegistrationInfo);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskdefinition-put_registrationinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_RegistrationInfo([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IRegistrationInfo>))] IRegistrationInfo pRegistrationInfo);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskdefinition-get_triggers
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Triggers([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITriggerCollection>))] out ITriggerCollection ppTriggers);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskdefinition-put_triggers
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Triggers([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITriggerCollection>))] ITriggerCollection pTriggers);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskdefinition-get_settings
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Settings([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITaskSettings>))] out ITaskSettings ppSettings);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskdefinition-put_settings
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Settings([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITaskSettings>))] ITaskSettings pSettings);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskdefinition-get_data
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Data(out BSTR pData);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskdefinition-put_data
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Data(BSTR data);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskdefinition-get_principal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Principal([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPrincipal>))] out IPrincipal ppPrincipal);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskdefinition-put_principal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Principal([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPrincipal>))] IPrincipal pPrincipal);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskdefinition-get_actions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Actions([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IActionCollection>))] out IActionCollection ppActions);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskdefinition-put_actions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Actions([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IActionCollection>))] IActionCollection pActions);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskdefinition-get_xmltext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_XmlText(out BSTR pXml);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskdefinition-put_xmltext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_XmlText(BSTR xml);
}
