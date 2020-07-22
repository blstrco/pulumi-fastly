// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Fastly.Inputs
{

    public sealed class ServiceComputeLoggingLogglyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The unique name of the Rackspace Cloud Files logging endpoint.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The data authentication token associated with this endpoint.
        /// </summary>
        [Input("token", required: true)]
        public Input<string> Token { get; set; } = null!;

        public ServiceComputeLoggingLogglyArgs()
        {
        }
    }
}
