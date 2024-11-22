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
    public class DITest2
    {
        public void Run(IRepositoryFactory factory)
        {
            IGenecricRepostory<Patient> repo = factory.GetRepo<Patient>();
            repo.Add(new Patient { Id = 1,  Name = "Md.Huraira", Address = "Agargong", Contact = "016XXXXXXX", Email = "star@gmail.com" });
            repo.Add(new Patient { Id = 2, Name = "Md.yousuf", Address = "Mirpur-2", Contact = "018XXXXXXX", Email = "r@gmail.com" });
            repo.Add(new Patient { Id = 3, Name = "Sotirtho Dash", Address = "Dhanmondi-15", Contact = "017XXXXXXX", Email = "a@gmail.com" });
            repo.Add(new Patient { Id = 4, Name = "Naran Chondro", Address = "Jomuna Future Park", Contact = "019XXXXXXX", Email = "j@gmail.com" });
            repo.Get()
           .ToList()
          .ForEach(p => Console.WriteLine($"Id:{p.Id}, Name: {p.Name},Address: {p.Address},Contact :{p.Contact} Email: {p.Email}"));
            //update
            Console.WriteLine("Patient  :");
            Console.WriteLine("===============");
            Console.WriteLine("------Patient Information Update-------");
            Console.WriteLine();
            var patient = repo.Get(2);
           patient.Contact = "019xxxxxxx";
            repo.Update(patient);
            repo.Get()
            .ToList()
            .ForEach(p => Console.WriteLine($"Id:{p.Id}, Name: {p.Name},Address: {p.Address},Contact :{p.Contact} Email: {p.Email}"));
            Console.WriteLine();
            //delete
            //delete
            Console.WriteLine("-------Patient Information Delete-------");
            Console.WriteLine();
            repo.Delete(3);
            repo.Get()
             .ToList()
             .ForEach(p => Console.WriteLine($"Id:{p.Id}, Name: {p.Name},Address: {p.Address},Contact :{p.Contact} Email: {p.Email}"));
            Console.WriteLine();
            Console.WriteLine("Doctor  :");
            Console.WriteLine("===============");

            IGenecricRepostory<Doctor> repo2 = factory.GetRepo<Doctor>();
            repo2.Add(new Doctor { Id = 1,DoctorName= "Prof. Kamim",Degrees= "M.B.B.S, F.C.P.S. ",Salary=50000,Address="Agargong",PhoneNo="016xxxxx",Email= "k@gmail.com" });
            repo2.AddRange(new Doctor[] {
                new Doctor{ Id = 2,DoctorName= "Professor Dr Kazi",Degrees= "MBBS  ",Salary=450000,Address="Nabin Nagar",PhoneNo="018xxxxx",Email= "k@gmail.com" },
                 new Doctor{ Id = 3,DoctorName = "Prof. Dr. Shovo", Degrees = "MBBS, FCPS (Medicine)", Salary = 200000, Address = "Mirpur-14", PhoneNo = "015xxxxx", Email = "s@gmail.com" },
                  new Doctor{ Id = 4,DoctorName = "Prof. Dr. Rashed", Degrees ="MD (Cardiology),MBBS  ", Salary = 100000, Address = "KawraBazar", PhoneNo = "019xxxxx", Email = "r@gmail.com" }
            });
            Console.WriteLine();
            repo2.Get()
                .ToList()
                .ForEach(b => Console.WriteLine($"Id :{b.Id}, Doctor Name: {b.DoctorName}, Degrees: {b.Degrees}, Salary: {b.Salary:C}\nAddress :{b.Address}, Phone Number :{b.PhoneNo}, Email :{b.Email}"));
            Console.WriteLine();
            //update
            Console.WriteLine("------ Doctor Update-------");
            Console.WriteLine();
            var doctor = repo2.Get(2);
            doctor.Salary = 35000;
            repo2.Update(doctor);
            Console.WriteLine();
            repo2.Get()
                .ToList()
                .ForEach(b => Console.WriteLine($"Id :{b.Id}, Doctor Name: {b.DoctorName}, Degrees: {b.Degrees}, Salary: {b.Salary:C}\nAddress :{b.Address}, Phone Number :{b.PhoneNo}, Email :{b.Email}")); ;
            //delete
            Console.WriteLine("------- Doctor Delete-------");
            Console.WriteLine();
            repo2.Delete(3);
                        Console.WriteLine();
            repo2.Get()
                .ToList()
                .ForEach(b => Console.WriteLine($"Id :{b.Id}, Doctor Name: {b.DoctorName}, Degrees: {b.Degrees}, Salary: {b.Salary:C}\nAddress :{b.Address}, Phone Number :{b.PhoneNo}, Email :{b.Email}"));
            Console.WriteLine();
        }
    }
}
