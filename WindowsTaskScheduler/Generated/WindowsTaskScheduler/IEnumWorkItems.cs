#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/mstask/nn-mstask-ienumworkitems
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("148bd528-a2ab-11ce-b11f-00aa00530503")]
public partial interface IEnumWorkItems
{
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-ienumworkitems-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint celt, out nint rgpwszNames, out uint pceltFetched);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-ienumworkitems-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint celt);
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-ienumworkitems-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/mstask/nf-mstask-ienumworkitems-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumWorkItems>))] out IEnumWorkItems ppEnumWorkItems);
}
