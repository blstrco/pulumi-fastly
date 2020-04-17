// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Fastly.Inputs
{

    public sealed class Servicev1CacheSettingArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Allows you to terminate request handling and immediately
        /// perform an action. When set it can be `lookup` or `pass` (Ignore the cache completely).
        /// </summary>
        [Input("action")]
        public Input<string>? Action { get; set; }

        /// <summary>
        /// Name of already defined `condition` to check after we have retrieved an object. If the condition passes then deliver this Request Object instead. This `condition` must be of type `CACHE`. For detailed information about Conditionals,
        /// see [Fastly's Documentation on Conditionals][fastly-conditionals].
        /// </summary>
        [Input("cacheCondition")]
        public Input<string>? CacheCondition { get; set; }

        /// <summary>
        /// A unique name to identify this dictionary.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Max "Time To Live" for stale (unreachable) objects.
        /// </summary>
        [Input("staleTtl")]
        public Input<int>? StaleTtl { get; set; }

        /// <summary>
        /// The Time-To-Live (TTL) for the object.
        /// </summary>
        [Input("ttl")]
        public Input<int>? Ttl { get; set; }

        public Servicev1CacheSettingArgs()
        {
        }
    }
}