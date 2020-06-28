using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ClassLibrary1;
namespace WebApplication1.Controllers
{
    public class ValuesController1 : ApiController
    {
        // GET api/<controller>
        public IEnumerable<TBL_TRN_TASKS> Get()
        {
            using (EasyLivingEntities entities = new EasyLivingEntities())
            {
                return entities.TBL_TRN_TASKS.ToList();
            }
        }

        // GET api/<controller>/5
        public TBL_TRN_TASKS Get(int id)
        {
            using (EasyLivingEntities entities = new EasyLivingEntities())
            {
                return entities.TBL_TRN_TASKS.FirstOrDefault(e => e.TASK_ID == id);
            }
        }
        // POST api/<controller>

    }
}