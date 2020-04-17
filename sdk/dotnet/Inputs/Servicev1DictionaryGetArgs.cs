// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Fastly.Inputs
{

    public sealed class Servicev1DictionaryGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ID of the dictionary.
        /// </summary>
        [Input("dictionaryId")]
        public Input<string>? DictionaryId { get; set; }

        /// <summary>
        /// A unique name to identify this dictionary.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("writeOnly")]
        public Input<bool>? WriteOnly { get; set; }

        public Servicev1DictionaryGetArgs()
        {
        }
    }
}
