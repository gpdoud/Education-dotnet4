using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education4 {
	class Instructor {

		public string Name { get; set; }
		public int ExperienceInYears { get; set; }
		public string PrimaryLanguage { get; set; } // CSharp or Java
		public string Email { get; set; }
		public string Phone { get; set; }

		public Assignment CreateAssignment(string name, string assignmentId) {
			Assignment asgn = new Assignment();
			asgn.Comments = null;
			asgn.Grade = null;
			asgn.Name = name;
			asgn.AssignmentId = assignmentId;
			return asgn;
		}

	}
}
