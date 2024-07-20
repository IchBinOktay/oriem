using Azure;
using ConsoleApp29.Contants;
using ConsoleApp29.Services;
using System.Runtime.InteropServices.ObjectiveC;
using static ConsoleApp29.Services.TeacherService;

namespace ConsoleApp29;

public static class Program
{
    public static void Main()
    {
        bool continuty = true;
        while (continuty)
        {
            ShowMenu();
            Messages.InputMessage("Choise");
            string choiceInput = Console.ReadLine();
            int choice;
            bool isSucceeded = int.TryParse(choiceInput, out choice);

            if (isSucceeded)
            {
                switch ((Operations)choice)
                {
                    case Operations.Exit:
                        continuty = false;
                        return;
                    case Operations.AllTeachers:
                        TeacherServices.GetAllTeachers();
                        break;
                    case Operations.CreateTeacher:
                        TeacherServices.CreateTeacher();
                        break;
                    case Operations.RemoveTeacher:
                        TeacherServices.RemoveTeacher();
                        break;
                    case Operations.UpdateTeacher:
                        TeacherServices.UpdateTeacher();
                        break;
                    case Operations.DetailsOfTeacher:
                        TeacherServices.DetailsTeacher();
                        break;
                    case Operations.CreateGroup:
                        GroupServices.CreateGroup();
                        break;
                    case Operations.UpdateGroup:
                        GroupServices.UpdateGroup();
                        break;
                    case Operations.RemoveGroup:
                        GroupServices.RemoveGroup();
                        break;
                    case Operations.DetailsOfGroup:
                        GroupServices.DetailsGroup();
                        break;
                    case Operations.AllStudents:
                        StudentServices.AddStudentToGroup();
                        break;
                    case Operations.AddStudent:
                        StudentServices.CreateStudent();
                        break;
                    case Operations.UpdateStudent:
                        StudentServices.UpdateStudent();
                        break;
                    case Operations.RemoveStudent:
                        StudentServices.RemoveStudent();
                        break;
                    case Operations.DetailsOfStudent:
                        StudentServices.DetailsStudent();
                        break;


                    default:
                        Messages.InvalidInputMessage("choice");
                        break;
                }
            }
            else
            {
                Messages.InvalidInputMessage("choice");
            }
        }
    }

    public static void ShowMenu()
    {
        Console.WriteLine("------MENU------");
        Console.WriteLine("1.All teachers");
        Console.WriteLine("2.Add teacher");
        Console.WriteLine("3.Delete teacher");
        Console.WriteLine("4.Update teacher");
        Console.WriteLine("5.Details of teacher");
        Console.WriteLine("0.Exit");
    }
}
