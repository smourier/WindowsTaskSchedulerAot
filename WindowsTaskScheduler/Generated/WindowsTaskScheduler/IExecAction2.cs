#nullable enable
namespace WindowsTaskScheduler;

[GeneratedComInterface, Guid("f2a82542-bda5-4e6b-9143-e2bf4f8987b6")]
public partial interface IExecAction2 : IExecAction
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_HideAppWindow(ref VARIANT_BOOL pHideAppWindow);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_HideAppWindow(VARIANT_BOOL hideAppWindow);
}
