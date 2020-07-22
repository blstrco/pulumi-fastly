// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Fastly.Inputs
{

    public sealed class ServiceComputeLoggingKafkaArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A comma-separated list of IP addresses or hostnames of Kafka brokers.
        /// </summary>
        [Input("brokers", required: true)]
        public Input<string> Brokers { get; set; } = null!;

        /// <summary>
        /// The codec used for compression of your logs. One of: gzip, snappy, lz4.
        /// </summary>
        [Input("compressionCodec")]
        public Input<string>? CompressionCodec { get; set; }

        /// <summary>
        /// The unique name of the Rackspace Cloud Files logging endpoint.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The Number of acknowledgements a leader must receive before a write is considered successful. One of: 1 (default) One server needs to respond. 0 No servers need to respond. -1	Wait for all in-sync replicas to respond.
        /// </summary>
        [Input("requiredAcks")]
        public Input<string>? RequiredAcks { get; set; }

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
        /// The Kafka topic to send logs to.
        /// </summary>
        [Input("topic", required: true)]
        public Input<string> Topic { get; set; } = null!;

        /// <summary>
        /// Whether to use TLS for secure logging. Can be either true or false.
        /// </summary>
        [Input("useTls")]
        public Input<bool>? UseTls { get; set; }

        public ServiceComputeLoggingKafkaArgs()
        {
        }
    }
}
