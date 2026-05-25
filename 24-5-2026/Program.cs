using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace _24_5_2026
{
    ////DATA ABSTRACTION  
    //class Employee
    //{
    //    int empid;
    //    string empname;
    //    double empsal;
    //    string empdesignation;
    //    public Employee(int eid,string ename,double esal,string edesig)
    //    {
    //        empid=eid;
    //        empname=ename;
    //        empsal=esal;
    //        empdesignation=edesig;
    //    }
    //    public void display()//IN THIS METHOD  THERE IS NO DATA ABSTRACTION 
    //    {
    //        Console.WriteLine("Employee id is:" + empid);
    //        Console.WriteLine("Employee name is:"+empname);
    //        Console.WriteLine("Employee salary is:"+empsal);
    //        Console.WriteLine("Employee designation is :"+empdesignation);
    //    }
    //    public void hike()//IN THIS METHOD WE HAVE AN ABSTRACTION THAT IS NOTHING BUT ,HERE WE ARE HIDING NAME DATA AND DESIGNAMTION DATA 
    //    {
    //        double insal = empsal * 0.20;
    //        double totsal = empsal + insal;
    //        Console.WriteLine("employee hilesal is:" + insal);
    //        Console.WriteLine("employee total sal after hike:"+totsal);
    //    }
    //}
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Employee emp = new Employee(1, "janani", 100000, "IT");
    //        emp.display();
    //        emp.hike();
    //    }
    //}
    //===========================================================================================================================================

    //class Company
    //{
    //    int cid;
    //    string cname;
    //    string caddress;
    //    public Company(int id,string name,string address)
    //    {
    //        cid = id;
    //        cname = name;
    //        caddress=address;
    //    }
    //    public void Display()
    //    {
    //        Console.WriteLine("Company id is:"+cid);
    //        Console.WriteLine("Company name is:"+cname);
    //        Console.WriteLine("Company address is:" + caddress);
    //    }
    //}
    //class Employee:Company
    //{
    //    int Empid;
    //    string empname;
    //    double empsal;
    //    public Employee(int eid, string name, double esal):base(1,"aa","hyd")
    //    { 
    //        Empid= eid;
    //        empname= name;
    //        empsal = esal;
    //    }
    //    public void EmpData()
    //    {
    //        Console.WriteLine("Employee id is:"+Empid);
    //        Console.WriteLine("Employee name is:" + empname);
    //        Console.WriteLine("Employee salary is:" + empsal);
    //    }
    //}
    //internal class program
    //{
    //    static void Main(string[] args)
    //    {
    //        Company c = new Company(1,"janai","IT");
    //        c.Display();
    //        Employee e = new Employee(1, "jkjjk",25000);
    //        e.EmpData();                                                                                                                                                                                                                                                                                   
    //    }
    //}
    //=================================================================================================

    //-=-=-=-=-=-=-=-=-=-=-=-=-=INHERITANCE EXAMPLE-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
    //class Branch
    //{
    //    int bid;
    //    string bname;
    //    string baddress;
    //    public Branch(int  bid, string bname, string baddress)
    //    {
    //        this.bid = bid;
    //        this.bname = bname;
    //        this.baddress = baddress;
    //    }
    //    public void BranchData()
    //    {
    //        Console.WriteLine("Branch id is=" + bid);
    //        Console.WriteLine("Branch name is="+bname);
    //        Console.WriteLine("bramch address is=" + baddress);
    //    }
    //}
    //class Student:Branch
    //{
    //    int sid;
    //    string sname;
    //    string scollege;
    //    public Student(int sid,string sname,string scollege):base(111,"AAA","Hyderabad")
    //    {
    //        this.sid= sid;
    //        this.sname= sname;
    //        this.scollege= scollege;
    //    }
    //    public void StudentData()
    //    {
    //        Console.WriteLine("Student id is:" + sid);
    //        Console.WriteLine("Student name is:" + sname);
    //        Console.WriteLine("Student  college is:" + scollege);
    //        base.BranchData();
    //    }
    //}
    //internal class program
    //{
    //    static void Main(string[] args)
    //    {
    //        Student std = new Student(1, "janani", "RIMS");
    //        std.StudentData();
    //       // std.BranchData();
    //    }
    //}

    //====================================================================================================
    //
    //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=PROTECTED ACCESS MODIFIER=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
    //class Myclass
    //{
    //    protected int a = 10;
    //    public void method1()
    //    {
    //        Console.WriteLine("value of a is:" + a);
    //    }
    //}
    //class NewClass : Myclass
    //{
    //    public void method2()
    //    {
    //        Console.WriteLine(" a value is: " + a);
    //    }
    //}
    //internal class program
    //{
    //    static void Main(string[] args)
    //    {
    //        NewClass obj = new NewClass();
    //        obj.method1();
    //        obj.method2();
    //    }
    //}

    class Student
    {
        protected int sid;
        protected string sname;
        protected string saddress;
        public Student( int sid,string sname,string saddress)
        {
            this.sid = sid;
            this.sname = sname;
            this.saddress = saddress;
        }

    }
    class College:Student
    {
        int cid;
        string cname;
        string caddress;
        public College( int cid,string cname,string caddress):base(1,"janani","Hyderabad")
        {
            this.cid = cid;
            this.cname = cname;
            this.caddress = caddress;
        }
        public void Collegedata()
        {
            Console.WriteLine("college id is:" + cid);
            Console.WriteLine("College name is:" + cname);
            Console.WriteLine("College address is:" + caddress);
        }
        public void Studentdata()
        {
            Console.WriteLine("Student id is:" + sid);
            Console.WriteLine("student name is:" + sname);
            Console.WriteLine("Student address is:" + saddress);
        }

    }
    internal class program
    {
        static void Main(string[] args)
        {
            College obj = new College(327, "RIMS", "Ameerpet");
            obj.Studentdata();
            obj.Collegedata();
        }
    }
}










