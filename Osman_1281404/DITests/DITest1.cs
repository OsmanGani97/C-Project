using Osman_1281404.Factories;
using Osman_1281404.Models;
using Osman_1281404.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osman_1281404.Tests
{
    public class DITest1
    {

        IRepositoryFactory factory;

        public DITest1(IRepositoryFactory factory)
        {
            this.factory = factory;
        }
        public void Run()
        {
            IGenecricRepostory<Doctor> repo = this.factory.GetRepo<Doctor>();
            repo.Add(new Doctor { Id = 1,DoctorName= "Prof. Fazila-Tun-Nesa Malik",Degrees= "M.B.B.S, F.C.P.S. (Medicine),  F.R.C.P ",Salary=250000,Address="Agargong",PhoneNo="016xxxxx",Email= "f@gmail.com" });
            repo.AddRange(new Doctor[] {
                new Doctor{ Id = 2,DoctorName= "Professor Dr Mir Nesaruddin Ahmed",Degrees= "MD (Cardiology),MBBS  ",Salary=150000,Address="Savar",PhoneNo="019xxxxx",Email= "k@gmail.com" },
                 new Doctor{ Id = 3,DoctorName = "Prof. Dr. Mohammad Badiuzzaman", Degrees = "MBBS, FCPS (Medicine), MD (Cardiology), FACC ", Salary = 200000, Address = "Mirpur-10", PhoneNo = "018xxxxx", Email = "M@gmail.com" },
                  new Doctor{ Id = 4,DoctorName = "Prof. Dr. Nazir Ahmed", Degrees ="MD (Cardiology),MBBS  ", Salary = 100000, Address = "SHEWRAPARA", PhoneNo = "017xxxxx", Email = "P@gmail.com" }
            });
            Console.WriteLine("Doctor  :");
            Console.WriteLine("===============");
            repo.Get()
                .ToList()
                .ForEach(b => Console.WriteLine($"Id :{b.Id}, Doctor Name: {b.DoctorName}, Degrees: {b.Degrees}, Salary: {b.Salary:C}\nAddress :{b.Address}, Phone Number :{b.PhoneNo}, Email :{b.Email}"));
            Console.WriteLine();
            //update
            Console.WriteLine("------ Doctor Update-------");
            Console.WriteLine();
            var doctor = repo.Get(2);
            doctor.Salary = 35000;
            repo.Update(doctor);
            Console.WriteLine();
            repo.Get()
                .ToList()
                .ForEach(b => Console.WriteLine($"Id :{b.Id}, Doctor Name: {b.DoctorName}, Degrees: {b.Degrees}, Salary: {b.Salary:C}\nAddress :{b.Address}, Phone Number :{b.PhoneNo}, Email :{b.Email}")); ;
            //delete
            Console.WriteLine("------- Doctor Delete-------");
            Console.WriteLine();
            repo.Delete(3);
                        Console.WriteLine();
            repo.Get()
                .ToList()
                .ForEach(b => Console.WriteLine($"Id :{b.Id}, Doctor Name: {b.DoctorName}, Degrees: {b.Degrees}, Salary: {b.Salary:C}\nAddress :{b.Address}, Phone Number :{b.PhoneNo}, Email :{b.Email}"));
            Console.WriteLine();
            Console.WriteLine("Patient :");
            
            Console.WriteLine("===============");
            IGenecricRepostory<Patient> repo1 = factory.GetRepo<Patient>();
            repo1.Add(new Patient { Id = 1, Name = "Md.Huraira", Address = "Agargong", Contact = "016XXXXXXX", Email = "star@gmail.com" });
            repo1.Add(new Patient { Id = 2, Name = "Md.yousuf", Address = "Mirpur-2", Contact = "018XXXXXXX", Email = "r@gmail.com" });
            repo1.Add(new Patient { Id = 3, Name = "Sotirtho Dash", Address = "Dhanmondi-15", Contact = "017XXXXXXX", Email = "a@gmail.com" });
            repo1.Add(new Patient { Id = 4, Name = "Naran Chondro", Address = "Jomuna Future Park", Contact = "019XXXXXXX", Email = "j@gmail.com" });
            repo1.Get()
           .ToList()
          .ForEach(p => Console.WriteLine($"Id:{p.Id}, Name: {p.Name},Address: {p.Address},Contact :{p.Contact} Email: {p.Email}"));
            //update
            Console.WriteLine();
            Console.WriteLine("------Patient Information Update-------");
            Console.WriteLine();
            var patient = repo1.Get(2);
            patient.Email = "o@gmail.com";
            repo1.Update(patient);
            repo1.Get()
            .ToList()
            .ForEach(p => Console.WriteLine($"Id:{p.Id}, Name: {p.Name},Address: {p.Address},Contact :{p.Contact} Email: {p.Email}"));
            Console.WriteLine();
            //delete
            //delete
            Console.WriteLine("-------Patient Information Delete-------");
            Console.WriteLine();
            repo1.Delete(3);
            repo1.Get()
             .ToList()
             .ForEach(p => Console.WriteLine($"Id:{p.Id}, Name: {p.Name},Address: {p.Address},Contact :{p.Contact} Email: {p.Email}"));
            Console.WriteLine();

        }
    }
}
