using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using DynamicCv.Services.CvServices;
using DynamicCv.Services.Interfaces;
using DynamicCv.Services.Repositories;
using System.IO;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Http;

namespace DynamicCv.Web
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = Configuration.GetConnectionString("DefaultConnection");
            services.AddEntityServiceConnection(connectionString, "DynamicCv.Web");
            // Add framework services.

            services.AddAuthentication(options => options.SignInScheme = CookieAuthenticationDefaults.AuthenticationScheme);
            services.AddMvc().AddJsonOptions(options => {
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            });

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<ICvEntriesRepository, CvEntriesRepository>();
            services.AddScoped<IUserRepsitory, UserReposistory>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationScheme = "Cookies",
                AutomaticAuthenticate = true,
                AutomaticChallenge = true
            });

            //app.UseGoogleAuthentication(new GoogleOptions {
            //    ClientId = "453230586864-i6238u1usqk4oemmfnnlfvfouh9hkgnn.apps.googleusercontent.com",
            //    ClientSecret = "-e-LBYgTm5UDFtsPGu6gOcxa",
            //    CallbackPath = new PathString("/signin-google") 

            //}
            //);

            app.UseOpenIdConnectAuthentication(new OpenIdConnectOptions
            {
                ClientId = "453230586864-i6238u1usqk4oemmfnnlfvfouh9hkgnn.apps.googleusercontent.com",
                ClientSecret = "-e-LBYgTm5UDFtsPGu6gOcxa",
                Authority = "https://accounts.google.com",
                ResponseType = OpenIdConnectResponseType.Code,
                GetClaimsFromUserInfoEndpoint = true,
                SaveTokens = true,
                Events = new OpenIdConnectEvents()
                {
                    OnRedirectToIdentityProvider = (context) =>
                    {
                        if (context.Request.Path != "/api/Account")
                        {
                            context.Response.Redirect("/api/Account/login");
                            context.HandleResponse();
                        }

                        return Task.FromResult(0);
                    }
                }
            });

            app.Use(async (context, next) => {
                await next();
                if (context.Response.StatusCode == 404 &&
                   !Path.HasExtension(context.Request.Path.Value) &&
                   !context.Request.Path.Value.StartsWith("/api/"))
                {
                    context.Request.Path = "/index.html";
                    await next();
                }
            });

            app.UseMvcWithDefaultRoute();
            app.UseDefaultFiles();
            app.UseStaticFiles();

         
            // app.UseMvc();
        }
    }
}
