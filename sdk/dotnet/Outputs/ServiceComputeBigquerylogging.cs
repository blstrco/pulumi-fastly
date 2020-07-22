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
    public sealed class ServiceComputeBigquerylogging
    {
        /// <summary>
        /// The Honeycomb Dataset you want to log to.
        /// </summary>
        public readonly string Dataset;
        /// <summary>
        /// The email for the service account with write access to your BigQuery dataset. If not provided, this will be pulled from a `FASTLY_BQ_EMAIL` environment variable.
        /// </summary>
        public readonly string? Email;
        /// <summary>
        /// The unique name of the Rackspace Cloud Files logging endpoint.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The ID of your Google Cloud Platform project.
        /// </summary>
        public readonly string ProjectId;
        /// <summary>
        /// Your DigitalOcean Spaces account secret key.
        /// </summary>
        public readonly string? SecretKey;
        /// <summary>
        /// The ID of your BigQuery table.
        /// </summary>
        public readonly string Table;
        public readonly string? Template;

        [OutputConstructor]
        private ServiceComputeBigquerylogging(
            string dataset,

            string? email,

            string name,

            string projectId,

            string? secretKey,

            string table,

            string? template)
        {
            Dataset = dataset;
            Email = email;
            Name = name;
            ProjectId = projectId;
            SecretKey = secretKey;
            Table = table;
            Template = template;
        }
    }
}
