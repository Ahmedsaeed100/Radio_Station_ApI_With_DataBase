using repository1.Model;
using repository1.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace repository1.Mapper
{
    public class LanguageMapper
    {
        public static Language LanguageDTOToLanguage(LanguageDTO DTo)
        {
            if (DTo == null) return null;

           
            var MASTER = new Language()
            {
                Language_Id = DTo.Language_Id,
                Language_Name = DTo.Language_Name
            };

            return MASTER;
        }
        public static LanguageDTO LanguageToLanguageDTO(Language DTo)
        {
            if (DTo == null) return null;
            var MASTER = new LanguageDTO()
            {
               Language_Id = DTo.Language_Id,
               Language_Name = DTo.Language_Name
            };

            return MASTER;
        }
    }
}