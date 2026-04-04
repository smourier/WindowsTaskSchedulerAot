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

    protected override void ExcludeTypesFromBuild(BuilderContext context)
    {
        base.ExcludeTypesFromBuild(context);

        var alreadyIncludedTypes = new HashSet<string>();
        foreach (var type in typeof(DirectN.VARIANT).Assembly.GetTypes())
        {
            if (type.IsPublic)
            {
                alreadyIncludedTypes.Add(type.Name);
            }
        }

        var typeNamesToBuild = new Dictionary<string, List<FullName>>();
        foreach (var type in context.TypesToBuild)
        {
            var name = type.Name;
            if (type.NestedName != null)
            {
                name = name[..type.Name.IndexOf('+')];
            }

            if (!typeNamesToBuild.TryGetValue(name, out var list))
            {
                list = [];
                typeNamesToBuild[name] = list;
            }
            list.Add(type);
        }

        // the following is because of this horrible bug https://github.com/dotnet/runtime/issues/111573
        var fixBug = true;

        var excluded = new HashSet<FullName>();
        foreach (var type in alreadyIncludedTypes)
        {
            if (typeNamesToBuild.Remove(type, out var list))
            {
                foreach (var item in list)
                {
                    if (fixBug)
                    {
                        if (context.TypesToBuild.Contains(item))
                        {
                            excluded.Add(item);
                        }
                    }
                    else
                    {
                        context.TypesToBuild.Remove(item);
                    }
                }
            }
        }

        if (fixBug)
        {
            var inheritedCount = new Dictionary<FullName, HashSet<FullName>>();
            foreach (var type in context.TypesToBuild)
            {
                if (context.AllTypes[type] is InterfaceType iface)
                {
                    excludeFromThis(iface);
                }
            }

            void excludeFromThis(InterfaceType itype)
            {
                if (itype.Interfaces.Count == 0)
                    return;

                foreach (var iface in itype.Interfaces)
                {
                    if (excluded.Contains(iface))
                    {
                        if (!inheritedCount.TryGetValue(iface, out var list))
                        {
                            inheritedCount[iface] = [];
                        }
                        inheritedCount[iface].Add(itype.FullName);
                    }
                }

                foreach (var iface in itype.Interfaces)
                {
                    if (context.AllTypes[iface] is InterfaceType i)
                    {
                        excludeFromThis(i);
                    }
                }
            }

            foreach (var kv in inheritedCount)
            {
                excluded.Remove(kv.Key);
            }

            foreach (var type in excluded)
            {
                context.TypesToBuild.Remove(type);
            }
        }
    }
}
