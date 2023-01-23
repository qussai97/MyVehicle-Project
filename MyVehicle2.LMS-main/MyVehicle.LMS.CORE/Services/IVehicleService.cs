using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.Services
{
   public interface IVehicleService
    {
        public bool InsertVehicles(Vehicles Veh);
        public bool UpdateVehicles(Vehicles Veh);
        public bool DeleteVehicles(int VehicleId);
        public List<Vehicles> GetAllVehicles();
        public Vehicles GetVehicleById(int VehicleId);

        //Searching For Vehicles LicenseExpiry //Admin
        public List<VehiclesUsersLicenseExpiry> SearchingForVehiclesLicenseExpiry(SearchingForVehiclesLicenseExpiry searchingForVehiclesLicenseExpiry);


        //Search By Vehicle Category  //Users
        public List<VehiclesUsers> SearchByVehicleCategory(SearchByVehicleCategory searchByVehicleCategory);

        //VehicleSystem  
        public List<VehicleSystemReport> VehicleSystemReport();
        // VehicleSystemReportBetween
        public List<VehicleSystemReport> VehicleSystemReportBetween(VehicleSystemReportBetween vehicleSystemReportBetween);

        // TechnecalReport


        public List<TechnecalReportJoinDto> TechnecalReport(int UserId);



    }
}
