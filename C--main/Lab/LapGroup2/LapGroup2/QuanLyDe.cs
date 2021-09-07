using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapGroup2
{
    public class QuanLyDe
    {
        public static void Menu()
        {
            int choice;
            do
            {
                Console.WriteLine("=====   CHUONG TRINH QUAN LY DE THI   =====");
                Console.WriteLine("========================================");
                Console.WriteLine("1. Quan ly cau hoi/Cau tra loi.");
                Console.WriteLine("2. Quan ly de thi.");
                Console.WriteLine("0. Exit");

                Console.WriteLine("Nhap lua chon cua ban : ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        QuestionAndAnswer_Managemnet();
                        break;
                    case 2:
                        Manage_ExamQuestion();
                        break;
                    case 0:
                        break;
                    default:
                        break;
                }
            } while (choice != 0);
            Console.Clear();

        }


        public static void QuestionAndAnswer_Managemnet()
        {
            int choice;
            do
            {
                Console.WriteLine("======  QUAN LY CAU HOI/CAU TRA LOI  ======");
                Console.WriteLine("========================================");
                Console.WriteLine("1. Xem danh sach Q/A.");
                Console.WriteLine("2. Cap nhat Q/A.");
                Console.WriteLine("3. Tao moi 1 Q/A.");
                Console.WriteLine("0. Tro ve Menu chinh.");


                Console.WriteLine("Nhap lua chon cua ban: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        CauHoi_CauTraLoi.ViewQuestionAndAnswer();
                        break;
                    case 2:
                        CauHoi_CauTraLoi.Update_QuestionAndAnswer();
                        break;
                    case 3:
                        CauHoi_CauTraLoi.Add_QuestionAndAnswer();
                        break;
                    case 0:
                        break;
                }
            }
            while (choice != 0);
            Console.Clear();
        }


        public static void Manage_ExamQuestion()
        {
            int choice;
            do
            {
                Console.WriteLine("======    QUAN LY DE THI   ======");
                Console.WriteLine("=================================");
                Console.WriteLine("1. Xem de thi.");
                Console.WriteLine("2. Tao de thi.");
                Console.WriteLine("0. Tro ve Menu chinh.");


                Console.WriteLine("Nhap lua chon cua ban : ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Manage_Exam_Questions.View_Exam_Questions();
                        break;
                    case 2:
                        Manage_Exam_Questions.Create_Exam_Questions();
                        break;
                    case 0:
                        break;
                }
            }
            while (choice != 0);
            Console.Clear();
        }
    }
}
