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
    public sealed class ServiceComputeSyslog
    {
        /// <summary>
        /// The SFTP address to stream logs to.
        /// </summary>
        public readonly string Address;
        /// <summary>
        /// How the message should be formatted. One of: classic (default), loggly, logplex or blank.
        /// </summary>
        public readonly string? MessageType;
        /// <summary>
        /// The unique name of the Rackspace Cloud Files logging endpoint.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The port the SFTP service listens on. (Default: `22`).
        /// </summary>
        public readonly int? Port;
        /// <summary>
        /// A secure certificate to authenticate the server with. Must be in PEM format.
        /// </summary>
        public readonly string? TlsCaCert;
        /// <summary>
        /// The client certificate used to make authenticated requests. Must be in PEM format.
        /// </summary>
        public readonly string? TlsClientCert;
        /// <summary>
        /// The client private key used to make authenticated requests. Must be in PEM format.
        /// </summary>
        public readonly string? TlsClientKey;
        /// <summary>
        /// The hostname used to verify the server's certificate. It can either be the Common Name or a Subject Alternative Name (SAN).
        /// </summary>
        public readonly string? TlsHostname;
        /// <summary>
        /// The data authentication token associated with this endpoint.
        /// </summary>
        public readonly string? Token;
        /// <summary>
        /// Whether to use TLS for secure logging. Can be either true or false.
        /// </summary>
        public readonly bool? UseTls;

        [OutputConstructor]
        private ServiceComputeSyslog(
            string address,

            string? messageType,

            string name,

            int? port,

            string? tlsCaCert,

            string? tlsClientCert,

            string? tlsClientKey,

            string? tlsHostname,

            string? token,

            bool? useTls)
        {
            Address = address;
            MessageType = messageType;
            Name = name;
            Port = port;
            TlsCaCert = tlsCaCert;
            TlsClientCert = tlsClientCert;
            TlsClientKey = tlsClientKey;
            TlsHostname = tlsHostname;
            Token = token;
            UseTls = useTls;
        }
    }
}
