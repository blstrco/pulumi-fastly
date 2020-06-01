// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Defines a map of Fastly dictionary items that can be used to populate a service dictionary.  This resource will populate a dictionary with the items and will track their state.
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
 * const mydictName = config.get("mydictName") || "My Dictionary";
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
 *     dictionary: [{
 *         name: mydictName,
 *     }],
 *     forceDestroy: true,
 * });
 * const items = new fastly.ServiceDictionaryItemsv1("items", {
 *     serviceId: myservice.id,
 *     dictionaryId: myservice.dictionaries.apply(dictionaries => dictionaries.reduce((__obj, s) => { ...__obj, [s.name]: s.dictionaryId })[mydictName]),
 *     items: {
 *         key1: "value1",
 *         key2: "value2",
 *     },
 * });
 * ```
 *
 * ### Complex object usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as fastly from "@pulumi/fastly";
 *
 * const config = new pulumi.Config();
 * const mydict = config.getObject("mydict") || {
 *     name: "My Dictionary",
 *     items: {
 *         key1: "value1x",
 *         key2: "value2x",
 *     },
 * };
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
 *     dictionary: [{
 *         name: mydict.name,
 *     }],
 *     forceDestroy: true,
 * });
 * const items = new fastly.ServiceDictionaryItemsv1("items", {
 *     serviceId: myservice.id,
 *     dictionaryId: myservice.dictionaries.apply(dictionaries => dictionaries.reduce((__obj, d) => { ...__obj, [d.name]: d.dictionaryId })[mydict.name]),
 *     items: mydict.items,
 * });
 * ```
 */
export class ServiceDictionaryItemsv1 extends pulumi.CustomResource {
    /**
     * Get an existing ServiceDictionaryItemsv1 resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ServiceDictionaryItemsv1State, opts?: pulumi.CustomResourceOptions): ServiceDictionaryItemsv1 {
        return new ServiceDictionaryItemsv1(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'fastly:index/serviceDictionaryItemsv1:ServiceDictionaryItemsv1';

    /**
     * Returns true if the given object is an instance of ServiceDictionaryItemsv1.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ServiceDictionaryItemsv1 {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ServiceDictionaryItemsv1.__pulumiType;
    }

    /**
     * The ID of the dictionary that the items belong to
     */
    public readonly dictionaryId!: pulumi.Output<string>;
    /**
     * A map representing an entry in the dictionary, (key/value)
     */
    public readonly items!: pulumi.Output<{[key: string]: any} | undefined>;
    /**
     * The ID of the service that the dictionary belongs to
     */
    public readonly serviceId!: pulumi.Output<string>;

    /**
     * Create a ServiceDictionaryItemsv1 resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ServiceDictionaryItemsv1Args, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ServiceDictionaryItemsv1Args | ServiceDictionaryItemsv1State, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as ServiceDictionaryItemsv1State | undefined;
            inputs["dictionaryId"] = state ? state.dictionaryId : undefined;
            inputs["items"] = state ? state.items : undefined;
            inputs["serviceId"] = state ? state.serviceId : undefined;
        } else {
            const args = argsOrState as ServiceDictionaryItemsv1Args | undefined;
            if (!args || args.dictionaryId === undefined) {
                throw new Error("Missing required property 'dictionaryId'");
            }
            if (!args || args.serviceId === undefined) {
                throw new Error("Missing required property 'serviceId'");
            }
            inputs["dictionaryId"] = args ? args.dictionaryId : undefined;
            inputs["items"] = args ? args.items : undefined;
            inputs["serviceId"] = args ? args.serviceId : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(ServiceDictionaryItemsv1.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ServiceDictionaryItemsv1 resources.
 */
export interface ServiceDictionaryItemsv1State {
    /**
     * The ID of the dictionary that the items belong to
     */
    readonly dictionaryId?: pulumi.Input<string>;
    /**
     * A map representing an entry in the dictionary, (key/value)
     */
    readonly items?: pulumi.Input<{[key: string]: any}>;
    /**
     * The ID of the service that the dictionary belongs to
     */
    readonly serviceId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ServiceDictionaryItemsv1 resource.
 */
export interface ServiceDictionaryItemsv1Args {
    /**
     * The ID of the dictionary that the items belong to
     */
    readonly dictionaryId: pulumi.Input<string>;
    /**
     * A map representing an entry in the dictionary, (key/value)
     */
    readonly items?: pulumi.Input<{[key: string]: any}>;
    /**
     * The ID of the service that the dictionary belongs to
     */
    readonly serviceId: pulumi.Input<string>;
}
