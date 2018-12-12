using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Business
{
    public class Recipe
    {

        public int Id { get; set; }
        public string RecipeName { get; set; }
        public int Duration { get; set; }


        public RecipeType RecipeType { get; set; }
    }
}
