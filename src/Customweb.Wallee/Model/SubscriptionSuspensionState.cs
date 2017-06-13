
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
    /// SubscriptionSuspensionState model.
    /// </summary>
    /// <value>SubscriptionSuspensionState model.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionSuspensionState
    {
        
        /// <summary>
        /// Enum RUNNING for "RUNNING"
        /// </summary>
        [EnumMember(Value = "RUNNING")]
        RUNNING,
        
        /// <summary>
        /// Enum ENDED for "ENDED"
        /// </summary>
        [EnumMember(Value = "ENDED")]
        ENDED
    }

}
