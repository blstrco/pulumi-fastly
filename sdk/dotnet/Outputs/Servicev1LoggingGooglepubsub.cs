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
    public sealed class Servicev1LoggingGooglepubsub
    {
        /// <summary>
        /// Apache style log formatting.
        /// </summary>
        public readonly string? Format;
        /// <summary>
        /// The version of the custom logging format used for the configured endpoint. Can be either `1` or `2`. (default: `2`).
        /// </summary>
        public readonly int? FormatVersion;
        /// <summary>
        /// A unique name to identify this dictionary.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Where in the generated VCL the logging call should be placed. Can be `none` or `waf_debug`.
        /// </summary>
        public readonly string? Placement;
        /// <summary>
        /// The ID of your Google Cloud Platform project.
        /// </summary>
        public readonly string ProjectId;
        /// <summary>
        /// The name of an existing condition in the configured endpoint, or leave blank to always execute.
        /// </summary>
        public readonly string? ResponseCondition;
        /// <summary>
        /// Your DigitalOcean Spaces account secret key.
        /// </summary>
        public readonly string SecretKey;
        /// <summary>
        /// The Kafka topic to send logs to.
        /// </summary>
        public readonly string Topic;
        /// <summary>
        /// The username for your Cloud Files account.
        /// </summary>
        public readonly string User;

        [OutputConstructor]
        private Servicev1LoggingGooglepubsub(
            string? format,

            int? formatVersion,

            string name,

            string? placement,

            string projectId,

            string? responseCondition,

            string secretKey,

            string topic,

            string user)
        {
            Format = format;
            FormatVersion = formatVersion;
            Name = name;
            Placement = placement;
            ProjectId = projectId;
            ResponseCondition = responseCondition;
            SecretKey = secretKey;
            Topic = topic;
            User = user;
        }
    }
}