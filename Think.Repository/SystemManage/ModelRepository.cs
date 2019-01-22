
using System.Collections.Generic;
using System.Linq;
using Think.Data;
using Think.Domain.Entity.SystemManage;
using Think.Domain.IRepository.SystemManage;

namespace Think.Repository.SystemManage
{
   public class ModelRepository:IModelRepository
    {
        SqlSugar.SqlSugarClient db = DemoBase.GetInstance();
        public List<Sys_Model> GetNavModelEntity()
        {
            return db.Queryable<Sys_Model>().ToList();
        }
        public List<Sys_Model> GetNavModelEntity(int PF_ID)
        {
            return db.Queryable<Sys_Model>().Where(x => x.PF_ParentId == PF_ID).ToList();
        }
    }
}
