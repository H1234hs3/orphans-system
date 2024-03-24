using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orphan.Data
{
    public interface IDataHelper<Table>
    {
        //Read  //تنجز بشكل اني

       
        List<Table> GetAllData();

       
        List<Table> Sherach(string SherachItem);
    
        Table find(int Id);

        //Write
        int Add(Table table);
        int Edit(Table table);
        int Delete(int Id);


        //Read Async //وظيفة تشتغل في الخلفية
        /// <summary>Gets all data asynchronous.</summary>
        /// <returns>All Data of Table</returns>
        Task< List<Table>> GetAllDataAsync();
        Task<List<Table>>SherachAsync(string SherachItem);
        Task< Table> findAsync(int Id);

        //Write Async
         Task<int> AddAsync(Table table);
         Task< int >EditAsync(Table table);
         Task<int> DeleteAsync(int Id);

    }
}
