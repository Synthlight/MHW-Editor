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
                new PlDataItemCustomView(this, "LR/HR Build Multiplier by HP (90%-100%)", "LR_HR_Build_Multiplier_by_HP_90_100_", Bytes, 36),
                new PlDataItemCustomView(this, "LR/HR Build Multiplier by HP (80%-90%)", "LR_HR_Build_Multiplier_by_HP_80_90_", Bytes, 40),
                new PlDataItemCustomView(this, "LR/HR Build Multiplier by HP (70%-80%)", "LR_HR_Build_Multiplier_by_HP_70_80_", Bytes, 44),
                new PlDataItemCustomView(this, "LR/HR Build Multiplier by HP (60%-70%)", "LR_HR_Build_Multiplier_by_HP_60_70_", Bytes, 48),
                new PlDataItemCustomView(this, "LR/HR Build Multiplier by HP (50%-60%)", "LR_HR_Build_Multiplier_by_HP_50_60_", Bytes, 52),
                new PlDataItemCustomView(this, "LR/HR Build Multiplier by HP (40%-50%)", "LR_HR_Build_Multiplier_by_HP_40_50_", Bytes, 56),
                new PlDataItemCustomView(this, "LR/HR Build Multiplier by HP (30%-40%)", "LR_HR_Build_Multiplier_by_HP_30_40_", Bytes, 60),
                new PlDataItemCustomView(this, "LR/HR Build Multiplier by HP (20%-30%)", "LR_HR_Build_Multiplier_by_HP_20_30_", Bytes, 64),
                new PlDataItemCustomView(this, "LR/HR Build Multiplier by HP (10%-20%)", "LR_HR_Build_Multiplier_by_HP_10_20_", Bytes, 68),
                new PlDataItemCustomView(this, "LR/HR Build Multiplier by HP (0%-10%)", "LR_HR_Build_Multiplier_by_HP_0_10_", Bytes, 72),
                new PlDataItemCustomView(this, "LR/HR Out of Combat Decay Multiplier", "LR_HR_Out_of_Combat_Decay_Multiplier", Bytes, 76),
                new PlDataItemCustomView(this, "MR Build to Trigger", "MR_Build_to_Trigger", Bytes, 80),
                new PlDataItemCustomView(this, "MR Duration", "MR_Duration", Bytes, 84),
                new PlDataItemCustomView(this, "MR Speed Modifier", "MR_Speed_Modifier", Bytes, 88),
                new PlDataItemCustomView(this, "MR Damage Modifier", "MR_Damage_Modifier", Bytes, 92),
                new PlDataItemCustomView(this, "MR Player Damage Modifier", "MR_Player_Damage_Modifier", Bytes, 96),
                new PlDataItemCustomView(this, "MR Build Multiplier by HP (90%-100%)", "MR_Build_Multiplier_by_HP_90_100_", Bytes, 100),
                new PlDataItemCustomView(this, "MR Build Multiplier by HP (80%-90%)", "MR_Build_Multiplier_by_HP_80_90_", Bytes, 104),
                new PlDataItemCustomView(this, "MR Build Multiplier by HP (70%-80%)", "MR_Build_Multiplier_by_HP_70_80_", Bytes, 108),
                new PlDataItemCustomView(this, "MR Build Multiplier by HP (60%-70%)", "MR_Build_Multiplier_by_HP_60_70_", Bytes, 112),
                new PlDataItemCustomView(this, "MR Build Multiplier by HP (50%-60%)", "MR_Build_Multiplier_by_HP_50_60_", Bytes, 116),
                new PlDataItemCustomView(this, "MR Build Multiplier by HP (40%-50%)", "MR_Build_Multiplier_by_HP_40_50_", Bytes, 120),
                new PlDataItemCustomView(this, "MR Build Multiplier by HP (30%-40%)", "MR_Build_Multiplier_by_HP_30_40_", Bytes, 124),
                new PlDataItemCustomView(this, "MR Build Multiplier by HP (20%-30%)", "MR_Build_Multiplier_by_HP_20_30_", Bytes, 128),
                new PlDataItemCustomView(this, "MR Build Multiplier by HP (10%-20%)", "MR_Build_Multiplier_by_HP_10_20_", Bytes, 132),
                new PlDataItemCustomView(this, "MR Build Multiplier by HP (0%-10%)", "MR_Build_Multiplier_by_HP_0_10_", Bytes, 136),
                new PlDataItemCustomView(this, "MR Out of Combat Decay Multiplier", "MR_Out_of_Combat_Decay_Multiplier", Bytes, 140),
            };
        }
    }
}