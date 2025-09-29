#region Unity.ShaderGraph.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.ShaderGraph.Editor.dll
#endregion

using System;
using UnityEngine.UIElements;

public class TabButton : VisualElement
{
    public TabButton();
    public TabButton(string text, VisualElement target);

    public bool IsCloseable { get; set; }
    public string TargetId { get; }
    public VisualElement Target { get; set; }

    public event Action<TabButton> OnSelect;
    public event Action<TabButton> OnClose;

    public void Select();
    public void Deselect();
}
