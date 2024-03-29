﻿using ProductivityApp.Domain.Enums;
using ProductivityApp.Dtos.TaskDtos;

namespace ProductivityApp.Dtos.UserSessionDtos
{
    public  class UpdateUserSessionDto
    {
        public int Id { get; set; }

        public DateTime StartTime { get; set; } = DateTime.UtcNow;
        public DateTime FinishTime { get; set; } = DateTime.UtcNow;

        public int UserSessionLength { get; set; } = 0;

        public List<TaskDto> Tasks { get; set; } = new List<TaskDto>() { };

        public int UserId { get; set; }
    }
}
