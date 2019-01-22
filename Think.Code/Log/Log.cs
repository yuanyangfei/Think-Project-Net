/*******************************************************************************
 * Copyright © 2016 Think.Framework 版权所有
 * Author: Think
 * Description: Think快速开发平台
 * Website：http://www.Think.cn
*********************************************************************************/
using log4net;

namespace Think.Code
{
    public class Log
    {
        private ILog logger;
        public Log(ILog log)
        {
            this.logger = log;
        }
        public void Debug(object message)
        {
            this.logger.Debug(message);
        }
        public void Error(object message)
        {
            this.logger.Error(message);
        }
        public void Info(object message)
        {
            this.logger.Info(message);
        }
        public void Warn(object message)
        {
            this.logger.Warn(message);
        }
    }
}
