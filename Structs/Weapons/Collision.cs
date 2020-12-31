using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using JetBrains.Annotations;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Structs.Weapons {
    public partial class Collision : MhwMultiStructFile<Collision> {
        public void Init(string targetFile) {
            var nameList = GetStructList<Names>();
            foreach (var name in nameList) {
                name.Init(targetFile);

                var clgm = GetClgm(name.Collider_Geomtry_Param_Id);
                if (clgm != null) {
                    name.LinkedClgm.Add(clgm);
                }

                var move = GetMove(name.Move_Id);
                if (move != null) {
                    name.LinkedMove.Add(move);
                    ((dynamic) move).translatedName = name.TranslatedName;
                }
            }
        }

        private Collider_Node_Param.Collider_Geomtry_Params GetClgm(int clgmId) {
            var clnd = GetStructList<Collider_Node_Param>().FirstOrDefault();
            return clnd?.Collider_Geomtry_Params_raw?.FirstOrDefault(clgm => (int) clgm.Index == clgmId);
        }

        private object GetMove(int moveId) {
            var moveList = GetStructList<Moves>();
            return (from Moves move in moveList
                    select GetAtk(moveId, move.Atks))
                .FirstOrDefault(atk => atk != null);
        }

        private object GetAtk(int moveId, dynamic atks) {
            foreach (var atk in atks) {
                if ((int) atk.Index == moveId) {
                    return atk;
                }
            }
            return null;
        }

        public partial class Names {
            public void Init(string targetFile) {
                TranslatedName = Name;

                var translatedName = Name;
                var description    = "";

                if (translatedName == "\0") translatedName = null;

                if (string.IsNullOrEmpty(Name) || Move_Id == -1) return;

                // ReSharper disable once ForeachCanBePartlyConvertedToQueryUsingAnotherGetEnumerator
                foreach (var key in DataHelper.collisionTranslationsData.Keys) {
                    if (targetFile.EndsWith(key)) {
                        var nameDescPair = DataHelper.collisionTranslationsData[key].TryGet(Move_Id, null);
                        if (nameDescPair != null) {
                            if (!string.IsNullOrEmpty(nameDescPair.name)) {
                                translatedName = nameDescPair.name;
                            }
                            description = nameDescPair.description;
                            if (description == "guess dummy") {
                                description = "Unused?";
                            }
                        } else {
                            return;
                        }
                    }
                }

                TranslatedName = translatedName;
                if (string.IsNullOrEmpty(TranslatedName)) {
                    TranslatedName = description;
                } else if (!string.IsNullOrEmpty(description)) {
                    TranslatedName += $", {description}";
                }
            }

            [DisplayName("Name")]
            [SortOrder(40)]
            public string TranslatedName { get; private set; }

            [SortOrder(Collider_Geomtry_Param_Id_sortIndex + 1)]
            [DisplayName("Linked Collider Geomtry Params")]
            public ObservableCollection<Collider_Node_Param.Collider_Geomtry_Params> LinkedClgm { get; } = new ObservableCollection<Collider_Node_Param.Collider_Geomtry_Params>();

            [SortOrder(Move_Id_sortIndex + 1)]
            [DisplayName("Linked Move")]
            public ObservableCollection<object> LinkedMove { get; } = new ObservableCollection<object>();
        }

        public partial class Moves {
            [SortOrder(Atk0_sortIndex)]
            [DisplayName("Atks")]
            [IsList]
            public dynamic Atks {
                get {
                    return Move_Type switch {
                        0 => Atk0_raw,
                        1 => Atk1_raw,
                        2 => Atk2_raw,
                        3 => Atk3_raw,
                        _ => null // Should never happen.
                    };
                }
            }

            private const string TRANSLATED_NAME_DISPLAY_NAME = "First Matching Name";
            private const int    TRANSLATED_NAME_SORT_ORDER   = 55;

            public partial class Atk0 : IAtk {
                [UsedImplicitly] public string translatedName;

                [DisplayName(TRANSLATED_NAME_DISPLAY_NAME)]
                [SortOrder(TRANSLATED_NAME_SORT_ORDER)]
                public string TranslatedName => translatedName;
            }

            public partial class Atk1 : IAtk {
                [UsedImplicitly] public string translatedName;

                [DisplayName(TRANSLATED_NAME_DISPLAY_NAME)]
                [SortOrder(TRANSLATED_NAME_SORT_ORDER)]
                public string TranslatedName => translatedName;
            }

            public partial class Atk2 : IAtk {
                [UsedImplicitly] public string translatedName;

                [DisplayName(TRANSLATED_NAME_DISPLAY_NAME)]
                [SortOrder(TRANSLATED_NAME_SORT_ORDER)]
                public string TranslatedName => translatedName;
            }

            public partial class Atk3 : IAtk {
                [UsedImplicitly] public string translatedName;

                [DisplayName(TRANSLATED_NAME_DISPLAY_NAME)]
                [SortOrder(TRANSLATED_NAME_SORT_ORDER)]
                public string TranslatedName => translatedName;
            }

            public interface IAtk {
                public string TranslatedName { get; }
            }
        }

        public partial class OAP {
            [SortOrder(The_rest_of_the_file_as_bytes__sortIndex - 1)]
            [DisplayName("Bytes Skipped")]
            public uint BytesSkipped => (uint) The_rest_of_the_file_as_bytes__raw.Count;

            public partial class End_Junk {
                public static ObservableCollection<End_Junk> LoadData(BinaryReader reader, OAP parent) {
                    var list  = new ObservableCollection<End_Junk>();
                    var bytes = reader.ReadRemainderAsByteArray();
                    for (var i = 0; i < bytes.Count; i++) {
                        list.Add(new End_Junk {
                            Index   = (ulong) i,
                            Unk_raw = bytes[i]
                        });
                    }
                    return list;
                }
            }
        }
    }
}