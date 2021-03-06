// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Reservations.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Exchange request properties
    /// </summary>
    public partial class ExchangeRequestProperties
    {
        /// <summary>
        /// Initializes a new instance of the ExchangeRequestProperties class.
        /// </summary>
        public ExchangeRequestProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExchangeRequestProperties class.
        /// </summary>
        /// <param name="sessionId">SessionId that was returned by
        /// CalculateExchange API.</param>
        public ExchangeRequestProperties(string sessionId = default(string))
        {
            SessionId = sessionId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets sessionId that was returned by CalculateExchange API.
        /// </summary>
        [JsonProperty(PropertyName = "sessionId")]
        public string SessionId { get; set; }

    }
}
