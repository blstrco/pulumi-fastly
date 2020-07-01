// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package fastly

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Use this data source to get the [IP ranges](https://docs.fastly.com/guides/securing-communications/accessing-fastlys-ip-ranges) of Fastly edge nodes.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-aws/sdk/v2/go/aws/ec2"
// 	"github.com/pulumi/pulumi-fastly/sdk/v2/go/fastly"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		fastly, err := fastly.GetFastlyIpRanges(ctx, nil, nil)
// 		if err != nil {
// 			return err
// 		}
// 		_, err = ec2.NewSecurityGroup(ctx, "fromFastly", &ec2.SecurityGroupArgs{
// 			Ingress: ec2.SecurityGroupIngressArray{
// 				&ec2.SecurityGroupIngressArgs{
// 					CidrBlocks:     toPulumiStringArray(fastly.CidrBlocks),
// 					FromPort:       pulumi.Int(443),
// 					Ipv6CidrBlocks: toPulumiStringArray(fastly.Ipv6CidrBlocks),
// 					Protocol:       pulumi.String("tcp"),
// 					ToPort:         pulumi.Int(443),
// 				},
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// func toPulumiStringArray(arr []string) pulumi.StringArray {
// 	var pulumiArr pulumi.StringArray
// 	for _, v := range arr {
// 		pulumiArr = append(pulumiArr, pulumi.String(v))
// 	}
// 	return pulumiArr
// }
// ```
func GetFastlyIpRanges(ctx *pulumi.Context, opts ...pulumi.InvokeOption) (*GetFastlyIpRangesResult, error) {
	var rv GetFastlyIpRangesResult
	err := ctx.Invoke("fastly:index/getFastlyIpRanges:getFastlyIpRanges", nil, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of values returned by getFastlyIpRanges.
type GetFastlyIpRangesResult struct {
	// The lexically ordered list of ipv4 CIDR blocks.
	CidrBlocks []string `pulumi:"cidrBlocks"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// The lexically ordered list of ipv6 CIDR blocks.
	Ipv6CidrBlocks []string `pulumi:"ipv6CidrBlocks"`
}
