using System;


namespace R5T.NetStandard
{
    /// <summary>
    /// A mutable typed-string.
    /// </summary>
    public abstract class MutableTypedString
    {
        public string Value { get; }


        public MutableTypedString(string value)
        {
            this.Value = value;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !obj.GetType().Equals(this.GetType()))
            {
                return false;
            }

            var objAsTypedString = obj as MutableTypedString;

            var isEqual = this.Equals_Internal(objAsTypedString);
            return isEqual;
        }

        protected virtual bool Equals_Internal(MutableTypedString other)
        {
            var isEqual = this.Value.Equals(other.Value);
            return isEqual;
        }

        public override int GetHashCode()
        {
            var hashCode = this.Value.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return this.Value;
        }

        public bool Equals(MutableTypedString other)
        {
            if (other == null || !other.GetType().Equals(this.GetType()))
            {
                return false;
            }

            var isEqual = this.Equals_Internal(other);
            return isEqual;
        }

        public int CompareTo(MutableTypedString other)
        {
            var output = this.Value.CompareTo(other.Value);
            return output;
        }
    }
}
