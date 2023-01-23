using Dapper;
using MyVehicle.LMS.CORE.Common;
using MyVehicle.LMS.CORE.DTO;
using MyVehicle.LMS.CORE.Repoisitory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MyVehicle.LMS.INFRA.Repoisitory
{
    public class NewCarLicensingRepository : INewCarLicensingRepository
    {
        private IDBContext dBContext;


        public NewCarLicensingRepository(IDBContext dBContext)
        {
            this.dBContext = dBContext;

        }

            public IEnumerable<PaymentValue> InsertNewCarLicensing(NewCarLicensing newCarLicensing)
        {

            var p = new DynamicParameters();
            p.Add("@VehicleName", newCarLicensing.VehicleName, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("@VehicleModel", newCarLicensing.VehicleModel, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@VehicleColor", newCarLicensing.VehicleColor, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@VehicleCategory", newCarLicensing.VehicleCategory, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@UseType", newCarLicensing.UseType, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@RegisterType", newCarLicensing.RegisterType, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@LicenseNumber", newCarLicensing.LicenseNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@LicenseExpiry", newCarLicensing.LicenseExpiry, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@EngineCapacity", newCarLicensing.EngineCapacity, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@EngineType", newCarLicensing.EngineType, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@MadeYear", newCarLicensing.MadeYear, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@LicensingCenter", newCarLicensing.LicensingCenter, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@ChassisNumber", newCarLicensing.ChassisNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@EngineNumber", newCarLicensing.EngineNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Address", newCarLicensing.Address, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@VehicleImage", newCarLicensing.VehicleImage, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@UserId", newCarLicensing.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@LicensingId", newCarLicensing.LicensingId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@InsuranceId", newCarLicensing.InsuranceId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<PaymentValue> result = dBContext.Connection.Query<PaymentValue>("NewCarLicensing", p, commandType: CommandType.StoredProcedure);
            return result;
            

             
        }
    }
}
