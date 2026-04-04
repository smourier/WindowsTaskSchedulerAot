using Win32InteropBuilder;
using Win32InteropBuilder.Model;

namespace WindowsTaskSchedulerAot.InteroBuilder.Cli;

public class Context(BuilderConfiguration configuration, IGenerator generator)
    : BuilderContext(configuration, generator)
{
}
