using System;
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
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;

namespace ConsoleApp
{
    class Program
    {
        private static int result = 0;
        static void Main(string[] args)
        {

            using (var dbcontext = new TestDbContext())
            {
                var objectContext = ((IObjectContextAdapter)dbcontext).ObjectContext;
                var mappingCollection = (StorageMappingItemCollection)objectContext.MetadataWorkspace.GetItemCollection(DataSpace.CSSpace);
                mappingCollection.GenerateViews(new List<EdmSchemaError>());
            }


            var stopWatch = new Stopwatch();
            stopWatch.Start();
            //Thread.Sleep(3000);
            //TestRetrieveDataDictInfo();
            //TestStudent();
            //TestUserRolePermission();
            //TestGetRolePermissions();
            //TestGetRolePermissions1();
            //TestQueryExits();
            //TestQueryPages();
            //TestQueryContains();
            //TestCreateBatch();

            TestDataDictionary();

            stopWatch.Stop();
            Console.WriteLine(stopWatch.ElapsedMilliseconds);
            Console.ReadLine();
        }

        private async static void TestDataDictionary()
        {
            List<DataDictionaryInfo> dataDictionaryInfos = new List<DataDictionaryInfo>();
            int result = 0;
            using (var db = new TestDbContext())
            {
                db.Database.Log = Console.WriteLine;
                using (var tran = db.Database.BeginTransaction())
                {
                    try
                    {
                        var dict = await db.Set<DataDictionary>().AsNoTracking().FirstOrDefaultAsync();
                        if (dict is null)
                        {
                            dict = db.Set<DataDictionary>().Add(new DataDictionary { DictionaryName = "仓储备货类型" });
                            result = await db.SaveChangesAsync();
                        }
                        else
                        {
                            db.Set<DataDictionary>().Attach(dict);
                        }

                        DataDictionaryInfo dataDictionaryInfo1 = new DataDictionaryInfo { DictionaryCode = "1", DictionaryDescription = "正常", DataDictionary = dict };
                        DataDictionaryInfo dataDictionaryInfo2 = new DataDictionaryInfo { DictionaryCode = "2", DictionaryDescription = "紧急", DataDictionary = dict };
                        DataDictionaryInfo dataDictionaryInfo3 = new DataDictionaryInfo { DictionaryCode = "3", DictionaryDescription = "塔奥", DataDictionary = dict };
                        DataDictionaryInfo dataDictionaryInfo4 = new DataDictionaryInfo { DictionaryCode = "4", DictionaryDescription = "诚众", DataDictionary = dict };
                        dataDictionaryInfos.Add(dataDictionaryInfo1);
                        dataDictionaryInfos.Add(dataDictionaryInfo2);
                        dataDictionaryInfos.Add(dataDictionaryInfo3);
                        dataDictionaryInfos.Add(dataDictionaryInfo4);
                        var dictInfo = db.Set<DataDictionaryInfo>().AddRange(dataDictionaryInfos);
                        result = await db.SaveChangesAsync();

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

        private async static void TestCreateBatch()
        {
            using (var db = new TestDbContext())
            {
                db.Database.Log = Console.WriteLine;
                Batch batch = new Batch { BatchNo = "2018-01-01" };
                db.Set<Batch>().Add(batch);
                await db.SaveChangesAsync();
            }
        }


        private async static void TestRetrieveDataDictInfo()
        {
            using (var db = new TestDbContext())
            {
                db.Database.Log = Console.WriteLine;

                var dict = await db.Set<DataDictionary>().AsNoTracking().FirstOrDefaultAsync(t => t.DictionaryName == DbFunctions.AsNonUnicode("仓储备货类型"));

                StringBuilder sb = new StringBuilder();
                foreach (var item in dict.DataDictionaryInfos)
                {
                    sb.Append(item.DataDictionary.DictionaryName);
                    sb.Append("-");
                    sb.Append(item.DictionaryCode);
                    sb.Append("-");
                    sb.Append(item.DictionaryDescription);
                    Console.WriteLine(sb.ToString());
                    sb.Clear();
                }

            }
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

        private static void TestQueryContains()
        {
            using (var db = new TestDbContext())
            {
                db.Database.Log = Console.WriteLine;

                //var permission = db.Set<Permission>().AsNoTracking().Where(p=>p.Name.Contains(DbFunctions.AsNonUnicode("permission1"))).ToList();
                //var permission2 = db.Set<Permission>().AsNoTracking().Where(p => p.Name.StartsWith(DbFunctions.AsNonUnicode("p"))).ToList();
                var permission3 = db.Set<Permission>().AsNoTracking().Where(p => p.PermissionName.EndsWith(DbFunctions.AsNonUnicode("1"))).ToList();

            }
        }

        private static void TestQueryPages()
        {
            int pageIndex = 1;
            int pageSize = 1;
            using (var db = new TestDbContext())
            {
                db.Database.Log = Console.WriteLine;

                var permission = db.Set<Permission>().AsNoTracking().OrderBy(p => p.PermissionName).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();

            }
        }

        private static void TestQueryExits()
        {
            using (TestDbContext db = new TestDbContext())
            {
                db.Database.Log = Console.WriteLine;

                //var user = db.Set<User>().AsNoTracking().Any(u => u.UserName == "wangjunpeng");
                var user = db.Set<User>().AsNoTracking().Any(u => u.LoginName == DbFunctions.AsNonUnicode("wangjunpeng"));

            }
        }

        //延迟加载
        private static void TestGetRolePermissions()
        {
            StringBuilder sb = new StringBuilder();
            using (var db = new TestDbContext())
            {
                db.Database.Log = Console.WriteLine;

                var roles = db.Set<Role>().AsNoTracking().ToList();
                foreach (var role in roles)
                {
                    foreach (var rolePermission in role.RolePermissions)
                    {
                        sb.Append(rolePermission.Role.RoleName);
                        sb.Append("-");
                        sb.Append(rolePermission.Permission.PermissionName);
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
            using (var db = new TestDbContext())
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
                        sb.Append(rolePermission.Permission.PermissionName);
                        Console.WriteLine(sb.ToString());
                        sb.Clear();
                    }

                }
            }
        }

        private static void TestUserRolePermission()
        {
            var user = new User { LoginName = "wangjunpeng", Password = "123456", Email = "junpeng1949@163.com", UserName = "王俊鹏" };
            var permission1 = new Permission { PermissionName = "permission1", FeatureName = "权限1", Description = "权限1的描述" };
            var permission2 = new Permission { PermissionName = "permission2", FeatureName = "权限2", Description = "权限2的描述" };
            var permission3 = new Permission { PermissionName = "permission3", FeatureName = "权限3", Description = "权限3的描述" };
            var permission4 = new Permission { PermissionName = "permission4", FeatureName = "权限4", Description = "权限4的描述" };
            var permission5 = new Permission { PermissionName = "permission5", FeatureName = "权限5", Description = "权限5的描述" };
            var permissions = new List<Permission>();
            permissions.Add(permission1);
            permissions.Add(permission2);
            permissions.Add(permission3);
            permissions.Add(permission4);
            permissions.Add(permission5);
            var role = new Role { RoleName = "管理员" };
            var rolePermissions = new List<RolePermission>();
            var userRole = new UserRole { UserId = user.Id, Role = role };
            using (var db = new TestDbContext())
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

                        db.Set<UserRole>().Add(userRole);
                        result = db.SaveChanges();
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
