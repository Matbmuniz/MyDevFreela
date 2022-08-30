using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("Meu Projeto ASP.NET Core", "Minha Descrição de projeto", 1, 1, 10000),
                new Project("Meu Projeto ASP.NET Core 1", "Minha Descrição de projeto 2", 1, 1, 20000),
                new Project("Meu Projeto ASP.NET Core 2", "Minha Descrição de projeto 3", 1, 1, 30000),
            };

            Users = new List<User>
            {
                new User("Matheus", "matheus@gmail.com", new DateTime(1999, 11, 11)),
                new User("Barreto", "Barreto@gmail.com", new DateTime(1998, 11, 11)),
                new User("Muniz", "Muniz@gmail.com", new DateTime(1997, 11, 11))
            };

            Skills = new List<Skill>
            {
                new Skill("Javascript"),
                new Skill(".NET Core"),
                new Skill("Sql Server")
            };
        }
        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
