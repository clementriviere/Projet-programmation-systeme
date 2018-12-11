using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Business.Mapper
{
   public static class RecipeType
    {
        public static Business.RecipeType Map(Data.DAO.RecipeType recipeType)
        {
            return new Business.RecipeType
            {
                Id = recipeType.Id,
                TypeName = recipeType.TypeName
            };
        }
    }
}
