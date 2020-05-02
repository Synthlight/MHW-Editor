using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Struct_Generation.Multi;

namespace MHW_Generator.Weapons {
    public class ShellParam : IMultiStruct {
        public MultiStruct Generate() { // .shlp
            var i = 0;

            var structs = new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("Shlp", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Magic 1", typeof(uint), true),
                    new MhwMultiStructData.Entry("SLP", typeof(char), true, typeof(string), arrayCount: 4),
                    new MhwMultiStructData.Entry("Magic 2", typeof(uint), true)
                }, 1),

                new MhwMultiStructData.StructData("Assets", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Header", typeof(uint)),
                    new MhwMultiStructData.Entry("Path", typeof(string), isNullTerminatedString: true, condition: "if (|ref|Header_raw != 0)")
                }, 25),

                new MhwMultiStructData.StructData("Shlp (1)", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Projectile Body: EPV Index", typeof(uint)),
                    new MhwMultiStructData.Entry("Projectile Body: EPV Element #", typeof(uint)),
                    new MhwMultiStructData.Entry("Muzzle: EPV Index", typeof(uint)),
                    new MhwMultiStructData.Entry("Muzzle: EPV Element #", typeof(uint)),
                    new MhwMultiStructData.Entry("Muzzle: Joint 1", typeof(byte)),
                    new MhwMultiStructData.Entry("Muzzle: Joint 2", typeof(byte)),
                    new MhwMultiStructData.Entry("Muzzle: Joint 3", typeof(byte)),
                    new MhwMultiStructData.Entry("Muzzle: Joint 4", typeof(byte)),
                    new MhwMultiStructData.Entry("Obj Collision Header", typeof(uint)),
                    new MhwMultiStructData.Entry("Obj Collision", typeof(string), isNullTerminatedString: true, condition: "if (|ref|Obj_Collision_Header_raw != 0)"),
                    new MhwMultiStructData.Entry("Obj Collision Index", typeof(uint)),
                    new MhwMultiStructData.Entry("Timeline List Header", typeof(uint)),
                    new MhwMultiStructData.Entry("Timeline List", typeof(string), isNullTerminatedString: true, condition: "if (|ref|Timeline_List_Header_raw != 0)"),
                    new MhwMultiStructData.Entry("Unk 2", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk 3", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk 4", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk 5", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk 6", typeof(uint))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData("Number of Linked Shell Params Holder", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Number of Linked Shell Params", typeof(uint), true).Out(out var linkedShellCount)
                }, 1, true).Out(out var linkedShellCountHolder),

                new MhwMultiStructData.StructData("Child Shell Params", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Header", typeof(uint)),
                    new MhwMultiStructData.Entry("Path", typeof(string), isNullTerminatedString: true),
                    new MhwMultiStructData.Entry("Unk 1", typeof(uint)),
                    new MhwMultiStructData.Entry("Flags", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk 3", typeof(uint))
                }, canAddRows: true, _010Link: new MhwMultiStructData.ArrayLink(linkedShellCountHolder, linkedShellCount)),

                new MhwMultiStructData.StructData("EPV", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Ground Hit: EPV Index", typeof(uint)),
                    new MhwMultiStructData.Entry("Ground Hit: EPV Element #", typeof(uint)),
                    new MhwMultiStructData.Entry("Wall Hit: EPV Index", typeof(uint)),
                    new MhwMultiStructData.Entry("Wall Hit: EPV Element #", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry("Obj Hit: EPV Index", typeof(uint)),
                    new MhwMultiStructData.Entry("Obj Hit: EPV Element #", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(int)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry("Locus: EPV Index", typeof(uint)),
                    new MhwMultiStructData.Entry("Locus: EPV Element #", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint))
                }, 1, showVertically: true),
                new MhwMultiStructData.StructData("Sound", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Wwise Container Header", typeof(uint)),
                    new MhwMultiStructData.Entry("Wwise Container", typeof(string), isNullTerminatedString: true, condition: "if (|ref|Wwise_Container_Header_raw != 0)"),
                    new MhwMultiStructData.Entry("Sound: Shoot Header", typeof(int)),
                    new MhwMultiStructData.Entry("Sound: Shoot", typeof(int)),
                    new MhwMultiStructData.Entry("Sound: Loop Header", typeof(int)),
                    new MhwMultiStructData.Entry("Sound: Loop", typeof(int)),
                    new MhwMultiStructData.Entry("Sound: Kill Header", typeof(int)),
                    new MhwMultiStructData.Entry("Sound: Kill", typeof(int)),
                    new MhwMultiStructData.Entry("Sound: Wall/Ground Hit Header", typeof(int)),
                    new MhwMultiStructData.Entry("Sound: Wall/Ground Hit", typeof(int)),
                    new MhwMultiStructData.Entry("Sound: Water Hit Header", typeof(int)),
                    new MhwMultiStructData.Entry("Sound: Water Hit", typeof(int)),
                    new MhwMultiStructData.Entry("Sound: Player Hit Header", typeof(int)),
                    new MhwMultiStructData.Entry("Sound: Player Hit", typeof(int)),
                    new MhwMultiStructData.Entry("Sound: Delay Set Header (Slinger)", typeof(int)),
                    new MhwMultiStructData.Entry("Sound: Delay Set (Slinger)", typeof(int)),
                    new MhwMultiStructData.Entry("Sound: Life End Header (Slinger)", typeof(int)),
                    new MhwMultiStructData.Entry("Sound: Life End (Slinger)", typeof(int)),
                    new MhwMultiStructData.Entry("Sound: Monster Reflect Header", typeof(int)),
                    new MhwMultiStructData.Entry("Sound: Monster Reflect", typeof(int)),
                    new MhwMultiStructData.Entry("Sound: Custom Header 1", typeof(int)),
                    new MhwMultiStructData.Entry("Sound: Custom 1", typeof(int)),
                    new MhwMultiStructData.Entry("Sound: Custom Header 2", typeof(int)),
                    new MhwMultiStructData.Entry("Sound: Custom 2", typeof(int)),
                    new MhwMultiStructData.Entry("Sound: Custom Header 3", typeof(int)),
                    new MhwMultiStructData.Entry("Sound: Custom 3", typeof(int))
                }, 1, showVertically: true),
                new MhwMultiStructData.StructData("Shlp (2)", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Header", typeof(uint)),
                    new MhwMultiStructData.Entry("Projectile: Entity Collider", typeof(uint)),
                    new MhwMultiStructData.Entry("Projectile: Model Lifespan", typeof(float)),
                    new MhwMultiStructData.Entry("Projectile: Distance Range", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry("Projectile: Spawn Pos Y", typeof(float)),
                    new MhwMultiStructData.Entry("Projectile: Spawn Pos X", typeof(float)),
                    new MhwMultiStructData.Entry("Projectile: Velocity", typeof(float)),
                    new MhwMultiStructData.Entry("Projectile: Falloff", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry("Angle Unk 1", typeof(float)),
                    new MhwMultiStructData.Entry("Angle Unk 2", typeof(float)),
                    new MhwMultiStructData.Entry("Angle Unk 3", typeof(float)),
                    new MhwMultiStructData.Entry("Angle Unk 4", typeof(float)),
                    new MhwMultiStructData.Entry("Projectile: Hitbox Range", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry("Insta-Kill Trigger", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(ushort)),
                    new MhwMultiStructData.Entry("Entity: Collide 1", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry("Entity: Collide 2", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.Entry("Entity: Spawn Location", typeof(byte)),
                    new MhwMultiStructData.Entry("Entity: Range", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(ushort)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData("Number of Modifiers Holder", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Number of Modifiers", typeof(uint), true).Out(out var modifiersCount)
                }, 1, true).Out(out var modifiersCountHolder),

                new MhwMultiStructData.StructData("Modifiers", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Header", typeof(uint)),
                    new MhwMultiStructData.Entry("Value 1 (if 412627386)", typeof(sbyte), condition: "if (|ref|Header_raw == 412627386)"),
                    new MhwMultiStructData.Entry("Value 2 (if 412627386)", typeof(sbyte), condition: "if (|ref|Header_raw == 412627386)"),
                    new MhwMultiStructData.Entry("Value 3 (if 412627386)", typeof(sbyte), condition: "if (|ref|Header_raw == 412627386)"),
                    new MhwMultiStructData.Entry("Value 4 (if 412627386)", typeof(sbyte), condition: "if (|ref|Header_raw == 412627386)"),
                    new MhwMultiStructData.Entry("Value (if 3289971)", typeof(int), condition: "if (|ref|Header_raw == 3289971)"),
                    new MhwMultiStructData.Entry("Value (if 79120377)", typeof(float), condition: "if (|ref|Header_raw == 79120377)"),
                    new MhwMultiStructData.Entry("Value (if 306780182)", typeof(sbyte), condition: "if (|ref|Header_raw == 306780182)"),
                    new MhwMultiStructData.Entry("Value X (if 1335056316)", typeof(float), condition: "if (|ref|Header_raw == 1335056316)"),
                    new MhwMultiStructData.Entry("Value Y (if 1335056316)", typeof(float), condition: "if (|ref|Header_raw == 1335056316)"),
                    new MhwMultiStructData.Entry("Value Z (if 1335056316)", typeof(float), condition: "if (|ref|Header_raw == 1335056316)"),
                    new MhwMultiStructData.Entry("Value Unk (if 1335056316)", typeof(float), condition: "if (|ref|Header_raw == 1335056316)"),
                    new MhwMultiStructData.Entry("Name", typeof(string), isNullTerminatedString: true),
                    new MhwMultiStructData.Entry("Unk 1", typeof(uint)),
                    new MhwMultiStructData.Entry("DataType", typeof(string), isNullTerminatedString: true),
                    new MhwMultiStructData.Entry("Unk 2", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk 3", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk 4", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk 5", typeof(byte))
                }, canAddRows: true, _010Link: new MhwMultiStructData.ArrayLink(modifiersCountHolder, modifiersCount)),

                new MhwMultiStructData.StructData("Unknown", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint))
                }, 1)
            };

            return new MultiStruct("MHW_Editor.Weapons", "ShellParam", new MhwMultiStructData(structs, "shlp", EncryptionKeys.FILE_EXT_KEY_LOOKUP[".shlp"]));
        }
    }
}