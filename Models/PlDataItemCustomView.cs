using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;

namespace MHW_Editor.Models {
    public class PlDataItemCustomView : MhwItem {
        private readonly IHasCustomView<PlDataItemCustomView> parent;
        private readonly MethodInfo getMethod;
        private readonly MethodInfo setMethod;
        private readonly Type propertyType;

        public PlDataItemCustomView(IHasCustomView<PlDataItemCustomView> parent, string name, string propertyName, byte[] bytes, ulong offset) : base(bytes, offset) {
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
        public string Type {
            get {
                // ReSharper disable once SwitchExpressionHandlesSomeKnownEnumValuesWithExceptionInDefault
                return System.Type.GetTypeCode(propertyType) switch {
                    TypeCode.Single => "float",
                    TypeCode.Double => "double",
                    TypeCode.Byte => "uInt8",
                    TypeCode.SByte => "sInt8",
                    TypeCode.UInt16 => "uInt16",
                    TypeCode.Int16 => "sInt16",
                    TypeCode.UInt32 => "uInt32",
                    TypeCode.Int32 => "sInt32",
                    TypeCode.Int64 => "sInt64",
                    TypeCode.UInt64 => "sInt64",
                    _ => throw new ArgumentOutOfRangeException()
                };
            }
        }
    }
}