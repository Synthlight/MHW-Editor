namespace MHW_Editor.Models {
    public struct IdNamePair<T> where T : struct {
        public readonly T      id;
        public readonly string name;

        public IdNamePair(T id, string name) {
            this.id   = id;
            this.name = name;
        }

        public static IdNamePair<T> Unknown(T id) {
            return new IdNamePair<T>(id, "Unknown");
        }

        public override string ToString() {
            return MainWindow.showIdBeforeName ? $"{id}: {name}" : $"{name}: {id}";
        }

        public override int GetHashCode() {
            return id.GetHashCode();
        }

        public bool Equals(IdNamePair<T> other) {
            return id.Equals(other.id);
        }

        public override bool Equals(object obj) {
            return obj is IdNamePair<T> other && Equals(other);
        }

        public static bool operator ==(IdNamePair<T> left, IdNamePair<T> right) {
            return left.Equals(right);
        }

        public static bool operator !=(IdNamePair<T> left, IdNamePair<T> right) {
            return !left.Equals(right);
        }
    }
}