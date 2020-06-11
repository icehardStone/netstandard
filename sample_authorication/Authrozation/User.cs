using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample_authorication.Authrozation
{
    /// <summary>
    /// 登录用户信息
    /// </summary>
    public class User
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { set; get; }
        /// <summary>
        /// id
        /// </summary>
        public string Id { set; get; }
        /// <summary>
        /// 角色Id
        /// </summary>
        public string RoleId { set; get; }
        /// <summary>
        /// 角色名称
        /// </summary>
        public string RoleName { set; get; }
        /// <summary>
        /// 签发时间
        /// </summary>
        public DateTime SignTime { set; get; }
        /// <summary>
        /// 过期时间
        /// </summary>
        public DateTime ExpireTime { set; get; }
    }
}
