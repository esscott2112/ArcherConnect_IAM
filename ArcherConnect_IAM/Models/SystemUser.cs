//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArcherConnect_IAM.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SystemUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Nullable<int> SystemPersonId { get; set; }
        public string RecoveryEmail { get; set; }
    }
}
