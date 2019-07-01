using System;


namespace R5T.NetStandard
{
    /// <summary>
    /// Represents a possibly lowercase string that has not been validated yet.
    /// </summary>
    public class LowercaseStringUnvalidated : TypedString
    {
        public LowercaseStringUnvalidated(string value)
            : base(value)
        {
        }
    }
}
