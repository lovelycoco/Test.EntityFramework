﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Test.Core.Entities;
using Test.Core.Entities.Test;
using Test.Core.IRepository;
using Test.EntityFramework;
using Test.EntityFramework.Repositories;
using System.Data.Entity;
using System.Linq.Expressions;

namespace ConsoleApp
{
    class Program
    {
        private static int result = 0;
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            //Thread.Sleep(3000);

            //TestStudent();
            //TestUserRolePermission();
            //TestGetRolePermissions();
            TestGetRolePermissions1();
            stopWatch.Stop();
            Console.WriteLine(stopWatch.ElapsedMilliseconds);
            Console.ReadLine();
        }

        private static void TestStudent()
        {
            IRepository<Student> repository = new StudentRepository();
            try
            {
                repository.Add(new Student { Name = "小团团", Age = 2 });
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //延迟加载
        private static void TestGetRolePermissions()
        {
            StringBuilder sb = new StringBuilder();
            using (TestDbContext db = new TestDbContext())
            {
                db.Database.Log = Console.WriteLine;

                var roles = db.Set<Role>().AsNoTracking().ToList();
                foreach (var role in roles)
                {
                    foreach (var rolePermission in role.RolePermissions)
                    {
                        sb.Append(rolePermission.Role.RoleName);
                        sb.Append("-");
                        sb.Append(rolePermission.Permission.Name);
                        Console.WriteLine(sb.ToString());
                        sb.Clear();
                    }

                }
            }
        }
        //主动加载
        private static void TestGetRolePermissions1()
        {
            StringBuilder sb = new StringBuilder();
            using (TestDbContext db = new TestDbContext())
            {
                db.Database.Log = Console.WriteLine;

                var roles = db.Set<Role>()
                    .Include(r => r.RolePermissions)
                    .Include(r => r.RolePermissions.Select(rp => rp.Role))
                    .Include(r => r.RolePermissions.Select(rp => rp.Permission));
                    //.AsNoTracking().ToList();


                foreach (var role in roles)
                {
                    foreach (var rolePermission in role.RolePermissions)
                    {
                        sb.Append(rolePermission.Role.RoleName);
                        sb.Append("-");
                        sb.Append(rolePermission.Permission.Name);
                        Console.WriteLine(sb.ToString());
                        sb.Clear();
                    }

                }
            }
        }

        private static void TestUserRolePermission()
        {
            var user = new User { UserName = "wangjunpeng", Password = "123456", Email = "junpeng1949@163.com", NormalizedUserName = "王俊鹏" };
            var permission1 = new Permission { Name = "permission1", FeatureName = "权限1", Description = "权限1的描述" };
            var permission2 = new Permission { Name = "permission2", FeatureName = "权限2", Description = "权限2的描述" };
            var permission3 = new Permission { Name = "permission3", FeatureName = "权限3", Description = "权限3的描述" };
            var permission4 = new Permission { Name = "permission4", FeatureName = "权限4", Description = "权限4的描述" };
            var permission5 = new Permission { Name = "permission5", FeatureName = "权限5", Description = "权限5的描述" };
            var permissions = new List<Permission>();
            permissions.Add(permission1);
            permissions.Add(permission2);
            permissions.Add(permission3);
            permissions.Add(permission4);
            permissions.Add(permission5);
            var role = new Role { RoleName = "管理员" };
            var rolePermissions = new List<RolePermission>();
            using (TestDbContext db = new TestDbContext())
            {
                db.Database.Log = Console.WriteLine;
                using (var tran = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Set<User>().Add(user);
                        result = db.SaveChanges();


                        db.Set<Permission>().AddRange(permissions);
                        result = db.SaveChanges();


                        db.Set<Role>().Add(role);
                        result = db.SaveChanges();

                        foreach (var permission in permissions)
                        {
                            rolePermissions.Add(new RolePermission { Role = role, Permission = permission });
                        }

                        db.Set<RolePermission>().AddRange(rolePermissions);
                        result = db.SaveChanges();

                        //throw new Exception("我故意的。");
                    }
                    catch (Exception ex)
                    {
                        result = 0;
                    }
                    finally
                    {
                        if (result > 0)
                        {
                            tran.Commit();
                        }
                        else
                        {
                            tran.Rollback();
                        }
                    }

                }

            }
        }
    }
}