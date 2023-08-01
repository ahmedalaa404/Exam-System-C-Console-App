﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_System_C__Console_App
{
	public class Final_Exam : Exam

	{

		public Final_Exam(int time, int numbrtOfQuestions) : base(time, numbrtOfQuestions)
		{

		}

		public override void CreateExam()
		{
			ListQuestions = new QuestionsBase[NumbrtOfQuestions];
			for (int i = 0; i < ListQuestions.Length; i++)
			{
				int Choose;
				bool flage = false;
				do
				{
					Console.WriteLine("Enter 1 - MCq \n 2 -True||False ");
					flage = int.TryParse(Console.ReadLine(), out Choose);
					if (Choose == 1 && Choose == 2)
						flage = true;


				} while (!flage);
				if (Choose == 1)
				{
					ListQuestions[i]=new McqQuestion();
					ListQuestions[i].AddQuestion();
				}
				else
				{
					ListQuestions[i] = new TFQuestions();
					ListQuestions[i].AddQuestion();
				}

			}

		}

		public override void ShowExam()
		{
			for (int i = 0; i < ListQuestions.Length; i++)
			{
                Console.WriteLine(ListQuestions[i]);
				for (int n = 0; n < ListQuestions[i].answerList.Length; n++)
				{
					Console.WriteLine((ListQuestions[i].answerList[n]) + "\n");
                }
                Console.WriteLine("Enter The Id Of Answers");
				int Answerid;
				bool Flage=false;
				do
				{
					Flage = int.TryParse(Console.ReadLine(), out Answerid);
					if(Answerid>0 &&Answerid<4)
						Flage=true;

				} while (!Flage);

				ListQuestions[i].UserAnswer.Answer_Id = Answerid;
				ListQuestions[i].UserAnswer.AnswerText = ListQuestions[i].answerList[Answerid-1].AnswerText;


			}
            Console.Clear();
			double totalMark=0;
			double grade=0;
			for (int i = 0; i < ListQuestions.Length; i++)
			{
				totalMark += ListQuestions[i].mark;
				if (ListQuestions[i].UserAnswer.Answer_Id == ListQuestions[i].rightAnswer.Answer_Id)
				{
					grade += ListQuestions[i].mark;
				}
				Console.WriteLine($"Q {i+1} {ListQuestions[i].Body} \t ({ListQuestions[i].mark}) \t");
				Console.WriteLine($"U Answer Is = {ListQuestions[i].UserAnswer.AnswerText}");
				Console.WriteLine($"Right Answer Is = {ListQuestions[i].rightAnswer.AnswerText}");



			}
			Console.WriteLine($"total Marks {totalMark}    /t u Grade ==  {grade}");

		}
	}
}