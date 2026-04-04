#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/nn-taskschd-iemailaction
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("10f62c64-7e16-4314-a0c2-0c3683f99d40")]
public partial interface IEmailAction : IAction
{
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iemailaction-get_server
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Server(out BSTR pServer);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iemailaction-put_server
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Server(BSTR server);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iemailaction-get_subject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Subject(out BSTR pSubject);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iemailaction-put_subject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Subject(BSTR subject);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iemailaction-get_to
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_To(out BSTR pTo);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iemailaction-put_to
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_To(BSTR to);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iemailaction-get_cc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Cc(out BSTR pCc);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iemailaction-put_cc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Cc(BSTR cc);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iemailaction-get_bcc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Bcc(out BSTR pBcc);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iemailaction-put_bcc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Bcc(BSTR bcc);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iemailaction-get_replyto
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ReplyTo(out BSTR pReplyTo);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iemailaction-put_replyto
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ReplyTo(BSTR replyTo);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iemailaction-get_from
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_From(out BSTR pFrom);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iemailaction-put_from
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_From(BSTR from);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iemailaction-get_headerfields
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_HeaderFields([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITaskNamedValueCollection>))] out ITaskNamedValueCollection ppHeaderFields);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iemailaction-put_headerfields
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_HeaderFields([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITaskNamedValueCollection>))] ITaskNamedValueCollection pHeaderFields);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iemailaction-get_body
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Body(out BSTR pBody);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iemailaction-put_body
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Body(BSTR body);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iemailaction-get_attachments
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Attachments(ref SAFEARRAY pAttachements);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iemailaction-put_attachments
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Attachments(ref SAFEARRAY pAttachements);
}
