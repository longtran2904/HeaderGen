#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
    [AddComponentMenu("UI/Legacy/Dropdown", 102)]
    [RequireComponent(typeof(RectTransform))]
    public class Dropdown : Selectable, ICancelHandler, IPointerClickHandler, ISubmitHandler
    {
        protected Dropdown();

        public RectTransform template { get; set; }
        public Text captionText { get; set; }
        public Image captionImage { get; set; }
        public Text itemText { get; set; }
        public Image itemImage { get; set; }
        public List<OptionData> options { get; set; }
        public DropdownEvent onValueChanged { get; set; }
        public float alphaFadeSpeed { get; set; }
        public int value { get; set; }

        public void SetValueWithoutNotify(int input);
        protected override void Awake();
        protected override void Start();
        protected override void OnValidate();
        protected override void OnDisable();
        public void RefreshShownValue();
        public void AddOptions(List<OptionData> options);
        public void AddOptions(List<string> options);
        public void AddOptions(List<Sprite> options);
        public void ClearOptions();
        public virtual void OnPointerClick(PointerEventData eventData);
        public virtual void OnSubmit(BaseEventData eventData);
        public virtual void OnCancel(BaseEventData eventData);
        public void Show();
        protected virtual GameObject CreateBlocker(Canvas rootCanvas);
        protected virtual void DestroyBlocker(GameObject blocker);
        protected virtual GameObject CreateDropdownList(GameObject template);
        protected virtual void DestroyDropdownList(GameObject dropdownList);
        protected virtual DropdownItem CreateItem(DropdownItem itemTemplate);
        protected virtual void DestroyItem(DropdownItem item);
        public void Hide();

        protected internal class DropdownItem : MonoBehaviour, ICancelHandler, IEventSystemHandler, IPointerEnterHandler
        {
            public DropdownItem();

            public Text text { get; set; }
            public Image image { get; set; }
            public RectTransform rectTransform { get; set; }
            public Toggle toggle { get; set; }

            public virtual void OnPointerEnter(PointerEventData eventData);
            public virtual void OnCancel(BaseEventData eventData);
        }
        public class OptionData
        {
            public OptionData();
            public OptionData(string text);
            public OptionData(Sprite image);
            public OptionData(string text, Sprite image);

            public string text { get; set; }
            public Sprite image { get; set; }
        }
        public class OptionDataList
        {
            public OptionDataList();

            public List<OptionData> options { get; set; }
        }
        public class DropdownEvent : UnityEvent<int>
        {
            public DropdownEvent();
        }
    }
}
