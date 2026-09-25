using Domain.Entities.Location;
using Domain.Entities.System;
using Domain.Entities.WebSiteBuilder;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.EF.Seed
{
    public static class GeneralDatabaseSeed
    {
        public static void Seed(ModelBuilder modelBuilder) {

            modelBuilder.Entity<ComponentType>().HasData(
                new ComponentType { Id = 1, Name = "Navbar", Code = "NAVBAR", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new ComponentType { Id = 2, Name = "Hero", Code = "HERO", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new ComponentType { Id = 3, Name = "About", Code = "ABOUT", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new ComponentType { Id = 4, Name = "Services", Code = "SERVICES", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new ComponentType { Id = 5, Name = "Features", Code = "FEATURES", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new ComponentType { Id = 6, Name = "Portfolio", Code = "PORTFOLIO", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new ComponentType { Id = 7, Name = "Gallery", Code = "GALLERY", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new ComponentType { Id = 8, Name = "Testimonials", Code = "TESTIMONIALS", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new ComponentType { Id = 9, Name = "Pricing", Code = "PRICING", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new ComponentType { Id = 10, Name = "FAQ", Code = "FAQ", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new ComponentType { Id = 11, Name = "Contact", Code = "CONTACT", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new ComponentType { Id = 12, Name = "Footer", Code = "FOOTER", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new ComponentType { Id = 13, Name = "Team", Code = "TEAM", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new ComponentType { Id = 14, Name = "Clients", Code = "CLIENTS", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new ComponentType { Id = 15, Name = "Statistics", Code = "STATISTICS", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new ComponentType { Id = 16, Name = "Skills", Code = "SKILLS", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new ComponentType { Id = 17, Name = "Experience", Code = "EXPERIENCE", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new ComponentType { Id = 18, Name = "Education", Code = "EDUCATION", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new ComponentType { Id = 19, Name = "Blog", Code = "BLOG", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new ComponentType { Id = 20, Name = "Newsletter", Code = "NEWSLETTER", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new ComponentType { Id = 21, Name = "Call To Action", Code = "CTA", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new ComponentType { Id = 22, Name = "Video", Code = "VIDEO", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new ComponentType { Id = 23, Name = "Process", Code = "PROCESS", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new ComponentType { Id = 24, Name = "Technologies", Code = "TECHNOLOGIES", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new ComponentType { Id = 25, Name = "Awards", Code = "AWARDS", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false }
            );

            modelBuilder.Entity<BusinessType>().HasData(
                new BusinessType { Id = 1, Name = "Restaurant", Code = "RESTAURANT", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 2, Name = "Cafe", Code = "CAFE", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 3, Name = "Bakery", Code = "BAKERY", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 4, Name = "Fast Food", Code = "FAST_FOOD", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 5, Name = "Hotel", Code = "HOTEL", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 6, Name = "Apartment Rental", Code = "APARTMENT_RENTAL", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 7, Name = "Travel Agency", Code = "TRAVEL_AGENCY", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 8, Name = "Tour Guide", Code = "TOUR_GUIDE", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 9, Name = "Car Rental", Code = "CAR_RENTAL", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 10, Name = "Auto Repair", Code = "AUTO_REPAIR", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 11, Name = "Car Dealership", Code = "CAR_DEALERSHIP", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 12, Name = "Taxi Service", Code = "TAXI_SERVICE", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 13, Name = "Moving Company", Code = "MOVING_COMPANY", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 14, Name = "Construction Company", Code = "CONSTRUCTION_COMPANY", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 15, Name = "Architecture Studio", Code = "ARCHITECTURE_STUDIO", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 16, Name = "Interior Design", Code = "INTERIOR_DESIGN", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 17, Name = "Real Estate Agency", Code = "REAL_ESTATE_AGENCY", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 18, Name = "Law Firm", Code = "LAW_FIRM", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 19, Name = "Accounting Firm", Code = "ACCOUNTING_FIRM", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 20, Name = "Insurance Agency", Code = "INSURANCE_AGENCY", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 21, Name = "Bank", Code = "BANK", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 22, Name = "Financial Advisor", Code = "FINANCIAL_ADVISOR", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 23, Name = "Medical Clinic", Code = "MEDICAL_CLINIC", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 24, Name = "Dental Clinic", Code = "DENTAL_CLINIC", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 25, Name = "Pharmacy", Code = "PHARMACY", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 26, Name = "Veterinary Clinic", Code = "VETERINARY_CLINIC", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 27, Name = "Fitness Gym", Code = "FITNESS_GYM", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 28, Name = "Personal Trainer", Code = "PERSONAL_TRAINER", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 29, Name = "Yoga Studio", Code = "YOGA_STUDIO", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 30, Name = "Beauty Salon", Code = "BEAUTY_SALON", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 31, Name = "Barber Shop", Code = "BARBER_SHOP", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 32, Name = "Spa", Code = "SPA", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 33, Name = "Tattoo Studio", Code = "TATTOO_STUDIO", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 34, Name = "Photographer", Code = "PHOTOGRAPHER", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 35, Name = "Videographer", Code = "VIDEOGRAPHER", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 36, Name = "Graphic Designer", Code = "GRAPHIC_DESIGNER", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 37, Name = "Web Design Agency", Code = "WEB_DESIGN_AGENCY", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 38, Name = "Software Company", Code = "SOFTWARE_COMPANY", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 39, Name = "IT Services", Code = "IT_SERVICES", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 40, Name = "Cybersecurity Company", Code = "CYBERSECURITY_COMPANY", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 41, Name = "Marketing Agency", Code = "MARKETING_AGENCY", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 42, Name = "SEO Agency", Code = "SEO_AGENCY", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 43, Name = "Digital Agency", Code = "DIGITAL_AGENCY", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 44, Name = "Freelancer", Code = "FREELANCER", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 45, Name = "Portfolio", Code = "PORTFOLIO", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 46, Name = "Personal Website", Code = "PERSONAL_WEBSITE", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 47, Name = "Blogger", Code = "BLOGGER", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 48, Name = "Influencer", Code = "INFLUENCER", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 49, Name = "Musician", Code = "MUSICIAN", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 50, Name = "DJ", Code = "DJ", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false }
            );

            modelBuilder.Entity<SocialMedia>().HasData(
                new SocialMedia { Id = 1, Name = "Facebook", Code = "FACEBOOK", Icon = "fa-brands fa-facebook", Color = "#1877F2", DisplayOrder = 1, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new SocialMedia { Id = 2, Name = "Instagram", Code = "INSTAGRAM", Icon = "fa-brands fa-instagram", Color = "#E4405F", DisplayOrder = 2, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new SocialMedia { Id = 3, Name = "LinkedIn", Code = "LINKEDIN", Icon = "fa-brands fa-linkedin", Color = "#0A66C2", DisplayOrder = 3, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new SocialMedia { Id = 4, Name = "X", Code = "X-TWITTER", Icon = "fa-brands fa-x-twitter", Color = "#000000", DisplayOrder = 4, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new SocialMedia { Id = 5, Name = "YouTube", Code = "YOUTUBE", Icon = "fa-brands fa-youtube", Color = "#FF0000", DisplayOrder = 5, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new SocialMedia { Id = 6, Name = "TikTok", Code = "TIKTOK", Icon = "fa-brands fa-tiktok", Color = "#000000", DisplayOrder = 6, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new SocialMedia { Id = 7, Name = "WhatsApp", Code = "WHATSAPP", Icon = "fa-brands fa-whatsapp", Color = "#25D366", DisplayOrder = 7, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new SocialMedia { Id = 8, Name = "Telegram", Code = "TELEGRAM", Icon = "fa-brands fa-telegram", Color = "#26A5E4", DisplayOrder = 8, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new SocialMedia { Id = 9, Name = "Discord", Code = "DISCORD", Icon = "fa-brands fa-discord", Color = "#5865F2", DisplayOrder = 9, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new SocialMedia { Id = 10, Name = "GitHub", Code = "GITHUB", Icon = "fa-brands fa-github", Color = "#181717", DisplayOrder = 10, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new SocialMedia { Id = 11, Name = "GitLab", Code = "GITLAB", Icon = "fa-brands fa-gitlab", Color = "#FC6D26", DisplayOrder = 11, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new SocialMedia { Id = 12, Name = "Pinterest", Code = "PINTEREST", Icon = "fa-brands fa-pinterest", Color = "#E60023", DisplayOrder = 12, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new SocialMedia { Id = 13, Name = "Snapchat", Code = "SNAPCHAT", Icon = "fa-brands fa-snapchat", Color = "#FFFC00", DisplayOrder = 13, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new SocialMedia { Id = 14, Name = "Dribbble", Code = "DRIBBBLE", Icon = "fa-brands fa-dribbble", Color = "#EA4C89", DisplayOrder = 14, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new SocialMedia { Id = 15, Name = "Behance", Code = "BEHANCE", Icon = "fa-brands fa-behance", Color = "#1769FF", DisplayOrder = 15, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new SocialMedia { Id = 16, Name = "Medium", Code = "MEDIUM", Icon = "fa-brands fa-medium", Color = "#000000", DisplayOrder = 16, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new SocialMedia { Id = 17, Name = "Reddit", Code = "REDDIT", Icon = "fa-brands fa-reddit", Color = "#FF4500", DisplayOrder = 17, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new SocialMedia { Id = 18, Name = "Twitch", Code = "TWITCH", Icon = "fa-brands fa-twitch", Color = "#9146FF", DisplayOrder = 18, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new SocialMedia { Id = 19, Name = "Spotify", Code = "SPOTIFY", Icon = "fa-brands fa-spotify", Color = "#1DB954", DisplayOrder = 19, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new SocialMedia { Id = 20, Name = "Threads", Code = "THREADS", Icon = "fa-brands fa-threads", Color = "#000000", DisplayOrder = 20, CreatedDateTime = DateTime.Now, IsDeleted = false }
            );

            modelBuilder.Entity<MessageUsReason>().HasData(
                new MessageUsReason { Id = 1, Name = "Info", Code = "INFO", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new MessageUsReason { Id = 2, Name = "Order", Code = "ORDER", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new MessageUsReason { Id = 3, Name = "Complain", Code = "COMPLAIN", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new MessageUsReason { Id = 4, Name = "Suggest", Code = "SUGGEST", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false }
            );

            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "Admin", Code = "ADMIN", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new Role { Id = 2, Name = "User", Code = "USER", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false }
            );

            modelBuilder.Entity<Gender>().HasData(
                new Gender { Id = 1, Name = "Male", Code = "M", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new Gender { Id = 2, Name = "Female", Code = "F", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new Gender { Id = 3, Name = "Prefer not to say", Code = "PNTS", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false }
            );

            modelBuilder.Entity<ContactType>().HasData(
                new ContactType { Id = 1, Name = "Email", Code = "EMAIL", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new ContactType { Id = 2, Name = "Phonenumber", Code = "PHONE_NUMBER", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false }
            );

            modelBuilder.Entity<Currency>().HasData(
                new Currency { Id = 1, Name = "Euro", Code = "EUR", Symbol = "€", DecimalPlaces = 2, CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new Currency { Id = 2, Name = "Dollar", Code = "USD", Symbol = "$", DecimalPlaces = 2, CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new Currency { Id = 3, Name = "Konvertibilna marka", Code = "BAM", Symbol = "KM", DecimalPlaces = 2, CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new Currency { Id = 4, Name = "Srpski dinar", Code = "RSD", Symbol = "din.", DecimalPlaces = 2, CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false }
            );
        }
    }
}
