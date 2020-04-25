using System;
using MHW_Editor.Models;

namespace MHW_Editor.Items {
    public partial class ShopList : MhwMultiStructItem<ShopList> {
        protected override ulong GetEntryCount(Type type) {
            if (type == typeof(Entries)) {
                return GetFirstEntry<Shop_List>().Item_Count;
            }

            return base.GetEntryCount(type);
        }

        protected override void PrepSave() {
            GetFirstEntry<Shop_List>().Item_Count = (uint) GetDataContainer<Entries>().list.Count;
        }
    }
}