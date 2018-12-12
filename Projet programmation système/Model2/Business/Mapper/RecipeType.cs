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

        public static List<Business.RecipeType> Map(List<Data.DAO.RecipeType> recipeTypes)
        {
            return (from recipeType in recipeTypes select Map(recipeType)).ToList();
        }

        public static Data.DAO.RecipeType Map(Business.RecipeType recipeType)
        {
            return new Data.DAO.RecipeType
            {
                Id = recipeType.Id,
                TypeName = recipeType.TypeName
            };
        }



    }
}
