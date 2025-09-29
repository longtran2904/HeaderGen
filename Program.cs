using System;
using System.Reflection;
using System.Collections.Concurrent;
using StringBuilder = System.Text.StringBuilder;

internal class Program
{
    static void GenerateHeaderFile(ICollection<Assembly> assemblies, string path)
    {
        bool writeToFolder = Directory.Exists(path);
        bool writeToFile = File.Exists(path);
        if (!writeToFolder && !writeToFile && !string.IsNullOrEmpty(path))
        {
            char c = path[path.Length - 1];
            writeToFolder = c == '\\' || c == '/';
            writeToFile = !writeToFolder;
        }
        
        HeaderGen.NameResolver.Init(assemblies, 32768);
        var fileTasks = new ConcurrentBag<Task>();
        var builder = new ThreadLocal<StringBuilder>(() => new StringBuilder(assemblies.Count * 256));
        
#if true // NOTE(long): Set to true to enable multithreading.
        Parallel.ForEach(Partitioner.Create(assemblies), AppendAssembly);
#else
        foreach (Assembly assembly in assemblies)
            AppendAssembly(assembly);
#endif
        
        Task.WaitAll(fileTasks.ToArray());
        if (writeToFile)
        {
            StringBuilder total = new StringBuilder();
            foreach (var sb in builder.Values)
                total.Append(sb);
            File.WriteAllText(path, total.ToString());
        }
        
        void AppendAssembly(Assembly assembly)
        {
            Type[] types = assembly.GetTypes();
            builder.Value.Append($"// ---- {assembly.GetName().Name}({assembly.Location}): {types.Length, 4} ----\n");
            
            foreach (Type type in types)
            {
                string content = HeaderGen.GetGlobalType(type);
                if (content != null)
                {
                    Console.WriteLine(content);
                    builder.Value.Append(content);
                    
                    if (writeToFolder)
                        fileTasks.Add(HeaderGen.DumpType(path, type, content));
                }
            }
        }
    }
    
    static void Main(string[] args)
    {
        string[] locations = new string[]
        {
            "DLLTest/bin/Debug/net8.0/DLLTest.dll",
            
            // NOTE(long): CurrentDomain.GetAssemblies returns different arrays in release vs debug mode
            // These are the namespaces missing in release mode:
            "C:/Program Files/Microsoft Visual Studio/2022/community/common7/ide/commonextensions/microsoft/hotreload/Microsoft.Extensions.DotNetDeltaApplier.dll",
            "C:/Program Files/dotnet/shared/Microsoft.NETCore.App/8.0.20/System.IO.Pipes.dll",
            "C:/Program Files/dotnet/shared/Microsoft.NETCore.App/8.0.20/System.Linq.dll",
            "C:/Program Files/dotnet/shared/Microsoft.NETCore.App/8.0.20/System.Console.dll",
            "C:/Program Files/dotnet/shared/Microsoft.NETCore.App/8.0.20/System.Threading.dll",
            "C:/Program Files/dotnet/shared/Microsoft.NETCore.App/8.0.20/System.Threading.Overlapped.dll",
            "C:/Program Files/dotnet/shared/Microsoft.NETCore.App/8.0.20/System.Security.AccessControl.dll",
            "C:/Program Files/dotnet/shared/Microsoft.NETCore.App/8.0.20/System.Security.Principal.Windows.dll",
            "C:/Program Files/dotnet/shared/Microsoft.NETCore.App/8.0.20/System.Security.Claims.dll",
            "C:/Program Files/dotnet/shared/Microsoft.NETCore.App/8.0.20/System.Runtime.Loader.dll",
            "C:/Program Files/dotnet/shared/Microsoft.NETCore.App/8.0.20/System.Collections.Concurrent.dll",
            "C:/Program Files/dotnet/shared/Microsoft.NETCore.App/8.0.20/System.Runtime.InteropServices.dll",
        };
        
        List<Assembly> assemblies = new List<Assembly>(AppDomain.CurrentDomain.GetAssemblies());
        assemblies.Capacity = locations.Length;
        
        foreach (string location in locations)
        {
            Assembly asm = Assembly.LoadFrom(location);
            if (asm != null && !assemblies.Contains(asm))
            {
                string name = asm.GetName().Name;
                string[] prefixes = new string[] { "System", "Unity", "Microsoft", "mscorlib", "netstandard", "DLLTest" };
                
                if (prefixes.Any(prefix => name.StartsWith(prefix)))
                    assemblies.Add(asm);
            }
        }
        
        var watch = System.Diagnostics.Stopwatch.StartNew();
        GenerateHeaderFile(assemblies, args.Length > 0 ? args[0] : "");
        watch.Stop();
        Console.WriteLine($"Elapsed time: {watch.Elapsed.TotalMilliseconds}ms");
    }
}
