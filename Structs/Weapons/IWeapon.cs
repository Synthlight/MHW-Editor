namespace MHW_Editor.Structs.Weapons {
    public interface IWeapon {
        ulong  Index          { get; set; }
        ushort Damage         { get; set; }
        uint   Cost           { get; set; }
        ushort Id             { get; set; }
        ushort GMD_Name_Index { get; set; }
    }
}