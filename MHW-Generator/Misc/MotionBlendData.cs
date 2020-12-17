using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Misc {
    public class MotionBlendData : IMultiStruct {
        public MultiStruct Generate() { // .mbd
            var structs = new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("Motion Blend Data (1)", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Magic 1", typeof(uint), true),
                    new MhwMultiStructData.Entry("Magic 2", typeof(uint), true),
                    new MhwMultiStructData.Entry("Entry Count", typeof(uint), true).Out(out var entryCount),
                    new MhwMultiStructData.Entry("Unk 1", typeof(uint))
                }, 1).Out(out var header),

                new MhwMultiStructData.StructData("Default", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("lmt Offset Index", typeof(uint)),
                    new MhwMultiStructData.Entry("Num of Values", typeof(uint), true).Out(out var innerCount),
                    new MhwMultiStructData.Entry("Unk 2", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk 3", typeof(uint)),

                    new MhwMultiStructData.Entry("Unk 4", typeof(void), subStruct: new MhwMultiStructData.StructData("Unk Array", new List<MhwMultiStructData.Entry> {
                        new MhwMultiStructData.Entry("Unk 1", typeof(string), isNullTerminatedString: true),
                        new MhwMultiStructData.Entry("Unk 2", typeof(float)),
                        new MhwMultiStructData.Entry("Animation Start Frame", typeof(uint)),
                        new MhwMultiStructData.Entry("Interpolation", typeof(uint)),
                        new MhwMultiStructData.Entry("Overlap Blending", typeof(uint)),
                        new MhwMultiStructData.Entry("Unk 6", typeof(float)),
                        new MhwMultiStructData.Entry("Interpolation Modifier?", typeof(uint)),
                        new MhwMultiStructData.Entry("Unk 8", typeof(int)),
                        new MhwMultiStructData.Entry("Animation Id", typeof(uint))
                    }, canAddRows: true, _010Link: new MhwMultiStructData.ArrayLink(null, innerCount))),

                    new MhwMultiStructData.Entry("Unk 5", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk 6", typeof(uint))
                }, canAddRows: true, _010Link: new MhwMultiStructData.ArrayLink(header, entryCount))
            };

            return new MultiStruct("Misc", "MotionBlendData", new MhwMultiStructData(structs, "mbd"));
        }
    }
}