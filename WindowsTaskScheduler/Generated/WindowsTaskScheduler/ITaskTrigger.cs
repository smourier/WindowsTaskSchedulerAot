#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/mstask/nn-mstask-itasktrigger
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("148bd52b-a2ab-11ce-b11f-00aa00530503")]
public partial interface ITaskTrigger
{
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-itasktrigger-settrigger
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTrigger(in TASK_TRIGGER pTrigger);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-itasktrigger-gettrigger
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTrigger(out TASK_TRIGGER pTrigger);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-itasktrigger-gettriggerstring
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTriggerString(out PWSTR ppwszTrigger);
}
