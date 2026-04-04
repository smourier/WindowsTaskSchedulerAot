#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/nn-taskschd-irepetitionpattern
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("7fb9acf1-26be-400e-85b5-294b9c75dfd6")]
public partial interface IRepetitionPattern : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-irepetitionpattern-get_interval
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Interval(out BSTR pInterval);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-irepetitionpattern-put_interval
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Interval(BSTR interval);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-irepetitionpattern-get_duration
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Duration(out BSTR pDuration);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-irepetitionpattern-put_duration
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Duration(BSTR duration);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-irepetitionpattern-get_stopatdurationend
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_StopAtDurationEnd(ref VARIANT_BOOL pStop);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-irepetitionpattern-put_stopatdurationend
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_StopAtDurationEnd(VARIANT_BOOL stop);
}
