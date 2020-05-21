// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Provides a Fastly User, representing the configuration for a user account for interacting with Fastly.
 *
 * The User resource requires a login and name, and optionally a role.
 *
 * ## Example Usage
 *
 *
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as fastly from "@pulumi/fastly";
 *
 * const demo = new fastly.Userv1("demo", {
 *     login: "demo@example.com",
 * });
 * ```
 */
export class Userv1 extends pulumi.CustomResource {
    /**
     * Get an existing Userv1 resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: Userv1State, opts?: pulumi.CustomResourceOptions): Userv1 {
        return new Userv1(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'fastly:index/userv1:Userv1';

    /**
     * Returns true if the given object is an instance of Userv1.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Userv1 {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Userv1.__pulumiType;
    }

    /**
     * The email address, which is the login name, of the User.
     */
    public readonly login!: pulumi.Output<string>;
    /**
     * The real life name of the user.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The role of this user. Can be `user` (the default), `billing`, `engineer`, or `superuser`. For detailed information on the abilities granted to each role, see [Fastly's Documentation on User roles](https://docs.fastly.com/en/guides/configuring-user-roles-and-permissions#user-roles-and-what-they-can-do).
     */
    public readonly role!: pulumi.Output<string | undefined>;

    /**
     * Create a Userv1 resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: Userv1Args, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: Userv1Args | Userv1State, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as Userv1State | undefined;
            inputs["login"] = state ? state.login : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["role"] = state ? state.role : undefined;
        } else {
            const args = argsOrState as Userv1Args | undefined;
            if (!args || args.login === undefined) {
                throw new Error("Missing required property 'login'");
            }
            inputs["login"] = args ? args.login : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["role"] = args ? args.role : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(Userv1.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Userv1 resources.
 */
export interface Userv1State {
    /**
     * The email address, which is the login name, of the User.
     */
    readonly login?: pulumi.Input<string>;
    /**
     * The real life name of the user.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The role of this user. Can be `user` (the default), `billing`, `engineer`, or `superuser`. For detailed information on the abilities granted to each role, see [Fastly's Documentation on User roles](https://docs.fastly.com/en/guides/configuring-user-roles-and-permissions#user-roles-and-what-they-can-do).
     */
    readonly role?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Userv1 resource.
 */
export interface Userv1Args {
    /**
     * The email address, which is the login name, of the User.
     */
    readonly login: pulumi.Input<string>;
    /**
     * The real life name of the user.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The role of this user. Can be `user` (the default), `billing`, `engineer`, or `superuser`. For detailed information on the abilities granted to each role, see [Fastly's Documentation on User roles](https://docs.fastly.com/en/guides/configuring-user-roles-and-permissions#user-roles-and-what-they-can-do).
     */
    readonly role?: pulumi.Input<string>;
}
