using Dapper;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using DevFreela.Infrastructure.Persistence;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Services.Implementations
{
    public class SkillService : ISkillService
    {
        private readonly DevFreelaDbContext _dbContext;
        private readonly string _connectString;
        public SkillService(DevFreelaDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _connectString = configuration.GetConnectionString("DevFreelaCs");
        }

        public List<SkillViewModel> GetAll()
        {
            //var skills = _dbContext.Skills;
            //var skillsViewModel = skills
            //    .Select(s => new SkillViewModel(s.Id, s.Description))
            //    .ToList();

            //return skillsViewModel;

            using (var sqlConnection = new SqlConnection(_connectString))
            {
                sqlConnection.Open();

                var script = "SELECT Id, Description FROM Skills";

                return sqlConnection.Query<SkillViewModel>(script).ToList();
            }
        }
    }
}
