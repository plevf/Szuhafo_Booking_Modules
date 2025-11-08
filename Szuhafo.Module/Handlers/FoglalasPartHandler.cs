using OrchardCore.ContentManagement.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szuhafo.Module.Models;

namespace Szuhafo.Module.Handlers
{
    public class FoglalasPartHandler : ContentPartHandler<FoglalasPart>
    {
        public override Task UpdatedAsync(UpdateContentContext context, FoglalasPart instance)
        {
            // megjelenítendő nevét (DisplayText) a part 'Nev' tulajdonsága alapján.
            context.ContentItem.DisplayText = instance.Nev;

            return Task.CompletedTask;
        }
    }
}
