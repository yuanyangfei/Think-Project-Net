﻿/*******************************************************************************
 * Copyright © 2016 Think.Framework 版权所有
 * Author: Think
 * Description: Think快速开发平台
 * Website：http://www.Think.cn
*********************************************************************************/
using System;

namespace Think.Domain
{
    public interface IDeleteAudited 
    {
        /// <summary>
        /// 逻辑删除标记
        /// </summary>
      //  bool? F_DeleteMark { get; set; }

        /// <summary>
        /// 删除实体的用户
        /// </summary>
    //    string F_DeleteUserId { get; set; }

        /// <summary>
        /// 删除实体时间
        /// </summary>
     //   DateTime? F_DeleteTime { get; set; } 
    }
}