using System.Collections.ObjectModel;
using MHW_Editor.Models;

namespace MHW_Editor.Monsters {
    public partial class MonsterEnrage {
        public ObservableCollection<PlDataItemCustomView> GetCustomView() {
            return new ObservableCollection<PlDataItemCustomView> {
                new PlDataItemCustomView(this, "Monster Id", "Monster_Id", Bytes, 8),
                new PlDataItemCustomView(this, "LR/HR Trigger Damage", "LR_HR_Trigger_Damage", Bytes, 16),
                new PlDataItemCustomView(this, "LR/HR Duration", "LR_HR_Duration", Bytes, 20),
                new PlDataItemCustomView(this, "LR/HR Speed", "LR_HR_Speed", Bytes, 24),
                new PlDataItemCustomView(this, "LR/HR Damage", "LR_HR_Damage", Bytes, 28),
                new PlDataItemCustomView(this, "LR/HR Player Damage", "LR_HR_Player_Damage", Bytes, 32),
                new PlDataItemCustomView(this, "LR/HR Build Multiplier by HP 1", "LR_HR_Build_Multiplier_by_HP_1", Bytes, 36),
                new PlDataItemCustomView(this, "LR/HR Build Multiplier by HP 2", "LR_HR_Build_Multiplier_by_HP_2", Bytes, 40),
                new PlDataItemCustomView(this, "LR/HR Build Multiplier by HP 3", "LR_HR_Build_Multiplier_by_HP_3", Bytes, 44),
                new PlDataItemCustomView(this, "LR/HR Build Multiplier by HP 4", "LR_HR_Build_Multiplier_by_HP_4", Bytes, 48),
                new PlDataItemCustomView(this, "LR/HR Build Multiplier by HP 5", "LR_HR_Build_Multiplier_by_HP_5", Bytes, 52),
                new PlDataItemCustomView(this, "LR/HR Build Multiplier by HP 6", "LR_HR_Build_Multiplier_by_HP_6", Bytes, 56),
                new PlDataItemCustomView(this, "LR/HR Build Multiplier by HP 7", "LR_HR_Build_Multiplier_by_HP_7", Bytes, 60),
                new PlDataItemCustomView(this, "LR/HR Build Multiplier by HP 8", "LR_HR_Build_Multiplier_by_HP_8", Bytes, 64),
                new PlDataItemCustomView(this, "LR/HR Build Multiplier by HP 9", "LR_HR_Build_Multiplier_by_HP_9", Bytes, 68),
                new PlDataItemCustomView(this, "LR/HR Build Multiplier by HP 10", "LR_HR_Build_Multiplier_by_HP_10", Bytes, 72),
                new PlDataItemCustomView(this, "LR/HR Decay", "LR_HR_Decay", Bytes, 76),
                new PlDataItemCustomView(this, "MR Trigger Damage", "MR_Trigger_Damage", Bytes, 80),
                new PlDataItemCustomView(this, "MR Duration", "MR_Duration", Bytes, 84),
                new PlDataItemCustomView(this, "MR Speed", "MR_Speed", Bytes, 88),
                new PlDataItemCustomView(this, "MR Damage", "MR_Damage", Bytes, 92),
                new PlDataItemCustomView(this, "MR Player Damage", "MR_Player_Damage", Bytes, 96),
                new PlDataItemCustomView(this, "MR Build Multiplier by HP 1", "MR_Build_Multiplier_by_HP_1", Bytes, 100),
                new PlDataItemCustomView(this, "MR Build Multiplier by HP 2", "MR_Build_Multiplier_by_HP_2", Bytes, 104),
                new PlDataItemCustomView(this, "MR Build Multiplier by HP 3", "MR_Build_Multiplier_by_HP_3", Bytes, 108),
                new PlDataItemCustomView(this, "MR Build Multiplier by HP 4", "MR_Build_Multiplier_by_HP_4", Bytes, 112),
                new PlDataItemCustomView(this, "MR Build Multiplier by HP 5", "MR_Build_Multiplier_by_HP_5", Bytes, 116),
                new PlDataItemCustomView(this, "MR Build Multiplier by HP 6", "MR_Build_Multiplier_by_HP_6", Bytes, 120),
                new PlDataItemCustomView(this, "MR Build Multiplier by HP 7", "MR_Build_Multiplier_by_HP_7", Bytes, 124),
                new PlDataItemCustomView(this, "MR Build Multiplier by HP 8", "MR_Build_Multiplier_by_HP_8", Bytes, 128),
                new PlDataItemCustomView(this, "MR Build Multiplier by HP 9", "MR_Build_Multiplier_by_HP_9", Bytes, 132),
                new PlDataItemCustomView(this, "MR Build Multiplier by HP 10", "MR_Build_Multiplier_by_HP_10", Bytes, 136),
                new PlDataItemCustomView(this, "MR Decay", "MR_Decay", Bytes, 140),
            };
        }
    }
}