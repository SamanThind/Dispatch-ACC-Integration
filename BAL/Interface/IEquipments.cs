
using DAL.Entity;

namespace BAL
{
    public interface IEquipments
    {
        List<Driver> GetDriversByCompanyId(long companyId);
    }
}