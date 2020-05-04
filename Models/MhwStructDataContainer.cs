using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Windows;
using JetBrains.Annotations;

namespace MHW_Editor.Models {
    public class MhwStructDataContainer {
        public readonly     ObservableCollection<object> list;
        public readonly     Type                         type;
        [CanBeNull] private MhwStructDataContainer       target;
        private             int                          targetIndex;
        [CanBeNull] private string                       fieldName;

        public MhwStructDataContainer(ObservableCollection<object> list, Type type) {
            this.list = list;
            this.type = type;

            list.CollectionChanged += List_CollectionChanged;
        }

        [SuppressMessage("ReSharper", "ParameterHidesMember")]
        public void SetCountTargetToUpdate(MhwStructDataContainer target, int targetIndex, string fieldName) {
            this.target      = target;
            this.targetIndex = targetIndex;
            this.fieldName   = fieldName;
        }

        public void PrepSave() {
            if (target == null || fieldName == null) return;

            var item = targetIndex > -1 ? target.list[targetIndex] : target.list.Last();

            var setter = item.GetType().GetProperty(fieldName, BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy)?.GetSetMethod();
            if (setter == null) throw new NotSupportedException($"Setter not found.\r\n\r\n{target.GetType().Name} :: {fieldName}");

            setter.Invoke(item, new object[] {(uint) list.Count});
        }

        private void List_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e) {
            ResetIndexes();
        }

        public string GridName        => (string) (type.GetField(nameof(GridName), BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)?.GetValue(null) ?? false);
        public bool   IsHidden        => (bool) (type.GetField(nameof(IsHidden), BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)?.GetValue(null) ?? false);
        public bool   IsAddingAllowed => (bool) (type.GetField(nameof(IsAddingAllowed), BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)?.GetValue(null) ?? false);

        public void Add_Click(object sender, RoutedEventArgs e) {
            var instance = (MhwStructItem) Activator.CreateInstance(type);
            instance.Index = (ulong) list.Count;
            list.Add(instance);
        }

        private void ResetIndexes() {
            for (var i = 0; i < list.Count; i++) {
                var item = (MhwStructItem) list[i];
                item.Index = (ulong) i;
                item.OnPropertyChanged(nameof(MhwStructItem.Index));
            }
        }
    }
}