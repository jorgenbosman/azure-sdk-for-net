// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for VirtualMachineEvictionPolicyTypes.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(VirtualMachineEvictionPolicyTypesConverter))]
    public struct VirtualMachineEvictionPolicyTypes : System.IEquatable<VirtualMachineEvictionPolicyTypes>
    {
        private VirtualMachineEvictionPolicyTypes(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        public static readonly VirtualMachineEvictionPolicyTypes Deallocate = "Deallocate";

        public static readonly VirtualMachineEvictionPolicyTypes Delete = "Delete";


        /// <summary>
        /// Underlying value of enum VirtualMachineEvictionPolicyTypes
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for VirtualMachineEvictionPolicyTypes
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type VirtualMachineEvictionPolicyTypes
        /// </summary>
        public bool Equals(VirtualMachineEvictionPolicyTypes e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to
        /// VirtualMachineEvictionPolicyTypes
        /// </summary>
        public static implicit operator VirtualMachineEvictionPolicyTypes(string value)
        {
            return new VirtualMachineEvictionPolicyTypes(value);
        }

        /// <summary>
        /// Implicit operator to convert VirtualMachineEvictionPolicyTypes to
        /// string
        /// </summary>
        public static implicit operator string(VirtualMachineEvictionPolicyTypes e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum VirtualMachineEvictionPolicyTypes
        /// </summary>
        public static bool operator == (VirtualMachineEvictionPolicyTypes e1, VirtualMachineEvictionPolicyTypes e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum VirtualMachineEvictionPolicyTypes
        /// </summary>
        public static bool operator != (VirtualMachineEvictionPolicyTypes e1, VirtualMachineEvictionPolicyTypes e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for VirtualMachineEvictionPolicyTypes
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is VirtualMachineEvictionPolicyTypes && Equals((VirtualMachineEvictionPolicyTypes)obj);
        }

        /// <summary>
        /// Returns for hashCode VirtualMachineEvictionPolicyTypes
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}