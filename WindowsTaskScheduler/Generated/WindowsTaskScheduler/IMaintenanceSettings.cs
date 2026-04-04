#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/nn-taskschd-imaintenancesettings
[GeneratedComInterface, Guid("a6024fa8-9652-4adb-a6bf-5cfcd877a7ba")]
public partial interface IMaintenanceSettings : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-imaintenancesettings-put_period
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Period(BSTR value);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-imaintenancesettings-get_period
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Period(out BSTR target);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-imaintenancesettings-put_deadline
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Deadline(BSTR value);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-imaintenancesettings-get_deadline
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Deadline(out BSTR target);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-imaintenancesettings-put_exclusive
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Exclusive(VARIANT_BOOL value);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-imaintenancesettings-get_exclusive
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Exclusive(ref VARIANT_BOOL target);
}
