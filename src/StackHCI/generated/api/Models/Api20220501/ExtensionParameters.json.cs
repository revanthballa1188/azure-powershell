// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Extensions;

    /// <summary>
    /// Describes the properties of a Machine Extension. This object mirrors the definition in HybridCompute.
    /// </summary>
    public partial class ExtensionParameters
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject into a new instance of <see cref="ExtensionParameters" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ExtensionParameters(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_forceUpdateTag = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString>("forceUpdateTag"), out var __jsonForceUpdateTag) ? (string)__jsonForceUpdateTag : (string)ForceUpdateTag;}
            {_publisher = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString>("publisher"), out var __jsonPublisher) ? (string)__jsonPublisher : (string)Publisher;}
            {_type = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString>("type"), out var __jsonType) ? (string)__jsonType : (string)Type;}
            {_typeHandlerVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString>("typeHandlerVersion"), out var __jsonTypeHandlerVersion) ? (string)__jsonTypeHandlerVersion : (string)TypeHandlerVersion;}
            {_autoUpgradeMinorVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonBoolean>("autoUpgradeMinorVersion"), out var __jsonAutoUpgradeMinorVersion) ? (bool?)__jsonAutoUpgradeMinorVersion : AutoUpgradeMinorVersion;}
            {_setting = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject>("settings"), out var __jsonSettings) ? Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Any.FromJson(__jsonSettings) : Setting;}
            {_protectedSetting = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject>("protectedSettings"), out var __jsonProtectedSettings) ? Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Any.FromJson(__jsonProtectedSettings) : ProtectedSetting;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionParameters.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionParameters.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionParameters FromJson(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject json ? new ExtensionParameters(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="ExtensionParameters" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ExtensionParameters" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._forceUpdateTag)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString(this._forceUpdateTag.ToString()) : null, "forceUpdateTag" ,container.Add );
            AddIf( null != (((object)this._publisher)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString(this._publisher.ToString()) : null, "publisher" ,container.Add );
            AddIf( null != (((object)this._type)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString(this._type.ToString()) : null, "type" ,container.Add );
            AddIf( null != (((object)this._typeHandlerVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString(this._typeHandlerVersion.ToString()) : null, "typeHandlerVersion" ,container.Add );
            AddIf( null != this._autoUpgradeMinorVersion ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonBoolean((bool)this._autoUpgradeMinorVersion) : null, "autoUpgradeMinorVersion" ,container.Add );
            AddIf( null != this._setting ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode) this._setting.ToJson(null,serializationMode) : null, "settings" ,container.Add );
            AddIf( null != this._protectedSetting ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode) this._protectedSetting.ToJson(null,serializationMode) : null, "protectedSettings" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}