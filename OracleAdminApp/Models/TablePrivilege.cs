using System;
using System.Collections.Generic;
using System.Text;

namespace OracleAdminApp.Models
{
    public class TablePrivilege
    {
        public string? Grantee { get; set; }        // Người được cấp (user/role)
        public string? Owner { get; set; }          // Chủ của đối tượng
        public string? TableName { get; set; }      // Tên bảng/view/proc
        public string? Grantor { get; set; }        // Người cấp quyền
        public string? Privilege { get; set; }      // SELECT, INSERT, UPDATE...
        public string? Grantable { get; set; }      // YES nếu có WITH GRANT OPTION
        public string? Hierarchy { get; set; }
    }
}
