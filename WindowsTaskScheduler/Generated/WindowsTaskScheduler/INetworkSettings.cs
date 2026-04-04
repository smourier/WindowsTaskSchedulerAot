#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/nn-taskschd-inetworksettings
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("9f7dea84-c30b-4245-80b6-00e9f646f1b4")]
public partial interface INetworkSettings : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-inetworksettings-get_name
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Name(out BSTR pName);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-inetworksettings-put_name
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Name(BSTR name);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-inetworksettings-get_id
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Id(out BSTR pId);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-inetworksettings-put_id
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Id(BSTR id);
}
