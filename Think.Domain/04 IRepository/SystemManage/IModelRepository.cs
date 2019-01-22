using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Think.Domain.Entity.SystemManage;

namespace Think.Domain.IRepository.SystemManage
{
    public interface IModelRepository
    {
        /// <summary>
        /// 获取导航列表
        /// </summary>
        /// <returns></returns>
        List<Sys_Model> GetNavModelEntity();
        List<Sys_Model> GetNavModelEntity(int KeyValue);
    }
}
