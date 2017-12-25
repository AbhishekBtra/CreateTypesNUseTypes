using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAndnUseTypes
{
    class TeamMember
    {
                public TeamMember(string fullName,
                string title = "Unknown",
                   string team = "Unknown",
                 bool isFullTime = false,
                TeamMember manager = null)
                {
                    FullName = fullName;
                    Title = title;
                    Team = team;
                    IsFullTime = isFullTime;
                    Manager = manager;
                }
        public string FullName { get; private set; }
        public string Title { get; private set; }
        public string Team { get; private set; }
        public bool IsFullTime { get; private set; }
        public TeamMember Manager { get; private set; }
    }
}
