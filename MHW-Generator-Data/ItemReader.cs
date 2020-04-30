using System.Collections.Generic;
using System.IO;
using MHW_Editor.Assets;
using MHW_Editor.Items;
using MHW_Template;
using MHW_Template.Armors;

namespace MHW_Generator_Data {
    public static class ItemReader {
        public static IEnumerable<uint> GetGemIds() {
            // ReSharper disable once StringLiteralTypo
            const string targetFile = @"V:\MHW\IB\chunk_combined\common\item\itemData.itm";

            using var dat = new BinaryReader(new FileStream(targetFile, FileMode.Open, FileAccess.Read));
            dat.BaseStream.Seek(6, SeekOrigin.Begin);
            var count = dat.ReadUInt32();

            dat.BaseStream.Seek(10, SeekOrigin.Begin);

            for (var i = 0; i < count; i++) {
                var position = dat.BaseStream.Position;
                var buff     = dat.ReadBytes((int) Item.StructSize);

                var itemId = new Item(buff, (ulong) position).Id;
                if (DataHelper.itemNames["eng"].TryGet(itemId).Contains(" Jewel")) {
                    yield return itemId;
                }
            }
        }
    }
}