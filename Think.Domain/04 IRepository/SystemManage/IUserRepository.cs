/*******************************************************************************
 * Copyright © 2016 Think.Framework 版权所有
 * Author: Think
 * Description: Think快速开发平台
 * Website：http://www.Think.cn
*********************************************************************************/
using Think.Data;
using Think.Domain.Entity.SystemManage;

namespace Think.Domain.IRepository.SystemManage
{
    
    public interface IUserRepository
    {
        /// <summary>
        /// 根据账号密码查询登录用户
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Sys_AccountInfo GetUserInfoEntity(Sys_AccountInfo entity);

        /// <summary>
        /// 根据姓名查找用户ID
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        int GetUserKeyByName(string Name);
    }
}
