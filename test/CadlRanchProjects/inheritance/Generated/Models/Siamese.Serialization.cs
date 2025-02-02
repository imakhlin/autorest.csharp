// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Models.Inheritance.Models
{
    public partial class Siamese : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("smart");
            writer.WriteBooleanValue(Smart);
            writer.WritePropertyName("age");
            writer.WriteNumberValue(Age);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }

        internal static Siamese DeserializeSiamese(JsonElement element)
        {
            bool smart = default;
            int age = default;
            string name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("smart"))
                {
                    smart = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("age"))
                {
                    age = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new Siamese(name, age, smart);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal new static Siamese FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeSiamese(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
