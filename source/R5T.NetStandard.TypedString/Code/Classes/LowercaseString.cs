using System;


namespace R5T.NetStandard
{
    public class LowercaseString : TypedString
    {
        public const LowercaseString Invalid = null;


        public LowercaseString(string value)
            : base(value)
        {
        }
    }
}
