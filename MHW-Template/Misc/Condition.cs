namespace MHW_Template.Misc {
    public enum Condition : int {
        None              = -1,
        WhenHardened      = 0,
        WhenCoveredInMud  = 1,
        WhenCoveredInGold = 2,
        WhenCharged       = 3,
        WhenCrystallized  = 4,
        WhenEmittingLight = 5,
        EldersealEfficacy = 6,
        FireActive        = 7,
        IceActive         = 8,
        DragonActive      = 9
    }
}