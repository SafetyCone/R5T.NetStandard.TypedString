using System;


namespace R5T.NetStandard
{
    public static class UpperCaseStringExtensions
    {
        /// <summary>
        /// Determines if a string really is an uppercase string.
        /// </summary>
        public static bool IsValid(this UppercaseString uppercaseString)
        {
            // Is the result of ToUpperInvariant() the same as the input?
            var uppered = uppercaseString.Value.ToUpperInvariant();

            var output = uppercaseString.Value == uppered;
            return output;
        }

        /// <summary>
        /// Throw an <see cref="Exception"/> if the upper-case string value is invalid.
        /// </summary>
        public static void Validate(this UppercaseString uppercaseString)
        {
            var isValid = uppercaseString.IsValid();
            if(!isValid)
            {
                throw new Exception($"Value '{uppercaseString.Value}' was not an upper-case string.");
            }
        }
    }
}
