#nullable enable
namespace WindowsTaskScheduler;

// https://learn.microsoft.com/windows/win32/api/taskschd/nn-taskschd-iidletrigger
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("d537d2b0-9fb3-4d34-9739-1ff5ce7b1ef3")]
public partial interface IIdleTrigger : ITrigger
{
}
