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
    public sealed class Servicev1Gcslogging
    {
        /// <summary>
        /// The name of the bucket in which to store the logs.
        /// </summary>
        public readonly string BucketName;
        /// <summary>
        /// The email for the service account with write access to your BigQuery dataset. If not provided, this will be pulled from a `FASTLY_BQ_EMAIL` environment variable.
        /// </summary>
        public readonly string? Email;
        /// <summary>
        /// Apache-style string or VCL variables to use for log formatting.
        /// </summary>
        public readonly string? Format;
        /// <summary>
        /// Level of GZIP compression from `0`to `9`. `0` means no compression. `1` is the fastest and the least compressed version, `9` is the slowest and the most compressed version. Default `0`.
        /// </summary>
        public readonly int? GzipLevel;
        /// <summary>
        /// How the message should be formatted; one of: `classic`, `loggly`, `logplex` or `blank`.  Default `blank`.
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
        /// Where in the generated VCL the logging call should be placed.
        /// </summary>
        public readonly string? Placement;
        /// <summary>
        /// The name of the `condition` to apply. If empty, always execute.
        /// </summary>
        public readonly string? ResponseCondition;
        /// <summary>
        /// The secret key associated with the sservice account that has write access to your BigQuery table. If not provided, this will be pulled from the `FASTLY_BQ_SECRET_KEY` environment variable. Typical format for this is a private key in a string with newlines.
        /// </summary>
        public readonly string? SecretKey;
        /// <summary>
        /// `strftime` specified timestamp formatting. Default `%Y-%m-%dT%H:%M:%S.000`.
        /// </summary>
        public readonly string? TimestampFormat;

        [OutputConstructor]
        private Servicev1Gcslogging(
            string bucketName,

            string? email,

            string? format,

            int? gzipLevel,

            string? messageType,

            string name,

            string? path,

            int? period,

            string? placement,

            string? responseCondition,

            string? secretKey,

            string? timestampFormat)
        {
            BucketName = bucketName;
            Email = email;
            Format = format;
            GzipLevel = gzipLevel;
            MessageType = messageType;
            Name = name;
            Path = path;
            Period = period;
            Placement = placement;
            ResponseCondition = responseCondition;
            SecretKey = secretKey;
            TimestampFormat = timestampFormat;
        }
    }
}
