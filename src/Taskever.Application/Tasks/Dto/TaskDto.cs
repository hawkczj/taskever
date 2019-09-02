﻿using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;

namespace Taskever.Tasks.Dto
{
    /// <summary>
    /// Task DTO.
    /// </summary>
    public class TaskDto : AuditedEntityDto
    {
        [Required]
        [StringLength(200, MinimumLength = 1)]
        public string Title { get; set; }

        [Required]
        [StringLength(2000, MinimumLength = 1)]
        public string Description { get; set; }

        public long AssignedUserId { get; set; }

        public byte Priority { get; set; }

        public byte State { get; set; }

        public byte Privacy { get; set; }
    }
}
