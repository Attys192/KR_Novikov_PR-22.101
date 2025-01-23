using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFTESTKR.Models;
namespace WPFTESTKR.Services
{
    internal class Helper
    {
        public static LoginBaseEntities2 GetContext()
        {


            return new LoginBaseEntities2();


        }
    }
}
