using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resources.Localizer
{
    public class Localizer
    {
        private readonly IStringLocalizer<SharedResource> _localizer;

        public Localizer(IStringLocalizer<SharedResource> localizer)
        {
            this._localizer = localizer;
        }
        #region Localizers
        public string MessageSent => _localizer["MessageSent"];
        public string Added => _localizer["Added"];
        public string Added2 => _localizer["Added2"];
        public string Required => _localizer["Required"];
        public string InvalidEmail => _localizer["InvalidEmail"];

        #endregion
    }
}
