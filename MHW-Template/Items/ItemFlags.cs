using System;

namespace MHW_Template.Items {
    [Flags]
    public enum ItemFlags {
        None = 0,
        Infinity_Symbol = 1,
        Supply_Item = 1 << 1,
        Unknown = 1 << 2, // Edible Berry/Meat/Fish. Maybe just affects stamina or status? Or Edible without drinking animation?
        Consumable = 1 << 3,
        Fey_or_Streamstone = 1 << 4,
        Infinite_Use = 1 << 5,
        Star = 1 << 6,
        New_Palico_Gadget_Symbol = 1 << 7,
        Level_1 = 1 << 8,
        Level_2 = 1 << 9,
        Level_3 = 1 << 10,
        Shiny = 1 << 11,
        Huge_Carriable = 1 << 12,
        Not_Storable_as_an_Item = 1 << 13, // Stuff you can use in the field but won't show up in your inventory.
        Unknown_15 = 1 << 14,
        Unknown_16 = 1 << 15,
        Unknown_17 = 1 << 16,
        Unknown_18 = 1 << 17,
        Unknown_19 = 1 << 18,
        Unknown_20 = 1 << 19,
        Unknown_21 = 1 << 20,
        Unknown_22 = 1 << 21,
        Unknown_23 = 1 << 22,
        Unknown_24 = 1 << 23,
        Unknown_25 = 1 << 24,
        Unknown_26 = 1 << 25,
        Unknown_27 = 1 << 26,
        Unknown_28 = 1 << 27,
        Unknown_29 = 1 << 28,
        Unknown_30 = 1 << 29,
        Unknown_31 = 1 << 30,
        Unknown_32 = 1 << 30
    }
}