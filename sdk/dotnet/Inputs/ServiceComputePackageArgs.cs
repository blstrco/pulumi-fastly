// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Fastly.Inputs
{

    public sealed class ServiceComputePackageArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The path to the Wasm deployment package within your local filesystem.
        /// </summary>
        [Input("filename", required: true)]
        public Input<string> Filename { get; set; } = null!;

        [Input("sourceCodeHash")]
        public Input<string>? SourceCodeHash { get; set; }

        public ServiceComputePackageArgs()
        {
        }
    }
}
