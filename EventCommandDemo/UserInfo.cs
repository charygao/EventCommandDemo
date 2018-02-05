using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCommandDemo
{
    /// <summary>
    /// 用户类用于保存记录
    /// </summary>
    public class UserInfo
    {
        public string UserName { get; set; }
        public string UserPwd { get; set; }
        /// <summary>
        /// 是否自动登录
        /// </summary>
        //[System.ComponentModel.DefaultValue(false)]
        public bool AutomaticLogon { get; set; }
        /// <summary>
        /// 是否记住密码
        /// </summary>
        //[System.ComponentModel.DefaultValue(false)]
        public bool RememberPwd { get; set; }
    }
}
