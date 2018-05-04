using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s2230moshou
{
    class shuzu
    {
        /// <summary>
        ///记录名字
        /// </summary>
        private string UserName;

        public string UserName1
        {
            get { return  UserName; }
            set { UserName = value; }
        }
        /// <summary>
        /// 记录密码
        /// </summary>
        private string pwd;

        public string Pwd
        {
            get { return pwd; }
            set { pwd = value; }
        }
        /// <summary>
        /// 记录身份证
        /// </summary>
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>
        /// 记录email
        /// </summary>
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
