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
    public sealed class Servicev1Papertrail
    {
        /// <summary>
        /// A hostname or IPv4 address of the Syslog endpoint.
        /// </summary>
        public readonly string Address;
        /// <summary>
        /// Apache-style string or VCL variables to use for log formatting.
        /// </summary>
        public readonly string? Format;
        /// <summary>
        /// A unique name to identify this dictionary.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Where in the generated VCL the logging call should be placed.
        /// </summary>
        public readonly string? Placement;
        /// <summary>
        /// The port number configured in Logentries to send logs to. Defaults to `20000`.
        /// </summary>
        public readonly int Port;
        /// <summary>
        /// The name of the `condition` to apply. If empty, always execute.
        /// </summary>
        public readonly string? ResponseCondition;

        [OutputConstructor]
        private Servicev1Papertrail(
            string address,

            string? format,

            string name,

            string? placement,

            int port,

            string? responseCondition)
        {
            Address = address;
            Format = format;
            Name = name;
            Placement = placement;
            Port = port;
            ResponseCondition = responseCondition;
        }
    }
}
