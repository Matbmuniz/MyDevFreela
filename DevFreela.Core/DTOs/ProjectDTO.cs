using DevFreela.Core.Entities;
using DevFreela.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevFreela.Core.DTOs
{
    public class ProjectDTO
    {
        public ProjectDTO(int id, string title, string description, decimal totalCost, DateTime createdAt, DateTime? finishedAt, string fullName1, string fullName2)
        {
            Title = title;
            Description = description;
            TotalCost = totalCost;
            CreatedAt = createdAt;
            FinishedAt = finishedAt;
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public int IdClient { get; private set; }
        public User Client { get; private set; }
        public int IdFreelancer { get; private set; }
        public User Freelancer { get; private set; }
        public decimal TotalCost { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? StartedAt { get; private set; }
        public DateTime? FinishedAt { get; private set; }
        public ProjectStatusEnum Status { get; private set; }
        public List<ProjectComment> Comments { get; private set; }
    }
}
