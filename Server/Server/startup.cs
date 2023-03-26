﻿
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Server.Helpers;
using System.Text;

namespace Server.Startup
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            ConfiguredValues configuredValues = new ConfiguredValues();

            services.AddCors(options =>
            {
                options.AddPolicy("EnableCORS", builder =>
                {
                    builder.AllowAnyHeader()
                           .AllowAnyMethod()
                           .WithOrigins(configuredValues.GetClient(), configuredValues.GetServer(), "http://frontend", "http://localhost","http://34.125.187.141");
                });
            });

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    // Validate the token's issuer, audience, expiration, and key
                    ValidateIssuer = true, // Server created the token
                    ValidateAudience = true, // Reciever is valid
                    ValidateLifetime = true, // The token has not expired
                    ValidateIssuerSigningKey = true, // key is valid

                    ValidIssuer = configuredValues.GetServer(), // issuer is this host
                    ValidAudience = configuredValues.GetClient(), // Audience is the default angular port
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuredValues.GetSecretKey())) // Secret key
                };
            });

            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // app.UseStaticFiles();

            app.UseRouting();
            app.UseCors("EnableCORS");



            // app.UseHttpsRedirection();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
