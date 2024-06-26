// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Extensions;

    /// <summary>Properties of the Queue info for event subscription.</summary>
    public partial class QueueInfo
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IQueueInfo.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IQueueInfo.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IQueueInfo FromJson(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonObject json ? new QueueInfo(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonObject into a new instance of <see cref="QueueInfo" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal QueueInfo(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_deadLetterDestinationWithResourceIdentity = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonObject>("deadLetterDestinationWithResourceIdentity"), out var __jsonDeadLetterDestinationWithResourceIdentity) ? Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.DeadLetterWithResourceIdentity.FromJson(__jsonDeadLetterDestinationWithResourceIdentity) : _deadLetterDestinationWithResourceIdentity;}
            {_receiveLockDurationInSecond = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonNumber>("receiveLockDurationInSeconds"), out var __jsonReceiveLockDurationInSeconds) ? (int?)__jsonReceiveLockDurationInSeconds : _receiveLockDurationInSecond;}
            {_maxDeliveryCount = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonNumber>("maxDeliveryCount"), out var __jsonMaxDeliveryCount) ? (int?)__jsonMaxDeliveryCount : _maxDeliveryCount;}
            {_eventTimeToLive = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonString>("eventTimeToLive"), out var __jsonEventTimeToLive) ? global::System.Xml.XmlConvert.ToTimeSpan( __jsonEventTimeToLive ) : _eventTimeToLive;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="QueueInfo" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="QueueInfo" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._deadLetterDestinationWithResourceIdentity ? (Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonNode) this._deadLetterDestinationWithResourceIdentity.ToJson(null,serializationMode) : null, "deadLetterDestinationWithResourceIdentity" ,container.Add );
            AddIf( null != this._receiveLockDurationInSecond ? (Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonNumber((int)this._receiveLockDurationInSecond) : null, "receiveLockDurationInSeconds" ,container.Add );
            AddIf( null != this._maxDeliveryCount ? (Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonNumber((int)this._maxDeliveryCount) : null, "maxDeliveryCount" ,container.Add );
            AddIf( (Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonNode)(null != this._eventTimeToLive ? new Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonString(global::System.Xml.XmlConvert.ToString((global::System.TimeSpan)this._eventTimeToLive)): null), "eventTimeToLive" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}