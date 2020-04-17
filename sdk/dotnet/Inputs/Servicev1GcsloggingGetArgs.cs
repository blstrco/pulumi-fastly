// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Fastly.Inputs
{

    public sealed class Servicev1GcsloggingGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the bucket in which to store the logs.
        /// </summary>
        [Input("bucketName", required: true)]
        public Input<string> BucketName { get; set; } = null!;

        /// <summary>
        /// The email for the service account with write access to your BigQuery dataset. If not provided, this will be pulled from a `FASTLY_BQ_EMAIL` environment variable.
        /// </summary>
        [Input("email")]
        public Input<string>? Email { get; set; }

        /// <summary>
        /// Apache-style string or VCL variables to use for log formatting. Default `%h %l %u %t \"%r\" %&gt;s %b`.
        /// </summary>
        [Input("format")]
        public Input<string>? Format { get; set; }

        /// <summary>
        /// Level of GZIP compression from `0`to `9`. `0` means no compression. `1` is the fastest and the least compressed version, `9` is the slowest and the most compressed version. Default `0`.
        /// </summary>
        [Input("gzipLevel")]
        public Input<int>? GzipLevel { get; set; }

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
        /// The path to upload logs to. Must end with a trailing slash. If this field is left empty, the files will be saved in the container's root path.
        /// </summary>
        [Input("path")]
        public Input<string>? Path { get; set; }

        /// <summary>
        /// How frequently the logs should be transferred in seconds. Default `3600`.
        /// </summary>
        [Input("period")]
        public Input<int>? Period { get; set; }

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
        /// The secret key associated with the sservice account that has write access to your BigQuery table. If not provided, this will be pulled from the `FASTLY_BQ_SECRET_KEY` environment variable. Typical format for this is a private key in a string with newlines.
        /// </summary>
        [Input("secretKey")]
        public Input<string>? SecretKey { get; set; }

        /// <summary>
        /// `strftime` specified timestamp formatting. Default `%Y-%m-%dT%H:%M:%S.000`.
        /// </summary>
        [Input("timestampFormat")]
        public Input<string>? TimestampFormat { get; set; }

        public Servicev1GcsloggingGetArgs()
        {
        }
    }
}
