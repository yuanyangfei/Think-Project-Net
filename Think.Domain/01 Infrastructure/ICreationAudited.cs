/*******************************************************************************
 * Copyright © 2016 Think.Framework 版权所有
 * Author: Think
 * Description: Think快速开发平台
 * Website：http://www.Think.cn
*********************************************************************************/
using System;

namespace Think.Domain
{
    public interface ICreationAudited
    {
        int PF_ID { get; set; }
        string PF_CreatorUserId { get; set; }
        DateTime? PF_LoginTime { get; set; }
    }
}