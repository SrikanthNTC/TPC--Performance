//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TPC.Context.EntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class FAQCategory
    {
        public FAQCategory()
        {
            this.FAQs = new HashSet<FAQ>();
        }
    
        public int FAQCategoryID { get; set; }
        public string Categories { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual ICollection<FAQ> FAQs { get; set; }
    }
}
