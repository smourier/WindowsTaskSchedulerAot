#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/nn-taskschd-itasknamedvaluepair
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("39038068-2b46-4afd-8662-7bb6f868d221")]
public partial interface ITaskNamedValuePair : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasknamedvaluepair-get_name
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Name(out BSTR pName);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasknamedvaluepair-put_name
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Name(BSTR name);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasknamedvaluepair-get_value
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Value(out BSTR pValue);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itasknamedvaluepair-put_value
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Value(BSTR value);
}
