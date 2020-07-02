// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Fastly.Inputs
{

    public sealed class Servicev1HttpsloggingGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The MIME type of the content.
        /// </summary>
        [Input("contentType")]
        public Input<string>? ContentType { get; set; }

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
        /// Custom header sent with the request.
        /// </summary>
        [Input("headerName")]
        public Input<string>? HeaderName { get; set; }

        /// <summary>
        /// Value of the custom header sent with the request.
        /// </summary>
        [Input("headerValue")]
        public Input<string>? HeaderValue { get; set; }

        /// <summary>
        /// Formats log entries as JSON. Can be either disabled (`0`), array of json (`1`), or newline delimited json (`2`).
        /// </summary>
        [Input("jsonFormat")]
        public Input<string>? JsonFormat { get; set; }

        /// <summary>
        /// How the message should be formatted. One of: classic (default), loggly, logplex or blank.
        /// </summary>
        [Input("messageType")]
        public Input<string>? MessageType { get; set; }

        /// <summary>
        /// HTTP method used for request. Can be either `POST` or `PUT`. Default `POST`.
        /// </summary>
        [Input("method")]
        public Input<string>? Method { get; set; }

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
        /// The maximum number of bytes sent in one request. Defaults to `0` for unbounded.
        /// </summary>
        [Input("requestMaxBytes")]
        public Input<int>? RequestMaxBytes { get; set; }

        /// <summary>
        /// The maximum number of logs sent in one request. Defaults to `0` for unbounded.
        /// </summary>
        [Input("requestMaxEntries")]
        public Input<int>? RequestMaxEntries { get; set; }

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
        /// The client certificate used to make authenticated requests. Must be in PEM format.
        /// </summary>
        [Input("tlsClientCert")]
        public Input<string>? TlsClientCert { get; set; }

        /// <summary>
        /// The client private key used to make authenticated requests. Must be in PEM format.
        /// </summary>
        [Input("tlsClientKey")]
        public Input<string>? TlsClientKey { get; set; }

        /// <summary>
        /// The hostname used to verify the server's certificate. It can either be the Common Name or a Subject Alternative Name (SAN).
        /// </summary>
        [Input("tlsHostname")]
        public Input<string>? TlsHostname { get; set; }

        /// <summary>
        /// Your OpenStack auth url.
        /// </summary>
        [Input("url", required: true)]
        public Input<string> Url { get; set; } = null!;

        public Servicev1HttpsloggingGetArgs()
        {
        }
    }
}
