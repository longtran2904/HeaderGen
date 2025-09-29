#region Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.dll
#endregion

using UnityEngine;
using UnityEngine.EventSystems;

namespace TMPro
{
    public class TMP_ScrollbarEventHandler : MonoBehaviour, IDeselectHandler, IEventSystemHandler, IPointerClickHandler, ISelectHandler
    {
        public bool isSelected;

        public TMP_ScrollbarEventHandler();

        public void OnPointerClick(PointerEventData eventData);
        public void OnSelect(BaseEventData eventData);
        public void OnDeselect(BaseEventData eventData);
    }
}
