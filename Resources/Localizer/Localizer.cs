using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
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
        public string Added3 => _localizer["Added3"];
        public string Deleted => _localizer["Deleted"];
        public string Deleted2 => _localizer["Deleted2"];
        public string Deleted3 => _localizer["Deleted3"];
        public string Required => _localizer["Required"];
        public string InvalidEmail => _localizer["InvalidEmail"];
        public string InternalServerError => _localizer["InternalServerError"];
        public string AlreadyExist => _localizer["AlreadyExist"];
        public string Location => _localizer["Location"];
        public string Address => _localizer["Address"];
        public string City => _localizer["City"];
        public string Region => _localizer["Region"];
        public string Country => _localizer["Country"];
        public string SomethingWentWrong => _localizer["SomethingWentWrong"];
        public string YearsOld => _localizer["YearsOld"];
        public string User => _localizer["User"];
        public string Email => _localizer["Email"];
        public string SocialMedia => _localizer["SocialMedia"];
        public string Edited => _localizer["Edited"];
        public string Edited2 => _localizer["Edited2"];
        public string Edited3 => _localizer["Edited3"];
        public string NotFound => _localizer["NotFound"];
        public string NotFound2 => _localizer["NotFound2"];
        public string NotFound3 => _localizer["NotFound3"];
        public string ContactType => _localizer["ContactType"];
        public string BusinessType => _localizer["BusinessType"];
        public string Gender => _localizer["Gender"];
        public string Role => _localizer["Role"];
        public string Reason => _localizer["Reason"];
        public string Feedback => _localizer["Feedback"];
        public string ComponentType => _localizer["ComponentType"];
        public string Message => _localizer["Message"];
        public string UserContact => _localizer["UserContact"];
        public string Currency => _localizer["Currency"];
        public string Unauthorized => _localizer["Unauthorized"];
        #endregion
    }
}
