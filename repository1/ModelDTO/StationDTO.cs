using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace repository1.ModelDTO
{
    public class StationDTO
    {
        public int Station_Id { get; set; }
        public int Subcategory_Id { get; set; }
        public int Category_Id { get; set; }
        [DisplayName("Station Name")]
        [Required(ErrorMessage = "Station Name is Required!")]
        public string Station_Name { get; set; }
        public short Language_Id { get; set; }
        public string Station_Image_Url { get; set; }
        public virtual categoryDTO Category { get; set; }
        public virtual LanguageDTO Language { get; set; }
        public virtual SubCategoryDTO subcategory { get; set; }
    }
}