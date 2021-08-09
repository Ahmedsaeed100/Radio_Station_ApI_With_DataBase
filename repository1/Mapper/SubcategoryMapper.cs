using repository1.Model;
using repository1.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace repository1.Mapper
{
    public class SubcategoryMapper
    {
        public static subcategory SubcategoryDTOToSubcategory(SubCategoryDTO DTo)
        {
            if (DTo == null) return null;


            var MASTER = new subcategory()
            {
                Subcategory_Id =DTo.Subcategory_Id,
                Category_Id =DTo.Category_Id,
                Station_Type_Name = DTo.Station_Type_Name
            };

            return MASTER;
        }
        public static SubCategoryDTO SubcategoryToSubcategoryDTO(subcategory DTo)
        {
            if (DTo == null) return null;
            var MASTER = new SubCategoryDTO()
            {
                Subcategory_Id = DTo.Subcategory_Id,
                Category_Id = DTo.Category_Id,
                Station_Type_Name = DTo.Station_Type_Name
            };

            return MASTER;
        }
    
}
}