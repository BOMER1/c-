using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapGroup2
{
    public class Manage_Exam_Questions
    {
        public static void Tao_Cau_Hoi_Thi()
        {
            int choice;
            do
            {
                Console.WriteLine("===========    Tao De Thi    ===========");
                Console.WriteLine("========================================");
                Console.WriteLine("1. De thi theo so luong cau hoi.");
                Console.WriteLine("2. De thi theo tong so diem.");
                Console.WriteLine("0. Tro ve Menu.");

                Console.WriteLine("Nhap lua chon cua ban : ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Create_Exam_BySL_Question();
                        break;
                    case 2:
                        Create_Exam_ByTotalScore();
                        break;
                    case 0:
                        break;
                }
            }
            while (choice != 0);
            Console.Clear();
        }


        // Tạo đề thi theo số lượng câu hỏi.
        public static void Create_Exam_BySL_Question()
        {
            Console.WriteLine(".....");
        }


        // Tạo đề thi theo tổng số điểm
        public static void Create_Exam_ByTotalScore()
        {
            Console.WriteLine("....");
        }


        // View Exam 
        public static void View_Exam_Questions()
        {
            Console.WriteLine("....");
        }
        public static void Create_Exam_Questions()
        {
            Console.WriteLine("....");
        }
    }
}
