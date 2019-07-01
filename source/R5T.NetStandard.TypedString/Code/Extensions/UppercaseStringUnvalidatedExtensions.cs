using System;


namespace R5T.NetStandard
{
    public static class UppercaseStringUnvalidatedExtensions
    {
        /// <summary>
        /// Determines if a string really is an uppercase string.
        /// </summary>
        public static bool IsValid(this UppercaseStringUnvalidated uppercaseStringUnvalidated)
        {
            // Is the result of ToLowerInvariant() the same as the input?
            var uppered = uppercaseStringUnvalidated.Value.ToUpperInvariant();

            var output = uppercaseStringUnvalidated.Value == uppered;
            return output;
        }

        public static bool TryValidate(this UppercaseStringUnvalidated uppercaseStringUnvalidated, out UppercaseString uppercaseString)
        {
            var isValid = uppercaseStringUnvalidated.IsValid();
            if (isValid)
            {
                uppercaseString = new UppercaseString(uppercaseStringUnvalidated.Value);
            }
            else
            {
                uppercaseString = UppercaseString.Invalid;
            }

            return isValid;
        }

        /// <summary>
        /// Throw an <see cref="Exception"/> if the upper-case string value is invalid.
        /// </summary>
        public static UppercaseString Validate(this UppercaseStringUnvalidated uppercaseStringUnvalidated)
        {
            var isValid = uppercaseStringUnvalidated.TryValidate(out var uppercaseString);
            if (!isValid)
            {
                throw new Exception($"Value '{uppercaseStringUnvalidated.Value}' was not an upper-case string.");
            }

            return uppercaseString;
        }
    }
}
