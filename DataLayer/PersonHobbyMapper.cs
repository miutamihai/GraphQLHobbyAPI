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
    
    public partial class PersonHobbyMapper
    {
        public int MappingID { get; set; }
        public int PersonID { get; set; }
        public int HobbyID { get; set; }
    
        public virtual Hobby Hobby { get; set; }
        public virtual Person Person { get; set; }
    }
}