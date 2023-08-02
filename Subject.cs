using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_System_C__Console_App
{
	public class Subject
	{
		int id;
		string Name;
		public Exam Subjectexam { get; set; }
		public Subject(int id, string name)
		{
			this.id = id;
			Name = name;
		}

		public void StartExam()
		{
            Console.WriteLine("Enter Time Between 30min ===>>>> 180Min");

			#region TimeExam
			int timeExam;
			bool flag;
			do
			{
				flag = int.TryParse(Console.ReadLine(), out timeExam);
				if (timeExam < 30 || timeExam > 180)
					flag = true;

			} while (!flag);
			#endregion

			#region Choose Number Of Q
			int numerQ;
            do
			{
				Console.WriteLine("Enter Number Of Q");

				flag = int.TryParse(Console.ReadLine(), out numerQ);


			} while (!flag);
      
            #endregion


            #region Choose Type Exam 
            int typeExam;

			do
			{
                Console.WriteLine("Enter type Exam ==> \n Fina (1) \n Practiacl (2)");
                flag = int.TryParse(Console.ReadLine(), out typeExam);
				if (typeExam == 1 || typeExam == 2)
					flag = false;



			} while (flag);





			#endregion

			#region Start Exam 
			if (typeExam == 1)
			{
				Subjectexam = new Final_Exam(timeExam, numerQ);
			}

			else
			{
				Subjectexam = new PrectiacalExam(timeExam, numerQ);
			}
			Subjectexam.CreateExam();
			#endregion



		}

		public void ShowExam()
		{
            Console.WriteLine("The End Of Exam");
			Subjectexam.ShowExam();

		}



	}
}
