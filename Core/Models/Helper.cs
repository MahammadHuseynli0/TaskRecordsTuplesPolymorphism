using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public static class Helper
    {
        public static bool CheckBlogTitle(string Title)
        {
            bool check = false;
            if (Title.Length > 5)
            {
                check = true;
                return true;
            }
            else { return check; }
        }

        public static bool CheckBlogDescription(string Description)
        {
            bool check = false;

            if (Description.Length > 8)
            {
                check = true;
                return true;
            }
            else { return check; }
        }
    }
                
                

    }


