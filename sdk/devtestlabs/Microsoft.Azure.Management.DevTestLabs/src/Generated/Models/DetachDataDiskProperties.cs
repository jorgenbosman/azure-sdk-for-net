// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Request body for detaching data disk from a virtual machine.
    /// </summary>
    public partial class DetachDataDiskProperties
    {
        /// <summary>
        /// Initializes a new instance of the DetachDataDiskProperties class.
        /// </summary>
        public DetachDataDiskProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DetachDataDiskProperties class.
        /// </summary>
        /// <param name="existingLabDiskId">Specifies the disk resource ID to
        /// detach from virtual machine.</param>
        public DetachDataDiskProperties(string existingLabDiskId = default(string))
        {
            ExistingLabDiskId = existingLabDiskId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the disk resource ID to detach from virtual
        /// machine.
        /// </summary>
        [JsonProperty(PropertyName = "existingLabDiskId")]
        public string ExistingLabDiskId { get; set; }

    }
}