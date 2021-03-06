// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Fastly.Inputs
{

    public sealed class ServiceComputeSyslogArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The SFTP address to stream logs to.
        /// </summary>
        [Input("address", required: true)]
        public Input<string> Address { get; set; } = null!;

        /// <summary>
        /// How the message should be formatted. One of: classic (default), loggly, logplex or blank.
        /// </summary>
        [Input("messageType")]
        public Input<string>? MessageType { get; set; }

        /// <summary>
        /// The unique name of the Rackspace Cloud Files logging endpoint.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The port the SFTP service listens on. (Default: `22`).
        /// </summary>
        [Input("port")]
        public Input<int>? Port { get; set; }

        /// <summary>
        /// A secure certificate to authenticate the server with. Must be in PEM format.
        /// </summary>
        [Input("tlsCaCert")]
        public Input<string>? TlsCaCert { get; set; }

        /// <summary>
        /// The client certificate used to make authenticated requests. Must be in PEM format.
        /// </summary>
        [Input("tlsClientCert")]
        public Input<string>? TlsClientCert { get; set; }

        /// <summary>
        /// The client private key used to make authenticated requests. Must be in PEM format.
        /// </summary>
        [Input("tlsClientKey")]
        public Input<string>? TlsClientKey { get; set; }

        /// <summary>
        /// The hostname used to verify the server's certificate. It can either be the Common Name or a Subject Alternative Name (SAN).
        /// </summary>
        [Input("tlsHostname")]
        public Input<string>? TlsHostname { get; set; }

        /// <summary>
        /// The data authentication token associated with this endpoint.
        /// </summary>
        [Input("token")]
        public Input<string>? Token { get; set; }

        /// <summary>
        /// Whether to use TLS for secure logging. Can be either true or false.
        /// </summary>
        [Input("useTls")]
        public Input<bool>? UseTls { get; set; }

        public ServiceComputeSyslogArgs()
        {
        }
    }
}
