#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/mstask/nn-mstask-iprovidetaskpage
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("4086658a-cbbb-11cf-b604-00c04fd8d565")]
public partial interface IProvideTaskPage
{
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-iprovidetaskpage-getpage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPage(TASKPAGE tpType, BOOL fPersistChanges, out HPROPSHEETPAGE phPage);
}
