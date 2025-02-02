// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Fake.Models
{
    /// <summary> The private endpoint connection status. </summary>
    public readonly partial struct ReferenceTypesPrivateEndpointServiceConnectionStatus : IEquatable<ReferenceTypesPrivateEndpointServiceConnectionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ReferenceTypesPrivateEndpointServiceConnectionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ReferenceTypesPrivateEndpointServiceConnectionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "Pending";
        private const string ApprovedValue = "Approved";
        private const string RejectedValue = "Rejected";

        /// <summary> Pending. </summary>
        public static ReferenceTypesPrivateEndpointServiceConnectionStatus Pending { get; } = new ReferenceTypesPrivateEndpointServiceConnectionStatus(PendingValue);
        /// <summary> Approved. </summary>
        public static ReferenceTypesPrivateEndpointServiceConnectionStatus Approved { get; } = new ReferenceTypesPrivateEndpointServiceConnectionStatus(ApprovedValue);
        /// <summary> Rejected. </summary>
        public static ReferenceTypesPrivateEndpointServiceConnectionStatus Rejected { get; } = new ReferenceTypesPrivateEndpointServiceConnectionStatus(RejectedValue);
        /// <summary> Determines if two <see cref="ReferenceTypesPrivateEndpointServiceConnectionStatus"/> values are the same. </summary>
        public static bool operator ==(ReferenceTypesPrivateEndpointServiceConnectionStatus left, ReferenceTypesPrivateEndpointServiceConnectionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ReferenceTypesPrivateEndpointServiceConnectionStatus"/> values are not the same. </summary>
        public static bool operator !=(ReferenceTypesPrivateEndpointServiceConnectionStatus left, ReferenceTypesPrivateEndpointServiceConnectionStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ReferenceTypesPrivateEndpointServiceConnectionStatus"/>. </summary>
        public static implicit operator ReferenceTypesPrivateEndpointServiceConnectionStatus(string value) => new ReferenceTypesPrivateEndpointServiceConnectionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ReferenceTypesPrivateEndpointServiceConnectionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ReferenceTypesPrivateEndpointServiceConnectionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
