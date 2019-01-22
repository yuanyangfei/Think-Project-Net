using System;

namespace Think.Domain.Entity.SystemManage
{
    /// <summary>
    /// Sys_Email_Path:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Sys_Email_Path
    {
        public Sys_Email_Path()
        { }
        #region Model
        private int _pf_id;
        private int? _pf_emailid;
        private string _pf_src;
        private string _pf_filename;
        /// <summary>
        /// 
        /// </summary>
        public int PF_ID
        {
            set { _pf_id = value; }
            get { return _pf_id; }
        }
        /// <summary>
        /// 关联邮件ID
        /// </summary>
        public int? PF_EmailID
        {
            set { _pf_emailid = value; }
            get { return _pf_emailid; }
        }
        /// <summary>
        /// 文件路径/压缩包
        /// </summary>
        public string PF_Src
        {
            set { _pf_src = value; }
            get { return _pf_src; }
        }
        /// <summary>
        /// 文件名称   用, 隔开 例如  aa.doc,bb.png
        /// </summary>
        public string PF_FileName
        {
            set { _pf_filename = value; }
            get { return _pf_filename; }
        }
        #endregion Model

    }
}
