using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrchardCore.Data.Migration;
using OrchardCore.ContentManagement.Metadata;
using OrchardCore.ContentManagement.Metadata.Settings;
using Szuhafo.Module.Models;

namespace Szuhafo.Module.Migrations
{
    public class FoglalasMigrations : DataMigration
    {
        private readonly IContentDefinitionManager _contentDefinitionManager;

        public FoglalasMigrations(IContentDefinitionManager contentDefinitionManager)
        {
            _contentDefinitionManager = contentDefinitionManager;
        }

        public int Create()
        {
            _contentDefinitionManager.AlterPartDefinitionAsync(nameof(FoglalasPart), part => part
                .Attachable()
                .WithField("Nev", field => field.OfType("TextField").WithDisplayName("Név"))
                .WithField("Email", field => field.OfType("TextField").WithDisplayName("Email"))
                .WithField("Erkezes", field => field.OfType("DateTimeField").WithDisplayName("Érkezés"))
                .WithField("Tavozas", field => field.OfType("DateTimeField").WithDisplayName("Távozás"))
            );

            _contentDefinitionManager.AlterTypeDefinitionAsync("FoglalasPage", type => type
            .Creatable()
            .Listable()
            .WithPart(nameof(FoglalasPart))
            );

            return 1;
        }
    }
}
