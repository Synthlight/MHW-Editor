using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Items;
using MHW_Template.Models;

namespace MHW_Generator.Items {
    public class ItemLottery : ISingleStruct {
        public SingleStruct Generate() { // .itlot
            var entries = new List<MhwStructData.Entry>();

            const ulong itemIdStart = 0;
            const ulong itemCountStart = 20;
            const ulong itemWeightStart = 30;
            const ulong itemUnkStart = 40;

            for (ulong i = 0; i < 10; i++) {
                entries.Add(new MhwStructData.Entry($"Item {i + 1} Id", itemIdStart + i * 2, typeof(ushort), dataSourceType: DataSourceType.Items));
                entries.Add(new MhwStructData.Entry($"Item {i + 1} Cnt", itemCountStart + i, typeof(byte)));
                entries.Add(new MhwStructData.Entry($"Item {i + 1} %", itemWeightStart + i, typeof(byte), valueString: "value.Clamp((byte) 0, (byte) 100)"));
                entries.Add(new MhwStructData.Entry($"Item {i + 1} Carve Anim", itemUnkStart + i, typeof(byte), typeof(CarveAnimation)));
            }

            return new SingleStruct("MHW_Editor.Items", "ItemLottery", new MhwStructData {
                size = 50,
                offsetInitial = 10,
                entryCountOffset = 6,
                encryptionKey = EncryptionKeys.ITLOT_KEY,
                uniqueIdFormula = "{Index}",
                entries = entries
            });
        }
    }
}