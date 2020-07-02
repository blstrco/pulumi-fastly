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
        /// The name of your Cloud Files container.
        /// </summary>
        public readonly string BucketName;
        /// <summary>
        /// The domain of the DigitalOcean Spaces endpoint (default "nyc3.digitaloceanspaces.com").
        /// </summary>
        public readonly string? Domain;
        /// <summary>
        /// Apache style log formatting.
        /// </summary>
        public readonly string? Format;
        /// <summary>
        /// The version of the custom logging format used for the configured endpoint. Can be either `1` or `2`. (default: `2`).
        /// </summary>
        public readonly int? FormatVersion;
        /// <summary>
        /// What level of GZIP encoding to have when dumping logs (default 0, no compression).
        /// </summary>
        public readonly int? GzipLevel;
        /// <summary>
        /// How the message should be formatted. One of: classic (default), loggly, logplex or blank.
        /// </summary>
        public readonly string? MessageType;
        /// <summary>
        /// A unique name to identify this dictionary.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The path to upload logs to.
        /// </summary>
        public readonly string? Path;
        /// <summary>
        /// How frequently log files are finalized so they can be available for reading (in seconds, default 3600).
        /// </summary>
        public readonly int? Period;
        /// <summary>
        /// Where in the generated VCL the logging call should be placed. Can be `none` or `waf_debug`.
        /// </summary>
        public readonly string? Placement;
        /// <summary>
        /// The PGP public key that Fastly will use to encrypt your log files before writing them to disk.
        /// </summary>
        public readonly string? PublicKey;
        /// <summary>
        /// The S3 redundancy level. Should be formatted; one of: `standard`, `reduced_redundancy` or null. Default `null`.
        /// </summary>
        public readonly string? Redundancy;
        /// <summary>
        /// The name of an existing condition in the configured endpoint, or leave blank to always execute.
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
        /// The strftime specified timestamp formatting (default `%Y-%m-%dT%H:%M:%S.000`).
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

            string? publicKey,

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
            PublicKey = publicKey;
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
