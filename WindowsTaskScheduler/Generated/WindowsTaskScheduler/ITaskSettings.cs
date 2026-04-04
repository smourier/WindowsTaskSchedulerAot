#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/nn-taskschd-itasksettings
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("8fd4711d-2d02-4c8c-87e3-eff699de127e")]
public partial interface ITaskSettings : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings-get_allowdemandstart
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AllowDemandStart(ref VARIANT_BOOL pAllowDemandStart);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings-put_allowdemandstart
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_AllowDemandStart(VARIANT_BOOL allowDemandStart);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings-get_restartinterval
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RestartInterval(out BSTR pRestartInterval);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings-put_restartinterval
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_RestartInterval(BSTR restartInterval);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings-get_restartcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RestartCount(ref int pRestartCount);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings-put_restartcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_RestartCount(int restartCount);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings-get_multipleinstances
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MultipleInstances(ref TASK_INSTANCES_POLICY pPolicy);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings-put_multipleinstances
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_MultipleInstances(TASK_INSTANCES_POLICY policy);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings-get_stopifgoingonbatteries
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_StopIfGoingOnBatteries(ref VARIANT_BOOL pStopIfOnBatteries);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings-put_stopifgoingonbatteries
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_StopIfGoingOnBatteries(VARIANT_BOOL stopIfOnBatteries);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings-get_disallowstartifonbatteries
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DisallowStartIfOnBatteries(ref VARIANT_BOOL pDisallowStart);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings-put_disallowstartifonbatteries
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DisallowStartIfOnBatteries(VARIANT_BOOL disallowStart);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings-get_allowhardterminate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AllowHardTerminate(ref VARIANT_BOOL pAllowHardTerminate);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings-put_allowhardterminate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_AllowHardTerminate(VARIANT_BOOL allowHardTerminate);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings-get_startwhenavailable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_StartWhenAvailable(ref VARIANT_BOOL pStartWhenAvailable);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings-put_startwhenavailable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_StartWhenAvailable(VARIANT_BOOL startWhenAvailable);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings-get_xmltext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_XmlText(out BSTR pText);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings-put_xmltext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_XmlText(BSTR text);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings-get_runonlyifnetworkavailable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RunOnlyIfNetworkAvailable(ref VARIANT_BOOL pRunOnlyIfNetworkAvailable);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings-put_runonlyifnetworkavailable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_RunOnlyIfNetworkAvailable(VARIANT_BOOL runOnlyIfNetworkAvailable);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings-get_executiontimelimit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ExecutionTimeLimit(out BSTR pExecutionTimeLimit);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings-put_executiontimelimit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ExecutionTimeLimit(BSTR executionTimeLimit);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings-get_enabled
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Enabled(ref VARIANT_BOOL pEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Enabled(VARIANT_BOOL enabled);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings-get_deleteexpiredtaskafter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DeleteExpiredTaskAfter(out BSTR pExpirationDelay);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings-put_deleteexpiredtaskafter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DeleteExpiredTaskAfter(BSTR expirationDelay);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings-get_priority
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Priority(ref int pPriority);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings-put_priority
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Priority(int priority);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings-get_compatibility
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Compatibility(ref TASK_COMPATIBILITY pCompatLevel);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings-put_compatibility
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Compatibility(TASK_COMPATIBILITY compatLevel);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings-get_hidden
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Hidden(ref VARIANT_BOOL pHidden);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings-put_hidden
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Hidden(VARIANT_BOOL hidden);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings-get_idlesettings
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IdleSettings([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IIdleSettings>))] out IIdleSettings ppIdleSettings);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings-put_idlesettings
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_IdleSettings([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IIdleSettings>))] IIdleSettings pIdleSettings);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings-get_runonlyifidle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RunOnlyIfIdle(ref VARIANT_BOOL pRunOnlyIfIdle);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings-put_runonlyifidle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_RunOnlyIfIdle(VARIANT_BOOL runOnlyIfIdle);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings-get_waketorun
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_WakeToRun(ref VARIANT_BOOL pWake);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings-put_waketorun
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_WakeToRun(VARIANT_BOOL wake);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings-get_networksettings
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_NetworkSettings([MarshalUsing(typeof(UniqueComInterfaceMarshaller<INetworkSettings>))] out INetworkSettings ppNetworkSettings);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasksettings-put_networksettings
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_NetworkSettings([MarshalUsing(typeof(UniqueComInterfaceMarshaller<INetworkSettings>))] INetworkSettings pNetworkSettings);
}
