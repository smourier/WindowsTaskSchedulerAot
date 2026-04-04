using Win32InteropBuilder;
using Win32InteropBuilder.Model;

namespace WindowsTaskSchedulerAot.InteroBuilder.Cli;

public partial class Builder : Win32InteropBuilder.Builder
{
    public const string Namespace = "WindowsTaskScheduler";
    public const string ProjectName = "WindowsTaskScheduler";

    public override BuilderContext CreateBuilderContext(BuilderConfiguration configuration, IGenerator generator)
    {
        ArgumentNullException.ThrowIfNull(configuration);
        ArgumentNullException.ThrowIfNull(generator);

        configuration.OutputDirectoryPath = Path.GetFullPath(Path.Combine(Win32Metadata.SolutionDir, ProjectName, "Generated"));
        var context = new Context(configuration, generator);
        context.ImplicitNamespaces.Add(Namespace);
        return context;
    }
}
