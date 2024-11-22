using Osman_1281404.Models;
using Osman_1281404.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osman_1281404.DITests
{
    public class DITest3
    {

        IGenecricRepostory<Doctor> repo;
        public DITest3(IGenecricRepostory<Doctor> repo)
        {
            this.repo = repo;
        }
        public void Run()
        {
            repo.Add(new Doctor { Id = 1, DoctorName = "Nesa Malik", Degrees = "F.C.P.S. (Medicine),  F.R.C.P ", Salary = 20000, Address = "Agargong", PhoneNo = "016xxxxx", Email = "f@gmail.com" });
            repo.AddRange(new Doctor[] {
                new Doctor{ Id = 2,DoctorName= "Dr Mir Ahmed",Degrees= "MD (Cardiology)  ",Salary=150000,Address="KaziPara",PhoneNo="016xxxxx",Email= "k@gmail.com" },
                 new Doctor{ Id = 3,DoctorName = "Prof. Dr. Badiuzzaman", Degrees = " MD (Cardiology), FACC ", Salary = 200000, Address = "Mirpur-10", PhoneNo = "015xxxxx", Email = "M@gmail.com" },
                  new Doctor{ Id = 4,DoctorName = "Prof. Dr. Nayeem Ahmed", Degrees ="MD (Cardiology),MBBS  ", Salary = 100000, Address = "Mirpur-1", PhoneNo = "013xxxxx", Email = "P@gmail.com" }
            });
            Console.WriteLine("Doctor  :");
            Console.WriteLine("===============");
            Console.WriteLine();
            repo.Get()
                .ToList()
                .ForEach(b => Console.WriteLine($"Id :{b.Id}, Doctor Name: {b.DoctorName}, Degrees: {b.Degrees}, Salary: {b.Salary:C}\nAddress :{b.Address}, Phone Number :{b.PhoneNo}, Email :{b.Email}"));
            Console.WriteLine();

        }
    }
}