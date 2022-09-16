﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.ViewModels
{
    public class ProjectDetailsViewModel
    {
        public ProjectDetailsViewModel(int id, string title, 
                                        string description, decimal? totalCost, 
                                        DateTime? dateCreate, DateTime? dateFinished,
                                        string clienteFullName, string freelancerFullName)
        {
            Id = id;
            Title = title;
            Description = description;
            TotalCost = totalCost;
            DateCreate = dateCreate;
            DateFinished = dateFinished;
            ClienteFullName = clienteFullName;
            FreelancerFullName = freelancerFullName;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public decimal? TotalCost { get; private set; }
        public DateTime? DateCreate { get; private set; }
        public DateTime? DateFinished { get; private set; }
        public string ClienteFullName { get; private set; }
        public string FreelancerFullName { get; private set; }
    }
}
