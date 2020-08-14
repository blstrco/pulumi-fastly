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
    public sealed class ServiceComputeSumologic
    {
        /// <summary>
        /// How the message should be formatted. One of: classic (default), loggly, logplex or blank.
        /// </summary>
        public readonly string? MessageType;
        /// <summary>
        /// The unique name of the Rackspace Cloud Files logging endpoint.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Your OpenStack auth url.
        /// </summary>
        public readonly string Url;

        [OutputConstructor]
        private ServiceComputeSumologic(
            string? messageType,

            string name,

            string url)
        {
            MessageType = messageType;
            Name = name;
            Url = url;
        }
    }
}