using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp7
{
    class TestStudent
    { 
        public List<Student> Students = null;
        public ControlStudent()
        {
            Students = new List<Student>();
        }
        public int GenID()
        {
            int max = 1;
            if (Students != null && Students.Count > 0)
            {
                max = Students[0].ID;
                foreach (Student st in Students)
                {
                    if (max < st.ID)
                    {
                        max = st.ID;
                    }
                }
                max++;
            }
            return max;
        }
        public int NumStudent()
        {
            int Count = 0;
            if (Students != null)
            {
                Count = Students.Count;
            }
            return Count;
        }
        public void InsertInfo()
        {
            Student st = new Student();
            st.ID = GenID();
            Console.WriteLine("Student Name:");
            st.Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Student Age: ");
            st.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Student DoB: ");
            st.DoB = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Student Class: ");
            st.Class = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Student Mark1: ");
            st.Mark1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Student Mark2: ");
            st.Mark2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Student Mark3: ");
            st.Mark3 = Convert.ToInt32(Console.ReadLine());
            Average(st);
        }
        
        public void UpdateSutdent(int ID)
        {
            
            Student st = FindByID(ID);
            if (st != null)
            {
                Console.Write("Student Name: ");
                string NewName = Convert.ToString(Console.ReadLine());
                if (NewName != null && NewName.Length > 0)
                {
                    st.Name = NewName;
                }

                Console.Write("Student Age: ");
                string NewAge = Convert.ToString(Console.ReadLine());
                if (NewAge != null && NewAge.Length > 0)
                {
                    st.Age = Convert.ToInt32(NewAge);
                }

                Console.Write("Student DoB: ");
                string NewDoB = Convert.ToString(Console.ReadLine());
                if (NewDoB != null && NewDoB.Length > 0)
                {
                    st.DoB = Convert.ToString(NewDoB);
                }

                Console.Write("Student Mark1: ");
                string NewMark1 = Convert.ToString(Console.ReadLine());
                if (NewMark1 != null && NewMark1.Length > 0)
                {
                    st.Mark1 = Convert.ToInt32(NewMark1);
                }
                Console.Write("Student Mark2: ");
                string NewMark2 = Convert.ToString(Console.ReadLine());
                if (NewMark2 != null && NewMark2.Length > 0)
                {
                    st.Mark2 = Convert.ToInt32(NewMark2);
                }
                Console.Write("Student Mark3: ");
                string NewMark3 = Convert.ToString(Console.ReadLine());
                if (NewMark3 != null && NewMark3.Length > 0)
                {
                    st.Mark3 = Convert.ToInt32(NewMark3);
                }
                Average(st);
            }
            else
            {
                Console.WriteLine("Student ID = {0} do not exsits.", ID);
            }
            
        }
        public void SortByName()
        {
            Students.Sort(delegate (Student st1, Student st2) {
                return st1.Name.CompareTo(st2.Name);
            });
        }
        public bool DeleteById(int ID)
        {
            bool IsDeleted = false;
            Student st = FindByID(ID);
            if (st != null)
            {
                IsDeleted = Students.Remove(st);
            }
            return IsDeleted;
        }


    }
       


}

