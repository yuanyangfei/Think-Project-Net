using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Think.Domain.Entity.SystemManage
{
    /// <summary>
    /// Sys_Email:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Sys_Email
    {
        public Sys_Email()
        { }
        #region Model
        private int _pf_id;
        private string _pf_in_userid;
        private string _pf_out_userid;
        private string _pf_title;
        private string _pf_msg;
        private int? _pf_improtent;
        private int? _pf_type_speach;
        private int? _pf_isread;
        private string _pf_tipclass;
        private DateTime _pf_createtime;
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey=true,IsIdentity=true)] 
        public int PF_ID
        {
            set { _pf_id = value; }
            get { return _pf_id; }
        }
        /// <summary>
        /// 收件人
        /// </summary>
        public string PF_In_UserID
        {
            set { _pf_in_userid = value; }
            get { return _pf_in_userid; }
        }
        /// <summary>
        /// 发件人
        /// </summary>
        public string PF_Out_UserID
        {
            set { _pf_out_userid = value; }
            get { return _pf_out_userid; }
        }
        /// <summary>
        /// 信件标题
        /// </summary>
        public string PF_Title
        {
            set { _pf_title = value; }
            get { return _pf_title; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PF_MSG
        {
            set { _pf_msg = value; }
            get { return _pf_msg; }
        }
        /// <summary>
        /// 0 不重要  1重要
        /// </summary>
        public int? PF_improtent
        {
            set { _pf_improtent = value; }
            get { return _pf_improtent; }
        }
        /// <summary>
        /// 0 工作 1 文档 2 社交 3 广告 4 客户端
        /// </summary>
        public int? PF_type_speach
        {
            set { _pf_type_speach = value; }
            get { return _pf_type_speach; }
        }
        /// <summary>
        /// 0 未读 1 已读
        /// </summary>
        public int? PF_IsRead
        {
            get { return _pf_isread; }
            set { _pf_isread = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime PF_CreateTime
        {
            set { _pf_createtime = value; }
            get { return _pf_createtime; }
        }
        public string PF_TipClass
        {
            set { _pf_tipclass = value; }
            get { return _pf_tipclass; }
        }
        #endregion Model

    }
}
