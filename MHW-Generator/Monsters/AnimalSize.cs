using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Monsters {
    public class AnimalSize : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .ransz
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Endemic Id", typeof(uint)),
                    new MhwMultiStructData.Entry("Endemic Sub Species Id", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk3", typeof(float)),
                    new MhwMultiStructData.Entry("Unk4", typeof(float)),
                    new MhwMultiStructData.Entry("Unk5", typeof(float)),
                    new MhwMultiStructData.Entry("Unk6", typeof(float)),
                    new MhwMultiStructData.Entry("Animal Base Size", typeof(float)),
                    new MhwMultiStructData.Entry("Model Size Multi", typeof(float)),
                    new MhwMultiStructData.Entry("Minimum Size Limit", typeof(float)),
                    new MhwMultiStructData.Entry("Maximum Size Limit", typeof(float)),
                    new MhwMultiStructData.Entry("Unk11", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk12", typeof(float)),
                    new MhwMultiStructData.Entry("Unk13", typeof(float)),
                    new MhwMultiStructData.Entry("Unk14", typeof(float)),
                    new MhwMultiStructData.Entry("Unk15", typeof(float)),
                    new MhwMultiStructData.Entry("Unk16", typeof(uint)),
                    new MhwMultiStructData.Entry("Small Gold Crown Limit", typeof(float)),
                    new MhwMultiStructData.Entry("Big Gold Crown Limit", typeof(float))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount))
            };

            return new MultiStruct("MHW_Editor.Monsters", "AnimalSize", new MhwMultiStructData(structs, "ransz"));
        }
    }
}