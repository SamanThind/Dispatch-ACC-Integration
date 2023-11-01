namespace DAL.Queries
{
    public class Equipment
    {
        public const string GetDrivers = "select DriverId,Fname,Lname,d.CarrierId,c.carrierName,SINNO,DrivingLicenseNumber from driver d " +
            " inner join Carrier c on d.CarrierId = c.CarrierId " +
            " where d.CompanyId = @companyId";
        const string GetEquipment = "select VehicleId, vin, f.CarrierId, EquipmentNumber as unitNumber, PlateNumber, c.CompanyId from Vehicle v " +
            " inner join  fleet f on f.FleetId = v.FleetId inner join carrier c on c.CarrierId = f.CarrierId " +
            " where c.CompanyId = @companyId";
    }
}
