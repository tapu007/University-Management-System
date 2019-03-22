
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using University.BLL.Contracts;
using University.BLL.Manager;
using University.DatabaseContexts.UniversityDatabaseContext;
using University.Models.EntityModels;
using University.Repositories.Contracts;
using University.Repositories.Repository;

namespace University.Configuration
{
    public static class AppConfiguration
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(configuration.GetConnectionString("UniversityDatabaseContext")));
            services.AddTransient<IDepartmentManager, DepartmentManager>();
            services.AddTransient<IDepartmentRepository, DepartmentRepository>();

            services.AddTransient<ISemesterRepository, SemesterRepository>();

            services.AddTransient<ICourseManager, CourseManager>();
            services.AddTransient<ICourseRepository, CourseRepository>();

            services.AddTransient<IDesignationRepository, DesignationRepository>();

            services.AddTransient<ITeacherRepository, TeacherRepository>();

            services.AddTransient<ICourseAssignToTeacherRepositor, CourseAssignToTeacherRepository>();

            services.AddTransient<IStudentManager, StudentManager>();
            services.AddTransient<IStudentRepository, StudentRepository>();

            services.AddTransient<IRoomManager, RoomManager>();
            services.AddTransient<IRoomRepository, RoomRepository>();

            services.AddTransient<IDayManager, DayManager>();
            services.AddTransient<IDayRepository, DayRepository>();

            services.AddTransient<IAllocateClassRoomManager, AllocateClassRoomManager>();
            services.AddTransient<IAllocateClassRoomRepository, AllocateClassRoomRepository>();

            services.AddTransient<ICourseEnrollToStudentManager, CourseEnrollToStudentManager>();
            services.AddTransient<ICourseEnrollToStudentRepository, CourseEnrollToStudentRepository>();

            services.AddTransient<IGradePointManager, GradePointManager>();
            services.AddTransient<IGradePointRepository, GradePointRepository>();

            services.AddTransient<IStudentResultManager, StudentResultManager>();
            services.AddTransient<IStudentResultRepository, StudentResultRepository>();

           

            services.AddIdentity<AppUser, IdentityRole>()
            .AddEntityFrameworkStores<DatabaseContext>()
            .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
            {
                // Default Password settings.
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 4;
                options.Password.RequiredUniqueChars = 0;
            });

            services.ConfigureApplicationCookie(options =>
            {
                options.AccessDeniedPath = "/AccountLogin/AccessDenied";
                options.Cookie.Name = "YourAppCookieName";
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                options.LoginPath = "/AccountLogin/Login";
                // ReturnUrlParameter requires 
                //using Microsoft.AspNetCore.Authentication.Cookies;
                options.ReturnUrlParameter = CookieAuthenticationDefaults.ReturnUrlParameter;
                options.SlidingExpiration = true;
            });

            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddJsonOptions(
                                 options => options.SerializerSettings.ReferenceLoopHandling =
                                 Newtonsoft.Json.ReferenceLoopHandling.Ignore
                              );


        }
    }
}
