using repository1.ModelDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;

namespace repository1.StoreProcedure
{
    /// <summary>
    /// Summary description for StoreProc
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class StoreProc : System.Web.Services.WebService
    {

        [WebMethod]
        public void GetAllRadioStations()
        {
            List<StationDTO> listRadios = new List<StationDTO>();

            string cs = ConfigurationManager.ConnectionStrings["Radio_StationEntities"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("GetAllRadioStations", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

               


                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    StationDTO listRadio = new StationDTO();
                    listRadio.Station_Id = Convert.ToInt32(rdr["Station_Id"]);
                    listRadio.Station_Name = rdr["Station_Name"].ToString();
                    listRadio.Station_Image_Url = rdr["Station_Image_Url"].ToString();
                 
                    listRadios.Add(listRadio);
                }
            }

            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(listRadios));
        }

        // Search
        public void Search(int Station_Name, int CategoryId, string SubcategoryId)
        {
            List<StationDTO> listRadios = new List<StationDTO>();

            string cs = ConfigurationManager.ConnectionStrings["Radio_StationEntities"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("GetAllRadioStations", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@Station_Name",
                    Value = Station_Name
                });

                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@CategoryId",
                    Value = CategoryId
                });
                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@SubcategoryId",
                    Value = SubcategoryId
                });



                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    StationDTO listRadio = new StationDTO();
                    listRadio.Station_Id = Convert.ToInt32(rdr["Station_Id"]);
                    listRadio.Station_Name = rdr["Station_Name"].ToString();
                    listRadio.Station_Image_Url = rdr["Station_Image_Url"].ToString();

                    listRadios.Add(listRadio);
                }
            }

            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(listRadios));
        }
    }
}
