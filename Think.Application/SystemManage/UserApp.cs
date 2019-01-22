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
using System;
using System.Collections.Generic;

namespace Think.Application.SystemManage
{
    public class UserApp
    {
        private IUserRepository service = new UserRepository();
        private UserLogOnApp userLogOnApp = new UserLogOnApp();

        public Sys_AccountInfo CheckLogin(Sys_AccountInfo entity)
        {
            Sys_AccountInfo Sys_AccountInfo_Entity_ = service.GetUserInfoEntity(entity);
            if (Sys_AccountInfo_Entity_ != null)
            {
                return Sys_AccountInfo_Entity_; }
            else {
                throw new Exception("密码不正确，请重新输入");
            }
        }

        public int GetUserKeyByName(string Name)
        {
            return service.GetUserKeyByName(Name);
        }
    }
}
