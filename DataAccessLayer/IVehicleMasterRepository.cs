using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IVehicleMasterRepository<VehicleMaster>
    {
        IEnumerable<VehicleMaster> GetAllVehicle();
       
        bool DeleteVehicle(int id);
        VehicleMaster GetVehicle(int modeNo);
        bool SaveVehicle(VehicleMaster vehicle);
        bool UpdateVehicle(VehicleMaster vehicle);



    }
}
