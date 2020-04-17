// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Fastly.Inputs
{

    public sealed class Servicev1HealthcheckArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// How often to run the Healthcheck in milliseconds. Default `5000`.
        /// </summary>
        [Input("checkInterval")]
        public Input<int>? CheckInterval { get; set; }

        /// <summary>
        /// The status code expected from the host. Default `200`.
        /// </summary>
        [Input("expectedResponse")]
        public Input<int>? ExpectedResponse { get; set; }

        /// <summary>
        /// The Host header to send for this Healthcheck.
        /// </summary>
        [Input("host", required: true)]
        public Input<string> Host { get; set; } = null!;

        /// <summary>
        /// Whether to use version 1.0 or 1.1 HTTP. Default `1.1`.
        /// </summary>
        [Input("httpVersion")]
        public Input<string>? HttpVersion { get; set; }

        /// <summary>
        /// When loading a config, the initial number of probes to be seen as OK. Default `2`.
        /// </summary>
        [Input("initial")]
        public Input<int>? Initial { get; set; }

        /// <summary>
        /// Which HTTP method to use. Default `HEAD`.
        /// </summary>
        [Input("method")]
        public Input<string>? Method { get; set; }

        /// <summary>
        /// A unique name to identify this dictionary.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The path to upload logs to. Must end with a trailing slash. If this field is left empty, the files will be saved in the container's root path.
        /// </summary>
        [Input("path", required: true)]
        public Input<string> Path { get; set; } = null!;

        /// <summary>
        /// How many Healthchecks must succeed to be considered healthy. Default `3`.
        /// </summary>
        [Input("threshold")]
        public Input<int>? Threshold { get; set; }

        /// <summary>
        /// Timeout in milliseconds. Default `500`.
        /// </summary>
        [Input("timeout")]
        public Input<int>? Timeout { get; set; }

        /// <summary>
        /// The number of most recent Healthcheck queries to keep for this Healthcheck. Default `5`.
        /// </summary>
        [Input("window")]
        public Input<int>? Window { get; set; }

        public Servicev1HealthcheckArgs()
        {
        }
    }
}
