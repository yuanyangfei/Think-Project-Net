using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Think.Domain.Entity.SystemManage
{
    /// <summary>
    /// Sys_Model:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Sys_Model
    {
        public Sys_Model()
        { }
        #region Model
        private int _pf_id;
        private int? _pf_parentid;
        private int? _pf_layer;
        private string _pf_fullname;
        private string _pf_url;
        private string _pf_target;
        private string _pf_ismenu;
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
        public int? PF_ParentId
        {
            set { _pf_parentid = value; }
            get { return _pf_parentid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? PF_Layer
        {
            set { _pf_layer = value; }
            get { return _pf_layer; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PF_FullName
        {
            set { _pf_fullname = value; }
            get { return _pf_fullname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PF_Url
        {
            set { _pf_url = value; }
            get { return _pf_url; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PF_TarGet
        {
            set { _pf_target = value; }
            get { return _pf_target; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PF_IsMenu
        {
            set { _pf_ismenu = value; }
            get { return _pf_ismenu; }
        }
        #endregion Model

    }
}
