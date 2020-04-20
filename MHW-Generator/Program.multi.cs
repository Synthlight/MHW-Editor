using System.Collections.Generic;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Generator {
    public static partial class Program {
        private static void GenMultiStruct() {
            GenShellProjectile();
            GenSupplyData();
        }

        private static void GenShellProjectile() {
            var structs = new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("Shlp", new List<MhwMultiStructData.StructData.Entry> {
                    new MhwMultiStructData.StructData.Entry("Magic 1", typeof(uint), true),
                    new MhwMultiStructData.StructData.Entry("SLP", typeof(char), true, typeof(string), arrayCount: 4),
                    new MhwMultiStructData.StructData.Entry("Magic 2", typeof(uint), true)
                }, 1),
                new MhwMultiStructData.StructData("Assets", new List<MhwMultiStructData.StructData.Entry> {
                    new MhwMultiStructData.StructData.Entry("Magic", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry("Path", typeof(string), isNullTerminatedString: true, condition: "if (data.Magic_raw != 0)")
                }, 25)
            };

            GenerateMultiStructProps("MHW_Editor.Weapons", "ShellProjectile", new MhwMultiStructData(structs, 0, EncryptionKeys.FILE_EXT_KEY_LOOKUP[".shlp"]));
        }

        private static void GenSupplyData() { // .supp
            var structs = new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("Supply Data", new List<MhwMultiStructData.StructData.Entry> {
                    new MhwMultiStructData.StructData.Entry("Magic 1", typeof(uint), true),
                    new MhwMultiStructData.StructData.Entry("Magic 2", typeof(uint), true),
                    new MhwMultiStructData.StructData.Entry("Magic 3", typeof(ushort), true),
                    new MhwMultiStructData.StructData.Entry("Supply Id", typeof(uint))
                }, 1),

                new MhwMultiStructData.StructData("Item Box", new List<MhwMultiStructData.StructData.Entry> {
                    new MhwMultiStructData.StructData.Entry("Item Id", typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.StructData.Entry("Item Count", typeof(ushort))
                }, 24),

                new MhwMultiStructData.StructData("Item Box Scaling", new List<MhwMultiStructData.StructData.Entry> {
                    new MhwMultiStructData.StructData.Entry("Items to Show", typeof(byte))
                }, 3),

                new MhwMultiStructData.StructData("Ammo Box", new List<MhwMultiStructData.StructData.Entry> {
                    new MhwMultiStructData.StructData.Entry("Ammo Id", typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.StructData.Entry("Ammo Count", typeof(ushort))
                }, 16),

                new MhwMultiStructData.StructData("Ammo Box Scaling", new List<MhwMultiStructData.StructData.Entry> {
                    new MhwMultiStructData.StructData.Entry("Ammo Items to Show", typeof(byte))
                }, 3)
            };

            GenerateMultiStructProps("MHW_Editor.Items", "SupplyData", new MhwMultiStructData(structs, 0));
        }

        public static void GenerateMultiStructProps(string @namespace, string className, MhwMultiStructData structData) {
            WriteResult($"{Global.GENERATED_ROOT}\\{@namespace.Replace(".", "\\")}", @namespace, className, new MultiStructItemTemplate {
                Session = new Dictionary<string, object> {
                    {"_namespace", @namespace},
                    {"className", className},
                    {"structData", structData}
                }
            });
        }
    }
}