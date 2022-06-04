using sample.Debugging;

namespace sample
{
    public class sampleConsts
    {
        public const string LocalizationSourceName = "sample";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "68d8d47bde6b4f1e932d50e8b538d35c";
    }
}
