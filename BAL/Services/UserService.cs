

using DAL.Entity;

namespace BAL
{
    public class UserService : IUser
    {
        private readonly DAL.DispatchDBContext db;
        public UserService(DAL.DispatchDBContext _db)
        {
            db=_db;
        }
        public List<WorkOrder> GetById()
        {
            return db.WorkOrder.ToList();
        }

    }

}