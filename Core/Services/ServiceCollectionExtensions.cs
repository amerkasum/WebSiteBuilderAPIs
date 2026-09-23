using Core.Services.IService;
using Core.Services.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public static class ServiceCollectionExtensions
    {
        public static void AddCustomServices(this IServiceCollection services)
        {

            services.AddTransient<IBusinessTypeService, BusinessTypeService>();
            services.AddTransient<IComponentTypeService, ComponentTypeService>();
            services.AddTransient<IContactTypeService, ContactTypeService>();
            services.AddTransient<IFeedbackService, FeedbackService>();
            services.AddTransient<IGenderService,  GenderService>();
            services.AddTransient<IMessageUsReasonService, MessageUsReasonService>();
            services.AddTransient<IMessageUsService, MessageUsService>();
            services.AddTransient<IRoleService, RoleService>();
            services.AddTransient<ISocialMediaService, SocialMediaService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IUserSocialMediaService, UserSocialMediaService>();
        }
    }
}
