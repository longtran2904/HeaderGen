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
            "D:/Documents/Projects/HeaderGen/DLLTest/bin/Debug/net8.0/DLLTest.dll",
            
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
            
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/Bee.BeeDriver.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/PlayerBuildProgramLibrary.Data.dll",
            "D:/Documents/GitHub/Rogue-like-game-i-guess/The game is liar/Library/PackageCache/com.unity.nuget.newtonsoft-json@3.2.1/Runtime/Newtonsoft.Json.dll",
            "D:/Documents/GitHub/Rogue-like-game-i-guess/The game is liar/Library/PackageCache/com.unity.ext.nunit@1.0.6/net35/unity-custom/nunit.framework.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Resources/Licensing/Client/System.CodeDom.dll",
            
            "D:/Programs/2021.3.36f1/Editor/Data/MonoBleedingEdge/lib/mono/unityjit-win32/mscorlib.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/MonoBleedingEdge/lib/mono/unityjit-win32/Facades/netstandard.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/MonoBleedingEdge/lib/mono/unityjit-win32/System.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/MonoBleedingEdge/lib/mono/unityjit-win32/Facades/System.Collections.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/MonoBleedingEdge/lib/mono/unityjit-win32/Facades/System.Collections.Concurrent.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/MonoBleedingEdge/lib/mono/unityjit-win32/System.Configuration.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/MonoBleedingEdge/lib/mono/unityjit-win32/System.Core.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/MonoBleedingEdge/lib/mono/unityjit-win32/Facades/System.Diagnostics.Debug.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/MonoBleedingEdge/lib/mono/unityjit-win32/System.Drawing.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/MonoBleedingEdge/lib/mono/unityjit-win32/Facades/System.Globalization.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/MonoBleedingEdge/lib/mono/unityjit-win32/Facades/System.IO.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/MonoBleedingEdge/lib/mono/unityjit-win32/System.Net.Http.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/MonoBleedingEdge/lib/mono/unityjit-win32/System.Numerics.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/MonoBleedingEdge/lib/mono/unityjit-win32/Facades/System.ObjectModel.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/MonoBleedingEdge/lib/mono/unityjit-win32/Facades/System.Reflection.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/MonoBleedingEdge/lib/mono/unityjit-win32/Facades/System.Runtime.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/MonoBleedingEdge/lib/mono/unityjit-win32/System.Runtime.Serialization.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/MonoBleedingEdge/lib/mono/unityjit-win32/System.ServiceModel.Internals.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/MonoBleedingEdge/lib/mono/unityjit-win32/Facades/System.Text.RegularExpressions.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/MonoBleedingEdge/lib/mono/unityjit-win32/Facades/System.Threading.Tasks.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/MonoBleedingEdge/lib/mono/unityjit-win32/System.Xml.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/MonoBleedingEdge/lib/mono/unityjit-win32/System.Xml.Linq.dll",
            
            "D:/Documents/GitHub/Rogue-like-game-i-guess/The game is liar/Library/ScriptAssemblies/Unity.2D.Sprite.Editor.dll",
            "D:/Documents/GitHub/Rogue-like-game-i-guess/The game is liar/Library/ScriptAssemblies/Unity.2D.Tilemap.Editor.dll",
            "D:/Documents/GitHub/Rogue-like-game-i-guess/The game is liar/Library/ScriptAssemblies/Unity.2D.Tilemap.Extras.dll",
            "D:/Documents/GitHub/Rogue-like-game-i-guess/The game is liar/Library/ScriptAssemblies/Unity.2D.Tilemap.Extras.Editor.dll",
            "D:/Documents/GitHub/Rogue-like-game-i-guess/The game is liar/Library/ScriptAssemblies/Unity.EditorCoroutines.Editor.dll",
            "D:/Documents/GitHub/Rogue-like-game-i-guess/The game is liar/Library/ScriptAssemblies/Unity.Mathematics.dll",
            "D:/Documents/GitHub/Rogue-like-game-i-guess/The game is liar/Library/ScriptAssemblies/Unity.Mathematics.Editor.dll",
            "D:/Documents/GitHub/Rogue-like-game-i-guess/The game is liar/Library/ScriptAssemblies/Unity.MemoryProfiler.dll",
            "D:/Documents/GitHub/Rogue-like-game-i-guess/The game is liar/Library/ScriptAssemblies/Unity.MemoryProfiler.Editor.dll",
            "D:/Documents/GitHub/Rogue-like-game-i-guess/The game is liar/Library/ScriptAssemblies/Unity.MemoryProfiler.Editor.MemoryProfilerModule.dll",
            "D:/Documents/GitHub/Rogue-like-game-i-guess/The game is liar/Library/ScriptAssemblies/Unity.Recorder.dll",
            "D:/Documents/GitHub/Rogue-like-game-i-guess/The game is liar/Library/ScriptAssemblies/Unity.Recorder.Base.dll",
            "D:/Documents/GitHub/Rogue-like-game-i-guess/The game is liar/Library/ScriptAssemblies/Unity.Recorder.Editor.dll",
            "D:/Documents/GitHub/Rogue-like-game-i-guess/The game is liar/Library/ScriptAssemblies/Unity.RenderPipeline.Universal.ShaderLibrary.dll",
            "D:/Documents/GitHub/Rogue-like-game-i-guess/The game is liar/Library/ScriptAssemblies/Unity.RenderPipelines.Core.Editor.dll",
            "D:/Documents/GitHub/Rogue-like-game-i-guess/The game is liar/Library/ScriptAssemblies/Unity.RenderPipelines.Core.Runtime.dll",
            "D:/Documents/GitHub/Rogue-like-game-i-guess/The game is liar/Library/ScriptAssemblies/Unity.RenderPipelines.Core.ShaderLibrary.dll",
            "D:/Documents/GitHub/Rogue-like-game-i-guess/The game is liar/Library/ScriptAssemblies/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.dll",
            "D:/Documents/GitHub/Rogue-like-game-i-guess/The game is liar/Library/ScriptAssemblies/Unity.RenderPipelines.Universal.Editor.dll",
            "D:/Documents/GitHub/Rogue-like-game-i-guess/The game is liar/Library/ScriptAssemblies/Unity.RenderPipelines.Universal.Runtime.dll",
            "D:/Documents/GitHub/Rogue-like-game-i-guess/The game is liar/Library/ScriptAssemblies/Unity.RenderPipelines.Universal.Shaders.dll",
            "D:/Documents/GitHub/Rogue-like-game-i-guess/The game is liar/Library/ScriptAssemblies/Unity.Searcher.Editor.dll",
            "D:/Documents/GitHub/Rogue-like-game-i-guess/The game is liar/Library/ScriptAssemblies/Unity.ShaderGraph.Editor.dll",
            "D:/Documents/GitHub/Rogue-like-game-i-guess/The game is liar/Library/ScriptAssemblies/Unity.ShaderGraph.Utilities.dll",
            "D:/Documents/GitHub/Rogue-like-game-i-guess/The game is liar/Library/ScriptAssemblies/Unity.TextMeshPro.dll",
            "D:/Documents/GitHub/Rogue-like-game-i-guess/The game is liar/Library/ScriptAssemblies/Unity.TextMeshPro.Editor.dll",
            "D:/Documents/GitHub/Rogue-like-game-i-guess/The game is liar/Library/ScriptAssemblies/Unity.Timeline.dll",
            "D:/Documents/GitHub/Rogue-like-game-i-guess/The game is liar/Library/ScriptAssemblies/Unity.Timeline.Editor.dll",
            "D:/Documents/GitHub/Rogue-like-game-i-guess/The game is liar/Library/ScriptAssemblies/Unity.VisualStudio.Editor.dll",
            
            "D:/Documents/GitHub/Rogue-like-game-i-guess/The game is liar/Library/ScriptAssemblies/UnityEngine.TestRunner.dll",
            "D:/Documents/GitHub/Rogue-like-game-i-guess/The game is liar/Library/ScriptAssemblies/UnityEditor.TestRunner.dll",
            "D:/Documents/GitHub/Rogue-like-game-i-guess/The game is liar/Library/ScriptAssemblies/UnityEngine.UI.dll",
            "D:/Documents/GitHub/Rogue-like-game-i-guess/The game is liar/Library/ScriptAssemblies/UnityEditor.UI.dll",
            
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/Unity.Cecil.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/Unity.CompilationPipeline.Common.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEditor.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEditor.CoreModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEditor.DeviceSimulatorModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEditor.DiagnosticsModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEditor.Graphs.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEditor.GraphViewModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEditor.PackageManagerUIModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEditor.QuickSearchModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEditor.SceneTemplateModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEditor.TextCoreFontEngineModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEditor.TextCoreTextEngineModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEditor.UIBuilderModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEditor.UIElementsModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEditor.UIElementsSamplesModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEditor.UIServiceModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEditor.UnityConnectModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/PlaybackEngines/WindowsStandaloneSupport/UnityEditor.WindowsStandalone.Extensions.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.AccessibilityModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.AIModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.AndroidJNIModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.AnimationModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.ARModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.AssetBundleModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.AudioModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.ClothModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.ClusterInputModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.ClusterRendererModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.CoreModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.CrashReportingModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.DirectorModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.DSPGraphModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.GameCenterModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.GIModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.GridModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.HotReloadModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.ImageConversionModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.IMGUIModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.InputLegacyModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.InputModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.JSONSerializeModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.LocalizationModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.NVIDIAModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.ParticleSystemModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.PerformanceReportingModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.Physics2DModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.PhysicsModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.ProfilerModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.RuntimeInitializeOnLoadManagerInitializerModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.ScreenCaptureModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.SharedInternalsModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.SpriteMaskModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.SpriteShapeModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.StreamingModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.SubstanceModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.SubsystemsModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.TerrainModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.TerrainPhysicsModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.TextCoreFontEngineModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.TextCoreTextEngineModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.TextRenderingModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.TilemapModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.TLSModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.UIElementsModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.UIElementsNativeModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.UIModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.UmbraModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.UNETModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.UnityAnalyticsCommonModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.UnityAnalyticsModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.UnityConnectModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.UnityCurlModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.UnityTestProtocolModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestAssetBundleModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestAudioModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestTextureModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestWWWModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.VehiclesModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.VFXModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.VideoModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.VirtualTexturingModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.VRModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.WindModule.dll",
            "D:/Programs/2021.3.36f1/Editor/Data/Managed/UnityEngine/UnityEngine.XRModule.dll",
        };
        
#if true
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
        
#else
        List<Assembly> assemblies = new List<Assembly>(1);
        assemblies.Add(Assembly.LoadFrom("D:/Documents/Projects/HeaderGen/DLLTest/bin/Debug/net8.0/DLLTest.dll"));
#endif
        
        var watch = System.Diagnostics.Stopwatch.StartNew();
        GenerateHeaderFile(assemblies, args.Length > 0 ? args[0] : "");
        watch.Stop();
        Console.WriteLine($"Elapsed time: {watch.Elapsed.TotalMilliseconds}ms");
    }
}
