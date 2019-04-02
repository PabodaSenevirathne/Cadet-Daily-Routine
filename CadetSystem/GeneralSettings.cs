using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadetSystem
{
    public class GeneralSettings
    {
        
    }

    public static class UserTypeId
    {
        public const int Officer = 1;
        public const int Cadet = 2;
        public const int Instructor = 3;
    }


    public static class UserStatusId
    {
        public const int Active = 1;
        public const int Inactive = 2;
    }

    public static class GenderId
    {
        public const int Male = 1;
        public const int Female = 2;
       
    }
    public static class NationalityId
    {
        public const int SriLankan = 1;
        public const int Other = 2;

    }
    public static class ReligionId
    {
        public const int Buddhism = 1;
        public const int Christian = 2;
        public const int Muslim = 3;
        public const int Hinduism = 4;
        public const int Other = 5;
    }
}
