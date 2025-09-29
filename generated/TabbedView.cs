#region Unity.ShaderGraph.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.ShaderGraph.Editor.dll
#endregion

using UnityEngine.UIElements;

public class TabbedView : VisualElement
{
    public TabbedView();

    public override VisualElement contentContainer { get; }

    public void AddTab(TabButton tabButton, bool activate);
    public void RemoveTab(TabButton tabButton);
    public void Activate(TabButton button);

    public class UxmlFactory : UxmlFactory<TabbedView, UxmlTraits>
    {
        public UxmlFactory();
    }
}
