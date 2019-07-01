using System;


namespace R5T.NetStandard
{
    public static class LowercaseStringUnvalidatedExtensions
    {
        /// <summary>
        /// Determines if a string really is an uppercase string.
        /// </summary>
        public static bool IsValid(this LowercaseStringUnvalidated lowercaseStringUnvalidated)
        {
            // Is the result of ToLowerInvariant() the same as the input?
            var lowered = lowercaseStringUnvalidated.Value.ToLowerInvariant();

            var output = lowercaseStringUnvalidated.Value == lowered;
            return output;
        }

        public static bool TryValidate(this LowercaseStringUnvalidated lowercaseStringUnvalidated, out LowercaseString lowercaseString)
        {
            var isValid = lowercaseStringUnvalidated.IsValid();
            if (isValid)
            {
                lowercaseString = new LowercaseString(lowercaseStringUnvalidated.Value);
            }
            else
            {
                lowercaseString = LowercaseString.Invalid;
            }

            return isValid;
        }

        /// <summary>
        /// Throw an <see cref="Exception"/> if the upper-case string value is invalid.
        /// </summary>
        public static LowercaseString Validate(this LowercaseStringUnvalidated lowercaseStringUnvalidated)
        {
            var isValid = lowercaseStringUnvalidated.TryValidate(out var lowercaseString);
            if (!isValid)
            {
                throw new Exception($"Value '{lowercaseStringUnvalidated.Value}' was not a lower-case string.");
            }

            return lowercaseString;
        }
    }
}
