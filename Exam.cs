using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_System_C__Console_App
{
	public abstract class Exam
	{


        public int Time { get; set; }

        public int NumbrtOfQuestions { get; set; } 
		public Exam(int time, int numbrtOfQuestions)
		{
			Time = time;
			NumbrtOfQuestions = numbrtOfQuestions;
		}

        public QuestionsBase[] ListQuestions { get; set; }

		public abstract void ShowExam();

		public abstract void CreateExam();
		public override string ToString()
		{
			return base.ToString();
		}


	}
}
