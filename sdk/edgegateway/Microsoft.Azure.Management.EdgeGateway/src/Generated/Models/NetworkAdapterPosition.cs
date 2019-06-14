// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EdgeGateway.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The network adapter position.
    /// </summary>
    public partial class NetworkAdapterPosition
    {
        /// <summary>
        /// Initializes a new instance of the NetworkAdapterPosition class.
        /// </summary>
        public NetworkAdapterPosition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NetworkAdapterPosition class.
        /// </summary>
        /// <param name="networkGroup">The network group. Possible values
        /// include: 'None', 'NonRDMA', 'RDMA'</param>
        /// <param name="port">The port.</param>
        public NetworkAdapterPosition(string networkGroup = default(string), int? port = default(int?))
        {
            NetworkGroup = networkGroup;
            Port = port;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the network group. Possible values include: 'None', 'NonRDMA',
        /// 'RDMA'
        /// </summary>
        [JsonProperty(PropertyName = "networkGroup")]
        public string NetworkGroup { get; private set; }

        /// <summary>
        /// Gets the port.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int? Port { get; private set; }

    }
}