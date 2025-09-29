#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public class NavigationMoveEvent : NavigationEventBase<NavigationMoveEvent>
    {

        public NavigationMoveEvent();

        public Direction direction { get; }
        public Vector2 move { get; }

        public static NavigationMoveEvent GetPooled(Vector2 moveVector);
        protected override void Init();
        public enum Direction
        {

            None = 0,
            Left = 1,
            Up = 2,
            Right = 3,
            Down = 4
        }
    }
}
