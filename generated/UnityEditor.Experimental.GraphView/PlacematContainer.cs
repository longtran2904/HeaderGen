#region UnityEditor.GraphViewModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.GraphViewModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{
    public class PlacematContainer : GraphView.Layer
    {
        public PlacematContainer(GraphView graphView);

        public IEnumerable<Placemat> Placemats { get; }
        public static int PlacematsLayer { get; }

        public bool GetPortCenterOverride(Port port, out Vector2 overriddenPosition);
        public T CreatePlacemat<T>(Rect placematPosition, int zOrder, string placematTitle) where T : Placemat, new();
        public T CreatePlacemat<T>(Func<T> creator, Rect placematPosition, int zOrder, string placematTitle) where T : Placemat;
        public void RemoveAllPlacemats();
        public int GetTopZOrder();
        protected virtual void UpdateElementsOrder();
        public void HideCollapsedEdges();

        public enum CycleDirection
        {
            Up = 0,
            Down = 1
        }
    }
}
