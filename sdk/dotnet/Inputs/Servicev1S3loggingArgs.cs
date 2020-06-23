// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Fastly.Inputs
{

    public sealed class Servicev1S3loggingArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the bucket in which to store the logs.
        /// </summary>
        [Input("bucketName", required: true)]
        public Input<string> BucketName { get; set; } = null!;

        /// <summary>
        /// If you created the S3 bucket outside of `us-east-1`,
        /// then specify the corresponding bucket endpoint. Example: `s3-us-west-2.amazonaws.com`.
        /// </summary>
        [Input("domain")]
        public Input<string>? Domain { get; set; }

        /// <summary>
        /// Apache-style string or VCL variables to use for log formatting.
        /// </summary>
        [Input("format")]
        public Input<string>? Format { get; set; }

        /// <summary>
        /// The version of the custom logging format used for the configured endpoint. Can be either `1` or `2`. The logging call gets placed by default in `vcl_log` if `format_version` is set to `2` and in `vcl_deliver` if `format_version` is set to `1`. Default `2`.
        /// </summary>
        [Input("formatVersion")]
        public Input<int>? FormatVersion { get; set; }

        /// <summary>
        /// What level of GZIP encoding to have when dumping logs (default 0, no compression).
        /// </summary>
        [Input("gzipLevel")]
        public Input<int>? GzipLevel { get; set; }

        /// <summary>
        /// How the message should be formatted. One of: classic (default), loggly, logplex or blank.
        /// </summary>
        [Input("messageType")]
        public Input<string>? MessageType { get; set; }

        /// <summary>
        /// A unique name to identify this dictionary.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The path to upload log files to. If the path ends in / then it is treated as a directory.
        /// </summary>
        [Input("path")]
        public Input<string>? Path { get; set; }

        /// <summary>
        /// How frequently log files are finalized so they can be available for reading (in seconds, default `3600`).
        /// </summary>
        [Input("period")]
        public Input<int>? Period { get; set; }

        /// <summary>
        /// The name of an existing condition in the configured endpoint, or leave blank to always execute.
        /// </summary>
        [Input("placement")]
        public Input<string>? Placement { get; set; }

        /// <summary>
        /// A PGP public key that Fastly will use to encrypt your log files before writing them to disk.
        /// </summary>
        [Input("publicKey")]
        public Input<string>? PublicKey { get; set; }

        /// <summary>
        /// The S3 redundancy level. Should be formatted; one of: `standard`, `reduced_redundancy` or null. Default `null`.
        /// </summary>
        [Input("redundancy")]
        public Input<string>? Redundancy { get; set; }

        /// <summary>
        /// The name of the `condition` to apply. If empty, always execute.
        /// </summary>
        [Input("responseCondition")]
        public Input<string>? ResponseCondition { get; set; }

        /// <summary>
        /// AWS Access Key of an account with the required
        /// permissions to post logs. It is **strongly** recommended you create a separate
        /// IAM user with permissions to only operate on this Bucket. This key will be
        /// not be encrypted. You can provide this key via an environment variable, `FASTLY_S3_ACCESS_KEY`.
        /// </summary>
        [Input("s3AccessKey")]
        public Input<string>? S3AccessKey { get; set; }

        /// <summary>
        /// AWS Secret Key of an account with the required
        /// permissions to post logs. It is **strongly** recommended you create a separate
        /// IAM user with permissions to only operate on this Bucket. This secret will be
        /// not be encrypted. You can provide this secret via an environment variable, `FASTLY_S3_SECRET_KEY`.
        /// </summary>
        [Input("s3SecretKey")]
        public Input<string>? S3SecretKey { get; set; }

        [Input("serverSideEncryption")]
        public Input<string>? ServerSideEncryption { get; set; }

        [Input("serverSideEncryptionKmsKeyId")]
        public Input<string>? ServerSideEncryptionKmsKeyId { get; set; }

        /// <summary>
        /// The strftime specified timestamp formatting (default `%Y-%m-%dT%H:%M:%S.000`).
        /// </summary>
        [Input("timestampFormat")]
        public Input<string>? TimestampFormat { get; set; }

        public Servicev1S3loggingArgs()
        {
        }
    }
}
