#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/nn-taskschd-itaskvariables
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("3e4c9351-d966-4b8b-bb87-ceba68bb0107")]
public partial interface ITaskVariables
{
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskvariables-getinput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInput(out BSTR pInput);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskvariables-setoutput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOutput(BSTR input);
    
    // https://learn.microsoft.com/windows/win32/api/taskschd/nf-taskschd-itaskvariables-getcontext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetContext(out BSTR pContext);
}
