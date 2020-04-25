namespace MHW_Template.Models {
    public class DataValuePair {
        public readonly ushort value;
        public readonly string name;
        public readonly string description;

        public DataValuePair(ushort value, string name, string description) {
            this.value = value;
            this.name = name;
            this.description = description;
        }

        // Compare by name since this is used to generate value classes and duplicate names are not allowed.
        protected bool Equals(DataValuePair other) {
            return name == other.name;
        }

        public override bool Equals(object obj) {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((DataValuePair) obj);
        }

        public override int GetHashCode() {
            return (name != null ? name.GetHashCode() : 0);
        }

        public static bool operator ==(DataValuePair left, DataValuePair right) {
            return Equals(left, right);
        }

        public static bool operator !=(DataValuePair left, DataValuePair right) {
            return !Equals(left, right);
        }
    }
}