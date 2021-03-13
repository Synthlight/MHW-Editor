using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Weapons {
    public class Collision : IMultiStruct {
        public MultiStruct Generate() { // .col
            var header = new MhwMultiStructData.StructData("Collisions", new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry("Magic 1", typeof(uint), true),
                new MhwMultiStructData.Entry("Name", typeof(char), true, typeof(string), arrayCount: 4),
                new MhwMultiStructData.Entry("Magic 2", typeof(uint), true),
                new MhwMultiStructData.Entry("Unk 1", typeof(uint), true),
                new MhwMultiStructData.Entry("Unk 2", typeof(uint), true),
                new MhwMultiStructData.Entry("Name Count", typeof(uint), true).Out(out var nameCount)
            }, 1);

            var names = new MhwMultiStructData.StructData("Names", new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry("Name", typeof(string), isNullTerminatedString: true, accessLevel: "protected"),
                new MhwMultiStructData.Entry("Collider Geomtry Param Id", typeof(int), true),
                new MhwMultiStructData.Entry("Move Id", typeof(int), true),
                new MhwMultiStructData.Entry("Unk 1", typeof(int)),
                new MhwMultiStructData.Entry("Unk 2", typeof(ushort)),
                new MhwMultiStructData.Entry("Unk 3", typeof(byte)),
                new MhwMultiStructData.Entry("Unk 4", typeof(uint))
            }, _010Link: new MhwMultiStructData.ArrayLink(header, nameCount));

            var clnd = new MhwMultiStructData.StructData("Collider Node Param", new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry("Magic 1", typeof(uint), true),
                new MhwMultiStructData.Entry("Name", typeof(char), true, typeof(string), arrayCount: 4),
                new MhwMultiStructData.Entry("Magic 2", typeof(uint), true),
                new MhwMultiStructData.Entry("Collider Geomtry Param Count", typeof(uint), true).Out(out var clgmCount),
                new MhwMultiStructData.Entry("Collider Geomtry Param Type", typeof(uint), true),
                new MhwMultiStructData.Entry("Unk 1", typeof(byte)),

                new MhwMultiStructData.Entry("Collider Geomtry Params", typeof(void), subStruct: new MhwMultiStructData.StructData("Collider Geomtry Params", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Magic 1", typeof(uint), true),
                    new MhwMultiStructData.Entry("Name", typeof(char), true, typeof(string), arrayCount: 4),
                    new MhwMultiStructData.Entry("Magic 2", typeof(uint), true),
                    new MhwMultiStructData.Entry("Collider Geomtry Param Inner Count", typeof(uint), true).Out(out var clgmInnerCount),

                    new MhwMultiStructData.Entry("Collider Geomtry Param Inner", typeof(void), subStruct: new MhwMultiStructData.StructData("Collider Geomtry Param Inner", new List<MhwMultiStructData.Entry> {
                        new MhwMultiStructData.Entry("Unk 1", typeof(byte)),
                        new MhwMultiStructData.Entry("Unk 2", typeof(byte)),
                        new MhwMultiStructData.Entry("Attack Range", typeof(float)),
                        new MhwMultiStructData.Entry("Unk 4", typeof(float)),
                        new MhwMultiStructData.Entry("Unk 5", typeof(float)),
                        new MhwMultiStructData.Entry("Unk 6", typeof(float)),
                        new MhwMultiStructData.Entry("Unk 7", typeof(short)),
                        new MhwMultiStructData.Entry("Unk 8", typeof(short)),
                        new MhwMultiStructData.Entry("Unk 9", typeof(float)),
                        new MhwMultiStructData.Entry("Unk 10", typeof(float)),
                        new MhwMultiStructData.Entry("Unk 11", typeof(float)),
                        new MhwMultiStructData.Entry("Unk 12", typeof(float)),
                        new MhwMultiStructData.Entry("Unk 13", typeof(float)),
                        new MhwMultiStructData.Entry("Unk 14", typeof(float)),
                        new MhwMultiStructData.Entry("Unk 15", typeof(ushort)),
                        new MhwMultiStructData.Entry("Unk 16", typeof(uint)),
                        new MhwMultiStructData.Entry("Unk 17", typeof(short)),
                        new MhwMultiStructData.Entry("Unk 18", typeof(float)),
                        new MhwMultiStructData.Entry("Unk 19", typeof(float)),
                        new MhwMultiStructData.Entry("Unk 20", typeof(float)),
                        new MhwMultiStructData.Entry("Unk 21", typeof(float)),
                        new MhwMultiStructData.Entry("Unk 22", typeof(ushort))
                    }, _010Link: new MhwMultiStructData.ArrayLink(null, clgmInnerCount))),

                    new MhwMultiStructData.Entry("Unk 1", typeof(uint)),
                    new MhwMultiStructData.Entry("Attack Range (if 'Unk 1' == 1)", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk 2", typeof(byte)),
                    new MhwMultiStructData.Entry("Unk 3", typeof(byte)),
                    new MhwMultiStructData.Entry("Unk 4", typeof(byte)),
                    new MhwMultiStructData.Entry("Unk 5", typeof(byte)),
                    new MhwMultiStructData.Entry("Unk 6", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk 7", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk 8", typeof(short)),
                    new MhwMultiStructData.Entry("Unk 9", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk 10", typeof(ushort)),

                    new MhwMultiStructData.Entry("Unk 11", typeof(int), condition: "if (parent.Collider_Geomtry_Param_Type_raw == 2)"),
                    new MhwMultiStructData.Entry("Unk 12", typeof(int), condition: "if (parent.Collider_Geomtry_Param_Type_raw == 2)"),
                    new MhwMultiStructData.Entry("Unk 13", typeof(int), condition: "if (parent.Collider_Geomtry_Param_Type_raw == 2)"),
                    new MhwMultiStructData.Entry("Unk 14", typeof(int), condition: "if (parent.Collider_Geomtry_Param_Type_raw == 2)"),
                    new MhwMultiStructData.Entry("Unk 15", typeof(int), condition: "if (parent.Collider_Geomtry_Param_Type_raw == 2)"),
                    new MhwMultiStructData.Entry("Unk 16", typeof(int), condition: "if (parent.Collider_Geomtry_Param_Type_raw == 2)"),
                    new MhwMultiStructData.Entry("Unk 17", typeof(int), condition: "if (parent.Collider_Geomtry_Param_Type_raw == 2)"),
                    new MhwMultiStructData.Entry("Unk 18", typeof(int), condition: "if (parent.Collider_Geomtry_Param_Type_raw == 2)"),

                    new MhwMultiStructData.Entry("Unk 19", typeof(byte))
                }, _010Link: new MhwMultiStructData.ArrayLink(null, clgmCount))),

                new MhwMultiStructData.Entry("Unk 2", typeof(byte)),
                new MhwMultiStructData.Entry("Unk 3", typeof(byte)),
                new MhwMultiStructData.Entry("Unk 4", typeof(byte))
            }, 1);

            var i = 0U;

            var atk0 = new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry("Index", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(ushort))
            };

            i = 0U;

            var atk1 = new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry("Index", typeof(uint)),
                new MhwMultiStructData.Entry("Attack Type", typeof(uint)),
                new MhwMultiStructData.Entry("Motion Value", typeof(float)),
                new MhwMultiStructData.Entry("Fixed Damage", typeof(float)),
                new MhwMultiStructData.Entry("Part Modifier", typeof(float)),
                new MhwMultiStructData.Entry("Elemental Modifier", typeof(float)),
                new MhwMultiStructData.Entry("Status Modifier", typeof(float)),
                new MhwMultiStructData.Entry("Stun", typeof(float)),
                new MhwMultiStructData.Entry("Exhaust", typeof(float)),
                new MhwMultiStructData.Entry("Mount", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                new MhwMultiStructData.Entry("Soften Value", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry("Flinch Value", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry("Mind's Eye", typeof(byte)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry("Hit Lag Speed Multiplier (a)", typeof(float)),
                new MhwMultiStructData.Entry("Hit Lag (a)", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry("Hit Lag Speed Multiplier (b)", typeof(float)),
                new MhwMultiStructData.Entry("Hit Lag (b)", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(sbyte)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry("Lingering Hurtbox", typeof(byte)),
                new MhwMultiStructData.Entry("Frame Delay", typeof(float)),
                new MhwMultiStructData.Entry("No Sharpness Consumed", typeof(uint), enumReturn: typeof(bool)),
                new MhwMultiStructData.Entry($"Unk {i += 2}", typeof(ushort)),
                new MhwMultiStructData.Entry("Energy Gen", typeof(float)),
                new MhwMultiStructData.Entry("Conditional Motion value change/replace", typeof(float)),
                new MhwMultiStructData.Entry("Conditional element modifier change/replace", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(ushort))
            };

            i = 0U;

            var atk2 = new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry("Index", typeof(uint)),
                new MhwMultiStructData.Entry("Knock-back Type", typeof(uint)),
                new MhwMultiStructData.Entry("Knock-back Lvl", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry("Motion Value", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry("Guard Stamina Cost", typeof(float)),
                new MhwMultiStructData.Entry("Guard Req", typeof(uint)),
                new MhwMultiStructData.Entry("Element Id", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry("Element Dmg", typeof(float)),
                new MhwMultiStructData.Entry("Standard Poison", typeof(float)),
                new MhwMultiStructData.Entry("Deadly Poison", typeof(float)),
                new MhwMultiStructData.Entry("Paralysis", typeof(float)),
                new MhwMultiStructData.Entry("Sleep", typeof(float)),
                new MhwMultiStructData.Entry("Blast", typeof(float)),
                new MhwMultiStructData.Entry("Blast Scourge", typeof(float)),
                new MhwMultiStructData.Entry("Stun", typeof(float)),
                new MhwMultiStructData.Entry("Bleed", typeof(float)),
                new MhwMultiStructData.Entry("Miasma", typeof(float)),
                new MhwMultiStructData.Entry("Ele Res Down Double", typeof(byte)),
                new MhwMultiStructData.Entry("Ele Res Down", typeof(byte)),
                new MhwMultiStructData.Entry("Def Down Double", typeof(byte)),
                new MhwMultiStructData.Entry("Def Down", typeof(byte)),
                new MhwMultiStructData.Entry($"Unk {i += 2}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(ushort))
            };

            i = 0U;

            var atk3 = new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry("Index", typeof(uint)),
                new MhwMultiStructData.Entry("Damage Type 1", typeof(uint)),
                new MhwMultiStructData.Entry("Damage Type 2", typeof(uint)),
                new MhwMultiStructData.Entry("Damage Motion Value", typeof(float)),
                new MhwMultiStructData.Entry("Fixed Damage", typeof(float)),
                new MhwMultiStructData.Entry("Modifier PartDamage", typeof(float)),
                new MhwMultiStructData.Entry("Element Type", typeof(uint)),
                new MhwMultiStructData.Entry("Fixed Elemental Damage", typeof(float)),
                new MhwMultiStructData.Entry("Modifier Element", typeof(float)),
                new MhwMultiStructData.Entry("Modifier Status", typeof(float)),
                new MhwMultiStructData.Entry("Fixed Status Value: Poison", typeof(float)),
                new MhwMultiStructData.Entry("Fixed Status Value: Paralysis", typeof(float)),
                new MhwMultiStructData.Entry("Fixed Status Value: Sleep", typeof(float)),
                new MhwMultiStructData.Entry("Fixed Status Value: Blast", typeof(float)),
                new MhwMultiStructData.Entry("Extra Stun", typeof(float)),
                new MhwMultiStructData.Entry("Extra Exhaust", typeof(float)),
                new MhwMultiStructData.Entry("Fixed Status Value: Traq", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry("Soften Value", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(sbyte)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry("Piercing Attack", typeof(byte)),
                new MhwMultiStructData.Entry("Delay Between Attack Frames", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++i}", typeof(ushort))
            };

            var moves = new MhwMultiStructData.StructData("Moves", new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry("Magic 1", typeof(uint), true),
                new MhwMultiStructData.Entry("Name", typeof(char), true, typeof(string), arrayCount: 4),
                new MhwMultiStructData.Entry("Magic 2", typeof(uint), true),
                new MhwMultiStructData.Entry("Move Count", typeof(uint), true).Out(out var moveCount),
                new MhwMultiStructData.Entry("Move Type", typeof(uint), true),

                new MhwMultiStructData.Entry("Atk0", typeof(void), subStruct: new MhwMultiStructData.StructData("Atk0", atk0, _010Link: new MhwMultiStructData.ArrayLink(null, moveCount))
                                             , condition: "if (|ref|Move_Type_raw == 0)", accessLevel: "protected"),
                new MhwMultiStructData.Entry("Atk1", typeof(void), subStruct: new MhwMultiStructData.StructData("Atk1", atk1, _010Link: new MhwMultiStructData.ArrayLink(null, moveCount))
                                             , condition: "if (|ref|Move_Type_raw == 1)", accessLevel: "protected"),
                new MhwMultiStructData.Entry("Atk2", typeof(void), subStruct: new MhwMultiStructData.StructData("Atk2", atk2, _010Link: new MhwMultiStructData.ArrayLink(null, moveCount))
                                             , condition: "if (|ref|Move_Type_raw == 2)", accessLevel: "protected"),
                new MhwMultiStructData.Entry("Atk3", typeof(void), subStruct: new MhwMultiStructData.StructData("Atk3", atk3, _010Link: new MhwMultiStructData.ArrayLink(null, moveCount))
                                             , condition: "if (|ref|Move_Type_raw == 3)", accessLevel: "protected")
            }, 1);

            var oap = new MhwMultiStructData.StructData("OAP", new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry("Magic 1", typeof(uint), true),
                new MhwMultiStructData.Entry("Magic 2", typeof(uint), true),
                new MhwMultiStructData.Entry("Name", typeof(char), true, typeof(string), arrayCount: 4),
                new MhwMultiStructData.Entry("Magic 3", typeof(uint), true),
                new MhwMultiStructData.Entry("The rest of the file as bytes.", typeof(void), true, subStruct: new MhwMultiStructData.StructData("End Junk", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Unk", typeof(byte), true)
                }, customSaveLoad: true))
            }, 1);

            var structs = new List<MhwMultiStructData.StructData> {
                header,
                names,
                clnd,
                moves,
                oap
            };

            return new MultiStruct("Weapons", "Collision", new MhwMultiStructData(structs, "col"));
        }
    }
}