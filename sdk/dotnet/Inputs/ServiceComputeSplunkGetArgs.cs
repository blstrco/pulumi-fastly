// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Fastly.Inputs
{

    public sealed class ServiceComputeSplunkGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The unique name of the Rackspace Cloud Files logging endpoint.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// A secure certificate to authenticate the server with. Must be in PEM format.
        /// </summary>
        [Input("tlsCaCert")]
        public Input<string>? TlsCaCert { get; set; }

        /// <summary>
        /// The hostname used to verify the server's certificate. It can either be the Common Name or a Subject Alternative Name (SAN).
        /// </summary>
        [Input("tlsHostname")]
        public Input<string>? TlsHostname { get; set; }

        /// <summary>
        /// The data authentication token associated with this endpoint.
        /// </summary>
        [Input("token", required: true)]
        public Input<string> Token { get; set; } = null!;

        /// <summary>
        /// Your OpenStack auth url.
        /// </summary>
        [Input("url", required: true)]
        public Input<string> Url { get; set; } = null!;

        public ServiceComputeSplunkGetArgs()
        {
        }
    }
}