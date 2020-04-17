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
    public sealed class Servicev1Blobstoragelogging
    {
        /// <summary>
        /// The unique Azure Blob Storage namespace in which your data objects are stored.
        /// </summary>
        public readonly string AccountName;
        /// <summary>
        /// The name of the Azure Blob Storage container in which to store logs.
        /// </summary>
        public readonly string Container;
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
        /// A PGP public key that Fastly will use to encrypt your log files before writing them to disk.
        /// </summary>
        public readonly string? PublicKey;
        /// <summary>
        /// The name of the `condition` to apply. If empty, always execute.
        /// </summary>
        public readonly string? ResponseCondition;
        /// <summary>
        /// The Azure shared access signature providing write access to the blob service objects. Be sure to update your token before it expires or the logging functionality will not work.
        /// </summary>
        public readonly string SasToken;
        /// <summary>
        /// `strftime` specified timestamp formatting. Default `%Y-%m-%dT%H:%M:%S.000`.
        /// </summary>
        public readonly string? TimestampFormat;

        [OutputConstructor]
        private Servicev1Blobstoragelogging(
            string accountName,

            string container,

            string? format,

            int? formatVersion,

            int? gzipLevel,

            string? messageType,

            string name,

            string? path,

            int? period,

            string? placement,

            string? publicKey,

            string? responseCondition,

            string sasToken,

            string? timestampFormat)
        {
            AccountName = accountName;
            Container = container;
            Format = format;
            FormatVersion = formatVersion;
            GzipLevel = gzipLevel;
            MessageType = messageType;
            Name = name;
            Path = path;
            Period = period;
            Placement = placement;
            PublicKey = publicKey;
            ResponseCondition = responseCondition;
            SasToken = sasToken;
            TimestampFormat = timestampFormat;
        }
    }
}
