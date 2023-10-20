using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml.Schema;

namespace n01593039Assignment2.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        ///  Determining how many ways we can roll the value of 10 from 2 dices
        /// </summary>
        /// <param name="m"> positive integer representing the number of sides on the first die  </param>
        /// <param name="n"> positive integer representing the number of sides on the second die </param>
        /// <returns> a string represent the totel of time that we can roll the value of 10</returns>
        /// <example>
        /// GET: api/J2/DiceGame/6/8		->	"There are 5 total ways to get the sum 10"
        /// </example>
        /// <example>
        /// GET: api/J2/DiceGame/12/4		->	"There are 4 ways to get the sum 10. "
        /// </example>
        // GET : api/J2/DiceGame
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]

        public string DiceGame(int m, int n)
        {
            int count = 0;
            List<string> array= new List<string>();
            // set condition like requiremnt 1<=m<=1000 and 1<=n<=1000
            if (m >= 1 && m<=1000 && n>=1 && n<=1000)
            {
                for (int i = 1;i<=m; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        int sum = i + j;
                        if (sum == 10)
                        {

                            count++;
                            // putting i,j to array to check
                            array.Add(i.ToString() + "+" + j.ToString() + "=" + sum);

                        }
                    }

                }
            }    

            // print aray to check
            foreach (var item in array)
            {
                Debug.WriteLine(item.ToString());
            }

            return "There are " + count + " total ways to get the sum 10 " ;
        }
    }
}
