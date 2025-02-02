// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Pagination.Models
{
    internal partial class PagedLedgerEntry
    {
        internal static PagedLedgerEntry DeserializePagedLedgerEntry(JsonElement element)
        {
            IReadOnlyList<LedgerEntry> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<LedgerEntry> array = new List<LedgerEntry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LedgerEntry.DeserializeLedgerEntry(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new PagedLedgerEntry(value, nextLink);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static PagedLedgerEntry FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializePagedLedgerEntry(document.RootElement);
        }
    }
}
