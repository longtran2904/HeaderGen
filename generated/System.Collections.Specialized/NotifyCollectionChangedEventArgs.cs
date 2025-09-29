#region System.ObjectModel, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.ObjectModel.dll
#endregion

namespace System.Collections.Specialized
{
    public class NotifyCollectionChangedEventArgs : EventArgs
    {
        public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action);
        public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object changedItem);
        public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object changedItem, int index);
        public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList changedItems);
        public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList changedItems, int startingIndex);
        public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object newItem, object oldItem);
        public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object newItem, object oldItem, int index);
        public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList newItems, IList oldItems);
        public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex);
        public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object changedItem, int index, int oldIndex);
        public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList changedItems, int index, int oldIndex);

        public NotifyCollectionChangedAction Action { get; }
        public IList NewItems { get; }
        public IList OldItems { get; }
        public int NewStartingIndex { get; }
        public int OldStartingIndex { get; }
    }
}
