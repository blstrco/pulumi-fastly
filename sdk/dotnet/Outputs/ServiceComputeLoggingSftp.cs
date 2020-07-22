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
    public sealed class ServiceComputeLoggingSftp
    {
        /// <summary>
        /// The SFTP address to stream logs to.
        /// </summary>
        public readonly string Address;
        /// <summary>
        /// What level of GZIP encoding to have when dumping logs (default 0, no compression).
        /// </summary>
        public readonly int? GzipLevel;
        /// <summary>
        /// How the message should be formatted. One of: classic (default), loggly, logplex or blank.
        /// </summary>
        public readonly string? MessageType;
        /// <summary>
        /// The unique name of the Rackspace Cloud Files logging endpoint.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The password for the server. If both `password` and `secret_key` are passed, `secret_key` will be preferred.
        /// </summary>
        public readonly string? Password;
        /// <summary>
        /// The path to upload logs to.
        /// </summary>
        public readonly string Path;
        /// <summary>
        /// How frequently log files are finalized so they can be available for reading (in seconds, default 3600).
        /// </summary>
        public readonly int? Period;
        /// <summary>
        /// The port the SFTP service listens on. (Default: `22`).
        /// </summary>
        public readonly int? Port;
        /// <summary>
        /// The PGP public key that Fastly will use to encrypt your log files before writing them to disk.
        /// </summary>
        public readonly string? PublicKey;
        /// <summary>
        /// Your DigitalOcean Spaces account secret key.
        /// </summary>
        public readonly string? SecretKey;
        /// <summary>
        /// A list of host keys for all hosts we can connect to over SFTP.
        /// </summary>
        public readonly string SshKnownHosts;
        /// <summary>
        /// The strftime specified timestamp formatting (default `%Y-%m-%dT%H:%M:%S.000`).
        /// </summary>
        public readonly string? TimestampFormat;
        /// <summary>
        /// The username for your Cloud Files account.
        /// </summary>
        public readonly string User;

        [OutputConstructor]
        private ServiceComputeLoggingSftp(
            string address,

            int? gzipLevel,

            string? messageType,

            string name,

            string? password,

            string path,

            int? period,

            int? port,

            string? publicKey,

            string? secretKey,

            string sshKnownHosts,

            string? timestampFormat,

            string user)
        {
            Address = address;
            GzipLevel = gzipLevel;
            MessageType = messageType;
            Name = name;
            Password = password;
            Path = path;
            Period = period;
            Port = port;
            PublicKey = publicKey;
            SecretKey = secretKey;
            SshKnownHosts = sshKnownHosts;
            TimestampFormat = timestampFormat;
            User = user;
        }
    }
}
