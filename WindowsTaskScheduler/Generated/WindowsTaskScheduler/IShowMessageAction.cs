#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/nn-taskschd-ishowmessageaction
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("505e9e68-af89-46b8-a30f-56162a83d537")]
public partial interface IShowMessageAction : IAction
{
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-ishowmessageaction-get_title
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Title(out BSTR pTitle);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-ishowmessageaction-put_title
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Title(BSTR title);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-ishowmessageaction-get_messagebody
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MessageBody(out BSTR pMessageBody);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-ishowmessageaction-put_messagebody
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_MessageBody(BSTR messageBody);
}
