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
    public sealed class Servicev1S3logging
    {
        /// <summary>
        /// The name of the bucket in which to store the logs.
        /// </summary>
        public readonly string BucketName;
        /// <summary>
        /// If you created the S3 bucket outside of `us-east-1`,
        /// then specify the corresponding bucket endpoint. Example: `s3-us-west-2.amazonaws.com`.
        /// </summary>
        public readonly string? Domain;
        /// <summary>
        /// Apache-style string or VCL variables to use for log formatting. Default `%h %l %u %t \"%r\" %&gt;s %b`.
        /// </summary>
        public readonly string? Format;
        /// <summary>
        /// The version of the custom logging format used for the configured endpoint. Can be either `1` or `2`. The logging call gets placed by default in `vcl_log` if `format_version` is set to `2` and in `vcl_deliver` if `format_version` is set to `1`. Default `2`.
        /// </summary>
        public readonly int? FormatVersion;
        /// <summary>
        /// Level of GZIP compression from `0`to `9`. `0` means no compression. `1` is the fastest and the least compressed version, `9` is the slowest and the most compressed version. Default `0`.
        /// </summary>
        public readonly int? GzipLevel;
        /// <summary>
        /// How the message should be formatted. Can be either `classic`, `loggly`, `logplex` or `blank`.  Default `classic`.
        /// </summary>
        public readonly string? MessageType;
        /// <summary>
        /// A unique name to identify this dictionary.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The path to upload logs to. Must end with a trailing slash. If this field is left empty, the files will be saved in the container's root path.
        /// </summary>
        public readonly string? Path;
        /// <summary>
        /// How frequently the logs should be transferred in seconds. Default `3600`.
        /// </summary>
        public readonly int? Period;
        /// <summary>
        /// Where in the generated VCL the logging call should be placed, overriding any `format_version` default. Can be either `none` or `waf_debug`.
        /// </summary>
        public readonly string? Placement;
        /// <summary>
        /// The S3 redundancy level. Should be formatted; one of: `standard`, `reduced_redundancy` or null. Default `null`.
        /// </summary>
        public readonly string? Redundancy;
        /// <summary>
        /// The name of the `condition` to apply. If empty, always execute.
        /// </summary>
        public readonly string? ResponseCondition;
        /// <summary>
        /// AWS Access Key of an account with the required
        /// permissions to post logs. It is **strongly** recommended you create a separate
        /// IAM user with permissions to only operate on this Bucket. This key will be
        /// not be encrypted. You can provide this key via an environment variable, `FASTLY_S3_ACCESS_KEY`.
        /// </summary>
        public readonly string? S3AccessKey;
        /// <summary>
        /// AWS Secret Key of an account with the required
        /// permissions to post logs. It is **strongly** recommended you create a separate
        /// IAM user with permissions to only operate on this Bucket. This secret will be
        /// not be encrypted. You can provide this secret via an environment variable, `FASTLY_S3_SECRET_KEY`.
        /// </summary>
        public readonly string? S3SecretKey;
        public readonly string? ServerSideEncryption;
        public readonly string? ServerSideEncryptionKmsKeyId;
        /// <summary>
        /// `strftime` specified timestamp formatting. Default `%Y-%m-%dT%H:%M:%S.000`.
        /// </summary>
        public readonly string? TimestampFormat;

        [OutputConstructor]
        private Servicev1S3logging(
            string bucketName,

            string? domain,

            string? format,

            int? formatVersion,

            int? gzipLevel,

            string? messageType,

            string name,

            string? path,

            int? period,

            string? placement,

            string? redundancy,

            string? responseCondition,

            string? s3AccessKey,

            string? s3SecretKey,

            string? serverSideEncryption,

            string? serverSideEncryptionKmsKeyId,

            string? timestampFormat)
        {
            BucketName = bucketName;
            Domain = domain;
            Format = format;
            FormatVersion = formatVersion;
            GzipLevel = gzipLevel;
            MessageType = messageType;
            Name = name;
            Path = path;
            Period = period;
            Placement = placement;
            Redundancy = redundancy;
            ResponseCondition = responseCondition;
            S3AccessKey = s3AccessKey;
            S3SecretKey = s3SecretKey;
            ServerSideEncryption = serverSideEncryption;
            ServerSideEncryptionKmsKeyId = serverSideEncryptionKmsKeyId;
            TimestampFormat = timestampFormat;
        }
    }
}
