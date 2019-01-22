
using Think.Domain.IRepository.SystemManage;
using Think.Repository.SystemManage;

namespace Think.Web.App_Start
{
    public class DataConfig
    {
        public IEmailRepository emailRepository = new EmailRepository();
        public IModelRepository modelRepository = new ModelRepository();
        public IUserRepository userRepository = new UserRepository();
        public IUserLogOnRepository userLogRepository = new UserLogOnRepository();
    }
}