using System;


namespace R5T.NetStandard
{
    public static class LowercaseStringExtensions
    {
        /// <summary>
        /// Determines if a string really is an uppercase string.
        /// </summary>
        public static bool IsValid(this LowercaseString lowercaseString)
        {
            // Is the result of ToLowerInvariant() the same as the input?
            var lowered = lowercaseString.Value.ToLowerInvariant();

            var output = lowercaseString.Value == lowered;
            return output;
        }

        /// <summary>
        /// Throw an <see cref="Exception"/> if the upper-case string value is invalid.
        /// </summary>
        public static void Validate(this LowercaseString lowercaseString)
        {
            var isValid = lowercaseString.IsValid();
            if (!isValid)
            {
                throw new Exception($"Value '{lowercaseString.Value}' was not a lower-case string.");
            }
        }
    }
}
