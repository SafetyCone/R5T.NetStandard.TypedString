using System;


namespace R5T.NetStandard
{
    /// <summary>
    /// Indicates an upper-case string.
    /// </summary>
    public class UppercaseString : TypedString
    {
        public const UppercaseString Invalid = null;


        public UppercaseString(string value)
            : base(value)
        {
        }
    }
}
