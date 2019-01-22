using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Think.Domain.Entity.SystemManage
{
    /// <summary>
    /// Sys_Custorm:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Sys_Custorm
    {
        public Sys_Custorm()
        { }
        #region Model
        private int _pf_id;
        private string _pf_name;
        private string _pf_sex;
        private string _pf_address;
        private string _pf_email;
        private string _pf_company;
        private string _pf_weibo;
        private string _pf_tell;
        private string _pf_img;
        private string _pf_job;
        /// <summary>
        /// 
        /// </summary>
        public int PF_ID
        {
            set { _pf_id = value; }
            get { return _pf_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PF_NAME
        {
            set { _pf_name = value; }
            get { return _pf_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PF_SEX
        {
            set { _pf_sex = value; }
            get { return _pf_sex; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PF_ADDRESS
        {
            set { _pf_address = value; }
            get { return _pf_address; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PF_EMAIL
        {
            set { _pf_email = value; }
            get { return _pf_email; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PF_COMPANY
        {
            set { _pf_company = value; }
            get { return _pf_company; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PF_WEIBO
        {
            set { _pf_weibo = value; }
            get { return _pf_weibo; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PF_TELL
        {
            set { _pf_tell = value; }
            get { return _pf_tell; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PF_IMG
        {
            set { _pf_img = value; }
            get { return _pf_img; }
        }
        /// <summary>
        /// 职位
        /// </summary>
        public string PF_JOB
        {
            set { _pf_job = value; }
            get { return _pf_job; }
        }
        #endregion Model

    }
}