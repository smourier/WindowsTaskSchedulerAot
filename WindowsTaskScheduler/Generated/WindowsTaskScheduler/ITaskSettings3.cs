#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/nn-taskschd-itasksettings3
[GeneratedComInterface, Guid("0ad9d0d7-0c7f-4ebb-9a5f-d1c648dca528")]
public partial interface ITaskSettings3 : ITaskSettings
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DisallowStartOnRemoteAppSession(ref VARIANT_BOOL pDisallowStart);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DisallowStartOnRemoteAppSession(VARIANT_BOOL disallowStart);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_UseUnifiedSchedulingEngine(ref VARIANT_BOOL pUseUnifiedEngine);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_UseUnifiedSchedulingEngine(VARIANT_BOOL useUnifiedEngine);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings3-get_maintenancesettings
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MaintenanceSettings([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMaintenanceSettings>))] out IMaintenanceSettings ppMaintenanceSettings);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings3-put_maintenancesettings
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_MaintenanceSettings([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMaintenanceSettings>))] IMaintenanceSettings pMaintenanceSettings);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateMaintenanceSettings([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMaintenanceSettings>))] out IMaintenanceSettings ppMaintenanceSettings);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings3-get_volatile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Volatile(ref VARIANT_BOOL pVolatile);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings3-put_volatile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Volatile(VARIANT_BOOL Volatile);
}
