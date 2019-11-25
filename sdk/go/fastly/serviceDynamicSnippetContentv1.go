// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package fastly

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// > This content is derived from https://github.com/terraform-providers/terraform-provider-fastly/blob/master/website/docs/r/service_dynamic_snippet_content_v1.html.markdown.
type ServiceDynamicSnippetContentv1 struct {
	s *pulumi.ResourceState
}

// NewServiceDynamicSnippetContentv1 registers a new resource with the given unique name, arguments, and options.
func NewServiceDynamicSnippetContentv1(ctx *pulumi.Context,
	name string, args *ServiceDynamicSnippetContentv1Args, opts ...pulumi.ResourceOpt) (*ServiceDynamicSnippetContentv1, error) {
	if args == nil || args.Content == nil {
		return nil, errors.New("missing required argument 'Content'")
	}
	if args == nil || args.ServiceId == nil {
		return nil, errors.New("missing required argument 'ServiceId'")
	}
	if args == nil || args.SnippetId == nil {
		return nil, errors.New("missing required argument 'SnippetId'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["content"] = nil
		inputs["serviceId"] = nil
		inputs["snippetId"] = nil
	} else {
		inputs["content"] = args.Content
		inputs["serviceId"] = args.ServiceId
		inputs["snippetId"] = args.SnippetId
	}
	s, err := ctx.RegisterResource("fastly:index/serviceDynamicSnippetContentv1:ServiceDynamicSnippetContentv1", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &ServiceDynamicSnippetContentv1{s: s}, nil
}

// GetServiceDynamicSnippetContentv1 gets an existing ServiceDynamicSnippetContentv1 resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetServiceDynamicSnippetContentv1(ctx *pulumi.Context,
	name string, id pulumi.ID, state *ServiceDynamicSnippetContentv1State, opts ...pulumi.ResourceOpt) (*ServiceDynamicSnippetContentv1, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["content"] = state.Content
		inputs["serviceId"] = state.ServiceId
		inputs["snippetId"] = state.SnippetId
	}
	s, err := ctx.ReadResource("fastly:index/serviceDynamicSnippetContentv1:ServiceDynamicSnippetContentv1", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &ServiceDynamicSnippetContentv1{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *ServiceDynamicSnippetContentv1) URN() pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *ServiceDynamicSnippetContentv1) ID() pulumi.IDOutput {
	return r.s.ID()
}

// The VCL code that specifies exactly what the snippet does.
func (r *ServiceDynamicSnippetContentv1) Content() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["content"])
}

// The ID of the service that the dynamic snippet belongs to
func (r *ServiceDynamicSnippetContentv1) ServiceId() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["serviceId"])
}

// The ID of the dynamic snippet that the content belong to
func (r *ServiceDynamicSnippetContentv1) SnippetId() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["snippetId"])
}

// Input properties used for looking up and filtering ServiceDynamicSnippetContentv1 resources.
type ServiceDynamicSnippetContentv1State struct {
	// The VCL code that specifies exactly what the snippet does.
	Content interface{}
	// The ID of the service that the dynamic snippet belongs to
	ServiceId interface{}
	// The ID of the dynamic snippet that the content belong to
	SnippetId interface{}
}

// The set of arguments for constructing a ServiceDynamicSnippetContentv1 resource.
type ServiceDynamicSnippetContentv1Args struct {
	// The VCL code that specifies exactly what the snippet does.
	Content interface{}
	// The ID of the service that the dynamic snippet belongs to
	ServiceId interface{}
	// The ID of the dynamic snippet that the content belong to
	SnippetId interface{}
}
