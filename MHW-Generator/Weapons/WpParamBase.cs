using System.Collections.Generic;
using MHW_Template.Struct_Generation.Multi;

namespace MHW_Generator.Weapons {
    public class WpParamBase {
        protected uint paramIndex;
        protected uint unkIndex;
        protected uint arrayIndex;

        protected virtual List<MhwMultiStructData.StructData> CreateBase(string wpNum) {
            var structs = new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData($"W{wpNum}p Params ({++paramIndex}, Shared)", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Weapon", typeof(char), true, typeof(string), arrayCount: 4),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(uint))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData($"Unk Arr {++arrayIndex} (Shared)", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Unk 1", typeof(float)),
                    new MhwMultiStructData.Entry("Unk 2", typeof(float)),
                    new MhwMultiStructData.Entry("Unk 3", typeof(float)),
                    new MhwMultiStructData.Entry("Unk 4", typeof(byte), enumReturn: typeof(bool)),
                    new MhwMultiStructData.Entry("Unk 5", typeof(float))
                }, 20),

                new MhwMultiStructData.StructData($"W{wpNum}p Params ({++paramIndex}, Shared)", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData("Guard Angles? (Shared)", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Guard Angle (Both Sides)", typeof(float)),
                    new MhwMultiStructData.Entry("Knockback Threshold Small", typeof(byte)),
                    new MhwMultiStructData.Entry("Knockback Threshold Medium", typeof(byte)),
                    new MhwMultiStructData.Entry("Knockback Threshold Large", typeof(byte))
                }, 2),

                new MhwMultiStructData.StructData($"W{wpNum}p Params ({++paramIndex}, Shared)", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(int))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData($"Unk Arr {++arrayIndex} (Shared)", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Unk 1", typeof(float)),
                    new MhwMultiStructData.Entry("Unk 2", typeof(float)),
                    new MhwMultiStructData.Entry("Unk 3", typeof(float)),
                    new MhwMultiStructData.Entry("Unk 4", typeof(float)),
                    new MhwMultiStructData.Entry("Unk 5", typeof(float)),
                    new MhwMultiStructData.Entry("Unk 6", typeof(float)),
                    new MhwMultiStructData.Entry("Unk 7", typeof(float)),
                    new MhwMultiStructData.Entry("Unk 8", typeof(float)),
                    new MhwMultiStructData.Entry("Unk 9", typeof(float)),
                    new MhwMultiStructData.Entry("Unk 10", typeof(float)),
                    new MhwMultiStructData.Entry("Unk 11", typeof(float)),
                    new MhwMultiStructData.Entry("Unk 12", typeof(float)),
                    new MhwMultiStructData.Entry("Unk 13", typeof(float)),
                    new MhwMultiStructData.Entry("Unk 14", typeof(byte)),
                    new MhwMultiStructData.Entry("Unk 15", typeof(int))
                }, 8)
            };

            return structs;
        }
    }
}