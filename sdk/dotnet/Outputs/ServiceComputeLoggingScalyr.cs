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
    public sealed class ServiceComputeLoggingScalyr
    {
        /// <summary>
        /// The unique name of the Rackspace Cloud Files logging endpoint.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The region to stream logs to. One of: DFW (Dallas), ORD (Chicago), IAD (Northern Virginia), LON (London), SYD (Sydney), HKG (Hong Kong).
        /// </summary>
        public readonly string? Region;
        /// <summary>
        /// The data authentication token associated with this endpoint.
        /// </summary>
        public readonly string Token;

        [OutputConstructor]
        private ServiceComputeLoggingScalyr(
            string name,

            string? region,

            string token)
        {
            Name = name;
            Region = region;
            Token = token;
        }
    }
}
