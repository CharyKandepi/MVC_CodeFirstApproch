using Microsoft.EntityFrameworkCore;


namespace MVC_CodeFirstApproch.EFMVCORMDB
{
    public class ORMCLASSFORDB: DbContext
    {

        public ORMCLASSFORDB(DbContextOptions<ORMCLASSFORDB> options) :base(options)
        { 
        
        }

    }
}
