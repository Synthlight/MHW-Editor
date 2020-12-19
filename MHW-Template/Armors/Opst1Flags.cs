using System;

namespace MHW_Template.Armors {
    [Flags]
    public enum Opst1Flags {
        None                   = 0,
        Hide_Torso             = 1,
        Hide_Head              = 1 << 1,
        Hide_Hands             = 1 << 2,
        Hide_Waist             = 1 << 3,
        Hide_Feet              = 1 << 4,
        Hide_Eyebrows_Whiskers = 1 << 5,
        Hide_Arms              = 1 << 6,
        Hide_Ears_Tail         = 1 << 7
    }
}