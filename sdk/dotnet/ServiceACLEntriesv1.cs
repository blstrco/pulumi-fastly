// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Fastly
{
    /// <summary>
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-fastly/blob/master/website/docs/r/service_acl_entries_v1.html.markdown.
    /// </summary>
    public partial class ServiceACLEntriesv1 : Pulumi.CustomResource
    {
        /// <summary>
        /// The ID of the ACL that the items belong to
        /// </summary>
        [Output("aclId")]
        public Output<string> AclId { get; private set; } = null!;

        /// <summary>
        /// A Set ACL entries that are applied to the service. Defined below
        /// </summary>
        [Output("entries")]
        public Output<ImmutableArray<Outputs.ServiceACLEntriesv1Entries>> Entries { get; private set; } = null!;

        /// <summary>
        /// The ID of the Service that the ACL belongs to
        /// </summary>
        [Output("serviceId")]
        public Output<string> ServiceId { get; private set; } = null!;


        /// <summary>
        /// Create a ServiceACLEntriesv1 resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ServiceACLEntriesv1(string name, ServiceACLEntriesv1Args args, CustomResourceOptions? options = null)
            : base("fastly:index/serviceACLEntriesv1:ServiceACLEntriesv1", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private ServiceACLEntriesv1(string name, Input<string> id, ServiceACLEntriesv1State? state = null, CustomResourceOptions? options = null)
            : base("fastly:index/serviceACLEntriesv1:ServiceACLEntriesv1", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ServiceACLEntriesv1 resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ServiceACLEntriesv1 Get(string name, Input<string> id, ServiceACLEntriesv1State? state = null, CustomResourceOptions? options = null)
        {
            return new ServiceACLEntriesv1(name, id, state, options);
        }
    }

    public sealed class ServiceACLEntriesv1Args : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ID of the ACL that the items belong to
        /// </summary>
        [Input("aclId", required: true)]
        public Input<string> AclId { get; set; } = null!;

        [Input("entries")]
        private InputList<Inputs.ServiceACLEntriesv1EntriesArgs>? _entries;

        /// <summary>
        /// A Set ACL entries that are applied to the service. Defined below
        /// </summary>
        public InputList<Inputs.ServiceACLEntriesv1EntriesArgs> Entries
        {
            get => _entries ?? (_entries = new InputList<Inputs.ServiceACLEntriesv1EntriesArgs>());
            set => _entries = value;
        }

        /// <summary>
        /// The ID of the Service that the ACL belongs to
        /// </summary>
        [Input("serviceId", required: true)]
        public Input<string> ServiceId { get; set; } = null!;

        public ServiceACLEntriesv1Args()
        {
        }
    }

    public sealed class ServiceACLEntriesv1State : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ID of the ACL that the items belong to
        /// </summary>
        [Input("aclId")]
        public Input<string>? AclId { get; set; }

        [Input("entries")]
        private InputList<Inputs.ServiceACLEntriesv1EntriesGetArgs>? _entries;

        /// <summary>
        /// A Set ACL entries that are applied to the service. Defined below
        /// </summary>
        public InputList<Inputs.ServiceACLEntriesv1EntriesGetArgs> Entries
        {
            get => _entries ?? (_entries = new InputList<Inputs.ServiceACLEntriesv1EntriesGetArgs>());
            set => _entries = value;
        }

        /// <summary>
        /// The ID of the Service that the ACL belongs to
        /// </summary>
        [Input("serviceId")]
        public Input<string>? ServiceId { get; set; }

        public ServiceACLEntriesv1State()
        {
        }
    }

    namespace Inputs
    {

    public sealed class ServiceACLEntriesv1EntriesArgs : Pulumi.ResourceArgs
    {
        [Input("comment")]
        public Input<string>? Comment { get; set; }

        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("ip", required: true)]
        public Input<string> Ip { get; set; } = null!;

        [Input("negated")]
        public Input<bool>? Negated { get; set; }

        [Input("subnet")]
        public Input<string>? Subnet { get; set; }

        public ServiceACLEntriesv1EntriesArgs()
        {
        }
    }

    public sealed class ServiceACLEntriesv1EntriesGetArgs : Pulumi.ResourceArgs
    {
        [Input("comment")]
        public Input<string>? Comment { get; set; }

        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("ip", required: true)]
        public Input<string> Ip { get; set; } = null!;

        [Input("negated")]
        public Input<bool>? Negated { get; set; }

        [Input("subnet")]
        public Input<string>? Subnet { get; set; }

        public ServiceACLEntriesv1EntriesGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class ServiceACLEntriesv1Entries
    {
        public readonly string? Comment;
        public readonly string Id;
        public readonly string Ip;
        public readonly bool? Negated;
        public readonly string? Subnet;

        [OutputConstructor]
        private ServiceACLEntriesv1Entries(
            string? comment,
            string id,
            string ip,
            bool? negated,
            string? subnet)
        {
            Comment = comment;
            Id = id;
            Ip = ip;
            Negated = negated;
            Subnet = subnet;
        }
    }
    }
}