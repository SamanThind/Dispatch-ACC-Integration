
using DAL.Entity;

namespace BAL
{
    public interface IUser
    {
        List<WorkOrder> GetById();
    }
}