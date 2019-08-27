using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace ChildViews
{
    public partial class AChildViewComponent : ViewComponent
    {
        public AChildViewComponent()
        {

        }

        public async Task<IViewComponentResult> InvokeAsync(int i)
        {
            return View(i);
        }
    }
}
