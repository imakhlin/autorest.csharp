// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Management.Storage.Models
{
    /// <summary> The ImmutabilityPolicy state defines the mode of the policy. Disabled state disables the policy, Unlocked state allows increase and decrease of immutability retention time and also allows toggling allowProtectedAppendWrites property, Locked state only allows the increase of the immutability retention time. A policy can only be created in a Disabled or Unlocked state and can be toggled between the two states. Only a policy in an Unlocked state can transition to a Locked state which cannot be reverted. </summary>
    public readonly partial struct AccountImmutabilityPolicyState : IEquatable<AccountImmutabilityPolicyState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AccountImmutabilityPolicyState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AccountImmutabilityPolicyState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnlockedValue = "Unlocked";
        private const string LockedValue = "Locked";
        private const string DisabledValue = "Disabled";

        /// <summary> Unlocked. </summary>
        public static AccountImmutabilityPolicyState Unlocked { get; } = new AccountImmutabilityPolicyState(UnlockedValue);
        /// <summary> Locked. </summary>
        public static AccountImmutabilityPolicyState Locked { get; } = new AccountImmutabilityPolicyState(LockedValue);
        /// <summary> Disabled. </summary>
        public static AccountImmutabilityPolicyState Disabled { get; } = new AccountImmutabilityPolicyState(DisabledValue);
        /// <summary> Determines if two <see cref="AccountImmutabilityPolicyState"/> values are the same. </summary>
        public static bool operator ==(AccountImmutabilityPolicyState left, AccountImmutabilityPolicyState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AccountImmutabilityPolicyState"/> values are not the same. </summary>
        public static bool operator !=(AccountImmutabilityPolicyState left, AccountImmutabilityPolicyState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AccountImmutabilityPolicyState"/>. </summary>
        public static implicit operator AccountImmutabilityPolicyState(string value) => new AccountImmutabilityPolicyState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AccountImmutabilityPolicyState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AccountImmutabilityPolicyState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
