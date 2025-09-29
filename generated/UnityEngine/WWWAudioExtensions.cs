#region UnityEngine.UnityWebRequestWWWModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UnityWebRequestWWWModule.dll
#endregion

using System;

namespace UnityEngine
{
    public static class WWWAudioExtensions
    {
        [Obsolete("WWWAudioExtensions.GetAudioClip extension method has been replaced by WWW.GetAudioClip instance method. (UnityUpgradable) -> WWW.GetAudioClip()", True)]
        public static AudioClip GetAudioClip(this WWW www);
        [Obsolete("WWWAudioExtensions.GetAudioClip extension method has been replaced by WWW.GetAudioClip instance method. (UnityUpgradable) -> WWW.GetAudioClip([mscorlib] System.Boolean)", True)]
        public static AudioClip GetAudioClip(this WWW www, bool threeD);
        [Obsolete("WWWAudioExtensions.GetAudioClip extension method has been replaced by WWW.GetAudioClip instance method. (UnityUpgradable) -> WWW.GetAudioClip([mscorlib] System.Boolean, [mscorlib] System.Boolean)", True)]
        public static AudioClip GetAudioClip(this WWW www, bool threeD, bool stream);
        [Obsolete("WWWAudioExtensions.GetAudioClip extension method has been replaced by WWW.GetAudioClip instance method. (UnityUpgradable) -> WWW.GetAudioClip([mscorlib] System.Boolean, [mscorlib] System.Boolean, UnityEngine.AudioType)", True)]
        public static AudioClip GetAudioClip(this WWW www, bool threeD, bool stream, AudioType audioType);
        [Obsolete("WWWAudioExtensions.GetAudioClipCompressed extension method has been replaced by WWW.GetAudioClipCompressed instance method. (UnityUpgradable) -> WWW.GetAudioClipCompressed()", True)]
        public static AudioClip GetAudioClipCompressed(this WWW www);
        [Obsolete("WWWAudioExtensions.GetAudioClipCompressed extension method has been replaced by WWW.GetAudioClipCompressed instance method. (UnityUpgradable) -> WWW.GetAudioClipCompressed([mscorlib] System.Boolean)", True)]
        public static AudioClip GetAudioClipCompressed(this WWW www, bool threeD);
        [Obsolete("WWWAudioExtensions.GetAudioClipCompressed extension method has been replaced by WWW.GetAudioClipCompressed instance method. (UnityUpgradable) -> WWW.GetAudioClipCompressed([mscorlib] System.Boolean, UnityEngine.AudioType)", True)]
        public static AudioClip GetAudioClipCompressed(this WWW www, bool threeD, AudioType audioType);
        [Obsolete("WWWAudioExtensions.GetMovieTexture extension method has been replaced by WWW.GetMovieTexture instance method. (UnityUpgradable) -> WWW.GetMovieTexture()", True)]
        public static MovieTexture GetMovieTexture(this WWW www);
    }
}
