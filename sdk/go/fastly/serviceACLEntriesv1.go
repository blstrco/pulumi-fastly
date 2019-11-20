// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package fastly

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// > This content is derived from https://github.com/terraform-providers/terraform-provider-fastly/blob/master/website/docs/r/service_acl_entries_v1.html.markdown.
type ServiceACLEntriesv1 struct {
	s *pulumi.ResourceState
}

// NewServiceACLEntriesv1 registers a new resource with the given unique name, arguments, and options.
func NewServiceACLEntriesv1(ctx *pulumi.Context,
	name string, args *ServiceACLEntriesv1Args, opts ...pulumi.ResourceOpt) (*ServiceACLEntriesv1, error) {
	if args == nil || args.AclId == nil {
		return nil, errors.New("missing required argument 'AclId'")
	}
	if args == nil || args.ServiceId == nil {
		return nil, errors.New("missing required argument 'ServiceId'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["aclId"] = nil
		inputs["entries"] = nil
		inputs["serviceId"] = nil
	} else {
		inputs["aclId"] = args.AclId
		inputs["entries"] = args.Entries
		inputs["serviceId"] = args.ServiceId
	}
	s, err := ctx.RegisterResource("fastly:index/serviceACLEntriesv1:ServiceACLEntriesv1", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &ServiceACLEntriesv1{s: s}, nil
}

// GetServiceACLEntriesv1 gets an existing ServiceACLEntriesv1 resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetServiceACLEntriesv1(ctx *pulumi.Context,
	name string, id pulumi.ID, state *ServiceACLEntriesv1State, opts ...pulumi.ResourceOpt) (*ServiceACLEntriesv1, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["aclId"] = state.AclId
		inputs["entries"] = state.Entries
		inputs["serviceId"] = state.ServiceId
	}
	s, err := ctx.ReadResource("fastly:index/serviceACLEntriesv1:ServiceACLEntriesv1", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &ServiceACLEntriesv1{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *ServiceACLEntriesv1) URN() *pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *ServiceACLEntriesv1) ID() *pulumi.IDOutput {
	return r.s.ID()
}

// The ID of the ACL that the items belong to
func (r *ServiceACLEntriesv1) AclId() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["aclId"])
}

// A Set ACL entries that are applied to the service. Defined below
func (r *ServiceACLEntriesv1) Entries() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["entries"])
}

// The ID of the Service that the ACL belongs to
func (r *ServiceACLEntriesv1) ServiceId() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["serviceId"])
}

// Input properties used for looking up and filtering ServiceACLEntriesv1 resources.
type ServiceACLEntriesv1State struct {
	// The ID of the ACL that the items belong to
	AclId interface{}
	// A Set ACL entries that are applied to the service. Defined below
	Entries interface{}
	// The ID of the Service that the ACL belongs to
	ServiceId interface{}
}

// The set of arguments for constructing a ServiceACLEntriesv1 resource.
type ServiceACLEntriesv1Args struct {
	// The ID of the ACL that the items belong to
	AclId interface{}
	// A Set ACL entries that are applied to the service. Defined below
	Entries interface{}
	// The ID of the Service that the ACL belongs to
	ServiceId interface{}
}
