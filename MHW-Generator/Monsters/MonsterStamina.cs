using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;

namespace MHW_Generator.Monsters {
    public class MonsterStamina : IMultiStruct {
        public MultiStruct Generate() { // .dtt_sta
            // Fatigue
            var fatigue = new List<MhwMultiStructData.StructData.Entry> {
                new MhwMultiStructData.StructData.Entry("Duration", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Stamina Min", typeof(uint)),
                new MhwMultiStructData.StructData.Entry("Stamina Max", typeof(uint))
            };
            // Stamina
            var stamina = new List<MhwMultiStructData.StructData.Entry> {
                new MhwMultiStructData.StructData.Entry("Unk", typeof(uint)),
                new MhwMultiStructData.StructData.Entry("Base", typeof(uint))
            };
            var staminaCount = new List<MhwMultiStructData.StructData.Entry> {
                new MhwMultiStructData.StructData.Entry("Number of Stamina Entries", typeof(uint), true)
            };

            var structs = new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("Monster Difficulty", new List<MhwMultiStructData.StructData.Entry> {
                    new MhwMultiStructData.StructData.Entry("Magic 1", typeof(uint), true),
                    new MhwMultiStructData.StructData.Entry("Magic 2", typeof(uint), true),
                    new MhwMultiStructData.StructData.Entry("Monster Id", typeof(uint), true),
                    new MhwMultiStructData.StructData.Entry("Magic 3", typeof(uint), true)
                }, 1),
                new MhwMultiStructData.StructData("Fatigue (LR)", fatigue, 1),
                new MhwMultiStructData.StructData("Stamina Count (LR)", staminaCount, 1, true),
                new MhwMultiStructData.StructData("Stamina (LR)", stamina, canAddRows: true),

                new MhwMultiStructData.StructData("Fatigue (HR)", fatigue, 1),
                new MhwMultiStructData.StructData("Stamina Count (HR)", staminaCount, 1, true),
                new MhwMultiStructData.StructData("Stamina (HR)", stamina, canAddRows: true),

                new MhwMultiStructData.StructData("Fatigue (MR)", fatigue, 1),
                new MhwMultiStructData.StructData("Stamina Count (MR)", staminaCount, 1, true),
                new MhwMultiStructData.StructData("Stamina (MR)", stamina, canAddRows: true)
            };

            return new MultiStruct("MHW_Editor.Monsters", "MonsterStamina", new MhwMultiStructData(structs));
        }
    }
}