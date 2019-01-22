/*******************************************************************************
 * Copyright © 2016 Think.Framework 版权所有
 * Author: Think
 * Description: Think快速开发平台
 * Website：http://www.Think.cn
*********************************************************************************/
using Think.Code;
using Think.Domain.Entity.SystemManage;
using Think.Domain.IRepository.SystemManage;
using Think.Repository.SystemManage;

namespace Think.Application.SystemManage
{
    public class UserLogOnApp
    {
        private IUserLogOnRepository service = new UserLogOnRepository();

        public Sys_Log_Entity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }
        public void UpdateForm(Sys_Log_Entity userLogOnEntity)
        {
            service.Update(userLogOnEntity);
        }
    }
}
