using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using System.Web;
using System.IO;
using repository1.repository;
using repository1.ModelDTO;
using System.Linq;
using System.Net.Http;

namespace API.Controllers
{
    [System.Web.Http.Cors.EnableCors(origins: "*", headers: "*", methods: "*")] // origins // put Url in Origins Get when Run Project 
    [RoutePrefix("api/Stations")]
    public class APIController : ApiController
    {
        StationRepository StationRepository = new StationRepository();


        // GET api/values
        [HttpGet]
        [Route("GetAllStation")]
        public List<StationDTO> GetAllStation()
        {
            try
            {
                var result = StationRepository.DataLoadStations();
                return result.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }


        //search For Radio Station
        [HttpGet]
        [Route("GetSearchForRadioStation/{StationName?}/{CategoryId?}/{SubcategoryId?}/{LanguageId?}")]
        public List<StationDTO> GetSearchForRadioStation(string StationName = null, int? CategoryId = null, int? SubcategoryId = null, int? LanguageId = null)
        {
            try
            {
                var result = StationRepository.SearchForRadioStation(StationName, CategoryId, SubcategoryId, LanguageId);
                return result.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }


        //search For Radio Station By Name Contains Same Character
        [HttpGet]
        [Route("GetSearchForRadioStationByName/{StationName?}")]
        public List<StationDTO> GetSearchForRadioStationByName(string StationName = null)
        {
            try
            {
                var result = StationRepository.GetStationByName(StationName);
                return result.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        //search For Radio Station By Name Contains Same Character
        [HttpGet]
        [Route("GetSearchForRadioStationBySameName/{StationName?}")]
        public List<StationDTO> GetSearchForRadioStationBySameName(string StationName = null)
        {
            try
            {
                var result = StationRepository.ChickForDuplicatedRadioStationName(StationName);
                return result.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }


        // Save New Radio Station
        [HttpPost]
        [Route("PostNewStation")]
        public HttpResponseMessage PostNewStation(StationDTO Nstation)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // check if client code or name is exist or not
                    var MR_NOExist = StationRepository.ChickForDuplicatedRadioStationName(Nstation.Station_Name);

                    if (MR_NOExist.Count != 0)
                    {
                        var message = "This Code is already exist!";
                        ModelState.AddModelError("", message);
                        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                    }

                    string id1 = Guid.NewGuid().ToString();
                    string path = null;

                    if (Nstation.Station_Image_Url != "0")
                    {
                        id1 = id1 + "." + Nstation.Station_Image_Url.Split('.')[1];
                        byte[] ret = Convert.FromBase64String(Nstation.Station_Image_Url.Split('.')[0]);

                        path = HttpContext.Current.Server.MapPath("~/StationImages/").ToString() + id1;
                        File.WriteAllBytes(path, ret);
                        Nstation.Station_Image_Url = id1;
                    }
                    else
                    {
                        Nstation.Station_Image_Url = null;
                    }
                    var result = StationRepository.SaveRadioStation(Nstation);
                    if (result != 0)
                    {
                        return Request.CreateResponse(HttpStatusCode.OK);
                    }
                    else
                        return Request.CreateResponse(HttpStatusCode.BadRequest);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }

            }
            catch (Exception ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        // Update Radio Station
        [HttpPost]
        [Route("UpdateStation")]
        public HttpResponseMessage UpdateStation(StationDTO m)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = StationRepository.UpdateRadioStation(m);
                    if (result != 0)
                    {
                        return Request.CreateResponse(HttpStatusCode.OK);
                    }
                    else
                        return Request.CreateResponse(HttpStatusCode.BadRequest);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }

            }
            catch (Exception ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }


        // Delete Radio Station
        [HttpPost]
        [Route("DeleteRadioStation/{id}")]
        public HttpResponseMessage DeleteRadioStation(int? id)
        {
            try
            {
                var result = StationRepository.DeleteRadioStation(id);
                if (result != 0)
                {
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                else
                    return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }


    }
}
