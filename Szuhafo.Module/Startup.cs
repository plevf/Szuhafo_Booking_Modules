using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.ContentManagement;
using OrchardCore.Data.Migration;
using OrchardCore.Modules;
using OrchardCore.Shortcodes;
using Szuhafo.Module.Migrations;
using Szuhafo.Module.Models;
using OrchardCore.Shortcodes;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using Szuhafo.Module.Drivers;

namespace Szuhafo.Module;

public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddContentPart<FoglalasPart>().UseDisplayDriver<FoglalasPartDisplayDriver>();
        services.AddScoped<IDataMigration, FoglalasMigrations>();
    }

    public override void Configure(IApplicationBuilder builder, IEndpointRouteBuilder routes, IServiceProvider serviceProvider)
    {
        routes.MapAreaControllerRoute(
            name: "Home",
            areaName: "Szuhafo.Module",
            pattern: "Home/Index",
            defaults: new { controller = "Home", action = "Index" }
        );
    }
}

