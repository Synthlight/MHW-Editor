using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Models;
using MHW_Template.Struct_Generation;
using MHW_Template.Weapons;

namespace MHW_Generator.Weapons {
    public class MonsterParts : IMultiStruct {
        public MultiStruct Generate() { // .dtt_epg
            var header = new MhwMultiStructData.StructData("Monster Parts", new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry("Magic 1", typeof(uint), true),
                new MhwMultiStructData.Entry("Magic 2", typeof(uint), true),
                new MhwMultiStructData.Entry("Monster Id", typeof(uint), true, dataSourceType: DataSourceType.Monsters),
                new MhwMultiStructData.Entry("Magic 3", typeof(uint), true),
                new MhwMultiStructData.Entry("Health", typeof(uint)),
                new MhwMultiStructData.Entry("Flinches Count", typeof(uint), true).Out(out var flinchesCount)
            }, 1);

            var parts1 = new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry("Part Id LR/HR1 Normal", typeof(int)),
                new MhwMultiStructData.Entry("Part Id LR/HR1 Wounded", typeof(int)),
                new MhwMultiStructData.Entry("Part Id LR/HR1 Special Phase 1", typeof(int)),
                new MhwMultiStructData.Entry("Part Id LR/HR1 Special Phase 2", typeof(int)),
                new MhwMultiStructData.Entry("Part Id LR/HR1 Special Phase 3", typeof(int)),
                new MhwMultiStructData.Entry("Part Id MR1 Normal", typeof(int)),
                new MhwMultiStructData.Entry("Part Id MR1 Wounded", typeof(int)),
                new MhwMultiStructData.Entry("Part Id MR1 Special Phase 1", typeof(int)),
                new MhwMultiStructData.Entry("Part Id MR1 Special Phase 2", typeof(int)),
                new MhwMultiStructData.Entry("Part Id MR1 Special Phase 3", typeof(int)),
                new MhwMultiStructData.Entry("unk9", typeof(uint)),
                new MhwMultiStructData.Entry("unk10", typeof(uint)),
                new MhwMultiStructData.Entry("unk11", typeof(uint)),
                new MhwMultiStructData.Entry("unk12", typeof(byte)),
                new MhwMultiStructData.Entry("unk13", typeof(byte))
            };

            var parts2 = new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry("Part Id LR/HR1 Normal", typeof(int)),
                new MhwMultiStructData.Entry("Part Id LR/HR1 Wounded", typeof(int)),
                new MhwMultiStructData.Entry("Part Id LR/HR1 Special Phase 1", typeof(int)),
                new MhwMultiStructData.Entry("Part Id LR/HR1 Special Phase 2", typeof(int)),
                new MhwMultiStructData.Entry("Part Id LR/HR1 Special Phase 3", typeof(int)),
                new MhwMultiStructData.Entry("Part Id MR1 Normal", typeof(int)),
                new MhwMultiStructData.Entry("Part Id MR1 Wounded", typeof(int)),
                new MhwMultiStructData.Entry("Part Id MR1 Special Phase 1", typeof(int)),
                new MhwMultiStructData.Entry("Part Id MR1 Special Phase 2", typeof(int)),
                new MhwMultiStructData.Entry("Part Id MR1 Special Phase 3", typeof(int)),
                new MhwMultiStructData.Entry("Part Id LR/HR2 Normal", typeof(int)),
                new MhwMultiStructData.Entry("Part Id LR/HR2 Wounded", typeof(int)),
                new MhwMultiStructData.Entry("Part Id LR/HR2 Special Phase 1", typeof(int)),
                new MhwMultiStructData.Entry("Part Id LR/HR2 Special Phase 2", typeof(int)),
                new MhwMultiStructData.Entry("Part Id LR/HR2 Special Phase 3", typeof(int)),
                new MhwMultiStructData.Entry("Part Id MR2 Normal", typeof(int)),
                new MhwMultiStructData.Entry("Part Id MR2 Wounded", typeof(int)),
                new MhwMultiStructData.Entry("Part Id MR2 Special Phase 1", typeof(int)),
                new MhwMultiStructData.Entry("Part Id MR2 Special Phase 2", typeof(int)),
                new MhwMultiStructData.Entry("Part Id MR2 Special Phase 3", typeof(int)),
                new MhwMultiStructData.Entry("unk19", typeof(uint)),
                new MhwMultiStructData.Entry("unk20", typeof(uint)),
                new MhwMultiStructData.Entry("unk21", typeof(uint)),
                new MhwMultiStructData.Entry("unk22", typeof(byte)),
                new MhwMultiStructData.Entry("unk23", typeof(byte))
            };

            var parts3 = new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry("Part Id LR/HR1 Normal", typeof(int)),
                new MhwMultiStructData.Entry("Part Id LR/HR1 Wounded", typeof(int)),
                new MhwMultiStructData.Entry("Part Id LR/HR1 Special Phase 1", typeof(int)),
                new MhwMultiStructData.Entry("Part Id LR/HR1 Special Phase 2", typeof(int)),
                new MhwMultiStructData.Entry("Part Id LR/HR1 Special Phase 3", typeof(int)),
                new MhwMultiStructData.Entry("Part Id MR1 Normal", typeof(int)),
                new MhwMultiStructData.Entry("Part Id MR1 Wounded", typeof(int)),
                new MhwMultiStructData.Entry("Part Id MR1 Special Phase 1", typeof(int)),
                new MhwMultiStructData.Entry("Part Id MR1 Special Phase 2", typeof(int)),
                new MhwMultiStructData.Entry("Part Id MR1 Special Phase 3", typeof(int)),
                new MhwMultiStructData.Entry("Part Id LR/HR2 Normal", typeof(int)),
                new MhwMultiStructData.Entry("Part Id LR/HR2 Wounded", typeof(int)),
                new MhwMultiStructData.Entry("Part Id LR/HR2 Special Phase 1", typeof(int)),
                new MhwMultiStructData.Entry("Part Id LR/HR2 Special Phase 2", typeof(int)),
                new MhwMultiStructData.Entry("Part Id LR/HR2 Special Phase 3", typeof(int)),
                new MhwMultiStructData.Entry("Part Id MR2 Normal", typeof(int)),
                new MhwMultiStructData.Entry("Part Id MR2 Wounded", typeof(int)),
                new MhwMultiStructData.Entry("Part Id MR2 Special Phase 1", typeof(int)),
                new MhwMultiStructData.Entry("Part Id MR2 Special Phase 2", typeof(int)),
                new MhwMultiStructData.Entry("Part Id MR2 Special Phase 3", typeof(int)),
                new MhwMultiStructData.Entry("Part Id LR/HR3 Normal", typeof(int)),
                new MhwMultiStructData.Entry("Part Id LR/HR3 Wounded", typeof(int)),
                new MhwMultiStructData.Entry("Part Id LR/HR3 Special Phase 1", typeof(int)),
                new MhwMultiStructData.Entry("Part Id LR/HR3 Special Phase 2", typeof(int)),
                new MhwMultiStructData.Entry("Part Id LR/HR3 Special Phase 3", typeof(int)),
                new MhwMultiStructData.Entry("Part Id MR3 Normal", typeof(int)),
                new MhwMultiStructData.Entry("Part Id MR3 Wounded", typeof(int)),
                new MhwMultiStructData.Entry("Part Id MR3 Special Phase 1", typeof(int)),
                new MhwMultiStructData.Entry("Part Id MR3 Special Phase 2", typeof(int)),
                new MhwMultiStructData.Entry("Part Id MR3 Special Phase 3", typeof(int)),
                new MhwMultiStructData.Entry("unk29", typeof(uint)),
                new MhwMultiStructData.Entry("unk30", typeof(uint)),
                new MhwMultiStructData.Entry("unk31", typeof(uint)),
                new MhwMultiStructData.Entry("unk32", typeof(byte)),
                new MhwMultiStructData.Entry("unk33", typeof(byte))
            };

            var flinches = new MhwMultiStructData.StructData("Flinches", new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry("Flinch Value", typeof(uint)),
                new MhwMultiStructData.Entry("Special Part 1", typeof(int)),
                new MhwMultiStructData.Entry("Special Part 2", typeof(int)),
                new MhwMultiStructData.Entry("Special Part 3", typeof(int)),
                new MhwMultiStructData.Entry("Kinsect Color", typeof(uint), enumReturn: typeof(KinsectColor)),
                new MhwMultiStructData.Entry("Parts Type", typeof(uint), true),

                new MhwMultiStructData.Entry("Parts1", typeof(void), subStruct: new MhwMultiStructData.StructData("Parts1", parts1, 1, showVertically: true), condition: "if (|ref|Parts_Type_raw == 1)", accessLevel: "protected"),
                new MhwMultiStructData.Entry("Parts2", typeof(void), subStruct: new MhwMultiStructData.StructData("Parts2", parts2, 1, showVertically: true), condition: "if (|ref|Parts_Type_raw == 2)", accessLevel: "protected"),
                new MhwMultiStructData.Entry("Parts3", typeof(void), subStruct: new MhwMultiStructData.StructData("Parts3", parts3, 1, showVertically: true), condition: "if (|ref|Parts_Type_raw == 3)", accessLevel: "protected")
            }, _010Link: new MhwMultiStructData.ArrayLink(header, flinchesCount));

            var hitzoneHeader = new MhwMultiStructData.StructData("Hitzone Header", new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry("Hitzone Count", typeof(uint), true).Out(out var hitzoneCount)
            }, 1, true);

            var hitzones = new MhwMultiStructData.StructData("Hitzones", new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry("Timer", typeof(float)),
                new MhwMultiStructData.Entry("Sever", typeof(uint)),
                new MhwMultiStructData.Entry("Impact", typeof(uint)),
                new MhwMultiStructData.Entry("Shot", typeof(uint)),
                new MhwMultiStructData.Entry("Fire", typeof(uint)),
                new MhwMultiStructData.Entry("Water", typeof(uint)),
                new MhwMultiStructData.Entry("Ice", typeof(uint)),
                new MhwMultiStructData.Entry("Thunder", typeof(uint)),
                new MhwMultiStructData.Entry("Dragon", typeof(uint)),
                new MhwMultiStructData.Entry("Stun", typeof(uint)),
                new MhwMultiStructData.Entry("Stamina", typeof(uint))
            }, _010Link: new MhwMultiStructData.ArrayLink(hitzoneHeader, hitzoneCount));

            var severHeader = new MhwMultiStructData.StructData("Sever Header", new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry("Sever Count", typeof(uint), true).Out(out var severCount)
            }, 1, true);

            var severs = new MhwMultiStructData.StructData("Severs", new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry("Damage", typeof(uint), enumReturn: typeof(DamageType)),
                new MhwMultiStructData.Entry("unk1", typeof(uint)),
                new MhwMultiStructData.Entry("unk2", typeof(uint)),
                new MhwMultiStructData.Entry("Sever", typeof(uint)),
                new MhwMultiStructData.Entry("unk5", typeof(int)),
                new MhwMultiStructData.Entry("Special", typeof(byte), enumReturn: typeof(bool)),
                new MhwMultiStructData.Entry("Blunt", typeof(byte), enumReturn: typeof(bool)),
                new MhwMultiStructData.Entry("Shot", typeof(byte), enumReturn: typeof(bool))
            }, _010Link: new MhwMultiStructData.ArrayLink(severHeader, severCount));

            var unkHeader = new MhwMultiStructData.StructData("Unk Header", new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry("Unk Count", typeof(uint), true).Out(out var unkCount)
            }, 1, true);

            var unknowns = new MhwMultiStructData.StructData("Unknowns", new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry("unk1", typeof(uint)),
                new MhwMultiStructData.Entry("unk2", typeof(uint)),
                new MhwMultiStructData.Entry("unk3", typeof(uint)),
                new MhwMultiStructData.Entry("unk4", typeof(byte)),
                new MhwMultiStructData.Entry("unk5", typeof(uint)),
                new MhwMultiStructData.Entry("unk6", typeof(byte)),
                new MhwMultiStructData.Entry("unk7", typeof(byte)),
                new MhwMultiStructData.Entry("unk8", typeof(int)),
                new MhwMultiStructData.Entry("unk9", typeof(byte)),
                new MhwMultiStructData.Entry("unk10", typeof(byte)),
                new MhwMultiStructData.Entry("unk11", typeof(byte))
            }, _010Link: new MhwMultiStructData.ArrayLink(unkHeader, unkCount));

            var remainder = new MhwMultiStructData.StructData("Unknown", new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry("unk1", typeof(uint)),
                new MhwMultiStructData.Entry("unk2", typeof(uint))
            }, 1, showVertically: true);

            var structs = new List<MhwMultiStructData.StructData> {
                header,
                flinches,
                hitzoneHeader,
                hitzones,
                severHeader,
                severs,
                unkHeader,
                unknowns,
                remainder
            };

            return new MultiStruct("MHW_Editor.Monsters", "MonsterParts", new MhwMultiStructData(structs, "dtt_epg", EncryptionKeys.FILE_EXT_KEY_LOOKUP[".dtt_epg"]));
        }
    }
}