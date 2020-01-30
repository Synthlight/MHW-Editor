namespace MHW_Editor.Skills {
    public struct Skill {
        public static readonly Skill DEFAULT = new Skill(0, "Unknown");
        public readonly ushort id;
        public readonly string name;

        public Skill(ushort id, string name) {
            this.id = id;
            this.name = name;
        }

        public override string ToString() {
            if (MainWindow.showSkillIdFirst) {
                return $"{id}: {name}";
            } else {
                return $"{name}: {id}";
            }
        }

        public bool Equals(Skill other) {
            return id == other.id;
        }

        public bool Equals(ushort other) {
            return id == other;
        }

        public override bool Equals(object obj) {
            return obj is Skill other1 && this == other1
                   || obj is ushort other2 && this == other2;
        }

        public override int GetHashCode() {
            return id.GetHashCode();
        }

        public static bool operator ==(Skill left, Skill right) {
            return left.id == right.id;
        }

        public static bool operator !=(Skill left, Skill right) {
            return left.id != right.id;
        }

        public static bool operator ==(Skill left, ushort right) {
            return left.id == right;
        }

        public static bool operator !=(Skill left, ushort right) {
            return left.id != right;
        }
    }
}