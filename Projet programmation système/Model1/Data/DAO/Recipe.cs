using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data.DAO
{
    public class Recipe
    {
        public int Id { get; set; }
        public string RecipeName { get; set; }
        public int Duration { get; set; }
        public int Price { get; set; }

        public int Id_RecipeType { get; set; }
        [ForeignKey("Id_RecipeType")]
        public virtual RecipeType RecipeType { get; set; }

    }
}
