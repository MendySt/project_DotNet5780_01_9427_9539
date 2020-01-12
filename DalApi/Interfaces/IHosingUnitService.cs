using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO.Models;

namespace DalApi.Interfaces
{
    public interface IHosingUnitService
    {
        void AddHostingUnit(HostingUnit hostingUnit);
        void RemoveHostingUnit(int key);
        void UpdateHostingUnit(HostingUnit hostingUnit);
        HostingUnit GetHostingUnit(int key);
        List<HostingUnit> GetHostingUnits();
    }

}
