using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Business.Mapper
{
    public static class Role
    {
        public static Business.Role Map(Data.DAO.Role role)
        {
            return new Business.Role
            {
                Id = role.Id,
                RoleName = role.RoleName
            };
        }
    }
}
