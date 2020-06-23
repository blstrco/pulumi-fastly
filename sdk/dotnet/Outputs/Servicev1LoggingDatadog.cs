// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Fastly.Outputs
{

    [OutputType]
    public sealed class Servicev1LoggingDatadog
    {
        /// <summary>
        /// Apache-style string or VCL variables to use for log formatting.
        /// </summary>
        public readonly string? Format;
        /// <summary>
        /// The version of the custom logging format used for the configured endpoint. Can be either `1` or `2`. The logging call gets placed by default in `vcl_log` if `format_version` is set to `2` and in `vcl_deliver` if `format_version` is set to `1`. Default `2`.
        /// </summary>
        public readonly int? FormatVersion;
        /// <summary>
        /// A unique name to identify this dictionary.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The name of an existing condition in the configured endpoint, or leave blank to always execute.
        /// </summary>
        public readonly string? Placement;
        /// <summary>
        /// The region that log data will be sent to. One of US or EU. Defaults to US if undefined.
        /// </summary>
        public readonly string? Region;
        /// <summary>
        /// The name of the `condition` to apply. If empty, always execute.
        /// </summary>
        public readonly string? ResponseCondition;
        /// <summary>
        /// The token to use for authentication (https://www.scalyr.com/keys).
        /// </summary>
        public readonly string Token;

        [OutputConstructor]
        private Servicev1LoggingDatadog(
            string? format,

            int? formatVersion,

            string name,

            string? placement,

            string? region,

            string? responseCondition,

            string token)
        {
            Format = format;
            FormatVersion = formatVersion;
            Name = name;
            Placement = placement;
            Region = region;
            ResponseCondition = responseCondition;
            Token = token;
        }
    }
}
