﻿using KARYA.MODEL.Entities.Base.Abstarct;
using KARYA.MODEL.Entities.Base.Concrete;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KARYA.MODEL.Entities
{
    public class Users:BaseEntityEnableCode, ILogEntity
    {
        public int? UserGroupId { get; set; }

        //[ForeignKey("UserGroupId")]
        //public UserGroup UserGroup { get; set; }

        [Required, StringLength(20)]
        public string Name { get; set; }

        [StringLength(20)]
        public string Lastname { get; set; }

        [StringLength(20)]
        public string UserName { get; set; }

        [StringLength(10)]
        public string Password { get; set; }

        [StringLength(30)]
        public string EMail { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public DateTime? CreatedTime { get; set; }
        
        public DateTime? UpdatedTime { get; set; }
        
        public int? CreatedUserId { get; set; }
        
        public int? UpdatedUserId { get; set; }
    }
}
