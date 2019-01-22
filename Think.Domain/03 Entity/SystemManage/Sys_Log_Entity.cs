/*******************************************************************************
 * Copyright © 2016 Think.Framework 版权所有
 * Author: Think
 * Description: Think快速开发平台
 * Website：http://www.Think.cn
*********************************************************************************/
using System;

namespace Think.Domain.Entity.SystemManage
{
    /// <summary>
    /// Sys_Log:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Sys_Log_Entity
    {
        public Sys_Log_Entity()
        { }
        #region Model
        private int _pf_id;
        private string _pf_modelname;
        private string _pf_type;
        private string _pf_nickname;
        private string _pf_result;
        private string _pf_description;
        private DateTime _pf_datetime;
        private string _pf_ipadress;
        /// <summary>
        /// 
        /// </summary>
        public int PF_ID
        {
            set { _pf_id = value; }
            get { return _pf_id; }
        }
        /// <summary>
        /// 操作模块名称
        /// </summary>
        public string PF_ModelName
        {
            set { _pf_modelname = value; }
            get { return _pf_modelname; }
        }
        /// <summary>
        /// 操作类型
        /// </summary>
        public string PF_Type
        {
            set { _pf_type = value; }
            get { return _pf_type; }
        }
        /// <summary>
        /// 真实名称
        /// </summary>
        public string PF_NickName
        {
            set { _pf_nickname = value; }
            get { return _pf_nickname; }
        }
        /// <summary>
        /// true or flase
        /// </summary>
        public string PF_Result
        {
            set { _pf_result = value; }
            get { return _pf_result; }
        }
        /// <summary>
        /// 描述信息
        /// </summary>
        public string PF_Description
        {
            set { _pf_description = value; }
            get { return _pf_description; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime PF_DateTime
        {
            set { _pf_datetime = value; }
            get { return _pf_datetime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PF_IPAdress
        {
            set { _pf_ipadress = value; }
            get { return _pf_ipadress; }
        }
        #endregion Model

    }
}
