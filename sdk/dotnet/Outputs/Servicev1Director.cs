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
    public sealed class Servicev1Director
    {
        /// <summary>
        /// Names of defined backends to map the director to. Example: `[ "origin1", "origin2" ]`
        /// </summary>
        public readonly ImmutableArray<string> Backends;
        /// <summary>
        /// Load balancing weight for the backends. Default `100`.
        /// </summary>
        public readonly int? Capacity;
        /// <summary>
        /// An optional comment about the Director.
        /// </summary>
        public readonly string? Comment;
        /// <summary>
        /// A unique name to identify this dictionary.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Percentage of capacity that needs to be up for the director itself to be considered up. Default `75`.
        /// </summary>
        public readonly int? Quorum;
        /// <summary>
        /// How many backends to search if it fails. Default `5`.
        /// </summary>
        public readonly int? Retries;
        /// <summary>
        /// Selected POP to serve as a "shield" for backends. Valid values for `shield` are included in the [`GET /datacenters`](https://developer.fastly.com/reference/api/utils/datacenter/) API response.
        /// </summary>
        public readonly string? Shield;
        /// <summary>
        /// The location in generated VCL where the snippet should be placed (can be one of `init`, `recv`, `hit`, `miss`, `pass`, `fetch`, `error`, `deliver`, `log` or `none`).
        /// </summary>
        public readonly int? Type;

        [OutputConstructor]
        private Servicev1Director(
            ImmutableArray<string> backends,

            int? capacity,

            string? comment,

            string name,

            int? quorum,

            int? retries,

            string? shield,

            int? type)
        {
            Backends = backends;
            Capacity = capacity;
            Comment = comment;
            Name = name;
            Quorum = quorum;
            Retries = retries;
            Shield = shield;
            Type = type;
        }
    }
}
