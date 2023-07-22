﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CytoBox.Domain.Entity
{
    /// <summary>
    /// 用户角色关系表
    /// </summary>
    public class UserRole
    {
        public UserRole() { }

        public UserRole(int uid, int rid)
        {
            UserId = uid;
            RoleId = rid;
            CreateTime = DateTime.Now;
            IsDeleted = false;
            CreateId = uid;
            CreateTime = DateTime.Now;
        }

        /// <summary>
        /// 主键Id
        /// </summary>        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        /// <summary>
        /// 用户Id
        /// </summary>
        public long UserId { get; set; }

        /// <summary>
        /// 角色Id
        /// </summary>
        public int RoleId { get; set; }

        /// <summary>
        /// 获取或设置是否禁用，逻辑上的删除，非物理删除
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// 创建ID
        /// </summary>
        public long? CreateId { get; set; }

        /// <summary>
        /// 创建者
        /// </summary>
        public string? CreateBy { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 修改ID
        /// </summary>
        public int? ModifyId { get; set; }

        /// <summary>
        /// 修改者
        /// </summary>
        public string? ModifyBy { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? ModifyTime { get; set; }
    }
}