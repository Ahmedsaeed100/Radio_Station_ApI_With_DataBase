using repository1.Model;
using repository1.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace repository1.Mapper
{
    public class StationMapper
    {
        public static Station StationDTOToStation(StationDTO DTo)
        {
            if (DTo == null) return null;

           

            var MASTER = new Station()
            {
                Station_Id = DTo.Station_Id,
                Category_Id = DTo.Category_Id,
                Subcategory_Id = DTo.Subcategory_Id,
                Station_Name = DTo.Station_Name,
                Language_Id = DTo.Language_Id,
                Station_Image_Url = DTo.Station_Image_Url,
                //MASETER_ORDERS_DETAILS = MASETER_ORDERS_DETAILS,
            };

            return MASTER;
        }

   

        public static StationDTO StationToStationsDTO(Station DTo)
        {
            if (DTo == null) return null;
            var Station = new StationDTO()
            {
                Station_Id = DTo.Station_Id,
                Category_Id = DTo.Category_Id,
                Subcategory_Id = DTo.Subcategory_Id,
                Station_Name = DTo.Station_Name,
                Language_Id = DTo.Language_Id,
                Station_Image_Url = DTo.Station_Image_Url,
            };

            return Station;
        }
    }
}