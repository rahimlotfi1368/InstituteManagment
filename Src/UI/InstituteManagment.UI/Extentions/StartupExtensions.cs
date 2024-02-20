namespace InstituteManagment.UI.Extentions
{
    public static class StartupExtensions
    {
        public static WebApplication ConfigureServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddControllersWithViews();
            return builder.Build();
        }

        public static WebApplication ConfigurePipeLines(this WebApplication app)
        {
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(name: "default",pattern: "{controller=Home}/{action=Index}/{id?}");
                          
            return app;
        }
    }
}
