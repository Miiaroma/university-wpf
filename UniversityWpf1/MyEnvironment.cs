using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityWpf1
{
    public static class MyEnvironment
    {
        
        public static string GetBaseUrl()
        {
            return "https://localhost:7080/api";
            //return "https://localhost:7140/api";
            //return "https://miian-dotnet-university.herokuapp.com/api";
        }
    }
}
