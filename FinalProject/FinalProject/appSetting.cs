using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public static class appSetting
    {
        public static string ConnectionString()
        {
            string constring = "Server=localhost;Database=finalproject;Uid=root;Pwd=''";
            return constring;
        }

    }
}
