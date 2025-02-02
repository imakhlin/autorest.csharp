// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;
using MgmtMockAndSample.Models;

namespace MgmtMockAndSample
{
    public partial class FirewallPolicyData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                JsonSerializer.Serialize(writer, Identity, serializeOptions);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(BasePolicy))
            {
                writer.WritePropertyName("basePolicy");
                JsonSerializer.Serialize(writer, BasePolicy);
            }
            if (Optional.IsDefined(ThreatIntelWhitelist))
            {
                writer.WritePropertyName("threatIntelWhitelist");
                writer.WriteObjectValue(ThreatIntelWhitelist);
            }
            if (Optional.IsDefined(Insights))
            {
                writer.WritePropertyName("insights");
                writer.WriteObjectValue(Insights);
            }
            if (Optional.IsDefined(Snat))
            {
                writer.WritePropertyName("snat");
                writer.WriteObjectValue(Snat);
            }
            if (Optional.IsDefined(DnsSettings))
            {
                writer.WritePropertyName("dnsSettings");
                writer.WriteObjectValue(DnsSettings);
            }
            if (Optional.IsDefined(IntrusionDetection))
            {
                writer.WritePropertyName("intrusionDetection");
                writer.WriteObjectValue(IntrusionDetection);
            }
            if (Optional.IsDefined(TransportSecurity))
            {
                writer.WritePropertyName("transportSecurity");
                writer.WriteObjectValue(TransportSecurity);
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static FirewallPolicyData DeserializeFirewallPolicyData(JsonElement element)
        {
            Optional<string> etag = default;
            Optional<ManagedServiceIdentity> identity = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<IReadOnlyList<WritableSubResource>> ruleCollectionGroups = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<WritableSubResource> basePolicy = default;
            Optional<IReadOnlyList<WritableSubResource>> firewalls = default;
            Optional<IReadOnlyList<WritableSubResource>> childPolicies = default;
            Optional<FirewallPolicyThreatIntelWhitelist> threatIntelWhitelist = default;
            Optional<FirewallPolicyInsights> insights = default;
            Optional<FirewallPolicySnat> snat = default;
            Optional<DnsSettings> dnsSettings = default;
            Optional<FirewallPolicyIntrusionDetection> intrusionDetection = default;
            Optional<FirewallPolicyTransportSecurity> transportSecurity = default;
            Optional<FirewallPolicySku> sku = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText(), serializeOptions);
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("ruleCollectionGroups"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            ruleCollectionGroups = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("basePolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            basePolicy = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("firewalls"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            firewalls = array;
                            continue;
                        }
                        if (property0.NameEquals("childPolicies"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            childPolicies = array;
                            continue;
                        }
                        if (property0.NameEquals("threatIntelWhitelist"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            threatIntelWhitelist = FirewallPolicyThreatIntelWhitelist.DeserializeFirewallPolicyThreatIntelWhitelist(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("insights"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            insights = FirewallPolicyInsights.DeserializeFirewallPolicyInsights(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("snat"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            snat = FirewallPolicySnat.DeserializeFirewallPolicySnat(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("dnsSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            dnsSettings = DnsSettings.DeserializeDnsSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("intrusionDetection"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            intrusionDetection = FirewallPolicyIntrusionDetection.DeserializeFirewallPolicyIntrusionDetection(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("transportSecurity"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            transportSecurity = FirewallPolicyTransportSecurity.DeserializeFirewallPolicyTransportSecurity(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("sku"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sku = FirewallPolicySku.DeserializeFirewallPolicySku(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new FirewallPolicyData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, etag.Value, identity, Optional.ToList(ruleCollectionGroups), Optional.ToNullable(provisioningState), basePolicy, Optional.ToList(firewalls), Optional.ToList(childPolicies), threatIntelWhitelist.Value, insights.Value, snat.Value, dnsSettings.Value, intrusionDetection.Value, transportSecurity.Value, sku.Value);
        }
    }
}
