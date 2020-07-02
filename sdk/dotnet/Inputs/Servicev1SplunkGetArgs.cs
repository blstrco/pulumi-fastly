// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Fastly.Inputs
{

    public sealed class Servicev1SplunkGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Apache style log formatting.
        /// </summary>
        [Input("format")]
        public Input<string>? Format { get; set; }

        /// <summary>
        /// The version of the custom logging format used for the configured endpoint. Can be either `1` or `2`. (default: `2`).
        /// </summary>
        [Input("formatVersion")]
        public Input<int>? FormatVersion { get; set; }

        /// <summary>
        /// A unique name to identify this dictionary.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Where in the generated VCL the logging call should be placed. Can be `none` or `waf_debug`.
        /// </summary>
        [Input("placement")]
        public Input<string>? Placement { get; set; }

        /// <summary>
        /// The name of an existing condition in the configured endpoint, or leave blank to always execute.
        /// </summary>
        [Input("responseCondition")]
        public Input<string>? ResponseCondition { get; set; }

        /// <summary>
        /// A secure certificate to authenticate the server with. Must be in PEM format.
        /// </summary>
        [Input("tlsCaCert")]
        public Input<string>? TlsCaCert { get; set; }

        /// <summary>
        /// The hostname used to verify the server's certificate. It can either be the Common Name or a Subject Alternative Name (SAN).
        /// </summary>
        [Input("tlsHostname")]
        public Input<string>? TlsHostname { get; set; }

        /// <summary>
        /// The data authentication token associated with this endpoint.
        /// </summary>
        [Input("token", required: true)]
        public Input<string> Token { get; set; } = null!;

        /// <summary>
        /// Your OpenStack auth url.
        /// </summary>
        [Input("url", required: true)]
        public Input<string> Url { get; set; } = null!;

        public Servicev1SplunkGetArgs()
        {
        }
    }
}
