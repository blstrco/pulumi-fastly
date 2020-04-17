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
    public sealed class Servicev1ResponseObject
    {
        /// <summary>
        /// Name of already defined `condition` to check after we have retrieved an object. If the condition passes then deliver this Request Object instead. This `condition` must be of type `CACHE`. For detailed information about Conditionals,
        /// see [Fastly's Documentation on Conditionals][fastly-conditionals].
        /// </summary>
        public readonly string? CacheCondition;
        /// <summary>
        /// The custom VCL code to upload.
        /// </summary>
        public readonly string? Content;
        /// <summary>
        /// The MIME type of the content.
        /// </summary>
        public readonly string? ContentType;
        /// <summary>
        /// A unique name to identify this dictionary.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Name of already defined `condition` to be checked during the request phase. If the condition passes then this object will be delivered. This `condition` must be of type `REQUEST`.
        /// </summary>
        public readonly string? RequestCondition;
        /// <summary>
        /// The HTTP Response. Default `Ok`.
        /// </summary>
        public readonly string? Response;
        /// <summary>
        /// The HTTP Status Code. Default `200`.
        /// </summary>
        public readonly int? Status;

        [OutputConstructor]
        private Servicev1ResponseObject(
            string? cacheCondition,

            string? content,

            string? contentType,

            string name,

            string? requestCondition,

            string? response,

            int? status)
        {
            CacheCondition = cacheCondition;
            Content = content;
            ContentType = contentType;
            Name = name;
            RequestCondition = requestCondition;
            Response = response;
            Status = status;
        }
    }
}
