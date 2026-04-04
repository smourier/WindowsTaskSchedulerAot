#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/nn-taskschd-icomhandleraction
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("6d2fd252-75c5-4f66-90ba-2a7d8cc3039f")]
public partial interface IComHandlerAction : IAction
{
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-icomhandleraction-get_classid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ClassId(out BSTR pClsid);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-icomhandleraction-put_classid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ClassId(BSTR clsid);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-icomhandleraction-get_data
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Data(out BSTR pData);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-icomhandleraction-put_data
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Data(BSTR data);
}
