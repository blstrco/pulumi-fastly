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
    public sealed class Servicev1Splunk
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
        /// Where in the generated VCL the logging call should be placed.
        /// </summary>
        public readonly string? Placement;
        /// <summary>
        /// The name of the `condition` to apply. If empty, always execute.
        /// </summary>
        public readonly string? ResponseCondition;
        /// <summary>
        /// A secure certificate to authenticate the server with. Must be in PEM format.
        /// </summary>
        public readonly string? TlsCaCert;
        /// <summary>
        /// Used during the TLS handshake to validate the certificate.
        /// </summary>
        public readonly string? TlsHostname;
        /// <summary>
        /// The Splunk token to be used for authentication.
        /// </summary>
        public readonly string Token;
        /// <summary>
        /// URL that log data will be sent to. Must use the https protocol.
        /// </summary>
        public readonly string Url;

        [OutputConstructor]
        private Servicev1Splunk(
            string? format,

            int? formatVersion,

            string name,

            string? placement,

            string? responseCondition,

            string? tlsCaCert,

            string? tlsHostname,

            string token,

            string url)
        {
            Format = format;
            FormatVersion = formatVersion;
            Name = name;
            Placement = placement;
            ResponseCondition = responseCondition;
            TlsCaCert = tlsCaCert;
            TlsHostname = tlsHostname;
            Token = token;
            Url = url;
        }
    }
}
