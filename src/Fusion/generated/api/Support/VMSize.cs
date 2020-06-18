// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Wandisco.Fusion.Support
{

    public partial struct VMSize :
        System.IEquatable<VMSize>
    {
        /// <summary>Large fusion server, typical for replication/migration larger than 500TB</summary>
        public static Wandisco.Fusion.Support.VMSize Large = @"Large";

        /// <summary>Medium fusion server, typical for replication/migration 1-500TB.</summary>
        public static Wandisco.Fusion.Support.VMSize Medium = @"Medium";

        /// <summary>Small fusion server, typical for replication/migration less than 1TB.</summary>
        public static Wandisco.Fusion.Support.VMSize Small = @"Small";

        /// <summary>the value for an instance of the <see cref="VMSize" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to VMSize</summary>
        /// <param name="value">the value to convert to an instance of <see cref="VMSize" />.</param>
        internal static object CreateFrom(object value)
        {
            return new VMSize(System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type VMSize</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Wandisco.Fusion.Support.VMSize e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type VMSize (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is VMSize && Equals((VMSize)obj);
        }

        /// <summary>Returns hashCode for enum VMSize</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for VMSize</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Creates an instance of the <see cref="VMSize" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private VMSize(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Implicit operator to convert string to VMSize</summary>
        /// <param name="value">the value to convert to an instance of <see cref="VMSize" />.</param>

        public static implicit operator VMSize(string value)
        {
            return new VMSize(value);
        }

        /// <summary>Implicit operator to convert VMSize to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="VMSize" />.</param>

        public static implicit operator string(Wandisco.Fusion.Support.VMSize e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum VMSize</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Wandisco.Fusion.Support.VMSize e1, Wandisco.Fusion.Support.VMSize e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum VMSize</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Wandisco.Fusion.Support.VMSize e1, Wandisco.Fusion.Support.VMSize e2)
        {
            return e2.Equals(e1);
        }
    }
}