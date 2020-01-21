using System.ComponentModel;

namespace MHW_Template.Items {
    public enum ItemType {
        [Description("Item")]
        ITEM = 0,
        [Description("Material")]
        MATERIAL = 1,
        [Description("Account Item")]
        ACCOUNT_ITEM,
        [Description("Ammo/Coating")]
        AMMO_OR_COATING,
        [Description("Decoration")]
        DECORATION
    }
}