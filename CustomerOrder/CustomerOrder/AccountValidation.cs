using System.Collections.Generic;

namespace CustomerOrder
{
    public static class AccountValidation
    {
        public static int UsernameMinimumLength { get; } = 6;
        public static int PasswordMinimumLength { get; } = 6;

        public static List<string> Errors { get; set; } = new List<string>();

        public static bool isThereAnyErrors => Errors.Count > 0;
    }
}
