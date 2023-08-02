using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exam_System_C__Console_App
{
	public class McqQuestion : QuestionsBase
	{
		public override string Header => "Mcq Question";

		public McqQuestion()
		{
			answerList = new Answers[4];
		}


		public override void AddQuestion()
		{
			Console.Clear();
			Console.WriteLine(Header);
			Console.WriteLine("Please Enter the Body Of Question");
			body = Console.ReadLine();
			bool flag = true;
			double Mark;
			do
			{
				Console.Clear();
				Console.WriteLine("Enter The Marks Of this Q");
				flag = double.TryParse(Console.ReadLine(), out Mark);
			} while (!flag);
			mark = Mark;
			for (int i = 0; i < 4; i++)
			{
				answerList[i] = new Answers()
				{
					Answer_Id = i + 1,
				};
				Console.WriteLine($"Enter the ({i + 1}) Of Answer");
				answerList[i].AnswerText = Console.ReadLine();
			}

			int RightAnserIds;
			do
			{
				Console.WriteLine("Enter The Id Of Right Answer");


			} while (!(int.TryParse(Console.ReadLine(), out RightAnserIds)) && (RightAnserIds > 0) && (RightAnserIds < 4));


			rightAnswer.Answer_Id = RightAnserIds;
			rightAnswer.AnswerText = answerList[RightAnserIds - 1].AnswerText;
		}

	}
}

