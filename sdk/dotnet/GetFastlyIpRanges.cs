// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Fastly
{
    public static class GetFastlyIpRanges
    {
        /// <summary>
        /// Use this data source to get the [IP ranges][1] of Fastly edge nodes.
        /// 
        /// {{% examples %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetFastlyIpRangesResult> InvokeAsync(InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetFastlyIpRangesResult>("fastly:index/getFastlyIpRanges:getFastlyIpRanges", InvokeArgs.Empty, options.WithVersion());
    }


    [OutputType]
    public sealed class GetFastlyIpRangesResult
    {
        /// <summary>
        /// The lexically ordered list of CIDR blocks.
        /// </summary>
        public readonly ImmutableArray<string> CidrBlocks;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetFastlyIpRangesResult(
            ImmutableArray<string> cidrBlocks,

            string id)
        {
            CidrBlocks = cidrBlocks;
            Id = id;
        }
    }
}
