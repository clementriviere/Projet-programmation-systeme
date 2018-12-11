using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Business.Mapper
{
    public static class Recipe
    {
        public static Business.Recipe Map(Data.DAO.Recipe recipe)
        {
            return new Business.Recipe
            {
                Id = recipe.Id,
                RecipeName = recipe.RecipeName,
                Duration = recipe.Duration,
                RecipeType = recipe.RecipeType != null ? RecipeType.Map(recipe.RecipeType) : null,

            };
        }
    }
}
