namespace MHW_Editor.Models {
    public struct IdNamePair {
        public readonly ushort id;
        public readonly string name;

        public IdNamePair(ushort id, string name) {
            this.id = id;
            this.name = name;
        }

        public static IdNamePair Unknown(ushort id) {
            return new IdNamePair(id, "Unknown");
        }

        public override string ToString() {
            if (MainWindow.showIdBeforeName) {
                return $"{id}: {name}";
            } else {
                return $"{name}: {id}";
            }
        }

        public bool Equals(IdNamePair other) {
            return id == other.id;
        }

        public bool Equals(ushort other) {
            return id == other;
        }

        public override bool Equals(object obj) {
            return obj is IdNamePair other1 && this == other1
                   || obj is ushort other2 && this == other2;
        }

        public override int GetHashCode() {
            return id.GetHashCode();
        }

        public static bool operator ==(IdNamePair left, IdNamePair right) {
            return left.id == right.id;
        }

        public static bool operator !=(IdNamePair left, IdNamePair right) {
            return left.id != right.id;
        }

        public static bool operator ==(IdNamePair left, ushort right) {
            return left.id == right;
        }

        public static bool operator !=(IdNamePair left, ushort right) {
            return left.id != right;
        }
    }
}