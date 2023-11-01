

using DAL.Entity;

namespace BAL
{
    public class EquipmentService : IEquipments
    {
        private readonly DAL.DispatchDBContext db;
        public EquipmentService(DAL.DispatchDBContext _db)
        {
            db=_db;
        }
        public List<Driver> GetDriversByCompanyId(long companyId)
        {
            return db.Drivers.ToList();
        }
    }
}