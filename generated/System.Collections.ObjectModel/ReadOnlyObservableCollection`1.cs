#region System.ObjectModel, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.ObjectModel.dll
#endregion

using System.Collections.Specialized;
using System.ComponentModel;

namespace System.Collections.ObjectModel
{
    public class ReadOnlyObservableCollection<T> : ReadOnlyCollection<T>, INotifyCollectionChanged, INotifyPropertyChanged
    {

        public ReadOnlyObservableCollection(ObservableCollection<T> list);

        public static ReadOnlyObservableCollection<T> Empty { get; }

        protected virtual event NotifyCollectionChangedEventHandler CollectionChanged;
        protected virtual event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs args);
        protected virtual void OnPropertyChanged(PropertyChangedEventArgs args);
    }
}
