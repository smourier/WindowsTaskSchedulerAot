#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/nn-taskschd-iaction
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("bae54997-48b1-4cbe-9965-d6be263ebea4")]
public partial interface IAction : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iaction-get_id
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Id(out BSTR pId);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iaction-put_id
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Id(BSTR Id);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iaction-get_type
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Type(ref TASK_ACTION_TYPE pType);
}
