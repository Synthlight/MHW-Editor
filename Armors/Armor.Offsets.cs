namespace MHW_Editor.Armors {
    public partial class Armor {
        public override string Name => DataHelper.armorData.TryGet(Set_Id, "Unknown");
    }
}