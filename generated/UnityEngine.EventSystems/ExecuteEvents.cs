#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

namespace UnityEngine.EventSystems
{
    public static class ExecuteEvents
    {
        public static EventFunction<IPointerMoveHandler> pointerMoveHandler { get; }
        public static EventFunction<IPointerEnterHandler> pointerEnterHandler { get; }
        public static EventFunction<IPointerExitHandler> pointerExitHandler { get; }
        public static EventFunction<IPointerDownHandler> pointerDownHandler { get; }
        public static EventFunction<IPointerUpHandler> pointerUpHandler { get; }
        public static EventFunction<IPointerClickHandler> pointerClickHandler { get; }
        public static EventFunction<IInitializePotentialDragHandler> initializePotentialDrag { get; }
        public static EventFunction<IBeginDragHandler> beginDragHandler { get; }
        public static EventFunction<IDragHandler> dragHandler { get; }
        public static EventFunction<IEndDragHandler> endDragHandler { get; }
        public static EventFunction<IDropHandler> dropHandler { get; }
        public static EventFunction<IScrollHandler> scrollHandler { get; }
        public static EventFunction<IUpdateSelectedHandler> updateSelectedHandler { get; }
        public static EventFunction<ISelectHandler> selectHandler { get; }
        public static EventFunction<IDeselectHandler> deselectHandler { get; }
        public static EventFunction<IMoveHandler> moveHandler { get; }
        public static EventFunction<ISubmitHandler> submitHandler { get; }
        public static EventFunction<ICancelHandler> cancelHandler { get; }

        public static T ValidateEventData<T>(BaseEventData data) where T : class;
        public static bool Execute<T>(GameObject target, BaseEventData eventData, EventFunction<T> functor) where T : IEventSystemHandler;
        public static GameObject ExecuteHierarchy<T>(GameObject root, BaseEventData eventData, EventFunction<T> callbackFunction) where T : IEventSystemHandler;
        public static bool CanHandleEvent<T>(GameObject go) where T : IEventSystemHandler;
        public static GameObject GetEventHandler<T>(GameObject root) where T : IEventSystemHandler;

        public delegate void EventFunction<T1>(T1 handler, BaseEventData eventData);
    }
}
