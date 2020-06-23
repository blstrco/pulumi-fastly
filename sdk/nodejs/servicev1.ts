// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Provides a Fastly Service, representing the configuration for a website, app,
 * API, or anything else to be served through Fastly. A Service encompasses Domains
 * and Backends.
 *
 * The Service resource requires a domain name that is correctly set up to direct
 * traffic to the Fastly service. See Fastly's guide on [Adding CNAME Records][fastly-cname]
 * on their documentation site for guidance.
 *
 * ## Example Usage
 *
 * ### Basic usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as fastly from "@pulumi/fastly";
 *
 * const demo = new fastly.Servicev1("demo", {
 *     backends: [{
 *         address: "127.0.0.1",
 *         name: "localhost",
 *         port: 80,
 *     }],
 *     domains: [{
 *         comment: "demo",
 *         name: "demo.notexample.com",
 *     }],
 *     forceDestroy: true,
 * });
 * ```
 *
 * ### Basic usage with an Amazon S3 Website and that removes the `x-amz-request-id` header
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 * import * as fastly from "@pulumi/fastly";
 *
 * const website = new aws.s3.Bucket("website", {
 *     acl: "public-read",
 *     website: {
 *         errorDocument: "error.html",
 *         indexDocument: "index.html",
 *     },
 * });
 * const demo = new fastly.Servicev1("demo", {
 *     backends: [{
 *         address: "demo.notexample.com.s3-website-us-west-2.amazonaws.com",
 *         name: "AWS S3 hosting",
 *         port: 80,
 *     }],
 *     defaultHost: pulumi.interpolate`${website.name}.s3-website-us-west-2.amazonaws.com`,
 *     domains: [{
 *         comment: "demo",
 *         name: "demo.notexample.com",
 *     }],
 *     forceDestroy: true,
 *     gzips: [{
 *         contentTypes: [
 *             "text/html",
 *             "text/css",
 *         ],
 *         extensions: [
 *             "css",
 *             "js",
 *         ],
 *         name: "file extensions and content types",
 *     }],
 *     headers: [{
 *         action: "delete",
 *         destination: "http.x-amz-request-id",
 *         name: "remove x-amz-request-id",
 *         type: "cache",
 *     }],
 * });
 * ```
 *
 * ### Basic usage with custom VCL:
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as fastly from "@pulumi/fastly";
 * import * as fs from "fs";
 *
 * const demo = new fastly.Servicev1("demo", {
 *     backends: [{
 *         address: "127.0.0.1",
 *         name: "localhost",
 *         port: 80,
 *     }],
 *     domains: [{
 *         comment: "demo",
 *         name: "demo.notexample.com",
 *     }],
 *     forceDestroy: true,
 *     vcls: [
 *         {
 *             content: fs.readFileSync(`./my_custom_main.vcl`, "utf-8"),
 *             main: true,
 *             name: "myCustomMainVcl",
 *         },
 *         {
 *             content: fs.readFileSync(`./my_custom_library.vcl`, "utf-8"),
 *             name: "myCustomLibraryVcl",
 *         },
 *     ],
 * });
 * ```
 *
 * ### Basic usage with custom Director
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as fastly from "@pulumi/fastly";
 *
 * const demo = new fastly.Servicev1("demo", {
 *     backends: [
 *         {
 *             address: "127.0.0.1",
 *             name: "origin1",
 *             port: 80,
 *         },
 *         {
 *             address: "127.0.0.2",
 *             name: "origin2",
 *             port: 80,
 *         },
 *     ],
 *     directors: [{
 *         backends: [
 *             "origin1",
 *             "origin2",
 *         ],
 *         name: "mydirector",
 *         quorum: 0,
 *         type: 3,
 *     }],
 *     domains: [{
 *         comment: "demo",
 *         name: "demo.notexample.com",
 *     }],
 *     forceDestroy: true,
 * });
 * ```
 */
export class Servicev1 extends pulumi.CustomResource {
    /**
     * Get an existing Servicev1 resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: Servicev1State, opts?: pulumi.CustomResourceOptions): Servicev1 {
        return new Servicev1(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'fastly:index/servicev1:Servicev1';

    /**
     * Returns true if the given object is an instance of Servicev1.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Servicev1 {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Servicev1.__pulumiType;
    }

    /**
     * A set of ACL configuration blocks.  Defined below.
     */
    public readonly acls!: pulumi.Output<outputs.Servicev1Acl[] | undefined>;
    /**
     * Conditionally prevents the Service from being activated. The apply step will continue to create a new draft version but will not activate it if this is set to false. Default true.
     */
    public readonly activate!: pulumi.Output<boolean | undefined>;
    /**
     * The currently active version of your Fastly Service.
     */
    public /*out*/ readonly activeVersion!: pulumi.Output<number>;
    /**
     * A set of Backends to service requests from your Domains.
     * Defined below. Backends must be defined in this argument, or defined in the
     * `vcl` argument below
     */
    public readonly backends!: pulumi.Output<outputs.Servicev1Backend[] | undefined>;
    /**
     * A BigQuery endpoint to send streaming logs too.
     * Defined below.
     */
    public readonly bigqueryloggings!: pulumi.Output<outputs.Servicev1Bigquerylogging[] | undefined>;
    /**
     * An Azure Blob Storage endpoint to send streaming logs too.
     * Defined below.
     */
    public readonly blobstorageloggings!: pulumi.Output<outputs.Servicev1Blobstoragelogging[] | undefined>;
    /**
     * A set of Cache Settings, allowing you to override
     */
    public readonly cacheSettings!: pulumi.Output<outputs.Servicev1CacheSetting[] | undefined>;
    /**
     * The latest cloned version by the provider. The value gets only set after running `pulumi up`.
     */
    public /*out*/ readonly clonedVersion!: pulumi.Output<number>;
    /**
     * An optional comment about the Director.
     */
    public readonly comment!: pulumi.Output<string | undefined>;
    /**
     * A set of conditions to add logic to any basic
     * configuration object in this service. Defined below.
     */
    public readonly conditions!: pulumi.Output<outputs.Servicev1Condition[] | undefined>;
    /**
     * Sets the host header.
     */
    public readonly defaultHost!: pulumi.Output<string>;
    /**
     * The default Time-to-live (TTL) for
     * requests.
     */
    public readonly defaultTtl!: pulumi.Output<number | undefined>;
    /**
     * A set of dictionaries that allow the storing of key values pair for use within VCL functions. Defined below.
     */
    public readonly dictionaries!: pulumi.Output<outputs.Servicev1Dictionary[] | undefined>;
    /**
     * A director to allow more control over balancing traffic over backends.
     * when an item is not to be cached based on an above `condition`. Defined below
     */
    public readonly directors!: pulumi.Output<outputs.Servicev1Director[] | undefined>;
    /**
     * If you created the S3 bucket outside of `us-east-1`,
     * then specify the corresponding bucket endpoint. Example: `s3-us-west-2.amazonaws.com`.
     */
    public readonly domains!: pulumi.Output<outputs.Servicev1Domain[]>;
    /**
     * A set of custom, "dynamic" VCL Snippet configuration blocks.  Defined below.
     */
    public readonly dynamicsnippets!: pulumi.Output<outputs.Servicev1Dynamicsnippet[] | undefined>;
    /**
     * Services that are active cannot be destroyed. In
     * order to destroy the Service, set `forceDestroy` to `true`. Default `false`.
     */
    public readonly forceDestroy!: pulumi.Output<boolean | undefined>;
    /**
     * A gcs endpoint to send streaming logs too.
     * Defined below.
     */
    public readonly gcsloggings!: pulumi.Output<outputs.Servicev1Gcslogging[] | undefined>;
    /**
     * A set of gzip rules to control automatic gzipping of
     * content. Defined below.
     */
    public readonly gzips!: pulumi.Output<outputs.Servicev1Gzip[] | undefined>;
    /**
     * A set of Headers to manipulate for each request. Defined
     * below.
     */
    public readonly headers!: pulumi.Output<outputs.Servicev1Header[] | undefined>;
    /**
     * Name of a defined `healthcheck` to assign to this backend.
     */
    public readonly healthchecks!: pulumi.Output<outputs.Servicev1Healthcheck[] | undefined>;
    /**
     * An HTTPS endpoint to send streaming logs to.
     * Defined below.
     */
    public readonly httpsloggings!: pulumi.Output<outputs.Servicev1Httpslogging[] | undefined>;
    /**
     * A logentries endpoint to send streaming logs too.
     * Defined below.
     */
    public readonly logentries!: pulumi.Output<outputs.Servicev1Logentry[] | undefined>;
    /**
     * A Datadog endpoint to send streaming logs to.
     * Defined below.
     */
    public readonly loggingDatadogs!: pulumi.Output<outputs.Servicev1LoggingDatadog[] | undefined>;
    /**
     * An Elasticsearch endpoint to send streaming logs to.
     * Defined below.
     */
    public readonly loggingElasticsearches!: pulumi.Output<outputs.Servicev1LoggingElasticsearch[] | undefined>;
    /**
     * An FTP endpoint to send streaming logs to.
     * Defined below.
     */
    public readonly loggingFtps!: pulumi.Output<outputs.Servicev1LoggingFtp[] | undefined>;
    /**
     * A Google Cloud Pub/Sub endpoint to send streaming logs to.
     * Defined below.
     */
    public readonly loggingGooglepubsubs!: pulumi.Output<outputs.Servicev1LoggingGooglepubsub[] | undefined>;
    /**
     * A Kafka endpoint to send streaming logs to.
     * Defined below.
     */
    public readonly loggingKafkas!: pulumi.Output<outputs.Servicev1LoggingKafka[] | undefined>;
    /**
     * A Loggly endpoint to send streaming logs to.
     * Defined below.
     */
    public readonly loggingLogglies!: pulumi.Output<outputs.Servicev1LoggingLoggly[] | undefined>;
    /**
     * A New Relic endpoint to send streaming logs to.
     * Defined below.
     */
    public readonly loggingNewrelics!: pulumi.Output<outputs.Servicev1LoggingNewrelic[] | undefined>;
    /**
     * A Scalyr endpoint to send streaming logs to.
     * Defined below.
     */
    public readonly loggingScalyrs!: pulumi.Output<outputs.Servicev1LoggingScalyr[] | undefined>;
    /**
     * An SFTP endpoint to send streaming logs to.
     * Defined below.
     */
    public readonly loggingSftps!: pulumi.Output<outputs.Servicev1LoggingSftp[] | undefined>;
    /**
     * A unique name to identify this dictionary.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * A Papertrail endpoint to send streaming logs too.
     * Defined below.
     */
    public readonly papertrails!: pulumi.Output<outputs.Servicev1Papertrail[] | undefined>;
    /**
     * A set of Request modifiers. Defined below
     */
    public readonly requestSettings!: pulumi.Output<outputs.Servicev1RequestSetting[] | undefined>;
    /**
     * Allows you to create synthetic responses that exist entirely on the varnish machine. Useful for creating error or maintenance pages that exists outside the scope of your datacenter. Best when used with Condition objects.
     */
    public readonly responseObjects!: pulumi.Output<outputs.Servicev1ResponseObject[] | undefined>;
    /**
     * A set of S3 Buckets to send streaming logs too.
     * Defined below.
     */
    public readonly s3loggings!: pulumi.Output<outputs.Servicev1S3logging[] | undefined>;
    /**
     * A set of custom, "regular" (non-dynamic) VCL Snippet configuration blocks.  Defined below.
     */
    public readonly snippets!: pulumi.Output<outputs.Servicev1Snippet[] | undefined>;
    /**
     * A Splunk endpoint to send streaming logs too.
     * Defined below.
     */
    public readonly splunks!: pulumi.Output<outputs.Servicev1Splunk[] | undefined>;
    /**
     * A Sumologic endpoint to send streaming logs too.
     * Defined below.
     */
    public readonly sumologics!: pulumi.Output<outputs.Servicev1Sumologic[] | undefined>;
    /**
     * A syslog endpoint to send streaming logs too.
     * Defined below.
     */
    public readonly syslogs!: pulumi.Output<outputs.Servicev1Syslog[] | undefined>;
    /**
     * A set of custom VCL configuration blocks. See the [Fastly documentation](https://docs.fastly.com/vcl/custom-vcl/uploading-custom-vcl/) for more information on using custom VCL.
     */
    public readonly vcls!: pulumi.Output<outputs.Servicev1Vcl[] | undefined>;
    /**
     * Description field for the version.
     */
    public readonly versionComment!: pulumi.Output<string | undefined>;

    /**
     * Create a Servicev1 resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: Servicev1Args, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: Servicev1Args | Servicev1State, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as Servicev1State | undefined;
            inputs["acls"] = state ? state.acls : undefined;
            inputs["activate"] = state ? state.activate : undefined;
            inputs["activeVersion"] = state ? state.activeVersion : undefined;
            inputs["backends"] = state ? state.backends : undefined;
            inputs["bigqueryloggings"] = state ? state.bigqueryloggings : undefined;
            inputs["blobstorageloggings"] = state ? state.blobstorageloggings : undefined;
            inputs["cacheSettings"] = state ? state.cacheSettings : undefined;
            inputs["clonedVersion"] = state ? state.clonedVersion : undefined;
            inputs["comment"] = state ? state.comment : undefined;
            inputs["conditions"] = state ? state.conditions : undefined;
            inputs["defaultHost"] = state ? state.defaultHost : undefined;
            inputs["defaultTtl"] = state ? state.defaultTtl : undefined;
            inputs["dictionaries"] = state ? state.dictionaries : undefined;
            inputs["directors"] = state ? state.directors : undefined;
            inputs["domains"] = state ? state.domains : undefined;
            inputs["dynamicsnippets"] = state ? state.dynamicsnippets : undefined;
            inputs["forceDestroy"] = state ? state.forceDestroy : undefined;
            inputs["gcsloggings"] = state ? state.gcsloggings : undefined;
            inputs["gzips"] = state ? state.gzips : undefined;
            inputs["headers"] = state ? state.headers : undefined;
            inputs["healthchecks"] = state ? state.healthchecks : undefined;
            inputs["httpsloggings"] = state ? state.httpsloggings : undefined;
            inputs["logentries"] = state ? state.logentries : undefined;
            inputs["loggingDatadogs"] = state ? state.loggingDatadogs : undefined;
            inputs["loggingElasticsearches"] = state ? state.loggingElasticsearches : undefined;
            inputs["loggingFtps"] = state ? state.loggingFtps : undefined;
            inputs["loggingGooglepubsubs"] = state ? state.loggingGooglepubsubs : undefined;
            inputs["loggingKafkas"] = state ? state.loggingKafkas : undefined;
            inputs["loggingLogglies"] = state ? state.loggingLogglies : undefined;
            inputs["loggingNewrelics"] = state ? state.loggingNewrelics : undefined;
            inputs["loggingScalyrs"] = state ? state.loggingScalyrs : undefined;
            inputs["loggingSftps"] = state ? state.loggingSftps : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["papertrails"] = state ? state.papertrails : undefined;
            inputs["requestSettings"] = state ? state.requestSettings : undefined;
            inputs["responseObjects"] = state ? state.responseObjects : undefined;
            inputs["s3loggings"] = state ? state.s3loggings : undefined;
            inputs["snippets"] = state ? state.snippets : undefined;
            inputs["splunks"] = state ? state.splunks : undefined;
            inputs["sumologics"] = state ? state.sumologics : undefined;
            inputs["syslogs"] = state ? state.syslogs : undefined;
            inputs["vcls"] = state ? state.vcls : undefined;
            inputs["versionComment"] = state ? state.versionComment : undefined;
        } else {
            const args = argsOrState as Servicev1Args | undefined;
            if (!args || args.domains === undefined) {
                throw new Error("Missing required property 'domains'");
            }
            inputs["acls"] = args ? args.acls : undefined;
            inputs["activate"] = args ? args.activate : undefined;
            inputs["backends"] = args ? args.backends : undefined;
            inputs["bigqueryloggings"] = args ? args.bigqueryloggings : undefined;
            inputs["blobstorageloggings"] = args ? args.blobstorageloggings : undefined;
            inputs["cacheSettings"] = args ? args.cacheSettings : undefined;
            inputs["comment"] = args ? args.comment : undefined;
            inputs["conditions"] = args ? args.conditions : undefined;
            inputs["defaultHost"] = args ? args.defaultHost : undefined;
            inputs["defaultTtl"] = args ? args.defaultTtl : undefined;
            inputs["dictionaries"] = args ? args.dictionaries : undefined;
            inputs["directors"] = args ? args.directors : undefined;
            inputs["domains"] = args ? args.domains : undefined;
            inputs["dynamicsnippets"] = args ? args.dynamicsnippets : undefined;
            inputs["forceDestroy"] = args ? args.forceDestroy : undefined;
            inputs["gcsloggings"] = args ? args.gcsloggings : undefined;
            inputs["gzips"] = args ? args.gzips : undefined;
            inputs["headers"] = args ? args.headers : undefined;
            inputs["healthchecks"] = args ? args.healthchecks : undefined;
            inputs["httpsloggings"] = args ? args.httpsloggings : undefined;
            inputs["logentries"] = args ? args.logentries : undefined;
            inputs["loggingDatadogs"] = args ? args.loggingDatadogs : undefined;
            inputs["loggingElasticsearches"] = args ? args.loggingElasticsearches : undefined;
            inputs["loggingFtps"] = args ? args.loggingFtps : undefined;
            inputs["loggingGooglepubsubs"] = args ? args.loggingGooglepubsubs : undefined;
            inputs["loggingKafkas"] = args ? args.loggingKafkas : undefined;
            inputs["loggingLogglies"] = args ? args.loggingLogglies : undefined;
            inputs["loggingNewrelics"] = args ? args.loggingNewrelics : undefined;
            inputs["loggingScalyrs"] = args ? args.loggingScalyrs : undefined;
            inputs["loggingSftps"] = args ? args.loggingSftps : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["papertrails"] = args ? args.papertrails : undefined;
            inputs["requestSettings"] = args ? args.requestSettings : undefined;
            inputs["responseObjects"] = args ? args.responseObjects : undefined;
            inputs["s3loggings"] = args ? args.s3loggings : undefined;
            inputs["snippets"] = args ? args.snippets : undefined;
            inputs["splunks"] = args ? args.splunks : undefined;
            inputs["sumologics"] = args ? args.sumologics : undefined;
            inputs["syslogs"] = args ? args.syslogs : undefined;
            inputs["vcls"] = args ? args.vcls : undefined;
            inputs["versionComment"] = args ? args.versionComment : undefined;
            inputs["activeVersion"] = undefined /*out*/;
            inputs["clonedVersion"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(Servicev1.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Servicev1 resources.
 */
export interface Servicev1State {
    /**
     * A set of ACL configuration blocks.  Defined below.
     */
    readonly acls?: pulumi.Input<pulumi.Input<inputs.Servicev1Acl>[]>;
    /**
     * Conditionally prevents the Service from being activated. The apply step will continue to create a new draft version but will not activate it if this is set to false. Default true.
     */
    readonly activate?: pulumi.Input<boolean>;
    /**
     * The currently active version of your Fastly Service.
     */
    readonly activeVersion?: pulumi.Input<number>;
    /**
     * A set of Backends to service requests from your Domains.
     * Defined below. Backends must be defined in this argument, or defined in the
     * `vcl` argument below
     */
    readonly backends?: pulumi.Input<pulumi.Input<inputs.Servicev1Backend>[]>;
    /**
     * A BigQuery endpoint to send streaming logs too.
     * Defined below.
     */
    readonly bigqueryloggings?: pulumi.Input<pulumi.Input<inputs.Servicev1Bigquerylogging>[]>;
    /**
     * An Azure Blob Storage endpoint to send streaming logs too.
     * Defined below.
     */
    readonly blobstorageloggings?: pulumi.Input<pulumi.Input<inputs.Servicev1Blobstoragelogging>[]>;
    /**
     * A set of Cache Settings, allowing you to override
     */
    readonly cacheSettings?: pulumi.Input<pulumi.Input<inputs.Servicev1CacheSetting>[]>;
    /**
     * The latest cloned version by the provider. The value gets only set after running `pulumi up`.
     */
    readonly clonedVersion?: pulumi.Input<number>;
    /**
     * An optional comment about the Director.
     */
    readonly comment?: pulumi.Input<string>;
    /**
     * A set of conditions to add logic to any basic
     * configuration object in this service. Defined below.
     */
    readonly conditions?: pulumi.Input<pulumi.Input<inputs.Servicev1Condition>[]>;
    /**
     * Sets the host header.
     */
    readonly defaultHost?: pulumi.Input<string>;
    /**
     * The default Time-to-live (TTL) for
     * requests.
     */
    readonly defaultTtl?: pulumi.Input<number>;
    /**
     * A set of dictionaries that allow the storing of key values pair for use within VCL functions. Defined below.
     */
    readonly dictionaries?: pulumi.Input<pulumi.Input<inputs.Servicev1Dictionary>[]>;
    /**
     * A director to allow more control over balancing traffic over backends.
     * when an item is not to be cached based on an above `condition`. Defined below
     */
    readonly directors?: pulumi.Input<pulumi.Input<inputs.Servicev1Director>[]>;
    /**
     * If you created the S3 bucket outside of `us-east-1`,
     * then specify the corresponding bucket endpoint. Example: `s3-us-west-2.amazonaws.com`.
     */
    readonly domains?: pulumi.Input<pulumi.Input<inputs.Servicev1Domain>[]>;
    /**
     * A set of custom, "dynamic" VCL Snippet configuration blocks.  Defined below.
     */
    readonly dynamicsnippets?: pulumi.Input<pulumi.Input<inputs.Servicev1Dynamicsnippet>[]>;
    /**
     * Services that are active cannot be destroyed. In
     * order to destroy the Service, set `forceDestroy` to `true`. Default `false`.
     */
    readonly forceDestroy?: pulumi.Input<boolean>;
    /**
     * A gcs endpoint to send streaming logs too.
     * Defined below.
     */
    readonly gcsloggings?: pulumi.Input<pulumi.Input<inputs.Servicev1Gcslogging>[]>;
    /**
     * A set of gzip rules to control automatic gzipping of
     * content. Defined below.
     */
    readonly gzips?: pulumi.Input<pulumi.Input<inputs.Servicev1Gzip>[]>;
    /**
     * A set of Headers to manipulate for each request. Defined
     * below.
     */
    readonly headers?: pulumi.Input<pulumi.Input<inputs.Servicev1Header>[]>;
    /**
     * Name of a defined `healthcheck` to assign to this backend.
     */
    readonly healthchecks?: pulumi.Input<pulumi.Input<inputs.Servicev1Healthcheck>[]>;
    /**
     * An HTTPS endpoint to send streaming logs to.
     * Defined below.
     */
    readonly httpsloggings?: pulumi.Input<pulumi.Input<inputs.Servicev1Httpslogging>[]>;
    /**
     * A logentries endpoint to send streaming logs too.
     * Defined below.
     */
    readonly logentries?: pulumi.Input<pulumi.Input<inputs.Servicev1Logentry>[]>;
    /**
     * A Datadog endpoint to send streaming logs to.
     * Defined below.
     */
    readonly loggingDatadogs?: pulumi.Input<pulumi.Input<inputs.Servicev1LoggingDatadog>[]>;
    /**
     * An Elasticsearch endpoint to send streaming logs to.
     * Defined below.
     */
    readonly loggingElasticsearches?: pulumi.Input<pulumi.Input<inputs.Servicev1LoggingElasticsearch>[]>;
    /**
     * An FTP endpoint to send streaming logs to.
     * Defined below.
     */
    readonly loggingFtps?: pulumi.Input<pulumi.Input<inputs.Servicev1LoggingFtp>[]>;
    /**
     * A Google Cloud Pub/Sub endpoint to send streaming logs to.
     * Defined below.
     */
    readonly loggingGooglepubsubs?: pulumi.Input<pulumi.Input<inputs.Servicev1LoggingGooglepubsub>[]>;
    /**
     * A Kafka endpoint to send streaming logs to.
     * Defined below.
     */
    readonly loggingKafkas?: pulumi.Input<pulumi.Input<inputs.Servicev1LoggingKafka>[]>;
    /**
     * A Loggly endpoint to send streaming logs to.
     * Defined below.
     */
    readonly loggingLogglies?: pulumi.Input<pulumi.Input<inputs.Servicev1LoggingLoggly>[]>;
    /**
     * A New Relic endpoint to send streaming logs to.
     * Defined below.
     */
    readonly loggingNewrelics?: pulumi.Input<pulumi.Input<inputs.Servicev1LoggingNewrelic>[]>;
    /**
     * A Scalyr endpoint to send streaming logs to.
     * Defined below.
     */
    readonly loggingScalyrs?: pulumi.Input<pulumi.Input<inputs.Servicev1LoggingScalyr>[]>;
    /**
     * An SFTP endpoint to send streaming logs to.
     * Defined below.
     */
    readonly loggingSftps?: pulumi.Input<pulumi.Input<inputs.Servicev1LoggingSftp>[]>;
    /**
     * A unique name to identify this dictionary.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * A Papertrail endpoint to send streaming logs too.
     * Defined below.
     */
    readonly papertrails?: pulumi.Input<pulumi.Input<inputs.Servicev1Papertrail>[]>;
    /**
     * A set of Request modifiers. Defined below
     */
    readonly requestSettings?: pulumi.Input<pulumi.Input<inputs.Servicev1RequestSetting>[]>;
    /**
     * Allows you to create synthetic responses that exist entirely on the varnish machine. Useful for creating error or maintenance pages that exists outside the scope of your datacenter. Best when used with Condition objects.
     */
    readonly responseObjects?: pulumi.Input<pulumi.Input<inputs.Servicev1ResponseObject>[]>;
    /**
     * A set of S3 Buckets to send streaming logs too.
     * Defined below.
     */
    readonly s3loggings?: pulumi.Input<pulumi.Input<inputs.Servicev1S3logging>[]>;
    /**
     * A set of custom, "regular" (non-dynamic) VCL Snippet configuration blocks.  Defined below.
     */
    readonly snippets?: pulumi.Input<pulumi.Input<inputs.Servicev1Snippet>[]>;
    /**
     * A Splunk endpoint to send streaming logs too.
     * Defined below.
     */
    readonly splunks?: pulumi.Input<pulumi.Input<inputs.Servicev1Splunk>[]>;
    /**
     * A Sumologic endpoint to send streaming logs too.
     * Defined below.
     */
    readonly sumologics?: pulumi.Input<pulumi.Input<inputs.Servicev1Sumologic>[]>;
    /**
     * A syslog endpoint to send streaming logs too.
     * Defined below.
     */
    readonly syslogs?: pulumi.Input<pulumi.Input<inputs.Servicev1Syslog>[]>;
    /**
     * A set of custom VCL configuration blocks. See the [Fastly documentation](https://docs.fastly.com/vcl/custom-vcl/uploading-custom-vcl/) for more information on using custom VCL.
     */
    readonly vcls?: pulumi.Input<pulumi.Input<inputs.Servicev1Vcl>[]>;
    /**
     * Description field for the version.
     */
    readonly versionComment?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Servicev1 resource.
 */
export interface Servicev1Args {
    /**
     * A set of ACL configuration blocks.  Defined below.
     */
    readonly acls?: pulumi.Input<pulumi.Input<inputs.Servicev1Acl>[]>;
    /**
     * Conditionally prevents the Service from being activated. The apply step will continue to create a new draft version but will not activate it if this is set to false. Default true.
     */
    readonly activate?: pulumi.Input<boolean>;
    /**
     * A set of Backends to service requests from your Domains.
     * Defined below. Backends must be defined in this argument, or defined in the
     * `vcl` argument below
     */
    readonly backends?: pulumi.Input<pulumi.Input<inputs.Servicev1Backend>[]>;
    /**
     * A BigQuery endpoint to send streaming logs too.
     * Defined below.
     */
    readonly bigqueryloggings?: pulumi.Input<pulumi.Input<inputs.Servicev1Bigquerylogging>[]>;
    /**
     * An Azure Blob Storage endpoint to send streaming logs too.
     * Defined below.
     */
    readonly blobstorageloggings?: pulumi.Input<pulumi.Input<inputs.Servicev1Blobstoragelogging>[]>;
    /**
     * A set of Cache Settings, allowing you to override
     */
    readonly cacheSettings?: pulumi.Input<pulumi.Input<inputs.Servicev1CacheSetting>[]>;
    /**
     * An optional comment about the Director.
     */
    readonly comment?: pulumi.Input<string>;
    /**
     * A set of conditions to add logic to any basic
     * configuration object in this service. Defined below.
     */
    readonly conditions?: pulumi.Input<pulumi.Input<inputs.Servicev1Condition>[]>;
    /**
     * Sets the host header.
     */
    readonly defaultHost?: pulumi.Input<string>;
    /**
     * The default Time-to-live (TTL) for
     * requests.
     */
    readonly defaultTtl?: pulumi.Input<number>;
    /**
     * A set of dictionaries that allow the storing of key values pair for use within VCL functions. Defined below.
     */
    readonly dictionaries?: pulumi.Input<pulumi.Input<inputs.Servicev1Dictionary>[]>;
    /**
     * A director to allow more control over balancing traffic over backends.
     * when an item is not to be cached based on an above `condition`. Defined below
     */
    readonly directors?: pulumi.Input<pulumi.Input<inputs.Servicev1Director>[]>;
    /**
     * If you created the S3 bucket outside of `us-east-1`,
     * then specify the corresponding bucket endpoint. Example: `s3-us-west-2.amazonaws.com`.
     */
    readonly domains: pulumi.Input<pulumi.Input<inputs.Servicev1Domain>[]>;
    /**
     * A set of custom, "dynamic" VCL Snippet configuration blocks.  Defined below.
     */
    readonly dynamicsnippets?: pulumi.Input<pulumi.Input<inputs.Servicev1Dynamicsnippet>[]>;
    /**
     * Services that are active cannot be destroyed. In
     * order to destroy the Service, set `forceDestroy` to `true`. Default `false`.
     */
    readonly forceDestroy?: pulumi.Input<boolean>;
    /**
     * A gcs endpoint to send streaming logs too.
     * Defined below.
     */
    readonly gcsloggings?: pulumi.Input<pulumi.Input<inputs.Servicev1Gcslogging>[]>;
    /**
     * A set of gzip rules to control automatic gzipping of
     * content. Defined below.
     */
    readonly gzips?: pulumi.Input<pulumi.Input<inputs.Servicev1Gzip>[]>;
    /**
     * A set of Headers to manipulate for each request. Defined
     * below.
     */
    readonly headers?: pulumi.Input<pulumi.Input<inputs.Servicev1Header>[]>;
    /**
     * Name of a defined `healthcheck` to assign to this backend.
     */
    readonly healthchecks?: pulumi.Input<pulumi.Input<inputs.Servicev1Healthcheck>[]>;
    /**
     * An HTTPS endpoint to send streaming logs to.
     * Defined below.
     */
    readonly httpsloggings?: pulumi.Input<pulumi.Input<inputs.Servicev1Httpslogging>[]>;
    /**
     * A logentries endpoint to send streaming logs too.
     * Defined below.
     */
    readonly logentries?: pulumi.Input<pulumi.Input<inputs.Servicev1Logentry>[]>;
    /**
     * A Datadog endpoint to send streaming logs to.
     * Defined below.
     */
    readonly loggingDatadogs?: pulumi.Input<pulumi.Input<inputs.Servicev1LoggingDatadog>[]>;
    /**
     * An Elasticsearch endpoint to send streaming logs to.
     * Defined below.
     */
    readonly loggingElasticsearches?: pulumi.Input<pulumi.Input<inputs.Servicev1LoggingElasticsearch>[]>;
    /**
     * An FTP endpoint to send streaming logs to.
     * Defined below.
     */
    readonly loggingFtps?: pulumi.Input<pulumi.Input<inputs.Servicev1LoggingFtp>[]>;
    /**
     * A Google Cloud Pub/Sub endpoint to send streaming logs to.
     * Defined below.
     */
    readonly loggingGooglepubsubs?: pulumi.Input<pulumi.Input<inputs.Servicev1LoggingGooglepubsub>[]>;
    /**
     * A Kafka endpoint to send streaming logs to.
     * Defined below.
     */
    readonly loggingKafkas?: pulumi.Input<pulumi.Input<inputs.Servicev1LoggingKafka>[]>;
    /**
     * A Loggly endpoint to send streaming logs to.
     * Defined below.
     */
    readonly loggingLogglies?: pulumi.Input<pulumi.Input<inputs.Servicev1LoggingLoggly>[]>;
    /**
     * A New Relic endpoint to send streaming logs to.
     * Defined below.
     */
    readonly loggingNewrelics?: pulumi.Input<pulumi.Input<inputs.Servicev1LoggingNewrelic>[]>;
    /**
     * A Scalyr endpoint to send streaming logs to.
     * Defined below.
     */
    readonly loggingScalyrs?: pulumi.Input<pulumi.Input<inputs.Servicev1LoggingScalyr>[]>;
    /**
     * An SFTP endpoint to send streaming logs to.
     * Defined below.
     */
    readonly loggingSftps?: pulumi.Input<pulumi.Input<inputs.Servicev1LoggingSftp>[]>;
    /**
     * A unique name to identify this dictionary.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * A Papertrail endpoint to send streaming logs too.
     * Defined below.
     */
    readonly papertrails?: pulumi.Input<pulumi.Input<inputs.Servicev1Papertrail>[]>;
    /**
     * A set of Request modifiers. Defined below
     */
    readonly requestSettings?: pulumi.Input<pulumi.Input<inputs.Servicev1RequestSetting>[]>;
    /**
     * Allows you to create synthetic responses that exist entirely on the varnish machine. Useful for creating error or maintenance pages that exists outside the scope of your datacenter. Best when used with Condition objects.
     */
    readonly responseObjects?: pulumi.Input<pulumi.Input<inputs.Servicev1ResponseObject>[]>;
    /**
     * A set of S3 Buckets to send streaming logs too.
     * Defined below.
     */
    readonly s3loggings?: pulumi.Input<pulumi.Input<inputs.Servicev1S3logging>[]>;
    /**
     * A set of custom, "regular" (non-dynamic) VCL Snippet configuration blocks.  Defined below.
     */
    readonly snippets?: pulumi.Input<pulumi.Input<inputs.Servicev1Snippet>[]>;
    /**
     * A Splunk endpoint to send streaming logs too.
     * Defined below.
     */
    readonly splunks?: pulumi.Input<pulumi.Input<inputs.Servicev1Splunk>[]>;
    /**
     * A Sumologic endpoint to send streaming logs too.
     * Defined below.
     */
    readonly sumologics?: pulumi.Input<pulumi.Input<inputs.Servicev1Sumologic>[]>;
    /**
     * A syslog endpoint to send streaming logs too.
     * Defined below.
     */
    readonly syslogs?: pulumi.Input<pulumi.Input<inputs.Servicev1Syslog>[]>;
    /**
     * A set of custom VCL configuration blocks. See the [Fastly documentation](https://docs.fastly.com/vcl/custom-vcl/uploading-custom-vcl/) for more information on using custom VCL.
     */
    readonly vcls?: pulumi.Input<pulumi.Input<inputs.Servicev1Vcl>[]>;
    /**
     * Description field for the version.
     */
    readonly versionComment?: pulumi.Input<string>;
}
