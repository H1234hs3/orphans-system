using Microsoft.EntityFrameworkCore.Metadata.Internal;
using orphan.Core.Interfaces;
using orphan.Core.Model;
using orphan.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orphan.Data.SqlServer.Controller
{
    public class NewOrphansEntity : IDataHelper<NewOrphan>
    {//للتعامل معه البيانات الهي انتتي فروم
        //variables
        private ApplicationDbContext db;
        private NewOrphan table;
        //Constructors
        public NewOrphansEntity()
        {
            db = new ApplicationDbContext();
        }
        #region Methods
        public int Add(NewOrphan table)
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    db.NewOrphan.Add(table);
                    db.SaveChanges();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return 0;

            }
        }

       
        public async Task<int> AddAsync(NewOrphan table)
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    await db.NewOrphan.AddAsync(table);
                    await db.SaveChangesAsync();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return 0;

            }
        }

      

        public int Delete(int Id)
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    var table = find(Id);
                    db.NewOrphan.Remove(table);
                    db.SaveChanges();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return 0;

            }
        }

        public async Task<int> DeleteAsync(int Id)
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    table = await findAsync(Id);
                    await Task.Run(() => db.NewOrphan.Remove(table));
                    await db.SaveChangesAsync();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return 0;

            }
        }

        public int Edit(NewOrphan table)
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    db = new ApplicationDbContext();
                    db.NewOrphan.Update(table);
                    db.SaveChanges();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return 0;

            }
        }

       
        public async Task<int> EditAsync(NewOrphan table)
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    db = new ApplicationDbContext();//ليش بيحصل غلط لو ما عملت هذه الانشلايز
                    await Task.Run(() => db.NewOrphan.Update(table));
                    await db.SaveChangesAsync();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return 0;

            }
        }

      

        public NewOrphan? find(int Id)
        {
            try
            {
                if (db.Database.CanConnect())
                {

                    return db.NewOrphan.Where(x => x.Id == Id).First();


                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;

            }
        }

        public async Task<NewOrphan> findAsync(int Id)
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {

                    return await Task.Run(() => db.NewOrphan.Where(x => x.Id == Id).First());


                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;

            }
        }

        public List<NewOrphan> GetAllData()
        {
            try
            {
                if (db.Database.CanConnect())
                {

                    return db.NewOrphan.ToList();


                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;

            }
        }

        public async Task<List<NewOrphan>> GetAllDataAsync()
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {

                    return await Task.Run(() => db.NewOrphan.ToList());


                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;

            }
        }

        public List<NewOrphan> Sherach(string SherachItem)
        {
            try
            {
                if (db.Database.CanConnect())
                {

                    return db.NewOrphan.Where(x => x.Id.ToString() == SherachItem
                    || x.NameOrphan.Contains(SherachItem)
                    || x.OrphanClassification.Contains(SherachItem)
                    || x.DateBirth.Date.ToString().Contains(SherachItem)



                    ).ToList();


                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;

            }
        }

        public async Task<List<NewOrphan>> SherachAsync(string SherachItem)
        {

            try
            {
                if (await db.Database.CanConnectAsync())
                {

                    return await Task.Run(() => db.NewOrphan.Where(x => x.Id.ToString() == SherachItem
                    || x.NameOrphan.Contains(SherachItem)
                    || x.OrphanClassification.Contains(SherachItem)
                    || x.DateBirth.ToShortDateString().Contains(SherachItem)



                    ).ToList());


                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;

            }
        }


    }
    #endregion
}

