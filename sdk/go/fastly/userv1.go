// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package fastly

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides a Fastly User, representing the configuration for a user account for interacting with Fastly.
//
// The User resource requires a login and name, and optionally a role.
type Userv1 struct {
	pulumi.CustomResourceState

	// The email address, which is the login name, of the User.
	Login pulumi.StringOutput `pulumi:"login"`
	// The real life name of the user.
	Name pulumi.StringOutput `pulumi:"name"`
	// The role of this user. Can be `user` (the default), `billing`, `engineer`, or `superuser`. For detailed information on the abilities granted to each role, see [Fastly's Documentation on User roles](https://docs.fastly.com/en/guides/configuring-user-roles-and-permissions#user-roles-and-what-they-can-do).
	Role pulumi.StringPtrOutput `pulumi:"role"`
}

// NewUserv1 registers a new resource with the given unique name, arguments, and options.
func NewUserv1(ctx *pulumi.Context,
	name string, args *Userv1Args, opts ...pulumi.ResourceOption) (*Userv1, error) {
	if args == nil || args.Login == nil {
		return nil, errors.New("missing required argument 'Login'")
	}
	if args == nil {
		args = &Userv1Args{}
	}
	var resource Userv1
	err := ctx.RegisterResource("fastly:index/userv1:Userv1", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetUserv1 gets an existing Userv1 resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetUserv1(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *Userv1State, opts ...pulumi.ResourceOption) (*Userv1, error) {
	var resource Userv1
	err := ctx.ReadResource("fastly:index/userv1:Userv1", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Userv1 resources.
type userv1State struct {
	// The email address, which is the login name, of the User.
	Login *string `pulumi:"login"`
	// The real life name of the user.
	Name *string `pulumi:"name"`
	// The role of this user. Can be `user` (the default), `billing`, `engineer`, or `superuser`. For detailed information on the abilities granted to each role, see [Fastly's Documentation on User roles](https://docs.fastly.com/en/guides/configuring-user-roles-and-permissions#user-roles-and-what-they-can-do).
	Role *string `pulumi:"role"`
}

type Userv1State struct {
	// The email address, which is the login name, of the User.
	Login pulumi.StringPtrInput
	// The real life name of the user.
	Name pulumi.StringPtrInput
	// The role of this user. Can be `user` (the default), `billing`, `engineer`, or `superuser`. For detailed information on the abilities granted to each role, see [Fastly's Documentation on User roles](https://docs.fastly.com/en/guides/configuring-user-roles-and-permissions#user-roles-and-what-they-can-do).
	Role pulumi.StringPtrInput
}

func (Userv1State) ElementType() reflect.Type {
	return reflect.TypeOf((*userv1State)(nil)).Elem()
}

type userv1Args struct {
	// The email address, which is the login name, of the User.
	Login string `pulumi:"login"`
	// The real life name of the user.
	Name *string `pulumi:"name"`
	// The role of this user. Can be `user` (the default), `billing`, `engineer`, or `superuser`. For detailed information on the abilities granted to each role, see [Fastly's Documentation on User roles](https://docs.fastly.com/en/guides/configuring-user-roles-and-permissions#user-roles-and-what-they-can-do).
	Role *string `pulumi:"role"`
}

// The set of arguments for constructing a Userv1 resource.
type Userv1Args struct {
	// The email address, which is the login name, of the User.
	Login pulumi.StringInput
	// The real life name of the user.
	Name pulumi.StringPtrInput
	// The role of this user. Can be `user` (the default), `billing`, `engineer`, or `superuser`. For detailed information on the abilities granted to each role, see [Fastly's Documentation on User roles](https://docs.fastly.com/en/guides/configuring-user-roles-and-permissions#user-roles-and-what-they-can-do).
	Role pulumi.StringPtrInput
}

func (Userv1Args) ElementType() reflect.Type {
	return reflect.TypeOf((*userv1Args)(nil)).Elem()
}
