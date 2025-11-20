using OrchardCore.ContentFields.Settings;
using OrchardCore.ContentManagement.Metadata;
using OrchardCore.ContentManagement.Metadata.Settings;
using OrchardCore.Data.Migration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                .WithField("Nev", field => field
                .OfType("TextField")
                .WithDisplayName("Név")
                .WithSettings(new TextFieldSettings
                {
                    Hint = "Adja meg a nevet."
                })
            )
            .WithField("Email", field => field
                .OfType("TextField")
                .WithDisplayName("E-mail cím")
                .WithSettings(new TextFieldSettings
                {
                    Hint = "Adja meg az e-mail címet."
                })
            )
            .WithField("Erkezes", field => field
                .OfType("DateTimeField")
                .WithDisplayName("Érkezés")
                .WithSettings(new DateTimeFieldSettings
                {
                    Hint = "Válassza ki az érkezés időpontját."
                })
            )
            .WithField("Tavozas", field => field
                .OfType("DateTimeField")
                .WithDisplayName("Távozás")
                .WithSettings(new DateTimeFieldSettings
                {
                    Hint = "Válassza ki a távozás időpontját."
                })
            )
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
