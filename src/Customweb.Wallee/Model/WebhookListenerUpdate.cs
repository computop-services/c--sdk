/**
 * Wallee SDK Client
 *
 * This client allows to interact with the Wallee API.
 *
 * Wallee API: 1.0.0
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Webhook Listener
    /// </summary>
    [DataContract]
    public partial class WebhookListenerUpdate : AbstractWebhookListenerUpdate,  IEquatable<WebhookListenerUpdate>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookListenerUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhookListenerUpdate() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookListenerUpdate" /> class.
        /// </summary>
        /// <param name="Id">The ID is the primary key of the entity. The ID identifies the entity uniquely. (required)</param>
        /// <param name="Version">The version number indicates the version of the entity. The version is incremented whenever the entity is changed. (required)</param>
        public WebhookListenerUpdate(long? Id = default(long?), long? Version = default(long?), CreationEntityState? State = default(CreationEntityState?), string Name = default(string))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new ArgumentNullException("Id is a required property for WebhookListenerUpdate and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Version" is required (not null)
            if (Version == null)
            {
                throw new ArgumentNullException("Version is a required property for WebhookListenerUpdate and cannot be null");
            }
            else
            {
                this.Version = Version;
            }
            this.Name = Name;
            this.State = State;
        }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public long? Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return this.ToJson();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public new string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            return this.Equals(obj as WebhookListenerUpdate);
        }

        /// <summary>
        /// Returns true if WebhookListenerUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of WebhookListenerUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookListenerUpdate other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.Version != null)
                {
                    hash = hash * 59 + this.Version.GetHashCode();
                }
                if (this.Name != null)
                {
                    hash = hash * 59 + this.Name.GetHashCode();
                }
                if (this.State != null)
                {
                    hash = hash * 59 + this.State.GetHashCode();
                }
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
