using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Weapons {
    public class MonsterDamageAttributes : IMultiStruct {
        public MultiStruct Generate() { // .dtt_eda
            var statusBuildup = new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry("Base", typeof(uint)),
                new MhwMultiStructData.Entry("Buildup", typeof(uint)),
                new MhwMultiStructData.Entry("Max Cap", typeof(uint)),
                new MhwMultiStructData.Entry("Drain Time", typeof(float)),
                new MhwMultiStructData.Entry("Drain Value", typeof(uint)),
                new MhwMultiStructData.Entry("Duration", typeof(float)),
                new MhwMultiStructData.Entry("Duration Decrease Per Use", typeof(float)),
                new MhwMultiStructData.Entry("Duration Minimum", typeof(float))
            };

            var structs = new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("Monster Damage Attributes (1)", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Magic 1", typeof(uint), true),
                    new MhwMultiStructData.Entry("Magic 2", typeof(uint), true),
                    new MhwMultiStructData.Entry("Monster Id", typeof(uint), true, dataSourceType: DataSourceType.Monsters),
                    new MhwMultiStructData.Entry("Magic 3", typeof(uint), true)
                }, 1),

                new MhwMultiStructData.StructData("Status Buildup: Poison", statusBuildup, 1),

                new MhwMultiStructData.StructData("Monster Damage Attributes (2)", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Poison Damage", typeof(uint)),
                    new MhwMultiStructData.Entry("Poison Interval", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData("Status Buildup: Sleep/Paralysis/Stun/Exhaustion", statusBuildup, 4),

                new MhwMultiStructData.StructData("Monster Damage Attributes (3)", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Unk 1", typeof(uint)),
                    new MhwMultiStructData.Entry("Exhaustion Damage", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData("Status Buildup: Mount/Blastblight", statusBuildup, 2),

                new MhwMultiStructData.StructData("Monster Damage Attributes (4)", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Blastblight Damage", typeof(uint))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData("Status Buildup: Capture", statusBuildup, 1),

                new MhwMultiStructData.StructData("Monster Damage Attributes (5)", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Capture LR/HR", typeof(uint)),
                    new MhwMultiStructData.Entry("Capture MR", typeof(uint))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData("Status Buildup: Dizziness LR/HR", statusBuildup, 1),

                new MhwMultiStructData.StructData("Monster Damage Attributes (6)", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Unk 1", typeof(uint))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData("Status Buildup: Dizziness MR", statusBuildup, 1),

                new MhwMultiStructData.StructData("Monster Damage Attributes (7)", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Dizziness MR Buildup", typeof(float)),
                    new MhwMultiStructData.Entry("Dizziness MR Max Cap", typeof(float)),
                    new MhwMultiStructData.Entry("Unk 1", typeof(float)),
                    new MhwMultiStructData.Entry("Unk 2", typeof(float)),
                    new MhwMultiStructData.Entry("Dizziness MR Recharge Timer", typeof(float)),
                    new MhwMultiStructData.Entry("Unk 3", typeof(float)),
                    new MhwMultiStructData.Entry("Dizziness MR Duration Re-occuring Use", typeof(float)),
                    new MhwMultiStructData.Entry("Dizziness MR Duration Initial Use", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData("Status Buildup: Mount Knock Down", statusBuildup, 1),

                new MhwMultiStructData.StructData("Monster Damage Attributes (8)", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Mount Knock Down Damage", typeof(uint))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData("Status Buildup: Dung", statusBuildup, 1),

                new MhwMultiStructData.StructData("Monster Damage Attributes (9)", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Unk 1", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk 2", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData("Status Buildup: Shock Trap/Pitfall Trap/Ivy Trap/Unk", statusBuildup, 4),

                new MhwMultiStructData.StructData("Monster Damage Attributes (10)", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Unk 1", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk 2", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData("Status Buildup: Dragonseal", statusBuildup, 1),

                new MhwMultiStructData.StructData("Monster Damage Attributes (11)", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Dragonseal Aura", typeof(uint))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData("Status Buildup: Unk", statusBuildup, 2),

                new MhwMultiStructData.StructData("Unk Array", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Unk 1", typeof(int)),
                    new MhwMultiStructData.Entry("Unk 2", typeof(int)),
                    new MhwMultiStructData.Entry("Unk 3", typeof(int))
                }, 6),

                new MhwMultiStructData.StructData("Status Buildup: Concussion", statusBuildup, 1),

                new MhwMultiStructData.StructData("Rage Build Up", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Claw Flinch Shot", typeof(float)),
                    new MhwMultiStructData.Entry("Claw Flinch Shot (No Wall)", typeof(float)),
                    new MhwMultiStructData.Entry("Claw Attack", typeof(float)),
                    new MhwMultiStructData.Entry("Claw Flinch Shot (Wall)", typeof(float)),
                    new MhwMultiStructData.Entry("Claw Flinch Shot (Ledge)", typeof(float))
                }, 2),

                new MhwMultiStructData.StructData("Status Buildup: Clagger", statusBuildup, 1)
            };

            return new MultiStruct("MHW_Editor.Monsters", "MonsterDamageAttributes", new MhwMultiStructData(structs, "dtt_eda", EncryptionKeys.FILE_EXT_KEY_LOOKUP[".dtt_eda"]));
        }
    }
}