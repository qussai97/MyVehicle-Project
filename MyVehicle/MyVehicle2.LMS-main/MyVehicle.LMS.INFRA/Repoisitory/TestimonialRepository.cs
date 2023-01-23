using Dapper;
using MyVehicle.LMS.CORE.Common;
using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.Repoisitory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MyVehicle.LMS.INFRA.Repoisitory
{
    public class TestimonialRepository : ITestimonialRepository
    {
        private readonly IDBContext dBContext;
        public TestimonialRepository(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public bool DeleteTestimonial(int TestimonialId)
        {
            var Parameters = new DynamicParameters();
            Parameters.Add("@TestimonialId",TestimonialId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var Reselt = dBContext.Connection.ExecuteAsync("DeleteTestimonial", Parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Testimonial> GetAllTestimonial()
        {
            IEnumerable<Testimonial> reselt = dBContext.Connection.Query<Testimonial>("GetAllTestimonial", commandType: CommandType.StoredProcedure);

            return reselt.ToList();
        }

        public bool InsertTestimonial(Testimonial testimonial)
        { 
   
            var Parameters = new DynamicParameters();
            Parameters.Add("@TestimonialName", testimonial.TestimonialName, dbType: DbType.String, direction: ParameterDirection.Input);
            Parameters.Add("@TestimonialEmail", testimonial.TestimonialEmail, dbType: DbType.String, direction: ParameterDirection.Input);
            Parameters.Add("@TestimonialTel", testimonial.TestimonialTel, dbType: DbType.Int32, direction: ParameterDirection.Input);
            Parameters.Add("@Comment", testimonial.Comment, dbType: DbType.String, direction: ParameterDirection.Input);
            Parameters.Add("@ProblemImage", testimonial.ProblemImage, dbType: DbType.String, direction: ParameterDirection.Input);
            Parameters.Add("@SettingId", testimonial.SettingId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var Reselt = dBContext.Connection.ExecuteAsync("InsertTestimonial", Parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateTestimonial(Testimonial testimonial)
        {
         
            var Parameters = new DynamicParameters();
            Parameters.Add("@TestimonialId", testimonial.TestimonialId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            Parameters.Add("@TestimonialName", testimonial.TestimonialName, dbType: DbType.String, direction: ParameterDirection.Input);
            Parameters.Add("@TestimonialEmail", testimonial.TestimonialEmail, dbType: DbType.String, direction: ParameterDirection.Input);
            Parameters.Add("@TestimonialTel", testimonial.TestimonialTel, dbType: DbType.Int32, direction: ParameterDirection.Input);
            Parameters.Add("@Comment", testimonial.Comment, dbType: DbType.String, direction: ParameterDirection.Input);
            Parameters.Add("@ProblemImage", testimonial.ProblemImage, dbType: DbType.String, direction: ParameterDirection.Input);
            Parameters.Add("@SettingId", testimonial.SettingId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var Reselt = dBContext.Connection.ExecuteAsync("UpdateTestimonial", Parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
