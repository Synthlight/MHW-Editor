using System.Collections.Generic;
using MHW_Template;

namespace MHW_Generator {
    public static partial class Program {
        private static void GenCommonPl() {
            GenPlItemParam();
        }

        private static void GenPlItemParam() {
            GeneratePlDataProps("MHW_Editor.PlData", "PlItemParam", new MhwStructData { // .plip
                size = 512,
                offsetInitial = 0,
                entryCountOffset = -1,
                uniqueIdFormula = "0",
                encryptionKey = EncryptionKeys.PL_PARAM_KEY,
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Unk1", 8, typeof(float)),
                    new MhwStructData.Entry("Potion Power", 12, typeof(uint)),
                    new MhwStructData.Entry("Unk2", 16, typeof(float)),
                    new MhwStructData.Entry("Unk3", 20, typeof(float)),
                    new MhwStructData.Entry("Unk4", 24, typeof(float)),
                    new MhwStructData.Entry("Mega Potion Power", 28, typeof(uint)),
                    new MhwStructData.Entry("Unk5", 32, typeof(float)),
                    new MhwStructData.Entry("Unk6", 36, typeof(float)),
                    new MhwStructData.Entry("Unk7", 40, typeof(float)),
                    new MhwStructData.Entry("Unk8", 44, typeof(byte)),
                    new MhwStructData.Entry("Mega Nutrients Power", 45, typeof(byte)),
                    new MhwStructData.Entry("Unk9", 46, typeof(byte)),
                    new MhwStructData.Entry("Mega Dash Juice Stamina Power", 47, typeof(float)),
                    new MhwStructData.Entry("Dash Juice Stamina Power", 51, typeof(float)),
                    new MhwStructData.Entry("Both Dash Juice Duration", 55, typeof(ushort)),
                    new MhwStructData.Entry("Both Dash Juice Power", 57, typeof(byte)),
                    new MhwStructData.Entry("Unk10", 58, typeof(float)),
                    new MhwStructData.Entry("Unk11", 62, typeof(ushort)),
                    new MhwStructData.Entry("Astera Jerky Power", 64, typeof(float)),
                    new MhwStructData.Entry("Astera Jerky Duration", 68, typeof(ushort)),
                    new MhwStructData.Entry("Unk12", 70, typeof(ushort)),
                    new MhwStructData.Entry("Unk13", 72, typeof(uint)),
                    new MhwStructData.Entry("Unk14", 76, typeof(uint)),
                    new MhwStructData.Entry("Unk15", 80, typeof(float)),
                    new MhwStructData.Entry("Cool Drink Duration", 84, typeof(ushort)),
                    new MhwStructData.Entry("Hot Drink Duration", 86, typeof(ushort)),
                    new MhwStructData.Entry("Might Seed Duration", 88, typeof(ushort)),
                    new MhwStructData.Entry("Might Seed Power", 90, typeof(ushort)),
                    new MhwStructData.Entry("Might Pill Duration", 92, typeof(ushort)),
                    new MhwStructData.Entry("Might Pill Power", 94, typeof(ushort)),
                    new MhwStructData.Entry("Adamant Seed Duration", 96, typeof(ushort)),
                    new MhwStructData.Entry("Adamant Seed Power", 98, typeof(ushort)),
                    new MhwStructData.Entry("Adamant Pill Duration", 100, typeof(ushort)),
                    new MhwStructData.Entry("Adamant Pill Power", 102, typeof(float)),
                    new MhwStructData.Entry("Demondrug Power", 106, typeof(byte)),
                    new MhwStructData.Entry("Mega Demondrug Power", 107, typeof(byte)),
                    new MhwStructData.Entry("Armorskin Power", 108, typeof(byte)),
                    new MhwStructData.Entry("Mega Armorskin Power", 109, typeof(byte)),
                    new MhwStructData.Entry("Lifepowder Power", 110, typeof(ushort)),
                    new MhwStructData.Entry("Dustof Life Power", 112, typeof(ushort)),
                    new MhwStructData.Entry("Herbal Powder Power", 114, typeof(ushort)),
                    new MhwStructData.Entry("Demon Powder Power", 116, typeof(ushort)),
                    new MhwStructData.Entry("Demon Powder Duration", 118, typeof(ushort)),
                    new MhwStructData.Entry("Hardshell Powder Power", 120, typeof(ushort)),
                    new MhwStructData.Entry("Hardshell Powder Duration", 122, typeof(ushort)),
                    new MhwStructData.Entry("Unk16", 124, typeof(ushort)),
                    new MhwStructData.Entry("Unk17", 126, typeof(ushort)),
                    new MhwStructData.Entry("Unk18", 128, typeof(ushort)),
                    new MhwStructData.Entry("Unk19", 130, typeof(ushort)),
                    new MhwStructData.Entry("Unk20", 132, typeof(ushort)),
                    new MhwStructData.Entry("Unk21", 134, typeof(ushort)),
                    new MhwStructData.Entry("Well Done Steak Something", 136, typeof(uint)),
                    new MhwStructData.Entry("Unk22", 140, typeof(float)),
                    new MhwStructData.Entry("Unk23", 144, typeof(float)),
                    new MhwStructData.Entry("Unk24", 148, typeof(float)),
                    new MhwStructData.Entry("Unk25", 152, typeof(ushort)),
                    new MhwStructData.Entry("Unk26", 154, typeof(short)),
                    new MhwStructData.Entry("Unk27", 156, typeof(byte)),
                    new MhwStructData.Entry("Unk28", 157, typeof(float)),
                    new MhwStructData.Entry("Unk29", 161, typeof(float)),
                    new MhwStructData.Entry("Unk30", 165, typeof(float)),
                    new MhwStructData.Entry("Unk31", 169, typeof(float)),
                    new MhwStructData.Entry("Unk32", 173, typeof(float)),
                    new MhwStructData.Entry("Unk33", 177, typeof(float)),
                    new MhwStructData.Entry("Unk34", 181, typeof(float)),
                    new MhwStructData.Entry("Unk35", 185, typeof(float)),
                    new MhwStructData.Entry("Unk36", 189, typeof(float)),
                    new MhwStructData.Entry("Unk37", 193, typeof(float)),
                    new MhwStructData.Entry("Unk38", 197, typeof(float)),
                    new MhwStructData.Entry("Unk39", 201, typeof(uint)),
                    new MhwStructData.Entry("Unk40", 205, typeof(uint)),
                    new MhwStructData.Entry("Unk41", 209, typeof(uint))
                    // TODO: There's more but IDGAF right now.
                }
            });
        }

        public static void GeneratePlDataProps(string @namespace, string className, MhwStructData structData) {
            GenerateItemProps(@namespace, className, structData);

            WriteResult($"{Global.GENERATED_ROOT}\\{@namespace.Replace(".", "\\")}", @namespace, $"{className}Internal", new PlDataItemTemplate {
                Session = new Dictionary<string, object> {
                    {"_namespace", @namespace},
                    {"className", className},
                    {"structData", structData}
                }
            });
        }
    }
}