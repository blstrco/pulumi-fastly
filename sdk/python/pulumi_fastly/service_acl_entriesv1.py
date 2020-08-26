# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Dict, List, Mapping, Optional, Tuple, Union
from . import _utilities, _tables
from . import outputs
from ._inputs import *

__all__ = ['ServiceACLEntriesv1']


class ServiceACLEntriesv1(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 acl_id: Optional[pulumi.Input[str]] = None,
                 entries: Optional[pulumi.Input[List[pulumi.Input[pulumi.InputType['ServiceACLEntriesv1EntryArgs']]]]] = None,
                 service_id: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Defines a set of Fastly ACL entries that can be used to populate a service ACL.  This resource will populate an ACL with the entries and will track their state.

        ## Example Usage
        ### Basic usage

        ```python
        import pulumi
        import pulumi_fastly as fastly

        config = pulumi.Config()
        myacl_name = config.get("myaclName")
        if myacl_name is None:
            myacl_name = "My ACL"
        myservice = fastly.Servicev1("myservice",
            domains=[fastly.Servicev1DomainArgs(
                name="demo.notexample.com",
                comment="demo",
            )],
            backends=[fastly.Servicev1BackendArgs(
                address="demo.notexample.com.s3-website-us-west-2.amazonaws.com",
                name="AWS S3 hosting",
                port=80,
            )],
            acls=[fastly.Servicev1AclArgs(
                name=myacl_name,
            )],
            force_destroy=True)
        entries = fastly.ServiceACLEntriesv1("entries",
            service_id=myservice.id,
            acl_id=myservice.acls.apply(lambda acls: {d.name: d.acl_id for d in acls}[myacl_name]),
            entries=[fastly.ServiceACLEntriesv1EntryArgs(
                ip="127.0.0.1",
                subnet="24",
                negated=False,
                comment="ALC Entry 1",
            )])
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] acl_id: The ID of the ACL that the items belong to
        :param pulumi.Input[List[pulumi.Input[pulumi.InputType['ServiceACLEntriesv1EntryArgs']]]] entries: A Set ACL entries that are applied to the service. Defined below
        :param pulumi.Input[str] service_id: The ID of the Service that the ACL belongs to
        """
        if __name__ is not None:
            warnings.warn("explicit use of __name__ is deprecated", DeprecationWarning)
            resource_name = __name__
        if __opts__ is not None:
            warnings.warn("explicit use of __opts__ is deprecated, use 'opts' instead", DeprecationWarning)
            opts = __opts__
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = dict()

            if acl_id is None:
                raise TypeError("Missing required property 'acl_id'")
            __props__['acl_id'] = acl_id
            __props__['entries'] = entries
            if service_id is None:
                raise TypeError("Missing required property 'service_id'")
            __props__['service_id'] = service_id
        super(ServiceACLEntriesv1, __self__).__init__(
            'fastly:index/serviceACLEntriesv1:ServiceACLEntriesv1',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            acl_id: Optional[pulumi.Input[str]] = None,
            entries: Optional[pulumi.Input[List[pulumi.Input[pulumi.InputType['ServiceACLEntriesv1EntryArgs']]]]] = None,
            service_id: Optional[pulumi.Input[str]] = None) -> 'ServiceACLEntriesv1':
        """
        Get an existing ServiceACLEntriesv1 resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] acl_id: The ID of the ACL that the items belong to
        :param pulumi.Input[List[pulumi.Input[pulumi.InputType['ServiceACLEntriesv1EntryArgs']]]] entries: A Set ACL entries that are applied to the service. Defined below
        :param pulumi.Input[str] service_id: The ID of the Service that the ACL belongs to
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["acl_id"] = acl_id
        __props__["entries"] = entries
        __props__["service_id"] = service_id
        return ServiceACLEntriesv1(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="aclId")
    def acl_id(self) -> str:
        """
        The ID of the ACL that the items belong to
        """
        return pulumi.get(self, "acl_id")

    @property
    @pulumi.getter
    def entries(self) -> Optional[List['outputs.ServiceACLEntriesv1Entry']]:
        """
        A Set ACL entries that are applied to the service. Defined below
        """
        return pulumi.get(self, "entries")

    @property
    @pulumi.getter(name="serviceId")
    def service_id(self) -> str:
        """
        The ID of the Service that the ACL belongs to
        """
        return pulumi.get(self, "service_id")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

