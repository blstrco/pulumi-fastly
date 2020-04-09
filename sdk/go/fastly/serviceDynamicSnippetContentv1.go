// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package fastly

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type ServiceDynamicSnippetContentv1 struct {
	pulumi.CustomResourceState

	// The VCL code that specifies exactly what the snippet does.
	Content pulumi.StringOutput `pulumi:"content"`
	// The ID of the service that the dynamic snippet belongs to
	ServiceId pulumi.StringOutput `pulumi:"serviceId"`
	// The ID of the dynamic snippet that the content belong to
	SnippetId pulumi.StringOutput `pulumi:"snippetId"`
}

// NewServiceDynamicSnippetContentv1 registers a new resource with the given unique name, arguments, and options.
func NewServiceDynamicSnippetContentv1(ctx *pulumi.Context,
	name string, args *ServiceDynamicSnippetContentv1Args, opts ...pulumi.ResourceOption) (*ServiceDynamicSnippetContentv1, error) {
	if args == nil || args.Content == nil {
		return nil, errors.New("missing required argument 'Content'")
	}
	if args == nil || args.ServiceId == nil {
		return nil, errors.New("missing required argument 'ServiceId'")
	}
	if args == nil || args.SnippetId == nil {
		return nil, errors.New("missing required argument 'SnippetId'")
	}
	if args == nil {
		args = &ServiceDynamicSnippetContentv1Args{}
	}
	var resource ServiceDynamicSnippetContentv1
	err := ctx.RegisterResource("fastly:index/serviceDynamicSnippetContentv1:ServiceDynamicSnippetContentv1", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetServiceDynamicSnippetContentv1 gets an existing ServiceDynamicSnippetContentv1 resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetServiceDynamicSnippetContentv1(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ServiceDynamicSnippetContentv1State, opts ...pulumi.ResourceOption) (*ServiceDynamicSnippetContentv1, error) {
	var resource ServiceDynamicSnippetContentv1
	err := ctx.ReadResource("fastly:index/serviceDynamicSnippetContentv1:ServiceDynamicSnippetContentv1", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ServiceDynamicSnippetContentv1 resources.
type serviceDynamicSnippetContentv1State struct {
	// The VCL code that specifies exactly what the snippet does.
	Content *string `pulumi:"content"`
	// The ID of the service that the dynamic snippet belongs to
	ServiceId *string `pulumi:"serviceId"`
	// The ID of the dynamic snippet that the content belong to
	SnippetId *string `pulumi:"snippetId"`
}

type ServiceDynamicSnippetContentv1State struct {
	// The VCL code that specifies exactly what the snippet does.
	Content pulumi.StringPtrInput
	// The ID of the service that the dynamic snippet belongs to
	ServiceId pulumi.StringPtrInput
	// The ID of the dynamic snippet that the content belong to
	SnippetId pulumi.StringPtrInput
}

func (ServiceDynamicSnippetContentv1State) ElementType() reflect.Type {
	return reflect.TypeOf((*serviceDynamicSnippetContentv1State)(nil)).Elem()
}

type serviceDynamicSnippetContentv1Args struct {
	// The VCL code that specifies exactly what the snippet does.
	Content string `pulumi:"content"`
	// The ID of the service that the dynamic snippet belongs to
	ServiceId string `pulumi:"serviceId"`
	// The ID of the dynamic snippet that the content belong to
	SnippetId string `pulumi:"snippetId"`
}

// The set of arguments for constructing a ServiceDynamicSnippetContentv1 resource.
type ServiceDynamicSnippetContentv1Args struct {
	// The VCL code that specifies exactly what the snippet does.
	Content pulumi.StringInput
	// The ID of the service that the dynamic snippet belongs to
	ServiceId pulumi.StringInput
	// The ID of the dynamic snippet that the content belong to
	SnippetId pulumi.StringInput
}

func (ServiceDynamicSnippetContentv1Args) ElementType() reflect.Type {
	return reflect.TypeOf((*serviceDynamicSnippetContentv1Args)(nil)).Elem()
}
