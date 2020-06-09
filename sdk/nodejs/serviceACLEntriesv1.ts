// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Defines a set of Fastly ACL entries that can be used to populate a service ACL.  This resource will populate an ACL with the entries and will track their state.
 *
 * ## Example Usage
 *
 * ### Basic usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as fastly from "@pulumi/fastly";
 *
 * const config = new pulumi.Config();
 * const myaclName = config.get("myaclName") || "My ACL";
 * const myservice = new fastly.Servicev1("myservice", {
 *     domain: [{
 *         name: "demo.notexample.com",
 *         comment: "demo",
 *     }],
 *     backend: [{
 *         address: "demo.notexample.com.s3-website-us-west-2.amazonaws.com",
 *         name: "AWS S3 hosting",
 *         port: 80,
 *     }],
 *     acl: [{
 *         name: myaclName,
 *     }],
 *     forceDestroy: true,
 * });
 * const entries = new fastly.ServiceACLEntriesv1("entries", {
 *     serviceId: myservice.id,
 *     aclId: myservice.acls.apply(acls => acls.reduce((__obj, d) => { ...__obj, [d.name]: d.aclId })[myaclName]),
 *     entry: [{
 *         ip: "127.0.0.1",
 *         subnet: "24",
 *         negated: false,
 *         comment: "ALC Entry 1",
 *     }],
 * });
 * ```
 *
 * ### Complex object usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as fastly from "@pulumi/fastly";
 *
 * const aclName = "myAcl";
 * const aclEntries = [
 *     {
 *         ip: "1.2.3.4",
 *         comment: "aclEntry1",
 *     },
 *     {
 *         ip: "1.2.3.5",
 *         comment: "aclEntry2",
 *     },
 *     {
 *         ip: "1.2.3.6",
 *         comment: "aclEntry3",
 *     },
 * ];
 * const myservice = new fastly.Servicev1("myservice", {
 *     domain: [{
 *         name: "demo.notexample.com",
 *         comment: "demo",
 *     }],
 *     backend: [{
 *         address: "1.2.3.4",
 *         name: "localhost",
 *         port: 80,
 *     }],
 *     acl: [{
 *         name: aclName,
 *     }],
 *     forceDestroy: true,
 * });
 * const entries = new fastly.ServiceACLEntriesv1("entries", {
 *     serviceId: myservice.id,
 *     aclId: myservice.acls.apply(acls => acls.reduce((__obj, d) => { ...__obj, [d.name]: d.aclId })[aclName]),
 *     dynamic: [{
 *         forEach: aclEntries.map(e => {
 *             ip: e.ip,
 *             comment: e.comment,
 *         }),
 *         content: [{
 *             ip: entry.value.ip,
 *             subnet: 22,
 *             comment: entry.value.comment,
 *             negated: false,
 *         }],
 *     }],
 * });
 * ```
 */
export class ServiceACLEntriesv1 extends pulumi.CustomResource {
    /**
     * Get an existing ServiceACLEntriesv1 resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ServiceACLEntriesv1State, opts?: pulumi.CustomResourceOptions): ServiceACLEntriesv1 {
        return new ServiceACLEntriesv1(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'fastly:index/serviceACLEntriesv1:ServiceACLEntriesv1';

    /**
     * Returns true if the given object is an instance of ServiceACLEntriesv1.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ServiceACLEntriesv1 {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ServiceACLEntriesv1.__pulumiType;
    }

    /**
     * The ID of the ACL that the items belong to
     */
    public readonly aclId!: pulumi.Output<string>;
    /**
     * A Set ACL entries that are applied to the service. Defined below
     */
    public readonly entries!: pulumi.Output<outputs.ServiceACLEntriesv1Entry[] | undefined>;
    /**
     * The ID of the Service that the ACL belongs to
     */
    public readonly serviceId!: pulumi.Output<string>;

    /**
     * Create a ServiceACLEntriesv1 resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ServiceACLEntriesv1Args, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ServiceACLEntriesv1Args | ServiceACLEntriesv1State, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as ServiceACLEntriesv1State | undefined;
            inputs["aclId"] = state ? state.aclId : undefined;
            inputs["entries"] = state ? state.entries : undefined;
            inputs["serviceId"] = state ? state.serviceId : undefined;
        } else {
            const args = argsOrState as ServiceACLEntriesv1Args | undefined;
            if (!args || args.aclId === undefined) {
                throw new Error("Missing required property 'aclId'");
            }
            if (!args || args.serviceId === undefined) {
                throw new Error("Missing required property 'serviceId'");
            }
            inputs["aclId"] = args ? args.aclId : undefined;
            inputs["entries"] = args ? args.entries : undefined;
            inputs["serviceId"] = args ? args.serviceId : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(ServiceACLEntriesv1.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ServiceACLEntriesv1 resources.
 */
export interface ServiceACLEntriesv1State {
    /**
     * The ID of the ACL that the items belong to
     */
    readonly aclId?: pulumi.Input<string>;
    /**
     * A Set ACL entries that are applied to the service. Defined below
     */
    readonly entries?: pulumi.Input<pulumi.Input<inputs.ServiceACLEntriesv1Entry>[]>;
    /**
     * The ID of the Service that the ACL belongs to
     */
    readonly serviceId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ServiceACLEntriesv1 resource.
 */
export interface ServiceACLEntriesv1Args {
    /**
     * The ID of the ACL that the items belong to
     */
    readonly aclId: pulumi.Input<string>;
    /**
     * A Set ACL entries that are applied to the service. Defined below
     */
    readonly entries?: pulumi.Input<pulumi.Input<inputs.ServiceACLEntriesv1Entry>[]>;
    /**
     * The ID of the Service that the ACL belongs to
     */
    readonly serviceId: pulumi.Input<string>;
}
