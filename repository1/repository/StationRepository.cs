using repository1.Mapper;
using repository1.Model;
using repository1.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace repository1.repository
{
    public class StationRepository
    {
        Radio_StationEntities DB = new Radio_StationEntities();


        public List<StationDTO> DataLoadStations()
        {
            List<StationDTO> result = (DB.Stations.ToList().Select

           (mrd => new StationDTO()
           {
               Station_Id = mrd.Station_Id,
               Station_Name = mrd.Station_Name,
               Station_Image_Url = mrd.Station_Image_Url,

               Category = new categoryDTO { Station_Category_Name = (mrd.category != null ? mrd.category.Station_Category_Name : "") },
               subcategory = new SubCategoryDTO { Station_Type_Name = (mrd.subcategory != null ? mrd.subcategory.Station_Type_Name : "") }
           }

               ).Select

               (st => new StationDTO()
               {
                   Station_Name = st.Station_Name,
                   Station_Image_Url = st.Station_Image_Url,

                   Category = new categoryDTO
                   {
                       Station_Category_Name = (st.Category != null ? st.Category.Station_Category_Name : "Under Process")
                   },
                   subcategory = new SubCategoryDTO
                   {
                       Station_Type_Name = (st.subcategory != null ? st.subcategory.Station_Type_Name : "Under Process")
                   },
                   Language = new LanguageDTO
                   {
                       Language_Name = (st.Language != null ? st.Language.Language_Name : "Under Process")
                   }


               }).ToList());
            return result;

           
        }

        // Searching For Radio Station
        public List<StationDTO> SearchForRadioStation(string StationName = null, int? CategoryId = null, int? SubcategoryId = null, int? LanguageId = null)
        {

            List<StationDTO> result = (DB.Stations.ToList().Where
              (pro =>
              (StationName == null || pro.Station_Name.Contains(StationName)) &&
               (pro.Category_Id == CategoryId || CategoryId == 0 || CategoryId == null) &&
               (pro.Subcategory_Id == SubcategoryId || SubcategoryId == 0 || SubcategoryId == null) &&
               (pro.Language_Id == LanguageId || LanguageId == 0 || LanguageId == null)
              
                            ).Select


           (st => new StationDTO()
           {
               Station_Name = st.Station_Name,
               Station_Image_Url = st.Station_Image_Url,

               Category = new categoryDTO
               {
                   Station_Category_Name = (st.category != null ? st.category.Station_Category_Name : "Under Process")
               },
               subcategory = new SubCategoryDTO
               {
                   Station_Type_Name = (st.subcategory != null ? st.subcategory.Station_Type_Name : "Under Process")
               },
               Language = new LanguageDTO
               {
                   Language_Name = (st.Language != null ? st.Language.Language_Name : "Under Process")
               }


           }).ToList());
            return result;
        }

       

        // Get Station By ID
        public StationDTO GetStationByID(int? id)
        {
            if (id == null)
            {
                return null;
            }
            Station result = DB.Stations.Find(id);
            StationDTO resultDTO = StationMapper.StationToStationsDTO(result);

            return resultDTO;
        }

        // Get Station By Name
        public List<StationDTO> GetStationByName(string Station_Name)
        {
            try
            {
                var result = DB.Stations.Where(c => c.Station_Name.Contains(Station_Name)).Select(m => new StationDTO()
                {
                    Station_Id = m.Station_Id
                }).ToList();
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        //Chick for duplicate Radio Station Name
        public List<StationDTO> ChickForDuplicatedRadioStationName(string StationName)
        {
            var result = DB.Stations.Where(c => c.Station_Name == StationName).Select(m => new StationDTO()
            {
                Station_Id = m.Station_Id
            }).ToList();
            return result;
        }


        // Save New Station Data
        public int SaveRadioStation(StationDTO result)
        {
            Station resultDomain = StationMapper.StationDTOToStation(result);
            try
            {
                DB.Stations.Add(resultDomain);
                DB.SaveChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

      
        // Update Stations
        public int UpdateRadioStation(StationDTO result)
        {
            Station resultDomain = StationMapper.StationDTOToStation(result);
            try
            {
                DB.Entry(resultDomain).State = System.Data.Entity.EntityState.Modified;
                DB.SaveChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public int DeleteRadioStation(int? id)
        {
            try
            {
                Station result = DB.Stations.Find(id);
                DB.Stations.Remove(result);
                DB.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }


       


        public List<StationDTO> DataLoadStations2() // Only Station Table
        {
            var result = DB.Stations.Select(m => new StationDTO()
            {
                Station_Id = m.Station_Id,
                Station_Name = m.Station_Name,
                Station_Image_Url = m.Station_Image_Url,
                Category_Id = m.Category_Id,
                Subcategory_Id = m.Subcategory_Id,
                Language_Id = m.Language_Id,

                //MASETER_ORDERS_DETAILS = new MASETER_ORDERS_DETAILSDTO()

            }).ToList();
            return result;

        }

    }
}