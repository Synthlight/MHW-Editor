using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Weapons {
    public class Wp04Param : WpParamBase, IMultiStruct {
        private const string N = "04";

        public MultiStruct Generate() { // .w04p
            var structs = new List<MhwMultiStructData.StructData>();
            structs.AddRange(CreateBase(N));

            structs.AddRange(new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData($"W{N}p Params ({++paramIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Number of Rotations When Spinning", typeof(uint)), // 91
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 2}", typeof(float)),
                    new MhwMultiStructData.Entry("Movement After N Rotations (See `Number of Rotations` above)", typeof(float)),
                    new MhwMultiStructData.Entry("Charge Time lvl 2", typeof(float)),
                    new MhwMultiStructData.Entry("Charge Time lvl 3", typeof(float)),
                    new MhwMultiStructData.Entry("Movement of Charged Brutal Upswing (With Direction)", typeof(float)),
                    new MhwMultiStructData.Entry("Movement of Charged Brutal Upswing (Without Direction)", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData("Event Pad Vib", eventPadVib, 3),

                new MhwMultiStructData.StructData($"Action Param {++actionParamIndex}", actionParam, 1),

                new MhwMultiStructData.StructData($"W{N}p Params ({++paramIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Charging Slide Speed 1?", typeof(float)),
                    new MhwMultiStructData.Entry("Charging Slide Speed 2?", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 8}", typeof(float)),
                    new MhwMultiStructData.Entry("Midair Spinning Height?", typeof(float)),
                    new MhwMultiStructData.Entry("Midair Spinning Distance?", typeof(float)),
                    new MhwMultiStructData.Entry("Midair Spinning Speed?", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData($"Action Param {++actionParamIndex}", actionParam, 1),

                new MhwMultiStructData.StructData("Midair Spinning Movement Params", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 4}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData($"Action Param {++actionParamIndex}", actionParam, 1),

                new MhwMultiStructData.StructData($"W{N}p Params ({paramIndex += 2})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Power Charge: Damage Multiplier", typeof(float)),
                    new MhwMultiStructData.Entry("Power Charge: Stun Buildup Multiplier", typeof(float)),
                    new MhwMultiStructData.Entry("Power Charge Duration 1?", typeof(float)), // 109
                    new MhwMultiStructData.Entry("Power Charge Duration 2?", typeof(float)),
                    new MhwMultiStructData.Entry("Power Charge Duration 3?", typeof(float)),
                    new MhwMultiStructData.Entry("Power Charge Duration 4?", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 7}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry("Clutching Distance (Clutch After Charged Big Bang)", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 2}", typeof(float)),
                    new MhwMultiStructData.Entry("Clutching Duration if Missed (Clutch After Charged Big Bang)", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData($"Action Param {++actionParamIndex}", actionParam, 1)
            });

            return new MultiStruct("Weapons", $"Wp{N}Param", new MhwMultiStructData(structs, $"w{N}p", EncryptionKeys.FILE_EXT_KEY_LOOKUP[$".w{N}p"]));
        }
    }
}