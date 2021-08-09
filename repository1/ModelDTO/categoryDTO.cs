using repository1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace repository1.ModelDTO
{
    public class categoryDTO
    {
        public int Category_Id { get; set; }
        [DisplayName("Station Category Name")]
        [Required(ErrorMessage = "Category Name is Required!")]
        public string Station_Category_Name { get; set; }
        public virtual ICollection<StationDTO> Station { get; set; }
        public virtual ICollection<SubCategoryDTO> subcategories { get; set; }
      
       
    }
}