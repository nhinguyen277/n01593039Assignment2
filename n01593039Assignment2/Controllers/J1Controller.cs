using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;

namespace n01593039Assignment2.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// Computing the total Calories of the meal following the menu of Chip’s Fast Food emporium
        /// </summary>
        /// <param name="burger"> the index burger choice </param>
        /// <param name="drink"> the index drink choice</param>
        /// <param name="side"> the index side choice</param>
        /// <param name="dessert"> the index dessert choice</param>
        /// <returns> A string represents the total of calories for choices from {burger},{drink},
        /// {side} and {dessert}</returns>
        /// <example>
        /// GET: api/J1/Menu/4/4/4/4		->	"Your total calorie count is 0"
        /// </example>
        /// <example>
        /// GET: api/J1/Menu/1/2/3/4		->	"Your total calorie count is 691"
        /// </example>
        // GET : api/J1 /Menu
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string Menu(int burger, int drink, int side, int dessert)
        {
            
            int[] Burger = new int[] { 461, 431,420,0 };

            int[] Drink = new int[] { 130, 160, 118, 0 };

            int[] Side = new int[] { 100, 57, 70, 0 };

            int[] Dessert = new int[] { 167, 266, 75, 0 };

            // get the input number minus 1 to get the index of array.
            int pick1 = burger-1;
            int pick2 = drink-1;
            int pick3 = side-1;
            int pick4 = dessert-1;

            int total = Burger[pick1] + Drink[pick2] + Side[pick3] + Dessert[pick4];


            return "Your total calorie count is " + total;
        }


    }
}
