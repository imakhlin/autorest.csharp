// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace CadlFirstTest.Models
{
    public partial class RoundTripModel : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("requiredString");
            writer.WriteStringValue(RequiredString);
            writer.WritePropertyName("requiredInt");
            writer.WriteNumberValue(RequiredInt);
            writer.WritePropertyName("requiredCollection");
            writer.WriteStartArray();
            foreach (var item in RequiredCollection)
            {
                writer.WriteStringValue(item.ToSerialString());
            }
            writer.WriteEndArray();
            writer.WritePropertyName("requiredDictionary");
            writer.WriteStartObject();
            foreach (var item in RequiredDictionary)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WritePropertyName("requiredModel");
            writer.WriteObjectValue(RequiredModel);
            writer.WriteEndObject();
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
