using repository1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace repository1.ModelDTO
{
    public class SubCategoryDTO
    {
        public int Subcategory_Id { get; set; }
        public int Category_Id { get; set; }
        public string Station_Type_Name { get; set; }

        public virtual category category { get; set; }
        public virtual ICollection<Station> Stations { get; set; }
    }
}