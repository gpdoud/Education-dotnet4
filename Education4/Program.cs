using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education4 {
	class Program {
		static void Main(string[] args) {

			Instructor danTheMan = new Instructor();
			danTheMan.Name = "Dan";
			danTheMan.ExperienceInYears = 17;
			danTheMan.PrimaryLanguage = "Csharp";
			danTheMan.Email = "danTheMan@military.gov";
			danTheMan.Phone = "123-456-7890";

			Class dotnetbc4 = new Class();
			dotnetbc4.Capacity = 16;
			dotnetbc4.Code = "DN4";
			dotnetbc4.Language = "CSharp";
			dotnetbc4.Name = "Dot Net Boot Camp 4";
			dotnetbc4.Instructor = danTheMan;

			Student foster = new Student();
			foster.Absences = 0;
			foster.ContactInfo = "Call Foster...";
			foster.FirstJob = DateTime.MinValue;
			foster.Name = "Foster";
			foster.Class = dotnetbc4;

			Student jj = new Student();
			jj.Absences = 0;
			jj.ContactInfo = "Call Jon";
			jj.FirstJob = DateTime.MinValue;
			jj.Name = "Jonathan";
			jj.Class = dotnetbc4;

			dotnetbc4.Students.Add(foster);
			dotnetbc4.Students.Add(jj);

		}
	}
}
