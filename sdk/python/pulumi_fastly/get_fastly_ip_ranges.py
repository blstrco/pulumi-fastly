# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from . import utilities, tables

class GetFastlyIpRangesResult:
    """
    A collection of values returned by getFastlyIpRanges.
    """
    def __init__(__self__, cidr_blocks=None, id=None):
        if cidr_blocks and not isinstance(cidr_blocks, list):
            raise TypeError("Expected argument 'cidr_blocks' to be a list")
        __self__.cidr_blocks = cidr_blocks
        """
        The lexically ordered list of CIDR blocks.
        """
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        __self__.id = id
        """
        The provider-assigned unique ID for this managed resource.
        """
class AwaitableGetFastlyIpRangesResult(GetFastlyIpRangesResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetFastlyIpRangesResult(
            cidr_blocks=self.cidr_blocks,
            id=self.id)

def get_fastly_ip_ranges(opts=None):
    """
    Use this data source to get the [IP ranges](https://docs.fastly.com/guides/securing-communications/accessing-fastlys-ip-ranges) of Fastly edge nodes.

    ## Example Usage



    ```python
    import pulumi
    import pulumi_aws as aws
    import pulumi_fastly as fastly

    fastly = fastly.get_fastly_ip_ranges()
    from_fastly = aws.ec2.SecurityGroup("fromFastly", ingress=[{
        "cidr_blocks": fastly.cidr_blocks,
        "from_port": "443",
        "protocol": "tcp",
        "to_port": "443",
    }])
    ```
    """
    __args__ = dict()


    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = utilities.get_version()
    __ret__ = pulumi.runtime.invoke('fastly:index/getFastlyIpRanges:getFastlyIpRanges', __args__, opts=opts).value

    return AwaitableGetFastlyIpRangesResult(
        cidr_blocks=__ret__.get('cidrBlocks'),
        id=__ret__.get('id'))
