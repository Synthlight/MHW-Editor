using System.Collections.Generic;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Generator {
    public static partial class Program {
        private static void GenMultiStruct() {
            GenMonsterDifficulty();
            GenMonsterEnrage();
            GenMonsterRandomSize();
            GenMonsterStamina();
            GenShellProjectile();
            GenSupplyData();
        }

        private static void GenMonsterStamina() { // .dtt_sta
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
                new MhwMultiStructData.StructData("Stamina (LR)", stamina),

                new MhwMultiStructData.StructData("Fatigue (HR)", fatigue, 1),
                new MhwMultiStructData.StructData("Stamina Count (HR)", staminaCount, 1, true),
                new MhwMultiStructData.StructData("Stamina (HR)", stamina),

                new MhwMultiStructData.StructData("Fatigue (MR)", fatigue, 1),
                new MhwMultiStructData.StructData("Stamina Count (MR)", staminaCount, 1, true),
                new MhwMultiStructData.StructData("Stamina (MR)", stamina)
            };

            GenerateMultiStructProps("MHW_Editor.Monsters", "MonsterStamina", new MhwMultiStructData(structs, 0));
        }

        private static void GenMonsterRandomSize() { // .dtt_rsz 
            var crownTable = new List<MhwMultiStructData.StructData.Entry> {
                new MhwMultiStructData.StructData.Entry("Name (Jap)", typeof(string), isNullTerminatedString: true)
            }; // TODO: Add support for sub-sub-structs.

            for (var i = 0; i < 38; i++) {
                crownTable.Add(new MhwMultiStructData.StructData.Entry($"Crown Size Multiplier {i + 1}", typeof(int)));
                crownTable.Add(new MhwMultiStructData.StructData.Entry($"Crown Size Rarity {i + 1}", typeof(int)));
            }

            var structs = new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("Monster Random Sizes", new List<MhwMultiStructData.StructData.Entry> {
                    new MhwMultiStructData.StructData.Entry("Magic 1", typeof(uint), true),
                    new MhwMultiStructData.StructData.Entry("Magic 2", typeof(uint), true),
                    new MhwMultiStructData.StructData.Entry("Number of Monsters", typeof(uint), true)
                }, 1),
                new MhwMultiStructData.StructData("Monsters", new List<MhwMultiStructData.StructData.Entry> {
                    new MhwMultiStructData.StructData.Entry("Monster Id", typeof(uint), true),
                    new MhwMultiStructData.StructData.Entry("Gold Small Crown Limit", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry("Silver Crown Limit", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry("Gold Big Crown Limit", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry("Base Size", typeof(float))
                }),
                new MhwMultiStructData.StructData("Crown Table Count", new List<MhwMultiStructData.StructData.Entry> {
                    new MhwMultiStructData.StructData.Entry("Number of Crown Tables", typeof(uint), true)
                }, 1, true),
                new MhwMultiStructData.StructData("Crown Tables", crownTable)
            };

            GenerateMultiStructProps("MHW_Editor.Monsters", "MonsterRandomSize", new MhwMultiStructData(structs, 0));
        }

        private static void GenMonsterDifficulty() { // .dtt_dif
            var scalingValues = new List<MhwMultiStructData.StructData.Entry> {
                new MhwMultiStructData.StructData.Entry("Monster HP Multiplier", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Monster Damage Multiplier", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Player Damage Multiplier", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Monster Part HP", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Monster Status Base", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Monster Status Buildup", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Monster Stun", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Monster Exhaust", typeof(float)),
                new MhwMultiStructData.StructData.Entry("Monster Mount", typeof(float))
            };

            var structs = new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("Monster Difficulty", new List<MhwMultiStructData.StructData.Entry> {
                    new MhwMultiStructData.StructData.Entry("Magic 1", typeof(uint), true),
                    new MhwMultiStructData.StructData.Entry("Magic 2", typeof(uint), true)
                }, 1),
                new MhwMultiStructData.StructData("Solo Stats", scalingValues, 1000),
                new MhwMultiStructData.StructData("Multi Stats", scalingValues, 1000),
                new MhwMultiStructData.StructData("Unknown", new List<MhwMultiStructData.StructData.Entry> {
                    new MhwMultiStructData.StructData.Entry("Unk 1", typeof(uint), true),
                    new MhwMultiStructData.StructData.Entry("Unk 2", typeof(uint), true),
                    new MhwMultiStructData.StructData.Entry("Unk 3", typeof(uint), true),
                    new MhwMultiStructData.StructData.Entry("Unk 4", typeof(uint), true),
                    new MhwMultiStructData.StructData.Entry("Unk 5", typeof(uint), true),
                    new MhwMultiStructData.StructData.Entry("Unk 6", typeof(uint), true),
                    new MhwMultiStructData.StructData.Entry("Unk 7", typeof(uint), true)
                }, 1)
            };

            GenerateMultiStructProps("MHW_Editor.Monsters", "MonsterDifficulty", new MhwMultiStructData(structs, 0));
        }

        private static void GenMonsterEnrage() { // .dtt_agr
            var structs = new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("Monster Rage", new List<MhwMultiStructData.StructData.Entry> {
                    new MhwMultiStructData.StructData.Entry("Magic 1", typeof(uint), true),
                    new MhwMultiStructData.StructData.Entry("Magic 2", typeof(uint), true),
                    new MhwMultiStructData.StructData.Entry("Monster Id", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry("Magic 3", typeof(uint), true)
                }, 1),
                new MhwMultiStructData.StructData("Rage Stats", new List<MhwMultiStructData.StructData.Entry> {
                    new MhwMultiStructData.StructData.Entry("Build to Trigger", typeof(int), valueString: "value.Clamp((int) -1, (int) int.MaxValue)"),
                    new MhwMultiStructData.StructData.Entry("Duration", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Speed Modifier", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Damage Modifier", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Player Damage Modifier", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Build Multiplier by HP (100%)", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Build Multiplier by HP (88%-99%)", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Build Multiplier by HP (77%-88%)", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Build Multiplier by HP (66%-77%)", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Build Multiplier by HP (55%-66%)", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Build Multiplier by HP (44%-55%)", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Build Multiplier by HP (33%-44%)", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Build Multiplier by HP (22%-33%)", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Build Multiplier by HP (11%-22%)", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Build Multiplier by HP (0%-11%)", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Out of Combat Decay Multiplier", typeof(float))
                }, 2)
            };

            GenerateMultiStructProps("MHW_Editor.Monsters", "MonsterEnrage", new MhwMultiStructData(structs, 0));
        }

        private static void GenShellProjectile() { // .shlp
            var i = 0;

            var structs = new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("Shlp", new List<MhwMultiStructData.StructData.Entry> {
                    new MhwMultiStructData.StructData.Entry("Magic 1", typeof(uint), true),
                    new MhwMultiStructData.StructData.Entry("SLP", typeof(char), true, typeof(string), arrayCount: 4),
                    new MhwMultiStructData.StructData.Entry("Magic 2", typeof(uint), true)
                }, 1),
                new MhwMultiStructData.StructData("Assets", new List<MhwMultiStructData.StructData.Entry> {
                    new MhwMultiStructData.StructData.Entry("Magic", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry("Path", typeof(string), isNullTerminatedString: true, condition: "if (|ref|Magic_raw != 0)")
                }, 25),
                new MhwMultiStructData.StructData("Shlp (1)", new List<MhwMultiStructData.StructData.Entry> {
                    new MhwMultiStructData.StructData.Entry("Particles: Projectile Header", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry("Particles: Projectile", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry("Particles: Muzzle Header", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry("Particles: Muzzle", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(int)),
                    new MhwMultiStructData.StructData.Entry("Obj Collision Header", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry("Obj Collision", typeof(string), isNullTerminatedString: true, condition: "if (|ref|Obj_Collision_Header_raw != 0)"),
                    new MhwMultiStructData.StructData.Entry("Obj Collision Index", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry("Timeline List Header", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry("Timeline List", typeof(string), isNullTerminatedString: true, condition: "if (|ref|Timeline_List_Header_raw != 0)"),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry("Number of Shell Params", typeof(uint), true)
                }, 1),
                new MhwMultiStructData.StructData("Shell Params", new List<MhwMultiStructData.StructData.Entry> {
                    new MhwMultiStructData.StructData.Entry("Header", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry("Path", typeof(string), isNullTerminatedString: true),
                    new MhwMultiStructData.StructData.Entry("Unk 1", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry("Unk 2", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry("Unk 3", typeof(uint))
                }),
                new MhwMultiStructData.StructData("Shlp (2)", new List<MhwMultiStructData.StructData.Entry> {
                    new MhwMultiStructData.StructData.Entry("Particles: Ground Decal Header", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry("Particles: Ground Decal", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry("Particles: Wall Decal Header", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry("Particles: Wall Decal", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry("Particles: Obj Hit Header", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry("Particles: Obj Hit", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(int)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry("Particles: Gun Fire Header", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry("Particles: Gun Fire", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(uint))
                }, 1),
                new MhwMultiStructData.StructData("Shlp (3)", new List<MhwMultiStructData.StructData.Entry> {
                    new MhwMultiStructData.StructData.Entry("Wwise Container Header", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry("Wwise Container", typeof(string), isNullTerminatedString: true, condition: "if (|ref|Wwise_Container_Header_raw != 0)"),
                    new MhwMultiStructData.StructData.Entry("Sound: Gun Fire Header", typeof(int)),
                    new MhwMultiStructData.StructData.Entry("Sound: Gun Fire", typeof(int)),
                    new MhwMultiStructData.StructData.Entry("Sound: Bullet Travel Header", typeof(int)),
                    new MhwMultiStructData.StructData.Entry("Sound: Bullet Travel", typeof(int)),
                    new MhwMultiStructData.StructData.Entry("Sound: Explode Header", typeof(int)),
                    new MhwMultiStructData.StructData.Entry("Sound: Explode", typeof(int)),
                    new MhwMultiStructData.StructData.Entry("Sound: Hit Wall or Ground Header", typeof(int)),
                    new MhwMultiStructData.StructData.Entry("Sound: Hit Wall or Ground", typeof(int)),
                    new MhwMultiStructData.StructData.Entry("Sound: Hit Obj Hit Header", typeof(int)),
                    new MhwMultiStructData.StructData.Entry("Sound: Hit Obj Hit", typeof(int)),
                    new MhwMultiStructData.StructData.Entry("Sound: Condition Header 1", typeof(int)),
                    new MhwMultiStructData.StructData.Entry("Sound: Condition 1", typeof(int)),
                    new MhwMultiStructData.StructData.Entry("Sound: Slinger Condition Header 1", typeof(int)),
                    new MhwMultiStructData.StructData.Entry("Sound: Slinger Condition 1", typeof(int)),
                    new MhwMultiStructData.StructData.Entry("Sound: Slinger Condition Header 2", typeof(int)),
                    new MhwMultiStructData.StructData.Entry("Sound: Slinger Condition 2", typeof(int)),
                    new MhwMultiStructData.StructData.Entry("Sound: Condition Header 2", typeof(int)),
                    new MhwMultiStructData.StructData.Entry("Sound: Condition 2", typeof(int)),
                    new MhwMultiStructData.StructData.Entry("Sound: Condition Header 3", typeof(int)),
                    new MhwMultiStructData.StructData.Entry("Sound: Condition 3", typeof(int)),
                    new MhwMultiStructData.StructData.Entry("Sound: Condition Header 4", typeof(int)),
                    new MhwMultiStructData.StructData.Entry("Sound: Condition 4", typeof(int)),
                    new MhwMultiStructData.StructData.Entry("Sound: Condition Header 5", typeof(int)),
                    new MhwMultiStructData.StructData.Entry("Sound: Condition 5", typeof(int))
                }, 1),
                new MhwMultiStructData.StructData("Shlp (4)", new List<MhwMultiStructData.StructData.Entry> {
                    new MhwMultiStructData.StructData.Entry("Header 2", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry("Projectile: Entity Collider", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry("Projectile: Model Lifespan", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Projectile: Distance Range", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry("Projectile: Spawn Pos Y", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Projectile: Spawn Pos X", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Projectile: Velocity", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Projectile: Falloff", typeof(float)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Projectile: Hitbox Range", typeof(float)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry("Insta-Kill Trigger", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(ushort)),
                    new MhwMultiStructData.StructData.Entry("Entity: Collide 1", typeof(float)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Entity: Collide 2", typeof(byte)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.StructData.Entry("Entity: Spawn Location", typeof(byte)),
                    new MhwMultiStructData.StructData.Entry("Entity: Range", typeof(byte)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(ushort)),
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry("Number of Modifiers", typeof(uint))
                }, 1),
                new MhwMultiStructData.StructData("Modifiers", new List<MhwMultiStructData.StructData.Entry> {
                    new MhwMultiStructData.StructData.Entry("Header", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry("Value 1 (if 412627386)", typeof(sbyte), condition: "if (|ref|Header_raw == 412627386)"),
                    new MhwMultiStructData.StructData.Entry("Value 2 (if 412627386)", typeof(sbyte), condition: "if (|ref|Header_raw == 412627386)"),
                    new MhwMultiStructData.StructData.Entry("Value 3 (if 412627386)", typeof(sbyte), condition: "if (|ref|Header_raw == 412627386)"),
                    new MhwMultiStructData.StructData.Entry("Value 4 (if 412627386)", typeof(sbyte), condition: "if (|ref|Header_raw == 412627386)"),
                    new MhwMultiStructData.StructData.Entry("Value (if 3289971)", typeof(int), condition: "if (|ref|Header_raw == 3289971)"),
                    new MhwMultiStructData.StructData.Entry("Value (if 79120377)", typeof(float), condition: "if (|ref|Header_raw == 79120377)"),
                    new MhwMultiStructData.StructData.Entry("Value (if 306780182)", typeof(sbyte), condition: "if (|ref|Header_raw == 306780182)"),
                    new MhwMultiStructData.StructData.Entry("Value X (if 1335056316)", typeof(sbyte), condition: "if (|ref|Header_raw == 1335056316)"),
                    new MhwMultiStructData.StructData.Entry("Value Y (if 1335056316)", typeof(sbyte), condition: "if (|ref|Header_raw == 1335056316)"),
                    new MhwMultiStructData.StructData.Entry("Value Z (if 1335056316)", typeof(sbyte), condition: "if (|ref|Header_raw == 1335056316)"),
                    new MhwMultiStructData.StructData.Entry("Value Unk (if 1335056316)", typeof(sbyte), condition: "if (|ref|Header_raw == 1335056316)"),
                    new MhwMultiStructData.StructData.Entry("Name", typeof(string), isNullTerminatedString: true),
                    new MhwMultiStructData.StructData.Entry("Unk 1", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry("DataType", typeof(string), isNullTerminatedString: true),
                    new MhwMultiStructData.StructData.Entry("Unk 2", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry("Unk 3", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry("Unk 4", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry("Unk 5", typeof(byte))
                }),
                new MhwMultiStructData.StructData("Unknown", new List<MhwMultiStructData.StructData.Entry> {
                    new MhwMultiStructData.StructData.Entry($"Unk {++i}", typeof(uint))
                }, 1)
            };

            GenerateMultiStructProps("MHW_Editor.Weapons", "ShellProjectile", new MhwMultiStructData(structs, 0, EncryptionKeys.FILE_EXT_KEY_LOOKUP[".shlp"]));
        }

        private static void GenSupplyData() { // .supp
            var structs = new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("Supply Data", new List<MhwMultiStructData.StructData.Entry> {
                    new MhwMultiStructData.StructData.Entry("Magic 1", typeof(uint), true),
                    new MhwMultiStructData.StructData.Entry("Magic 2", typeof(uint), true),
                    new MhwMultiStructData.StructData.Entry("Magic 3", typeof(ushort), true),
                    new MhwMultiStructData.StructData.Entry("Supply Id", typeof(uint))
                }, 1),

                new MhwMultiStructData.StructData("Item Box", new List<MhwMultiStructData.StructData.Entry> {
                    new MhwMultiStructData.StructData.Entry("Item Id", typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.StructData.Entry("Item Count", typeof(ushort))
                }, 24),

                new MhwMultiStructData.StructData("Item Box Scaling", new List<MhwMultiStructData.StructData.Entry> {
                    new MhwMultiStructData.StructData.Entry("Items to Show", typeof(byte))
                }, 3),

                new MhwMultiStructData.StructData("Ammo Box", new List<MhwMultiStructData.StructData.Entry> {
                    new MhwMultiStructData.StructData.Entry("Ammo Id", typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.StructData.Entry("Ammo Count", typeof(ushort))
                }, 16),

                new MhwMultiStructData.StructData("Ammo Box Scaling", new List<MhwMultiStructData.StructData.Entry> {
                    new MhwMultiStructData.StructData.Entry("Ammo Items to Show", typeof(byte))
                }, 3)
            };

            GenerateMultiStructProps("MHW_Editor.Items", "SupplyData", new MhwMultiStructData(structs, 0));
        }

        public static void GenerateMultiStructProps(string @namespace, string className, MhwMultiStructData structData) {
            WriteResult($"{Global.GENERATED_ROOT}\\{@namespace.Replace(".", "\\")}", @namespace, className, new MultiStructItemTemplate {
                Session = new Dictionary<string, object> {
                    {"_namespace", @namespace},
                    {"className", className},
                    {"structData", structData}
                }
            });
        }
    }
}