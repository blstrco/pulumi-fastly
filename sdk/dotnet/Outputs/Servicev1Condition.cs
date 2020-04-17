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
    public sealed class Servicev1Condition
    {
        /// <summary>
        /// A unique name to identify this dictionary.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Priority determines the ordering for multiple snippets. Lower numbers execute first.  Defaults to `100`.
        /// </summary>
        public readonly int? Priority;
        /// <summary>
        /// The statement used to determine if the condition is met.
        /// </summary>
        public readonly string Statement;
        /// <summary>
        /// The location in generated VCL where the snippet should be placed (can be one of `init`, `recv`, `hit`, `miss`, `pass`, `fetch`, `error`, `deliver`, `log` or `none`).
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private Servicev1Condition(
            string name,

            int? priority,

            string statement,

            string type)
        {
            Name = name;
            Priority = priority;
            Statement = statement;
            Type = type;
        }
    }
}
