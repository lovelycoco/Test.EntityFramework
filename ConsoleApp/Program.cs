using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Test.Core.Entities;
using Test.Core.IRepository;
using Test.EntityFramework.Repositories;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            //Thread.Sleep(3000);

            IRepository<Student> repository = new StudentRepository();

            repository.Add(new Student { Name = "小团团", Age = 2 });


            stopWatch.Stop();
            Console.WriteLine(stopWatch.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}
