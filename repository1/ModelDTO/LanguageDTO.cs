using repository1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace repository1.ModelDTO
{
    public class LanguageDTO
    {
        public short Language_Id { get; set; }
        [DisplayName("Language")]
        [Required(ErrorMessage = "Language is Required!")]
        public string Language_Name { get; set; }

        public virtual ICollection<StationDTO> Stations { get; set; }
    }
}