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
    public sealed class ServiceComputeLoggingHoneycomb
    {
        /// <summary>
        /// The Honeycomb Dataset you want to log to.
        /// </summary>
        public readonly string Dataset;
        /// <summary>
        /// The unique name of the Rackspace Cloud Files logging endpoint.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The data authentication token associated with this endpoint.
        /// </summary>
        public readonly string Token;

        [OutputConstructor]
        private ServiceComputeLoggingHoneycomb(
            string dataset,

            string name,

            string token)
        {
            Dataset = dataset;
            Name = name;
            Token = token;
        }
    }
}
