using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example8
{
    
    public class studentSystem 
    {
        private Dictionary<string, student> repo;
        public Dictionary<string , student> Repo
        {
            get { return repo; }
           private set { repo = value; }
        }
        //public Dictionary<string,student> Repo { get; set; }
        public studentSystem()
        {
            this.Repo = new Dictionary<string, student>();

        }
        //student student = new student("hoang anh", 18, 1);
           public void ParseCommand()
        {
            String[] args = Console.ReadLine().Split();
            if (args[0] == "Create")
            {
                var name = args[1];
                var age = int.Parse(args[2]);
                var grade = double.Parse(args[3]);
                if (!repo.ContainsKey(name))
                {
                    var student = new student(name, age, grade);
                    Repo[name] = student;
                }
            }
            else if (args[0] == "Show")
            {
                var name = args[1];
                if (Repo.ContainsKey(name))
                {
                    var student = Repo[name];
                    string view = $"{student.Name } is { student.Age}  year old and  grade is {student.Grade}";
                    Console.WriteLine(view);
                }

               

            }else if(args[0] == "exit")
            {
                Environment.Exit(0);
            }
        }
    
    
    }




    public class student
    {
        private string name;
        private int age;
        private double grade;

        //public string grade { get; set; }
        public double Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public student()
        {

        }
        public student(string name, int age,double grade)
        {
            this.Name = name;//student st = new student();st.name
            this.Age = age;//đối tượng hiện tại của lớp "this"
            this.Grade = grade;

        }
        public student (string name)
        {
            this.Name = name;
        }
        student st = new student("anhduc", 18, 10);
        student st2 = new student("anh duc");
   

        student st3 = new student();
        
    }
}
