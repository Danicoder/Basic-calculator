using System;
using System.Collections.Generic;
using System.Text;

namespace Calculate
{
    class Utils
    {

        public static int ReadOption()
        {
            try
            {
                int UserOption;
                UserOption = System.Convert.ToInt32(System.Console.ReadLine());
                return UserOption;
            }
            catch
            {
                return -1;
            }
        }
        //hacer una funcion para el título 12 líneas es con controles.?color..

    }
}
