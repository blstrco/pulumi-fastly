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
    public sealed class ServiceComputeLoggingCloudfile
    {
        /// <summary>
        /// Your Cloud File account access key.
        /// </summary>
        public readonly string AccessKey;
        /// <summary>
        /// The name of your Cloud Files container.
        /// </summary>
        public readonly string BucketName;
        /// <summary>
        /// What level of GZIP encoding to have when dumping logs (default 0, no compression).
        /// </summary>
        public readonly int? GzipLevel;
        /// <summary>
        /// How the message should be formatted. One of: classic (default), loggly, logplex or blank.
        /// </summary>
        public readonly string? MessageType;
        /// <summary>
        /// The unique name of the Rackspace Cloud Files logging endpoint.
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
        /// The PGP public key that Fastly will use to encrypt your log files before writing them to disk.
        /// </summary>
        public readonly string? PublicKey;
        /// <summary>
        /// The region to stream logs to. One of: DFW (Dallas), ORD (Chicago), IAD (Northern Virginia), LON (London), SYD (Sydney), HKG (Hong Kong).
        /// </summary>
        public readonly string? Region;
        /// <summary>
        /// The strftime specified timestamp formatting (default `%Y-%m-%dT%H:%M:%S.000`).
        /// </summary>
        public readonly string? TimestampFormat;
        /// <summary>
        /// The username for your Cloud Files account.
        /// </summary>
        public readonly string User;

        [OutputConstructor]
        private ServiceComputeLoggingCloudfile(
            string accessKey,

            string bucketName,

            int? gzipLevel,

            string? messageType,

            string name,

            string? path,

            int? period,

            string? publicKey,

            string? region,

            string? timestampFormat,

            string user)
        {
            AccessKey = accessKey;
            BucketName = bucketName;
            GzipLevel = gzipLevel;
            MessageType = messageType;
            Name = name;
            Path = path;
            Period = period;
            PublicKey = publicKey;
            Region = region;
            TimestampFormat = timestampFormat;
            User = user;
        }
    }
}
