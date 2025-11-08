using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentManagement.Display.Models;
using OrchardCore.DisplayManagement.ModelBinding;
using OrchardCore.DisplayManagement.Views;
using OrchardCore.Shortcodes;
using Shortcodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szuhafo.Module.Models;
using Szuhafo.Module.ViewModels;

namespace Szuhafo.Module.Drivers
{
    public class FoglalasPartDisplayDriver : ContentPartDisplayDriver<FoglalasPart>
    {
        public override IDisplayResult Display(FoglalasPart part, BuildPartDisplayContext context) =>
            Initialize<FoglalasPartViewModel>(
                GetDisplayShapeType(context),
                viewModel => PopulateViewModel(part, viewModel))
                .Location("Detail", "Content:5")
                .Location("Summary", "Content:5");

        public override IDisplayResult Edit(FoglalasPart part, BuildPartEditorContext context) =>
            Initialize<FoglalasPartViewModel>(
                GetEditorShapeType(context),
                viewModel => PopulateViewModel(part, viewModel))
                .Location("Content: 5");

        public async Task<IDisplayResult> UpdateAsync(FoglalasPart part, IUpdateModel updater, UpdatePartEditorContext context)
        {
            var viewModel = new FoglalasPartViewModel();
            await updater.TryUpdateModelAsync(viewModel, Prefix);

            // Populate part from view model here.

            return Edit(part, context);
        }

        private static void PopulateViewModel(FoglalasPart part, FoglalasPartViewModel viewModel)
        {
            viewModel.Nev = part.Nev;
            viewModel.Email = part.Email;
            viewModel.Erkezes = part.Erkezes;
            viewModel.Tavozas = part.Tavozas;
        }
    }
}
