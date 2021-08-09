using repository1.Model;
using repository1.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace repository1.Mapper
{
    public class CategoryMapper
    {
        public static category CategoryDTOToCategory(categoryDTO DTo)
        {
            if (DTo == null) return null;

            List<subcategory> Subcategory = new List<subcategory>();
            if (Subcategory != null)
            {
                foreach (SubCategoryDTO repdto in DTo.subcategories)
                {
                    Subcategory.Add(SubcategoryMapper.SubcategoryDTOToSubcategory(repdto));
                }
            }

            List<Station> Station = new List<Station>();
            if (Station != null)
            {
                foreach (StationDTO repdto in DTo.Station)
                {
                    Station.Add(StationMapper.StationDTOToStation(repdto));
                }
            }

            var MASTER = new category()
            {
                Category_Id = DTo.Category_Id,
                Station_Category_Name = DTo.Station_Category_Name,
                subcategories = Subcategory,
                Stations = Station
            };

            return MASTER;
        }
        public static categoryDTO CategoryToCategoryDTO(category DTo)
        {
            if (DTo == null) return null;
            var MASTER = new categoryDTO()
            {
                Category_Id = DTo.Category_Id,
                Station_Category_Name = DTo.Station_Category_Name,
                
            };

            return MASTER;
        }
    }
}