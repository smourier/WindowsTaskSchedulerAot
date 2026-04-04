#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/nn-taskschd-iregistrationinfo
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("416d8b73-cb41-4ea1-805c-9be9a5ac4a74")]
public partial interface IRegistrationInfo : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iregistrationinfo-get_description
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Description(out BSTR pDescription);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iregistrationinfo-put_description
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Description(BSTR description);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iregistrationinfo-get_author
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Author(out BSTR pAuthor);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iregistrationinfo-put_author
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Author(BSTR author);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iregistrationinfo-get_version
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Version(out BSTR pVersion);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iregistrationinfo-put_version
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Version(BSTR version);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iregistrationinfo-get_date
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Date(out BSTR pDate);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iregistrationinfo-put_date
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Date(BSTR date);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iregistrationinfo-get_documentation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Documentation(out BSTR pDocumentation);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iregistrationinfo-put_documentation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Documentation(BSTR documentation);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iregistrationinfo-get_xmltext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_XmlText(out BSTR pText);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iregistrationinfo-put_xmltext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_XmlText(BSTR text);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iregistrationinfo-get_uri
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_URI(out BSTR pUri);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iregistrationinfo-put_uri
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_URI(BSTR uri);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iregistrationinfo-get_securitydescriptor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SecurityDescriptor(ref VARIANT pSddl);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iregistrationinfo-put_securitydescriptor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_SecurityDescriptor(VARIANT sddl);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iregistrationinfo-get_source
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Source(out BSTR pSource);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-iregistrationinfo-put_source
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Source(BSTR source);
}
