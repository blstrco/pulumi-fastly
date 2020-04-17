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
    public sealed class Servicev1Sumologic
    {
        /// <summary>
        /// Apache-style string or VCL variables to use for log formatting. Default `%h %l %u %t \"%r\" %&gt;s %b`.
        /// </summary>
        public readonly string? Format;
        /// <summary>
        /// The version of the custom logging format used for the configured endpoint. Can be either `1` or `2`. The logging call gets placed by default in `vcl_log` if `format_version` is set to `2` and in `vcl_deliver` if `format_version` is set to `1`. Default `2`.
        /// </summary>
        public readonly int? FormatVersion;
        /// <summary>
        /// How the message should be formatted. Can be either `classic`, `loggly`, `logplex` or `blank`.  Default `classic`.
        /// </summary>
        public readonly string? MessageType;
        /// <summary>
        /// A unique name to identify this dictionary.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Where in the generated VCL the logging call should be placed, overriding any `format_version` default. Can be either `none` or `waf_debug`.
        /// </summary>
        public readonly string? Placement;
        /// <summary>
        /// The name of the `condition` to apply. If empty, always execute.
        /// </summary>
        public readonly string? ResponseCondition;
        /// <summary>
        /// The Splunk URL to stream logs to.
        /// </summary>
        public readonly string Url;

        [OutputConstructor]
        private Servicev1Sumologic(
            string? format,

            int? formatVersion,

            string? messageType,

            string name,

            string? placement,

            string? responseCondition,

            string url)
        {
            Format = format;
            FormatVersion = formatVersion;
            MessageType = messageType;
            Name = name;
            Placement = placement;
            ResponseCondition = responseCondition;
            Url = url;
        }
    }
}
