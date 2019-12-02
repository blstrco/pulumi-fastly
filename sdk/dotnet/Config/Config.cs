// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;

namespace Pulumi.Fastly
{
    public static class Config
    {
        private static readonly Pulumi.Config __config = new Pulumi.Config("fastly");

        /// <summary>
        /// Fastly API Key from https://app.fastly.com/#account
        /// </summary>
        public static string? ApiKey { get; set; } = __config.Get("apiKey") ?? Utilities.GetEnv("FASTLY_API_KEY");

        /// <summary>
        /// Fastly API URL
        /// </summary>
        public static string? BaseUrl { get; set; } = __config.Get("baseUrl") ?? Utilities.GetEnv("FASTLY_API_URL") ?? "https://api.fastly.com";

    }
    namespace ConfigTypes
    {
    }
}