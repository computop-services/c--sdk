
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
    /// CriteriaOperator model.
    /// </summary>
    /// <value>CriteriaOperator model.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CriteriaOperator
    {
        
        /// <summary>
        /// Enum EQUALS for "EQUALS"
        /// </summary>
        [EnumMember(Value = "EQUALS")]
        EQUALS,
        
        /// <summary>
        /// Enum GREATER_THAN for "GREATER_THAN"
        /// </summary>
        [EnumMember(Value = "GREATER_THAN")]
        GREATER_THAN,
        
        /// <summary>
        /// Enum GREATER_THAN_OR_EQUAL for "GREATER_THAN_OR_EQUAL"
        /// </summary>
        [EnumMember(Value = "GREATER_THAN_OR_EQUAL")]
        GREATER_THAN_OR_EQUAL,
        
        /// <summary>
        /// Enum LESS_THAN for "LESS_THAN"
        /// </summary>
        [EnumMember(Value = "LESS_THAN")]
        LESS_THAN,
        
        /// <summary>
        /// Enum LESS_THAN_OR_EQUAL for "LESS_THAN_OR_EQUAL"
        /// </summary>
        [EnumMember(Value = "LESS_THAN_OR_EQUAL")]
        LESS_THAN_OR_EQUAL,
        
        /// <summary>
        /// Enum CONTAINS for "CONTAINS"
        /// </summary>
        [EnumMember(Value = "CONTAINS")]
        CONTAINS,
        
        /// <summary>
        /// Enum NOT_EQUALS for "NOT_EQUALS"
        /// </summary>
        [EnumMember(Value = "NOT_EQUALS")]
        NOT_EQUALS,
        
        /// <summary>
        /// Enum NOT_CONTAINS for "NOT_CONTAINS"
        /// </summary>
        [EnumMember(Value = "NOT_CONTAINS")]
        NOT_CONTAINS,
        
        /// <summary>
        /// Enum IS_NULL for "IS_NULL"
        /// </summary>
        [EnumMember(Value = "IS_NULL")]
        IS_NULL
    }

}
