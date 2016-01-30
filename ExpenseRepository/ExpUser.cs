//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;using Newtonsoft.Json; 

public partial class ExpUser
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public ExpUser()
    {
        this.ExpenseRecords = new HashSet<ExpenseRecord>();
        this.ExpPersonalCategories = new HashSet<ExpPersonalCategory>();
    }

    public System.Guid id { get; set; }
    public string email { get; set; }
    public string password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Nullable<int> OrgId { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    [JsonIgnore]  
public virtual ICollection<ExpenseRecord> ExpenseRecords { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    [JsonIgnore]  
public virtual ICollection<ExpPersonalCategory> ExpPersonalCategories { get; set; }
}
