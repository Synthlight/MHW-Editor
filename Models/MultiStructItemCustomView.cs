using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using JetBrains.Annotations;

namespace MHW_Editor.Models {
    public class MultiStructItemCustomView : MhwStructItem {
        private readonly IHasCustomView<MultiStructItemCustomView> parent;
        private readonly MethodInfo getMethod;
        private readonly MethodInfo setMethod;
        private readonly Type propertyType;

        public MultiStructItemCustomView(IHasCustomView<MultiStructItemCustomView> parent, string name, string propertyName) {
            this.parent = parent;
            Name = name;

            var property = parent.GetType().GetProperty(propertyName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            Debug.Assert(property != null, nameof(property) + " != null");

            propertyType = property.PropertyType;
            getMethod = property.GetGetMethod();
            setMethod = property.GetSetMethod();
        }

        [SortOrder(0)]
        [UsedImplicitly]
        public string Name { get; }

        [DisplayName("")] // Hide it for vertical view since it will always be 0;
        public override ulong Index => base.Index;

        [SortOrder(25)]
        [DisplayName("Data")]
        public object Data {
            get {
                var value = getMethod.Invoke(parent, null);
                return Convert.ChangeType(value, typeof(object));
            }
            set {
                if (setMethod == null) return;
                try {
                    var returnValue = Convert.ChangeType(value, propertyType);
                    setMethod.Invoke(parent, new[] {returnValue});
                    OnPropertyChanged(nameof(Data));
                } catch (FormatException) {
                }
            }
        }

        [SortOrder(50)]
        [DisplayName("Type")]
        [UsedImplicitly]
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
                    TypeCode.String => "string",
                    _ => throw new ArgumentOutOfRangeException()
                };
            }
        }

        public override void WriteData(BinaryWriter writer) {
            throw new NotImplementedException();
        }
    }
}