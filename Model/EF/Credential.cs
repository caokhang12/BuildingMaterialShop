﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.EF
{
    [Table("Credential")]
    public class Credential
    {
        [Key]
        [StringLength(20)]
        public string UserGroupID { get; set; }

        [StringLength(50)]
        public string RoleID { get; set; }
    }
}
