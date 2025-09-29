#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using System;
using UnityEngine;

namespace UnityEditor.Rendering
{
    public static class CoreEditorDrawer<TData>
    {

        public static readonly IDrawer space;
        public static readonly IDrawer noop;

        public static IDrawer Conditional(Enabler enabler, params IDrawer[] contentDrawers);
        public static IDrawer Conditional(Enabler enabler, params ActionDrawer[] contentDrawers);
        public static IDrawer TernaryConditional(Enabler switch, IDrawer drawIfTrue, IDrawer drawIfFalse);
        public static IDrawer TernaryConditional(Enabler switch, ActionDrawer drawIfTrue, ActionDrawer drawIfFalse);
        public static IDrawer Group(params IDrawer[] contentDrawers);
        public static IDrawer Group(params ActionDrawer[] contentDrawers);
        public static IDrawer Group(float labelWidth, params IDrawer[] contentDrawers);
        public static IDrawer Group(GUIContent header, params IDrawer[] contentDrawers);
        public static IDrawer Group(float labelWidth, params ActionDrawer[] contentDrawers);
        public static IDrawer Group(GUIContent header, params ActionDrawer[] contentDrawers);
        public static IDrawer Group(GroupOption options, params IDrawer[] contentDrawers);
        public static IDrawer Group(GroupOption options, params ActionDrawer[] contentDrawers);
        public static IDrawer Group(float labelWidth, GroupOption options, params IDrawer[] contentDrawers);
        public static IDrawer Group(GUIContent header, GroupOption options, params IDrawer[] contentDrawers);
        public static IDrawer Group(float labelWidth, GroupOption options, params ActionDrawer[] contentDrawers);
        public static IDrawer Group(GUIContent header, GroupOption options, params ActionDrawer[] contentDrawers);
        public static IDrawer Select<T2Data>(DataSelect<T2Data> dataSelect, params CoreEditorDrawer<T2Data>.IDrawer[] otherDrawers);
        public static IDrawer Select<T2Data>(DataSelect<T2Data> dataSelect, params CoreEditorDrawer<T2Data>.ActionDrawer[] otherDrawers);
        public static IDrawer FoldoutGroup<TEnum, TState>(string title, TEnum mask, ExpandedState<TEnum, TState> state, params IDrawer[] contentDrawers) where TEnum : IConvertible, struct;
        public static IDrawer FoldoutGroup<TEnum, TState>(string title, TEnum mask, ExpandedState<TEnum, TState> state, params ActionDrawer[] contentDrawers) where TEnum : IConvertible, struct;
        public static IDrawer FoldoutGroup<TEnum, TState>(string title, TEnum mask, ExpandedState<TEnum, TState> state, FoldoutOption options, params IDrawer[] contentDrawers) where TEnum : IConvertible, struct;
        public static IDrawer FoldoutGroup<TEnum, TState>(string title, TEnum mask, ExpandedState<TEnum, TState> state, FoldoutOption options, params ActionDrawer[] contentDrawers) where TEnum : IConvertible, struct;
        public static IDrawer FoldoutGroup<TEnum, TState>(GUIContent title, TEnum mask, ExpandedState<TEnum, TState> state, params IDrawer[] contentDrawers) where TEnum : IConvertible, struct;
        public static IDrawer FoldoutGroup<TEnum, TState>(GUIContent title, TEnum mask, ExpandedState<TEnum, TState> state, params ActionDrawer[] contentDrawers) where TEnum : IConvertible, struct;
        public static IDrawer FoldoutGroup<TEnum, TState>(GUIContent title, TEnum mask, ExpandedState<TEnum, TState> state, FoldoutOption options, params IDrawer[] contentDrawers) where TEnum : IConvertible, struct;
        public static IDrawer FoldoutGroup<TEnum, TState>(GUIContent title, TEnum mask, ExpandedState<TEnum, TState> state, FoldoutOption options, params ActionDrawer[] contentDrawers) where TEnum : IConvertible, struct;
        [Obsolete("Use AdditionalPropertiesFoldoutGroup instead.")]
        public static IDrawer AdvancedFoldoutGroup<TEnum, TState>(GUIContent foldoutTitle, TEnum foldoutMask, ExpandedState<TEnum, TState> foldoutState, Enabler isAdvanced, SwitchEnabler switchAdvanced, IDrawer normalContent, IDrawer advancedContent, FoldoutOption options = FoldoutOption.Indent) where TEnum : IConvertible, struct;
        [Obsolete("Use AdditionalPropertiesFoldoutGroup instead.")]
        public static IDrawer AdvancedFoldoutGroup<TEnum, TState>(GUIContent foldoutTitle, TEnum foldoutMask, ExpandedState<TEnum, TState> foldoutState, Enabler isAdvanced, SwitchEnabler switchAdvanced, ActionDrawer normalContent, IDrawer advancedContent, FoldoutOption options = FoldoutOption.Indent) where TEnum : IConvertible, struct;
        [Obsolete("Use AdditionalPropertiesFoldoutGroup instead.")]
        public static IDrawer AdvancedFoldoutGroup<TEnum, TState>(GUIContent foldoutTitle, TEnum foldoutMask, ExpandedState<TEnum, TState> foldoutState, Enabler isAdvanced, SwitchEnabler switchAdvanced, IDrawer normalContent, ActionDrawer advancedContent, FoldoutOption options = FoldoutOption.Indent) where TEnum : IConvertible, struct;
        [Obsolete("Use AdditionalPropertiesFoldoutGroup instead.")]
        public static IDrawer AdvancedFoldoutGroup<TEnum, TState>(GUIContent foldoutTitle, TEnum foldoutMask, ExpandedState<TEnum, TState> foldoutState, Enabler isAdvanced, SwitchEnabler switchAdvanced, ActionDrawer normalContent, ActionDrawer advancedContent, FoldoutOption options = FoldoutOption.Indent) where TEnum : IConvertible, struct;
        public static IDrawer AdditionalPropertiesFoldoutGroup<TEnum, TState, TAPEnum, TAPState>(GUIContent foldoutTitle, TEnum foldoutMask, ExpandedState<TEnum, TState> foldoutState, TAPEnum additionalPropertiesMask, AdditionalPropertiesState<TAPEnum, TAPState> additionalPropertiesState, IDrawer normalContent, IDrawer additionalContent, FoldoutOption options = FoldoutOption.Indent) where TEnum : IConvertible, struct where TAPEnum : IConvertible, struct;
        public static IDrawer AdditionalPropertiesFoldoutGroup<TEnum, TState, TAPEnum, TAPState>(GUIContent foldoutTitle, TEnum foldoutMask, ExpandedState<TEnum, TState> foldoutState, TAPEnum additionalPropertiesMask, AdditionalPropertiesState<TAPEnum, TAPState> additionalPropertiesState, ActionDrawer normalContent, IDrawer additionalContent, FoldoutOption options = FoldoutOption.Indent) where TEnum : IConvertible, struct where TAPEnum : IConvertible, struct;
        public static IDrawer AdditionalPropertiesFoldoutGroup<TEnum, TState, TAPEnum, TAPState>(GUIContent foldoutTitle, TEnum foldoutMask, ExpandedState<TEnum, TState> foldoutState, TAPEnum additionalPropertiesMask, AdditionalPropertiesState<TAPEnum, TAPState> additionalPropertiesState, IDrawer normalContent, ActionDrawer additionalContent, FoldoutOption options = FoldoutOption.Indent) where TEnum : IConvertible, struct where TAPEnum : IConvertible, struct;
        public static IDrawer AdditionalPropertiesFoldoutGroup<TEnum, TState, TAPEnum, TAPState>(GUIContent foldoutTitle, TEnum foldoutMask, ExpandedState<TEnum, TState> foldoutState, TAPEnum additionalPropertiesMask, AdditionalPropertiesState<TAPEnum, TAPState> additionalPropertiesState, ActionDrawer normalContent, ActionDrawer additionalContent, FoldoutOption options = FoldoutOption.Indent) where TEnum : IConvertible, struct where TAPEnum : IConvertible, struct;
        public interface IDrawer
        {

            void Draw(TData serializedProperty, Editor owner);
        }
        public delegate bool Enabler(TData data, Editor owner);
        public delegate void SwitchEnabler(TData data, Editor owner);
        public delegate T2Data DataSelect<T2Data>(TData data, Editor owner);
        public delegate void ActionDrawer(TData data, Editor owner);
    }
}
