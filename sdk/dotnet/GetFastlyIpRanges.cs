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
        /// Use this data source to get the [IP ranges](https://docs.fastly.com/guides/securing-communications/accessing-fastlys-ip-ranges) of Fastly edge nodes.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Aws = Pulumi.Aws;
        /// using Fastly = Pulumi.Fastly;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var fastly = Output.Create(Fastly.GetFastlyIpRanges.InvokeAsync());
        ///         var fromFastly = new Aws.Ec2.SecurityGroup("fromFastly", new Aws.Ec2.SecurityGroupArgs
        ///         {
        ///             Ingress = 
        ///             {
        ///                 new Aws.Ec2.Inputs.SecurityGroupIngressArgs
        ///                 {
        ///                     CidrBlocks = fastly.Apply(fastly =&gt; fastly.CidrBlocks),
        ///                     FromPort = "443",
        ///                     Ipv6CidrBlocks = fastly.Apply(fastly =&gt; fastly.Ipv6CidrBlocks),
        ///                     Protocol = "tcp",
        ///                     ToPort = "443",
        ///                 },
        ///             },
        ///         });
        ///     }
        /// 
        /// }
        /// ```
        /// 
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetFastlyIpRangesResult> InvokeAsync(InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetFastlyIpRangesResult>("fastly:index/getFastlyIpRanges:getFastlyIpRanges", InvokeArgs.Empty, options.WithVersion());
    }


    [OutputType]
    public sealed class GetFastlyIpRangesResult
    {
        /// <summary>
        /// The lexically ordered list of ipv4 CIDR blocks.
        /// </summary>
        public readonly ImmutableArray<string> CidrBlocks;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The lexically ordered list of ipv6 CIDR blocks.
        /// </summary>
        public readonly ImmutableArray<string> Ipv6CidrBlocks;

        [OutputConstructor]
        private GetFastlyIpRangesResult(
            ImmutableArray<string> cidrBlocks,

            string id,

            ImmutableArray<string> ipv6CidrBlocks)
        {
            CidrBlocks = cidrBlocks;
            Id = id;
            Ipv6CidrBlocks = ipv6CidrBlocks;
        }
    }
}
