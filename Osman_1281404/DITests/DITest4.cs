using Osman_1281404.Models;
using Osman_1281404.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osman_1281404.DITests
{
    public class DITest4
    {
       
        public void Run(IGenecricRepostory<Patient> repo)
        {
            Console.WriteLine("Patient  :");
            Console.WriteLine("===============");
            repo.Add(new Patient { Id = 1, Name = "Md.Osman", Address = "Shewrapara", Contact = "018XXXXXXX", Email = "star@gmail.com" });
            repo.Add(new Patient { Id = 2, Name = "Md.Zakir", Address = "Mirpur-2", Contact = "019XXXXXXX", Email = "r@gmail.com" });
            repo.Add(new Patient { Id = 3, Name = "FarZana", Address = "Dhanmondi-15", Contact = "017XXXXXXX", Email = "a@gmail.com" });
            repo.Add(new Patient { Id = 4, Name = "Naran ", Address = "Jomuna Future Park", Contact = "014XXXXXXX", Email = "j@gmail.com" });
            repo.Get()
           .ToList()
          .ForEach(p => Console.WriteLine($"Id:{p.Id}, Name: {p.Name},Address: {p.Address},Contact :{p.Contact} Email: {p.Email}"));
            //update
            Console.WriteLine();
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
        }
    }
}
