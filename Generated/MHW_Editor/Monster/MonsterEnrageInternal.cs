using System.Collections.ObjectModel;
using MHW_Editor.Models;

namespace MHW_Editor.Monster {
    public partial class MonsterEnrage {
        public ObservableCollection<PlDataItemCustomView> GetCustomView() {
            return new ObservableCollection<PlDataItemCustomView> {
                new PlDataItemCustomView(this, "Monster Id", "Monster_Id", Bytes, 8),
                new PlDataItemCustomView(this, "LR/HR Trigger Damage", "LR_HR_Trigger_Damage", Bytes, 16),
                new PlDataItemCustomView(this, "LR/HR Duration", "LR_HR_Duration", Bytes, 20),
                new PlDataItemCustomView(this, "LR/HR Speed", "LR_HR_Speed", Bytes, 24),
                new PlDataItemCustomView(this, "LR/HR Damage", "LR_HR_Damage", Bytes, 28),
                new PlDataItemCustomView(this, "LR/HR Player Damage", "LR_HR_Player_Damage", Bytes, 32),
                new PlDataItemCustomView(this, "Unk1", "Unk1", Bytes, 36),
                new PlDataItemCustomView(this, "Unk2", "Unk2", Bytes, 40),
                new PlDataItemCustomView(this, "Unk3", "Unk3", Bytes, 44),
                new PlDataItemCustomView(this, "Unk4", "Unk4", Bytes, 48),
                new PlDataItemCustomView(this, "Unk5", "Unk5", Bytes, 52),
                new PlDataItemCustomView(this, "Unk6", "Unk6", Bytes, 56),
                new PlDataItemCustomView(this, "Unk7", "Unk7", Bytes, 60),
                new PlDataItemCustomView(this, "Unk8", "Unk8", Bytes, 64),
                new PlDataItemCustomView(this, "Unk9", "Unk9", Bytes, 68),
                new PlDataItemCustomView(this, "Unk10", "Unk10", Bytes, 72),
                new PlDataItemCustomView(this, "Unk11", "Unk11", Bytes, 76),
                new PlDataItemCustomView(this, "MR Trigger Damage", "MR_Trigger_Damage", Bytes, 80),
                new PlDataItemCustomView(this, "MR Duration", "MR_Duration", Bytes, 84),
                new PlDataItemCustomView(this, "MR Speed", "MR_Speed", Bytes, 88),
                new PlDataItemCustomView(this, "MR Damage", "MR_Damage", Bytes, 92),
                new PlDataItemCustomView(this, "MR Player Damage", "MR_Player_Damage", Bytes, 96),
                new PlDataItemCustomView(this, "Unk12", "Unk12", Bytes, 100),
                new PlDataItemCustomView(this, "Unk13", "Unk13", Bytes, 104),
                new PlDataItemCustomView(this, "Unk14", "Unk14", Bytes, 108),
                new PlDataItemCustomView(this, "Unk15", "Unk15", Bytes, 112),
                new PlDataItemCustomView(this, "Unk16", "Unk16", Bytes, 116),
                new PlDataItemCustomView(this, "Unk17", "Unk17", Bytes, 120),
                new PlDataItemCustomView(this, "Unk18", "Unk18", Bytes, 124),
                new PlDataItemCustomView(this, "Unk19", "Unk19", Bytes, 128),
                new PlDataItemCustomView(this, "Unk20", "Unk20", Bytes, 132),
                new PlDataItemCustomView(this, "Unk21", "Unk21", Bytes, 136),
                new PlDataItemCustomView(this, "Unk22", "Unk22", Bytes, 140),
            };
        }
    }
}