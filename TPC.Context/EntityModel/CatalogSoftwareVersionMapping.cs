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
    
    public partial class CatalogSoftwareVersionMapping
    {
        public int CSVMapID { get; set; }
        public int CatSubOptSoftwareValID { get; set; }
        public int CatSubOptVersionValID { get; set; }
    
        public virtual CatalogSubjectOptionValue CatalogSubjectOptionValue { get; set; }
        public virtual CatalogSubjectOptionValue CatalogSubjectOptionValue1 { get; set; }
    }
}
