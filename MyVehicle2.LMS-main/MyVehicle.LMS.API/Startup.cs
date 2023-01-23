using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using MyVehicle.LMS.CORE.Common;
using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.Repoisitory;
using MyVehicle.LMS.CORE.Services;

using MyVehicle.LMS.INFRA.Common;
using MyVehicle.LMS.INFRA.Repoisitory;
using MyVehicle.LMS.INFRA.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVehicle.LMS.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(corsOptions =>
            {
                corsOptions.AddPolicy("x",
                builder =>
                {
                    //builder.WithOrigins("http://127.0.0.1:4200", "http://localhost:4200", "https://localhost:4200")
                    // .AllowAnyHeader()
                    // .AllowAnyMethod();

                    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                });
            });

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;



            }).AddJwtBearer(y =>
            {
                y.RequireHttpsMetadata = false;
                y.SaveToken = true;
                y.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("[SECRET USED TO SIGN AND VERIFY JWT TOKENS, IT CAN BE ANY STRING]")),
                    ValidateIssuer = false,
                    ValidateAudience = false,


                };
            });

            services.AddControllers();
            services.AddScoped<IDBContext, DBContext>();
            services.AddScoped<ICardsRepoisitory, CardsRepoisitory>();
            services.AddScoped<IContactRepoisitory, ContactRepoisitory>();
            services.AddScoped<IReportTypeRepoisitory, ReportTypeRepoisitory>();
            services.AddScoped<IRoleRepoisitory, RoleRepoisitory>();
            services.AddScoped<IUsersRepoisitory, UsersRepoisitory>();
            services.AddScoped<IBankCardRepoisitory, BankCardRepoisitory>();
            services.AddScoped<IReportRepoisitory, ReportRepoisitory>();
            services.AddScoped<IWebsiteSettingRepoisitory, WebsiteSettingRepoisitory>();
            services.AddScoped<IInsuranceRepoisitory, InsuranceRepoisitory>();
            services.AddScoped<ILicensingRepoisitory, LicensingRepoisitory>();
            services.AddScoped<ITestimonialRepository, TestimonialRepository>(); 
            services.AddScoped<INotificationRepository, NotificationRepository>();
            services.AddScoped<IAttendanceRepository, AttendanceRepostiory>();
            services.AddScoped<IAboutRepository, AboutRepository>();
            services.AddScoped<ILicensingAndInsuranceRepository, LicensingAndInsuranceRepository>();
            services.AddScoped<IReviewRepoisitory, ReviewRepoisitory>();
            services.AddScoped<IVehicleRepoisitory, VehicleRepoisitory>();
            services.AddScoped<IPermissionsRepoisitory, PermissionsRepoisitory>();
            services.AddScoped<IMessageRepoisitory, MessageRepoisitory>();
            services.AddScoped<ITaskJobRepoisitory, TaskJobRepoisitory>();

            services.AddScoped<IPaymentRepoisitory, PaymentRepoisitory>();
            services.AddScoped<ILoginRepoisitory, LoginRepoisitory>();
            services.AddScoped<INewCarLicensingRepository,NewCarLicensingRepository>();


            services.AddScoped<ISalaryRepoisitory,SalaryRepoisitory>();
            services.AddScoped<IImagesRepository, ImagesRepository>();
            services.AddScoped<IJwtRepository, JwtRepository>();
            services.AddScoped<IUserRegistrationRepository, UserRegistrationRepository>();

       
            services.AddScoped<ICardService, CardService>();
            services.AddScoped<IContactService, ContactService>();
            services.AddScoped<IReportTypeService, ReportTypeService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IUsersService, UsersService>();
            services.AddScoped<IBankCardService, BankCardService>();
            services.AddScoped<IReportService, ReportService>();
            services.AddScoped<IWebsiteSettingService, WebsiteSettingService>();
            services.AddScoped<IInsuranceService, InsuranceService>();
            services.AddScoped<ILicensingService, LicensingService>();

            services.AddScoped<ITestimonialService, TestimonialService>();
            services.AddScoped<INotificationService, NotificationService>();
            services.AddScoped<IAttendanceService, AttendanceService>();
            services.AddScoped<IAboutService, AboutService>();
            services.AddScoped<ILicensingAndInsuranceService, LicensingAndInsuranceService>();
            services.AddScoped<IReviewServiice, ReviewService>();
            services.AddScoped<IVehicleService, VehicleService>();
            services.AddScoped<IPermissionsService, PermissionsService>();
            services.AddScoped<IMessageService, MessageService>();
            services.AddScoped<ITaskJobServices, TaskJobServices>();
            services.AddScoped<IPaymentService, PaymentService>();
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<ISalaryService, SalaryService>();
            services.AddScoped<IImagesService, ImagesService>();
            services.AddScoped<IJwtService, JwtService>();

            services.AddScoped<INewCarLicensingService,NewCarLicensingService>();
            services.AddScoped<IUserRegistrationService, UserRegistrationService>();

            services.Configure<MailSettings>(Configuration.GetSection("MailSettings"));
            services.AddTransient<IMailService, MailService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseCors("x");
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
