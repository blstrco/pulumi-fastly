// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Fastly.Inputs
{

    public sealed class Servicev1DirectorArgs : Pulumi.ResourceArgs
    {
        [Input("backends", required: true)]
        private InputList<string>? _backends;

        /// <summary>
        /// Names of defined backends to map the director to. Example: `[ "origin1", "origin2" ]`
        /// </summary>
        public InputList<string> Backends
        {
            get => _backends ?? (_backends = new InputList<string>());
            set => _backends = value;
        }

        /// <summary>
        /// Load balancing weight for the backends. Default `100`.
        /// </summary>
        [Input("capacity")]
        public Input<int>? Capacity { get; set; }

        /// <summary>
        /// An optional comment about the Director.
        /// </summary>
        [Input("comment")]
        public Input<string>? Comment { get; set; }

        /// <summary>
        /// A unique name to identify this dictionary.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Percentage of capacity that needs to be up for the director itself to be considered up. Default `75`.
        /// </summary>
        [Input("quorum")]
        public Input<int>? Quorum { get; set; }

        /// <summary>
        /// How many backends to search if it fails. Default `5`.
        /// </summary>
        [Input("retries")]
        public Input<int>? Retries { get; set; }

        /// <summary>
        /// Selected POP to serve as a "shield" for origin servers.
        /// </summary>
        [Input("shield")]
        public Input<string>? Shield { get; set; }

        /// <summary>
        /// The location in generated VCL where the snippet should be placed (can be one of `init`, `recv`, `hit`, `miss`, `pass`, `fetch`, `error`, `deliver`, `log` or `none`).
        /// </summary>
        [Input("type")]
        public Input<int>? Type { get; set; }

        public Servicev1DirectorArgs()
        {
        }
    }
}