//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AngularJS.webapi1
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserRole
    {
        public int UserID { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
