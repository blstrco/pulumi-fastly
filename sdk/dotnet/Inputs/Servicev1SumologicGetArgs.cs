// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Fastly.Inputs
{

    public sealed class Servicev1SumologicGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Apache-style string or VCL variables to use for log formatting. Default `%h %l %u %t \"%r\" %&gt;s %b`.
        /// </summary>
        [Input("format")]
        public Input<string>? Format { get; set; }

        /// <summary>
        /// The version of the custom logging format used for the configured endpoint. Can be either `1` or `2`. The logging call gets placed by default in `vcl_log` if `format_version` is set to `2` and in `vcl_deliver` if `format_version` is set to `1`. Default `2`.
        /// </summary>
        [Input("formatVersion")]
        public Input<int>? FormatVersion { get; set; }

        /// <summary>
        /// How the message should be formatted. Can be either `classic`, `loggly`, `logplex` or `blank`.  Default `classic`.
        /// </summary>
        [Input("messageType")]
        public Input<string>? MessageType { get; set; }

        /// <summary>
        /// A unique name to identify this dictionary.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Where in the generated VCL the logging call should be placed, overriding any `format_version` default. Can be either `none` or `waf_debug`.
        /// </summary>
        [Input("placement")]
        public Input<string>? Placement { get; set; }

        /// <summary>
        /// The name of the `condition` to apply. If empty, always execute.
        /// </summary>
        [Input("responseCondition")]
        public Input<string>? ResponseCondition { get; set; }

        /// <summary>
        /// The Splunk URL to stream logs to.
        /// </summary>
        [Input("url", required: true)]
        public Input<string> Url { get; set; } = null!;

        public Servicev1SumologicGetArgs()
        {
        }
    }
}
