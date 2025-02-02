// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace ApiVersionInCadl.Models
{
    /// <summary> Detection results for the given resultId. </summary>
    public partial class DetectionResult
    {
        /// <summary> Initializes a new instance of DetectionResult. </summary>
        /// <param name="resultId"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="resultId"/> is null. </exception>
        internal DetectionResult(string resultId)
        {
            Argument.AssertNotNull(resultId, nameof(resultId));

            ResultId = resultId;
        }

        /// <summary> Gets the result id. </summary>
        public string ResultId { get; }
    }
}
