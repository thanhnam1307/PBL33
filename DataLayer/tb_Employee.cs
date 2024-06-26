//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_Employee()
        {
            this.tb_Invoice = new HashSet<tb_Invoice>();
            this.tb_OverTime = new HashSet<tb_OverTime>();
        }
    
        public string EmployeeID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public Nullable<bool> Gender { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public int WorkingTime { get; set; }
        public decimal Salary { get; set; }
        public string TypeEmpID { get; set; }
        public string Password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Invoice> tb_Invoice { get; set; }
        public virtual tb_EmpType tb_EmpType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_OverTime> tb_OverTime { get; set; }
    }
}
