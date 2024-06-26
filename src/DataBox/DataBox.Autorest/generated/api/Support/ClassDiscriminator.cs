// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support
{

    /// <summary>Indicates the type of job details.</summary>
    public partial struct ClassDiscriminator :
        System.IEquatable<ClassDiscriminator>
    {
        /// <summary>Data Box orders.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ClassDiscriminator DataBox = @"DataBox";

        /// <summary>Data Box Customer Disk orders.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ClassDiscriminator DataBoxCustomerDisk = @"DataBoxCustomerDisk";

        /// <summary>Data Box Disk orders.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ClassDiscriminator DataBoxDisk = @"DataBoxDisk";

        /// <summary>Data Box Heavy orders.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ClassDiscriminator DataBoxHeavy = @"DataBoxHeavy";

        /// <summary>the value for an instance of the <see cref="ClassDiscriminator" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Creates an instance of the <see cref="ClassDiscriminator"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ClassDiscriminator(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to ClassDiscriminator</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ClassDiscriminator" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ClassDiscriminator(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ClassDiscriminator</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ClassDiscriminator e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ClassDiscriminator (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ClassDiscriminator && Equals((ClassDiscriminator)obj);
        }

        /// <summary>Returns hashCode for enum ClassDiscriminator</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for ClassDiscriminator</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ClassDiscriminator</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ClassDiscriminator" />.</param>

        public static implicit operator ClassDiscriminator(string value)
        {
            return new ClassDiscriminator(value);
        }

        /// <summary>Implicit operator to convert ClassDiscriminator to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ClassDiscriminator" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ClassDiscriminator e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ClassDiscriminator</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ClassDiscriminator e1, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ClassDiscriminator e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ClassDiscriminator</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ClassDiscriminator e1, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ClassDiscriminator e2)
        {
            return e2.Equals(e1);
        }
    }
}