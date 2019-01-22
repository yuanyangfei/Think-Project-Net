/*******************************************************************************
 * Copyright © 2016 Think.Framework 版权所有
 * Author: Think
 * Description: Think快速开发平台
 * Website：http://www.Think.cn
*********************************************************************************/
using Think.Domain.Entity.SystemManage;
using System.Data.Entity.ModelConfiguration;

namespace Think.Mapping.SystemManage
{
    public class UserMap : EntityTypeConfiguration<Sys_AccountInfo>
    {
        public UserMap()
        {
            this.ToTable("Sys_AccountInfo");
            this.HasKey(t => t.PF_ID);
        }
    }
}
