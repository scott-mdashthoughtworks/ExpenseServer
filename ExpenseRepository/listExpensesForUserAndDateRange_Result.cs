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

public partial class listExpensesForUserAndDateRange_Result
{
    public int id { get; set; }
    public System.Guid OwnerId { get; set; }
    public System.DateTime ExpDate { get; set; }
    public string Description { get; set; }
    public decimal Amount { get; set; }
    public Nullable<System.DateTime> Posted { get; set; }
    public Nullable<int> PersonalCategoryId { get; set; }
    public Nullable<int> CategoriesId { get; set; }
}
