using System.Collections.ObjectModel;
using MHW_Editor.Models;

namespace MHW_Editor.Monsters {
    public partial class MonsterEnrage {
        public ObservableCollection<PlDataItemCustomView> GetCustomView() {
            return new ObservableCollection<PlDataItemCustomView> {
                new PlDataItemCustomView(this, "Monster Id", "Monster_Id", Bytes, 8),
                new PlDataItemCustomView(this, "LR/HR Build to Trigger", "LR_HR_Build_to_Trigger", Bytes, 16),
                new PlDataItemCustomView(this, "LR/HR Duration", "LR_HR_Duration", Bytes, 20),
                new PlDataItemCustomView(this, "LR/HR Speed Modifier", "LR_HR_Speed_Modifier", Bytes, 24),
                new PlDataItemCustomView(this, "LR/HR Damage Modifier", "LR_HR_Damage_Modifier", Bytes, 28),
                new PlDataItemCustomView(this, "LR/HR Player Damage Modifier", "LR_HR_Player_Damage_Modifier", Bytes, 32),
                new PlDataItemCustomView(this, "LR/HR Build Multiplier by HP (100%)", "LR_HR_Build_Multiplier_by_HP_100_", Bytes, 36),
                new PlDataItemCustomView(this, "LR/HR Build Multiplier by HP (88%-99%)", "LR_HR_Build_Multiplier_by_HP_88_99_", Bytes, 40),
                new PlDataItemCustomView(this, "LR/HR Build Multiplier by HP (77%-88%)", "LR_HR_Build_Multiplier_by_HP_77_88_", Bytes, 44),
                new PlDataItemCustomView(this, "LR/HR Build Multiplier by HP (66%-77%)", "LR_HR_Build_Multiplier_by_HP_66_77_", Bytes, 48),
                new PlDataItemCustomView(this, "LR/HR Build Multiplier by HP (55%-66%)", "LR_HR_Build_Multiplier_by_HP_55_66_", Bytes, 52),
                new PlDataItemCustomView(this, "LR/HR Build Multiplier by HP (44%-55%)", "LR_HR_Build_Multiplier_by_HP_44_55_", Bytes, 56),
                new PlDataItemCustomView(this, "LR/HR Build Multiplier by HP (33%-44%)", "LR_HR_Build_Multiplier_by_HP_33_44_", Bytes, 60),
                new PlDataItemCustomView(this, "LR/HR Build Multiplier by HP (22%-33%)", "LR_HR_Build_Multiplier_by_HP_22_33_", Bytes, 64),
                new PlDataItemCustomView(this, "LR/HR Build Multiplier by HP (11%-22%)", "LR_HR_Build_Multiplier_by_HP_11_22_", Bytes, 68),
                new PlDataItemCustomView(this, "LR/HR Build Multiplier by HP (0%-11%)", "LR_HR_Build_Multiplier_by_HP_0_11_", Bytes, 72),
                new PlDataItemCustomView(this, "LR/HR Out of Combat Decay Multiplier", "LR_HR_Out_of_Combat_Decay_Multiplier", Bytes, 76),
                new PlDataItemCustomView(this, "MR Build to Trigger", "MR_Build_to_Trigger", Bytes, 80),
                new PlDataItemCustomView(this, "MR Duration", "MR_Duration", Bytes, 84),
                new PlDataItemCustomView(this, "MR Speed Modifier", "MR_Speed_Modifier", Bytes, 88),
                new PlDataItemCustomView(this, "MR Damage Modifier", "MR_Damage_Modifier", Bytes, 92),
                new PlDataItemCustomView(this, "MR Player Damage Modifier", "MR_Player_Damage_Modifier", Bytes, 96),
                new PlDataItemCustomView(this, "MR Build Multiplier by HP (100%)", "MR_Build_Multiplier_by_HP_100_", Bytes, 100),
                new PlDataItemCustomView(this, "MR Build Multiplier by HP (88%-99%)", "MR_Build_Multiplier_by_HP_88_99_", Bytes, 104),
                new PlDataItemCustomView(this, "MR Build Multiplier by HP (77%-88%)", "MR_Build_Multiplier_by_HP_77_88_", Bytes, 108),
                new PlDataItemCustomView(this, "MR Build Multiplier by HP (66%-77%)", "MR_Build_Multiplier_by_HP_66_77_", Bytes, 112),
                new PlDataItemCustomView(this, "MR Build Multiplier by HP (55%-66%)", "MR_Build_Multiplier_by_HP_55_66_", Bytes, 116),
                new PlDataItemCustomView(this, "MR Build Multiplier by HP (44%-55%)", "MR_Build_Multiplier_by_HP_44_55_", Bytes, 120),
                new PlDataItemCustomView(this, "MR Build Multiplier by HP (33%-44%)", "MR_Build_Multiplier_by_HP_33_44_", Bytes, 124),
                new PlDataItemCustomView(this, "MR Build Multiplier by HP (22%-33%)", "MR_Build_Multiplier_by_HP_22_33_", Bytes, 128),
                new PlDataItemCustomView(this, "MR Build Multiplier by HP (11%-22%)", "MR_Build_Multiplier_by_HP_11_22_", Bytes, 132),
                new PlDataItemCustomView(this, "MR Build Multiplier by HP (0%-11%)", "MR_Build_Multiplier_by_HP_0_11_", Bytes, 136),
                new PlDataItemCustomView(this, "MR Out of Combat Decay Multiplier", "MR_Out_of_Combat_Decay_Multiplier", Bytes, 140),
            };
        }
    }
}