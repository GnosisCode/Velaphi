using System;
using System.Collections.Generic;
using System.Text;
using Velaphi.Localization;
using Volo.Abp.Application.Services;

namespace Velaphi
{
    /* Inherit your application services from this class.
     */
    public abstract class VelaphiAppService : ApplicationService
    {
        protected VelaphiAppService()
        {
            LocalizationResource = typeof(VelaphiResource);
        }
    }
}
