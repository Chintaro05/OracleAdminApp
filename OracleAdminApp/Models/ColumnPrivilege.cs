using System;
using System.Collections.Generic;
using System.Text;

namespace OracleAdminApp.Models
{
    public class ColumnPrivilege
    {
        public string? Grantee { get; set; }
        public string? Owner { get; set; }
        public string? TableName { get; set; }
        public string? ColumnName { get; set; }     // Tên cột được cấp quyền
        public string? Grantor { get; set; }
        public string? Privilege { get; set; }      // Thường là SELECT hoặc UPDATE
        public string? Grantable { get; set; }
    }
}
