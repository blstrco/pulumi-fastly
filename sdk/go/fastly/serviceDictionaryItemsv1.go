// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package fastly

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type ServiceDictionaryItemsv1 struct {
	pulumi.CustomResourceState

	// The ID of the dictionary that the items belong to
	DictionaryId pulumi.StringOutput `pulumi:"dictionaryId"`
	// A map representing an entry in the dictionary, (key/value)
	Items pulumi.MapOutput `pulumi:"items"`
	// The ID of the service that the dictionary belongs to
	ServiceId pulumi.StringOutput `pulumi:"serviceId"`
}

// NewServiceDictionaryItemsv1 registers a new resource with the given unique name, arguments, and options.
func NewServiceDictionaryItemsv1(ctx *pulumi.Context,
	name string, args *ServiceDictionaryItemsv1Args, opts ...pulumi.ResourceOption) (*ServiceDictionaryItemsv1, error) {
	if args == nil || args.DictionaryId == nil {
		return nil, errors.New("missing required argument 'DictionaryId'")
	}
	if args == nil || args.ServiceId == nil {
		return nil, errors.New("missing required argument 'ServiceId'")
	}
	if args == nil {
		args = &ServiceDictionaryItemsv1Args{}
	}
	var resource ServiceDictionaryItemsv1
	err := ctx.RegisterResource("fastly:index/serviceDictionaryItemsv1:ServiceDictionaryItemsv1", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetServiceDictionaryItemsv1 gets an existing ServiceDictionaryItemsv1 resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetServiceDictionaryItemsv1(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ServiceDictionaryItemsv1State, opts ...pulumi.ResourceOption) (*ServiceDictionaryItemsv1, error) {
	var resource ServiceDictionaryItemsv1
	err := ctx.ReadResource("fastly:index/serviceDictionaryItemsv1:ServiceDictionaryItemsv1", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ServiceDictionaryItemsv1 resources.
type serviceDictionaryItemsv1State struct {
	// The ID of the dictionary that the items belong to
	DictionaryId *string `pulumi:"dictionaryId"`
	// A map representing an entry in the dictionary, (key/value)
	Items map[string]interface{} `pulumi:"items"`
	// The ID of the service that the dictionary belongs to
	ServiceId *string `pulumi:"serviceId"`
}

type ServiceDictionaryItemsv1State struct {
	// The ID of the dictionary that the items belong to
	DictionaryId pulumi.StringPtrInput
	// A map representing an entry in the dictionary, (key/value)
	Items pulumi.MapInput
	// The ID of the service that the dictionary belongs to
	ServiceId pulumi.StringPtrInput
}

func (ServiceDictionaryItemsv1State) ElementType() reflect.Type {
	return reflect.TypeOf((*serviceDictionaryItemsv1State)(nil)).Elem()
}

type serviceDictionaryItemsv1Args struct {
	// The ID of the dictionary that the items belong to
	DictionaryId string `pulumi:"dictionaryId"`
	// A map representing an entry in the dictionary, (key/value)
	Items map[string]interface{} `pulumi:"items"`
	// The ID of the service that the dictionary belongs to
	ServiceId string `pulumi:"serviceId"`
}

// The set of arguments for constructing a ServiceDictionaryItemsv1 resource.
type ServiceDictionaryItemsv1Args struct {
	// The ID of the dictionary that the items belong to
	DictionaryId pulumi.StringInput
	// A map representing an entry in the dictionary, (key/value)
	Items pulumi.MapInput
	// The ID of the service that the dictionary belongs to
	ServiceId pulumi.StringInput
}

func (ServiceDictionaryItemsv1Args) ElementType() reflect.Type {
	return reflect.TypeOf((*serviceDictionaryItemsv1Args)(nil)).Elem()
}
