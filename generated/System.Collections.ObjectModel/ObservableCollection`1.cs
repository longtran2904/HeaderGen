#region System.ObjectModel, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.ObjectModel.dll
#endregion

using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;

namespace System.Collections.ObjectModel
{
    public class ObservableCollection<T> : Collection<T>, INotifyCollectionChanged, INotifyPropertyChanged
    {

        public ObservableCollection();
        public ObservableCollection(IEnumerable<T> collection);
        public ObservableCollection(List<T> list);

        public virtual event NotifyCollectionChangedEventHandler CollectionChanged;
        protected virtual event PropertyChangedEventHandler PropertyChanged;

        public void Move(int oldIndex, int newIndex);
        protected override void ClearItems();
        protected override void RemoveItem(int index);
        protected override void InsertItem(int index, T item);
        protected override void SetItem(int index, T item);
        protected virtual void MoveItem(int oldIndex, int newIndex);
        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e);
        protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e);
        protected IDisposable BlockReentrancy();
        protected void CheckReentrancy();
    }
}
