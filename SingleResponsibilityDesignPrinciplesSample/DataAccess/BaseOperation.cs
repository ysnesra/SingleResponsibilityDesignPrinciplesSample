using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityDesignPrinciplesSample.DataAccess
{
    public class BaseOperation<T>
    {
    
        public T Add(T Entity)
        {
            try
            {
                using (Db_Connection db_Connection = new Db_Connection())
                {
                    db_Connection.Add(Entity);   //veritabanına enitity yani T gönderiyor.Generic yapı
                    db_Connection.SaveChanges();
                    return Entity;
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
