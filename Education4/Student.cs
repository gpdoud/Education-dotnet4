﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education4 {
	class Student {

		public string Name { get; set; }
		public Class Class { get; set; }
		public string ContactInfo { get; set; }
		public DateTime? FirstJob { get; set; }
		public int Absences { get; set; }
		public List<Assignment> Assignments = new List<Assignment>();

	}
}
