using DevFreela.Core.Enum;
using System;
using System.Collections.Generic;

namespace DevFreela.Core.Entities
{
    public class Project : BaseEntity
    {
        public Project(string title, string description, int idClient, int idFreelancer, decimal? totalCost)
        {
            Title = title;
            Description = description;
            IdClient = idClient;
            IdFreelancer = idFreelancer;
            TotalCost = totalCost;

            CreateDate = DateTime.Now;
            Status = ProjectStatusEnum.Created;
            Comments = new List<ProjectComment>();  
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public int IdClient { get; private set; }
        public int IdFreelancer { get; private set; }
        public decimal? TotalCost { get; private set; }
        public DateTime CreateDate { get; private set; }
        public DateTime? StartedCreate { get; private set; }
        public DateTime? FinishedCreate { get; private set; }

        public ProjectStatusEnum Status { get; private set; }
        public List<ProjectComment> Comments { get; private set; }

        public void Cancel()
        {
            if (Status == ProjectStatusEnum.InProgress)
            {
                Status = ProjectStatusEnum.Cancelled;
            }
        }

        public void Start()
        {
            if (Status == ProjectStatusEnum.Created)
            {
                Status = ProjectStatusEnum.InProgress;
                StartedCreate = DateTime.Now;
            }
        }

        public void Finish()
        {
            if(Status == ProjectStatusEnum.InProgress)
            {
                Status = ProjectStatusEnum.Finished;
                FinishedCreate = DateTime.Now;
            }
        }

        public void Update(string title, string description, decimal? totalCost)
        {
            Title = title;
            Description = description;
            TotalCost = totalCost;
        }
    }
}
