//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace repository1.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Station
    {
        public int Station_Id { get; set; }
        public int Subcategory_Id { get; set; }
        public int Category_Id { get; set; }
        public string Station_Name { get; set; }
        public short Language_Id { get; set; }
        public string Station_Image_Url { get; set; }
    
        public virtual category category { get; set; }
        public virtual Language Language { get; set; }
        public virtual subcategory subcategory { get; set; }
    }
}
