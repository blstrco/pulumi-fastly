// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Fastly.Inputs
{

    public sealed class Servicev1DynamicsnippetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A unique name to identify this dictionary.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Priority determines the ordering for multiple snippets. Lower numbers execute first.  Defaults to `100`.
        /// </summary>
        [Input("priority")]
        public Input<int>? Priority { get; set; }

        /// <summary>
        /// The ID of the dynamic snippet.
        /// </summary>
        [Input("snippetId")]
        public Input<string>? SnippetId { get; set; }

        /// <summary>
        /// The location in generated VCL where the snippet should be placed (can be one of `init`, `recv`, `hit`, `miss`, `pass`, `fetch`, `error`, `deliver`, `log` or `none`).
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public Servicev1DynamicsnippetArgs()
        {
        }
    }
}
