#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Internal;

namespace UnityEditor
{
    public sealed class EditorStyles
    {
        public EditorStyles();

        public static GUIStyle label { get; }
        public static GUIStyle miniLabel { get; }
        public static GUIStyle largeLabel { get; }
        public static GUIStyle boldLabel { get; }
        public static GUIStyle miniBoldLabel { get; }
        public static GUIStyle centeredGreyMiniLabel { get; }
        public static GUIStyle wordWrappedMiniLabel { get; }
        public static GUIStyle wordWrappedLabel { get; }
        public static GUIStyle linkLabel { get; }
        public static GUIStyle whiteLabel { get; }
        public static GUIStyle whiteMiniLabel { get; }
        public static GUIStyle whiteLargeLabel { get; }
        public static GUIStyle whiteBoldLabel { get; }
        public static GUIStyle radioButton { get; }
        public static GUIStyle miniButton { get; }
        public static GUIStyle miniButtonLeft { get; }
        public static GUIStyle miniButtonMid { get; }
        public static GUIStyle miniButtonRight { get; }
        public static GUIStyle miniPullDown { get; }
        public static GUIStyle textField { get; }
        public static GUIStyle textArea { get; }
        public static GUIStyle miniTextField { get; }
        public static GUIStyle numberField { get; }
        public static GUIStyle popup { get; }
        [Obsolete("structHeadingLabel is deprecated, use EditorStyles.label instead.")]
        public static GUIStyle structHeadingLabel { get; }
        public static GUIStyle objectField { get; }
        public static GUIStyle objectFieldThumb { get; }
        public static GUIStyle objectFieldMiniThumb { get; }
        public static GUIStyle colorField { get; }
        public static GUIStyle layerMaskField { get; }
        public static GUIStyle toggle { get; }
        public static GUIStyle foldout { get; }
        public static GUIStyle foldoutPreDrop { get; }
        public static GUIStyle foldoutHeader { get; }
        public static GUIStyle foldoutHeaderIcon { get; }
        public static GUIStyle toggleGroup { get; }
        public static Font standardFont { get; }
        public static Font boldFont { get; }
        public static Font miniFont { get; }
        public static Font miniBoldFont { get; }
        public static GUIStyle toolbar { get; }
        public static GUIStyle toolbarButton { get; }
        public static GUIStyle toolbarPopup { get; }
        public static GUIStyle toolbarDropDown { get; }
        public static GUIStyle toolbarTextField { get; }
        public static GUIStyle inspectorDefaultMargins { get; }
        public static GUIStyle inspectorFullWidthMargins { get; }
        public static GUIStyle helpBox { get; }
        public static GUIStyle toolbarSearchField { get; }
        public static GUIStyle iconButton { get; }
        public static GUIStyle selectionRect { get; }

        [ExcludeFromDocs]
        public static GUIStyle FromUSS(string ussStyleRuleName, string ussInPlaceStyleOverride = null);
        [ExcludeFromDocs]
        public static GUIStyle FromUSS(GUIStyle baseStyle, string ussStyleRuleName, string ussInPlaceStyleOverride = null);
        [ExcludeFromDocs]
        public static GUIStyle ApplyUSS(GUIStyle style, string ussStyleRuleName, string ussInPlaceStyleOverride = null);
    }
}
