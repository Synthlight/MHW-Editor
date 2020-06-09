using System.Collections.Generic;
using MHW_Editor.Assets;
using MHW_Editor.Structs.Items;
using MHW_Template;

namespace MHW_Generator_Data {
    public static class ItemReader {
        public static IEnumerable<uint> GetGemIds() {
            // ReSharper disable once StringLiteralTypo
            const string targetFile = @"V:\MHW\IB\chunk_combined\common\item\itemData.itm";

            foreach (var item in Item.LoadData(targetFile).GetIterableStructList()) {
                var itemId = item.Id;
                if (DataHelper.itemNames["eng"].TryGet(itemId).Contains(" Jewel")) {
                    yield return itemId;
                }
            }
        }
    }
}