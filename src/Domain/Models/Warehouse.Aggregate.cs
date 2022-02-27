using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public partial class Warehouse
    {
        public Warehouse(
             string whName
            ,string whNameContract
            ,string whNumber
            ,string whAddress
            ,string whPostalCode
            ,int province
            ,int distrinct
            ,int commune
            ,string locationMap
            )
        {

            this.Update(whName,whNameContract,whNumber,whAddress,whPostalCode,province,distrinct,commune,locationMap);

        }
        void Update(
            string whName
            , string whNameContract
            , string whNumber
            , string whAddress
            , string whPostalCode
            , int province
            , int distrinct
            , int commune
            , string locationMap
            )
        {
            Guid id = Guid.NewGuid();
            WarehouseId = id.ToString();
            WarehouseName = whName;
            WarehouseNameContact = whNameContract;
            WarehouseNumber = whNumber;
            WarehouseAddress = whAddress;
            WarehousePostalCode = whPostalCode;
            ProvinceId = province;
            DistrinctId = distrinct;
            CommuneId = commune;
            LocationMap = locationMap;

        }
    }
}
