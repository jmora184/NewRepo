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
    
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.Order_Sale = new HashSet<Order_Sale>();
            this.Payrolls = new HashSet<Payroll>();
        }
    
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public Nullable<System.DateTime> JoinDate { get; set; }
        public Nullable<bool> Active { get; set; }
        public string EmpAddress { get; set; }
        public string EmpPhone { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_Sale> Order_Sale { get; set; }
        public virtual UserRole UserRole { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payroll> Payrolls { get; set; }
    }
}