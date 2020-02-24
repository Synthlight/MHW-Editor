using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using MHW_Editor.PlData;

namespace MHW_Editor.Models {
    public class PlItemCustomView : MhwItem {
        private readonly PlItemParam parent;
        private readonly MethodInfo getMethod;
        private readonly MethodInfo setMethod;
        private readonly Type propertyType;

        public PlItemCustomView(PlItemParam parent, string name, string propertyName, byte[] bytes, ulong offset) : base(bytes, offset) {
            this.parent = parent;
            Name = name;

            var property = parent.GetType().GetProperty(propertyName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            Debug.Assert(property != null, nameof(property) + " != null");

            propertyType = property.PropertyType;
            getMethod = property.GetGetMethod();
            setMethod = property.GetSetMethod();
        }

        public override string UniqueId => "0";

        [SortOrder(0)]
        public override string Name { get; }

        [SortOrder(25)]
        [DisplayName("Data")]
        public float Data {
            get {
                var value = getMethod.Invoke(parent, null);
                return (float) Convert.ChangeType(value, typeof(float));
            }
            set {
                var returnValue = Convert.ChangeType(value, propertyType);
                setMethod.Invoke(parent, new[] {returnValue});
                OnPropertyChanged(nameof(Data));
            }
        }

        [SortOrder(50)]
        [DisplayName("Type")]
        public string Type => propertyType.Name;
    }
}