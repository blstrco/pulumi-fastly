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
    public sealed class Servicev1LoggingLoggly
    {
        /// <summary>
        /// Apache style log formatting.
        /// </summary>
        public readonly string? Format;
        /// <summary>
        /// The version of the custom logging format used for the configured endpoint. Can be either `1` or `2`. (default: `2`).
        /// </summary>
        public readonly int? FormatVersion;
        /// <summary>
        /// A unique name to identify this dictionary.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Where in the generated VCL the logging call should be placed. Can be `none` or `waf_debug`.
        /// </summary>
        public readonly string? Placement;
        /// <summary>
        /// The name of an existing condition in the configured endpoint, or leave blank to always execute.
        /// </summary>
        public readonly string? ResponseCondition;
        /// <summary>
        /// The data authentication token associated with this endpoint.
        /// </summary>
        public readonly string Token;

        [OutputConstructor]
        private Servicev1LoggingLoggly(
            string? format,

            int? formatVersion,

            string name,

            string? placement,

            string? responseCondition,

            string token)
        {
            Format = format;
            FormatVersion = formatVersion;
            Name = name;
            Placement = placement;
            ResponseCondition = responseCondition;
            Token = token;
        }
    }
}
