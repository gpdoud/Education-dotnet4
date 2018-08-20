﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education4 {
	class Class {
		/// <summary>
		/// 
		/// </summary>
		public string Name { get; set; }
		private string _Language;
		/// <summary>
		/// Language accepts only Csharp or Java
		/// </summary>
		public string Language {
			get {
				return _Language;
			}
			set {
				if(value.ToUpper() == "CSHARP" || value.ToUpper() == "JAVA") {
					_Language = value;
				} else {
					throw new ApplicationException("Language must be CSharp or Java");
				}
			}
		} // CSharp or Java
		public string Code { get; set; }
		public int Capacity { get; set; }
		public Instructor Instructor { get; set; }
		public List<Student> Students = new List<Student>();

		public void DistributeAssignment(Assignment assignment) {
			foreach(Student student in Students) {
				Assignment asgn = new Assignment();
				asgn.AssignmentId = assignment.AssignmentId;
				asgn.Comments = assignment.Comments;
				asgn.Grade = assignment.Grade;
				asgn.Name = assignment.Name;
				student.Assignments.Add(asgn);
			}
			try {
				int x = 0;
				int y = 1 / x;
			} catch (DivideByZeroException ex) {
				Console.WriteLine(ex.Message);
				Console.ReadLine();
			} catch(Exception ex) {
				throw ex;
			}
		}
	}
}
