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
	/// Sys_AccountInfo_Entity:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
    public partial class Sys_AccountInfo : IEntity<Sys_AccountInfo>, ICreationAudited, IDeleteAudited, IModificationAudited
    {
        public Sys_AccountInfo()
        { }
        #region Model
        private int _pf_id;
        private string _pf_uname;
        private string _pf_upwd;
        private int? _pf_status;
        private int? _pf_usertype;
        private string _pf_creatoruserid;
        private int? _pf_logincount;
        private DateTime? _pf_logintime;
        private DateTime _pf_lastlogintime;
        /// <summary>
        /// 
        /// </summary>
        public int PF_ID
        {
            set { _pf_id = value; }
            get { return _pf_id; }
        }
        public int? PF_LoginCount
        {
            set { _pf_logincount = value; }
            get { return _pf_logincount; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PF_UName
        {
            set { _pf_uname = value; }
            get { return _pf_uname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PF_UPwd
        {
            set { _pf_upwd = value; }
            get { return _pf_upwd; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? PF_Status
        {
            set { _pf_status = value; }
            get { return _pf_status; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? PF_UserType
        {
            set { _pf_usertype = value; }
            get { return _pf_usertype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? PF_LoginTime
        {
            set { _pf_logintime = value; }
            get { return _pf_logintime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime PF_LastLoginTime
        {
            set { _pf_lastlogintime = value; }
            get { return _pf_lastlogintime; }
        }
        public string PF_CreatorUserId
        {
            set { _pf_creatoruserid = value; }
            get { return _pf_creatoruserid; }
        }
        #endregion Model

    }


}
