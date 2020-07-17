using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using JetBrains.Annotations;
using MHW_Editor.Windows;

namespace MHW_Editor.Models {
    public abstract class MhwStructDataContainer {
        public readonly Type type;

        protected MhwStructDataContainer(Type type) {
            this.type = type;
        }

        public abstract void SetupView(Grid grid, MainWindow main);
        public abstract void PrepSave();
        public abstract void WriteData(BinaryWriter writer);

        public abstract string GridName        { get; }
        public abstract bool   IsHidden        { get; }
        public abstract bool   IsAddingAllowed { get; }
        public abstract string Description     { get; }

        public abstract IEnumerable<object> GetGenericEnumerable();
        public abstract IEnumerable<E>      GetEnumerable<E>();
        public abstract object              First();
        public abstract void                Add_Click(object sender, RoutedEventArgs e);
    }

    public class MhwStructDataContainer<T> : MhwStructDataContainer where T : IMhwStructItem, IWriteData {
        public readonly ObservableMhwStructCollection<T> list;

        public MhwStructDataContainer(ObservableMhwStructCollection<T> list, Type type) : base(type) {
            this.list = list;
        }

        public override void SetupView(Grid grid, MainWindow main) {
            if (IsHidden) return;

            grid.AddControl(new Label {Content = GridName, FontSize = MainWindow.FONT_SIZE});

            var desc = Description;
            if (desc != null) {
                grid.AddControl(new Label {Content = desc, FontSize = MainWindow.FONT_SIZE * .8});
            }

            if (type.IsGeneric(typeof(IHasCustomView<>))) {
                main.AddDataGrid(((IHasCustomView<MultiStructItemCustomView>) list[0]).GetCustomView());
            } else {
                var dataGrid = main.AddDataGrid(list);
                dataGrid.IsAddingAllowed = IsAddingAllowed;
            }
        }

        public override void PrepSave() {
        }

        public override void WriteData(BinaryWriter writer) {
            foreach (var obj in list) {
                obj.WriteData(writer);
            }
        }

        public override string GridName        => (string) (typeof(T).GetField(nameof(GridName), BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)?.GetValue(null) ?? false);
        public override bool   IsHidden        => (bool) (typeof(T).GetField(nameof(IsHidden), BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)?.GetValue(null) ?? false);
        public override bool   IsAddingAllowed => (bool) (typeof(T).GetField(nameof(IsAddingAllowed), BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)?.GetValue(null) ?? false);
        public override string Description     => (string) typeof(T).GetField(nameof(Description), BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)?.GetValue(null);

        public override IEnumerable<object> GetGenericEnumerable() {
            return list.Cast<object>();
        }

        public override IEnumerable<E> GetEnumerable<E>() {
            return list.Cast<E>().SelectMany(GetEnumerable);
        }

        private IEnumerable<E> GetEnumerable<E>(E item) {
            yield return item;

            if (item is IHasChildren itemWithChildren) {
                foreach (var innerItem in itemWithChildren.GetAllEnumerableChildrenOfType<E>()) {
                    foreach (var enumerableItem in GetEnumerable(innerItem)) {
                        yield return enumerableItem;
                    }
                }
            }
        }

        public override object First() {
            return list[0];
        }

        public override void Add_Click(object sender, RoutedEventArgs e) {
            var instance = (T) Activator.CreateInstance(typeof(T));
            instance.Index = (ulong) list.Count;
            list.Add(instance);
        }
    }

    public class MhwStructDataContainer<T, C> : MhwStructDataContainer<T> where T : IMhwStructItem, IWriteData
                                                                          where C : IMhwStructItem, IWriteData {
        [CanBeNull] private MhwStructDataContainer<C> target;
        private             int                       targetIndex;
        [CanBeNull] private string                    fieldName;

        public MhwStructDataContainer(ObservableMhwStructCollection<T> list, Type type) : base(list, type) {
        }

        [SuppressMessage("ReSharper", "ParameterHidesMember")]
        public void SetCountTargetToUpdate(MhwStructDataContainer<C> target, int targetIndex, string fieldName) {
            this.target      = target;
            this.targetIndex = targetIndex;
            this.fieldName   = fieldName;
        }

        public override void PrepSave() {
            if (target == null || fieldName == null) return;

            var item = targetIndex > -1 ? target.list[targetIndex] : target.list.Last();

            var setter = item.GetType().GetProperty(fieldName, BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy)?.GetSetMethod();
            if (setter == null) throw new NotSupportedException($"Setter not found.\r\n\r\n{target.GetType().Name} :: {fieldName}");

            setter.Invoke(item, new object[] {(uint) list.Count});
        }
    }
}