using Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Service
{
    public class Role
    {

        public Model.Data.Context Context;

        public Role()
        {
            Context = new Context();
        }


        public List<Business.Role> Get()
        {
            return Business.Mapper.Role.Map(Context.Role.ToList());
        }


        public Business.Role Get(int Id)
        {
            return (from c in Context.Role where c.Id == Id select Business.Mapper.Role.Map(c)).FirstOrDefault();
        }
    }
}
