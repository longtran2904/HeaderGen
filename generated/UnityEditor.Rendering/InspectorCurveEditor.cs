#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.Rendering
{
    public sealed class InspectorCurveEditor
    {
        public readonly Settings settings;

        public InspectorCurveEditor();
        public InspectorCurveEditor(Settings settings);

        public void Add(params SerializedProperty[] curves);
        public void Add(SerializedProperty curve);
        public void Add(SerializedProperty curve, CurveState state);
        public void Remove(SerializedProperty curve);
        public void RemoveAll();
        public CurveState GetCurveState(SerializedProperty curve);
        public void SetCurveState(SerializedProperty curve, CurveState state);
        public Selection GetSelection();
        public void SetKeyframe(SerializedProperty curve, int keyframeIndex, Keyframe keyframe);
        public bool OnGUI(Rect rect);

        public struct Settings
        {
            public Rect bounds;
            public RectOffset padding;
            public Color selectionColor;
            public float curvePickingDistance;
            public float keyTimeClampingDistance;

            public static Settings defaultSettings { get; }
        }
        public struct CurveState
        {
            public bool visible;
            public bool editable;
            public uint minPointCount;
            public float zeroKeyConstantValue;
            public Color color;
            public float width;
            public float handleWidth;
            public bool showNonEditableHandles;
            public bool onlyShowHandlesOnSelection;
            public bool loopInBounds;

            public static CurveState defaultState { get; }
        }
        public struct Selection
        {
            public SerializedProperty curve;
            public int keyframeIndex;
            public Keyframe? keyframe;

            public Selection(SerializedProperty curve, int keyframeIndex, Keyframe? keyframe);
        }
    }
}
