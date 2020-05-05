using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using JetBrains.Annotations;

namespace MHW_Editor.Models {
    public class ObservableMhwStructCollection<T> : ObservableCollection<T> where T : IMhwStructItem {
        public ObservableMhwStructCollection() {
        }

        public ObservableMhwStructCollection([NotNull] List<T> list) : base(list) {
        }

        public ObservableMhwStructCollection([NotNull] IEnumerable<T> collection) : base(collection) {
        }

        protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e) {
            for (var i = 0; i < Items.Count; i++) {
                var item = (IMhwStructItem) Items[i];
                item.Index = (ulong) i;
                item.OnPropertyChanged(nameof(IMhwStructItem.Index));
            }

            base.OnCollectionChanged(e);
        }
    }
}