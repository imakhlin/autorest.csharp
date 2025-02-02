// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace AnomalyDetector.Models
{
    /// <summary> Response of getting a model. </summary>
    public partial class AnomalyDetectionModel
    {
        /// <summary> Initializes a new instance of AnomalyDetectionModel. </summary>
        /// <param name="modelId"></param>
        /// <param name="createdTime"></param>
        /// <param name="lastUpdatedTime"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="modelId"/> is null. </exception>
        internal AnomalyDetectionModel(string modelId, DateTimeOffset createdTime, DateTimeOffset lastUpdatedTime)
        {
            Argument.AssertNotNull(modelId, nameof(modelId));

            ModelId = modelId;
            CreatedTime = createdTime;
            LastUpdatedTime = lastUpdatedTime;
        }

        /// <summary> Initializes a new instance of AnomalyDetectionModel. </summary>
        /// <param name="modelId"></param>
        /// <param name="createdTime"></param>
        /// <param name="lastUpdatedTime"></param>
        /// <param name="modelInfo"></param>
        internal AnomalyDetectionModel(string modelId, DateTimeOffset createdTime, DateTimeOffset lastUpdatedTime, ModelInfo modelInfo)
        {
            ModelId = modelId;
            CreatedTime = createdTime;
            LastUpdatedTime = lastUpdatedTime;
            ModelInfo = modelInfo;
        }

        /// <summary> Gets the model id. </summary>
        public string ModelId { get; }
        /// <summary> Gets the created time. </summary>
        public DateTimeOffset CreatedTime { get; }
        /// <summary> Gets the last updated time. </summary>
        public DateTimeOffset LastUpdatedTime { get; }
        /// <summary> Gets the model info. </summary>
        public ModelInfo ModelInfo { get; }
    }
}
