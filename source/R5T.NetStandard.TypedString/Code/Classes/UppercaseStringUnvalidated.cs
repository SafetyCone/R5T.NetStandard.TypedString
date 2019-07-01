using System;


namespace R5T.NetStandard
{
    /// <summary>
    /// Represents a possibly uppercase string that has not been validated yet.
    /// </summary>
    public class UppercaseStringUnvalidated : TypedString
    {
        public UppercaseStringUnvalidated(string value)
            : base(value)
        {
        }
    }
}
