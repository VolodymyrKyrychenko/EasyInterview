using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models.Problem
{
    public class ProblemViewModel
    {
        public string Name { get; set; }

        public string Condition { get; set; }

        public string Notation { get; set; }

        public string Example { get; set; }

        public string Template { get; set; }

        public int Level { get; set; }

        //public ICollection<LibraryProblem> Libraries { get; set; }

        public ICollection<TestViewModel> Tests { get; set; }

        //public ICollection<ProblemTag> Tags { get; set; }
    }
}
