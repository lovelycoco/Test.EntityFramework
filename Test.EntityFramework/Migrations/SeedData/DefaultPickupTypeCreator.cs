using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities;

namespace Test.EntityFramework.Migrations.SeedData
{
    public class DefaultPickupTypeCreator
    {
        private readonly TestDbContext _context;

        public DefaultPickupTypeCreator(TestDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreatePickupType();
        }

        private void CreatePickupType()
        {
            List<DataDictionaryInfo> dataDictionaryInfos = new List<DataDictionaryInfo>();
            DataDictionaryInfo dataDictionaryInfo1 = new DataDictionaryInfo { DictionaryCode = "1", DictionaryDescription = "正常", Operator = Guid.Empty };
            DataDictionaryInfo dataDictionaryInfo2 = new DataDictionaryInfo { DictionaryCode = "2", DictionaryDescription = "紧急", Operator = Guid.Empty };
            DataDictionaryInfo dataDictionaryInfo3 = new DataDictionaryInfo { DictionaryCode = "3", DictionaryDescription = "塔奥", Operator = Guid.Empty };
            DataDictionaryInfo dataDictionaryInfo4 = new DataDictionaryInfo { DictionaryCode = "4", DictionaryDescription = "诚众", Operator = Guid.Empty };
            dataDictionaryInfos.Add(dataDictionaryInfo1);
            dataDictionaryInfos.Add(dataDictionaryInfo2);
            dataDictionaryInfos.Add(dataDictionaryInfo3);
            dataDictionaryInfos.Add(dataDictionaryInfo4);

            var dict = _context.Set<DataDictionary>().Add(new DataDictionary { DictionaryName = "仓储备货类型", Operator = Guid.Empty, DataDictionaryInfos = dataDictionaryInfos });





            //var defaultType = _context.Editions.FirstOrDefault(e => e.Name == EditionManager.DefaultEditionName);
            //if (defaultEdition == null)
            //{
            //    defaultEdition = new Edition { Name = EditionManager.DefaultEditionName, DisplayName = EditionManager.DefaultEditionName };
            //    _context.Editions.Add(defaultEdition);
            //    _context.SaveChanges();

            //    //TODO: Add desired features to the standard edition, if wanted!
            //}
        }
    }
}
