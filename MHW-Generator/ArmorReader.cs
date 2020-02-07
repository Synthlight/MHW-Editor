using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using MHW_Editor.Armors;

namespace MHW_Generator {
    public static class ArmorReader {
        public static Dictionary<Armor, ushort> GetArmor() {
            // ReSharper disable once StringLiteralTypo
            const string targetFile = @"V:\MHW\IB\chunk_combined\common\equip\armor.am_dat";
            var armors = new Dictionary<Armor, ushort>();

            using (var dat = new BinaryReader(new FileStream(targetFile, FileMode.Open, FileAccess.Read))) {
                dat.BaseStream.Seek(6, SeekOrigin.Begin);
                var count = dat.ReadUInt32();

                dat.BaseStream.Seek(10, SeekOrigin.Begin);

                for (var i = 0; i < count; i++) {
                    var position = dat.BaseStream.Position;
                    var buff = dat.ReadBytes((int) Armor.StructSize);

                    var armor = new Armor(buff, (ulong) position);
                    var gmdIndex = Convert.ToUInt16(armor.GetType().GetProperty("GMD_Name_Index", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(armor));

                    armors[armor] = gmdIndex;
                }
            }

            return armors;
        }
    }
}