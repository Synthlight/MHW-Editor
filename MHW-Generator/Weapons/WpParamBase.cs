using System.Collections.Generic;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Weapons {
    public class WpParamBase {
        protected uint paramIndex;
        protected uint unkIndex;
        protected uint arrayIndex;
        protected uint actionParamIndex;

        protected readonly List<MhwMultiStructData.Entry> guardAngles = new List<MhwMultiStructData.Entry> {
            new MhwMultiStructData.Entry("Guard Angle (Both Sides)", typeof(float)),
            new MhwMultiStructData.Entry("Knockback Threshold Small", typeof(byte)),
            new MhwMultiStructData.Entry("Knockback Threshold Medium", typeof(byte)),
            new MhwMultiStructData.Entry("Knockback Threshold Large", typeof(byte))
        };

        protected readonly List<MhwMultiStructData.Entry> actionParam = new List<MhwMultiStructData.Entry> {
            new MhwMultiStructData.Entry("Gravity", typeof(float)),
            new MhwMultiStructData.Entry("Speed Rate", typeof(float)),
            new MhwMultiStructData.Entry("X Offset", typeof(float)),
            new MhwMultiStructData.Entry("Y Offset", typeof(float)),
            new MhwMultiStructData.Entry("Z Offset", typeof(float))
        };

        protected readonly List<MhwMultiStructData.Entry> eventPadVib = new List<MhwMultiStructData.Entry> {
            new MhwMultiStructData.Entry("B", typeof(byte)),
            new MhwMultiStructData.Entry("X", typeof(ushort)),
            new MhwMultiStructData.Entry("Y", typeof(ushort)),
            new MhwMultiStructData.Entry("Time", typeof(float)),
            new MhwMultiStructData.Entry("P", typeof(ushort))
        };

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
                    new MhwMultiStructData.Entry("Sharpness Consumed (Melee Only)", typeof(byte)),
                    new MhwMultiStructData.Entry("Guard Knockback Sharpness Usage: Small", typeof(byte)),
                    new MhwMultiStructData.Entry("Guard Knockback Sharpness Usage: Medium", typeof(byte)),
                    new MhwMultiStructData.Entry("Guard Knockback Sharpness Usage: Large", typeof(byte)),
                    new MhwMultiStructData.Entry("Weapon Sweet-spot", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 6}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry("Elderseal Modifier?", typeof(float)),
                    new MhwMultiStructData.Entry("Limit Until The Tic Damage Decreases 1shot (e.g. Pierce / Slice Ammo)", typeof(byte)),
                    new MhwMultiStructData.Entry("Decreases Tic Damage Over The Limit", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData("Guard Angles (Shared)", guardAngles, 2),

                new MhwMultiStructData.StructData($"W{wpNum}p Params ({++paramIndex}, Shared)", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 4}", typeof(float)),
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
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData($"Unk Arr {++arrayIndex} (Shared)", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Unk 1", typeof(byte)),
                    new MhwMultiStructData.Entry("Unk 2", typeof(int)),
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
                    new MhwMultiStructData.Entry("Unk 14", typeof(float)),
                    new MhwMultiStructData.Entry("Unk 15", typeof(float))
                }, 8),

                new MhwMultiStructData.StructData($"W{wpNum}p Params ({++paramIndex}, Shared)", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(int)),
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
                    new MhwMultiStructData.Entry("Unk (15.10) 1", typeof(float)),
                    new MhwMultiStructData.Entry("Unk (15.10) 2", typeof(float)),
                    new MhwMultiStructData.Entry("Unk (15.10) 3", typeof(float)),
                    new MhwMultiStructData.Entry("Unk (15.10) 4", typeof(float)),
                    new MhwMultiStructData.Entry("Unk (15.10) 5", typeof(float)),
                    new MhwMultiStructData.Entry("Unk (15.10) 6", typeof(float))
                }, 1, showVertically: true)
            };

            return structs;
        }
    }
}