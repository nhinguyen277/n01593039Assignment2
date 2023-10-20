using Antlr.Runtime;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static System.Net.Mime.MediaTypeNames;

namespace n01593039Assignment2.Controllers
{
    public class J3Controller : ApiController
    {
        /// <summary>
        ///  Input a year and determine what is the next year with distinct digits?
        /// </summary>
        /// <param name="y"> The input consists of one integer Y representing the starting year</param>
        /// <returns> The output will be the single integer which is the next year after Y with distinct digits.</returns>
        /// <example>
        /// GET: api/J3/DistinctDigits/1987		->	"2013"
        /// </example>
        /// <example>
        /// GET: api/J3/DistinctDigits/999		->	"1023"
        /// </example>
        // GET : api/J3/DistinctDigits
        [HttpGet]
        [Route("api/J3/DistinctDigits/{y}")]
        public int DistinctDigits(int y)
        {


            string devide = "";
            string number = "";
            string array = "";
            string mainNum = "";
            int result= 0;

            
            // set new number > input number and it's condition
            for (int i = y + 1; i<=10000; i ++)
            {
                //changing number to string
                number = i.ToString();
                // deviding its component by commas by using string.concat.
                devide = String.Concat(number.Select(c => c + ","));
                // putting  and change string to array
                string[] yearSplit = devide.Split(',');
                // set condition for checking array
                for(int j = 0; j < yearSplit.Length; j++)
                {
                    array = yearSplit[j].Substring(0);
                    
                }
                // setting condition to get new number when it > input number and it must have distinct digits
                if (i>y && yearSplit[0] != yearSplit[1] && yearSplit[0] != yearSplit[2] 
                    && yearSplit[0] != yearSplit[3] && yearSplit[0] != yearSplit[4] && 
                    yearSplit[1] != yearSplit[2] && yearSplit[1] != yearSplit[3] && 
                    yearSplit[1] != yearSplit[4] && yearSplit[2] != yearSplit[3] &&
                    yearSplit[2] != yearSplit[4] && yearSplit[3] != yearSplit[4])
                {
                    // remove space between by string.Join
                    mainNum = string.Join("", yearSplit);
                    // changing to interger
                    result = int.Parse(mainNum);

                    break;
                }
                
            }

            // check array output
            foreach (var item in array)
            {
                Debug.WriteLine(item.ToString());
            }
            // return result
            return result;
        }
    }
}
