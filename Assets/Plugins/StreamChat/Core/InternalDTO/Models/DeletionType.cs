//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------


using StreamChat.Core.InternalDTO.Responses;
using StreamChat.Core.InternalDTO.Requests;
using StreamChat.Core.InternalDTO.Events;

namespace StreamChat.Core.InternalDTO.Models
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public enum DeletionType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"soft")]
        Soft = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"pruning")]
        Pruning = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"hard")]
        Hard = 2,

    }

}

