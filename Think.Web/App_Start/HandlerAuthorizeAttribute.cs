using Think.Application.SystemManage;
using Think.Code;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Think.Web
{
    public class HandlerAuthorizeAttribute : ActionFilterAttribute
    {
        public bool Ignore { get; set; }
        public HandlerAuthorizeAttribute(bool ignore = true)
        {
            Ignore = ignore;
        }
      
    }
}