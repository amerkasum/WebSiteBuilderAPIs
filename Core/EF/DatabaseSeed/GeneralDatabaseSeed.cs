using Domain.Entities.Location;
using Domain.Entities.Personal;
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
        public static void Seed(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ComponentType>().HasData(
               new ComponentType { Id = 1, Name = "Navbar", Code = "NAVBAR", Description = "Website navigation bar used to provide links to the main pages and sections.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
               new ComponentType { Id = 2, Name = "Hero", Code = "HERO", Description = "Prominent introductory section that presents the main message, title, and call to action.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
               new ComponentType { Id = 3, Name = "About", Code = "ABOUT", Description = "Section used to introduce a business, organization, person, or project.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
               new ComponentType { Id = 4, Name = "Services", Code = "SERVICES", Description = "Section that presents the services or solutions offered by a business or organization.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
               new ComponentType { Id = 5, Name = "Features", Code = "FEATURES", Description = "Section that highlights the key features, benefits, or capabilities of a product or service.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
               new ComponentType { Id = 6, Name = "Portfolio", Code = "PORTFOLIO", Description = "Section used to showcase completed projects, work samples, or professional achievements.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
               new ComponentType { Id = 7, Name = "Gallery", Code = "GALLERY", Description = "Visual section used to display a collection of images or other media.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
               new ComponentType { Id = 8, Name = "Testimonials", Code = "TESTIMONIALS", Description = "Section that displays customer or client reviews, opinions, and experiences.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
               new ComponentType { Id = 9, Name = "Pricing", Code = "PRICING", Description = "Section used to present products, services, packages, or subscription plans together with their prices.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
               new ComponentType { Id = 10, Name = "FAQ", Code = "FAQ", Description = "Section containing frequently asked questions and their answers.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
               new ComponentType { Id = 11, Name = "Contact", Code = "CONTACT", Description = "Section that provides contact information and allows visitors to get in touch.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
               new ComponentType { Id = 12, Name = "Footer", Code = "FOOTER", Description = "Bottom section of a website containing additional navigation, contact information, legal links, and other details.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
               new ComponentType { Id = 13, Name = "Team", Code = "TEAM", Description = "Section used to introduce team members, employees, or staff.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
               new ComponentType { Id = 14, Name = "Clients", Code = "CLIENTS", Description = "Section used to showcase clients, customers, partners, or companies that work with the business.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
               new ComponentType { Id = 15, Name = "Statistics", Code = "STATISTICS", Description = "Section used to present important business statistics, numbers, metrics, or achievements.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
               new ComponentType { Id = 16, Name = "Skills", Code = "SKILLS", Description = "Section used to present professional skills, competencies, technologies, or areas of expertise.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
               new ComponentType { Id = 17, Name = "Experience", Code = "EXPERIENCE", Description = "Section used to display professional experience, employment history, or previous positions.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
               new ComponentType { Id = 18, Name = "Education", Code = "EDUCATION", Description = "Section used to present educational background, degrees, certifications, or academic achievements.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
               new ComponentType { Id = 19, Name = "Blog", Code = "BLOG", Description = "Section used to display articles, news, posts, and other written content.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
               new ComponentType { Id = 20, Name = "Newsletter", Code = "NEWSLETTER", Description = "Section that allows visitors to subscribe to a newsletter or receive updates.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
               new ComponentType { Id = 21, Name = "Call To Action", Code = "CTA", Description = "Section designed to encourage visitors to perform a specific action, such as contacting the business, purchasing a product, or signing up.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
               new ComponentType { Id = 22, Name = "Video", Code = "VIDEO", Description = "Section used to display promotional, informational, or presentation videos.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
               new ComponentType { Id = 23, Name = "Process", Code = "PROCESS", Description = "Section that explains the steps, stages, or workflow involved in delivering a product or service.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
               new ComponentType { Id = 24, Name = "Technologies", Code = "TECHNOLOGIES", Description = "Section used to showcase technologies, tools, frameworks, or platforms used by a business or professional.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
               new ComponentType { Id = 25, Name = "Awards", Code = "AWARDS", Description = "Section used to showcase awards, recognitions, certificates, or professional achievements.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false }
            );

            modelBuilder.Entity<BusinessType>().HasData(
                new BusinessType { Id = 1, Name = "Restaurant", Code = "RESTAURANT", Description = "Business that prepares and serves meals and beverages to customers.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 2, Name = "Cafe", Code = "CAFE", Description = "Business that serves coffee, beverages, snacks, and light meals.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 3, Name = "Bakery", Code = "BAKERY", Description = "Business that produces and sells bread, pastries, cakes, and other baked goods.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 4, Name = "Fast Food", Code = "FAST_FOOD", Description = "Business that provides quickly prepared meals and takeaway food.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 5, Name = "Hotel", Code = "HOTEL", Description = "Business that provides accommodation and hospitality services to guests.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 6, Name = "Apartment Rental", Code = "APARTMENT_RENTAL", Description = "Business that provides apartments or residential properties for short-term or long-term rental.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 7, Name = "Travel Agency", Code = "TRAVEL_AGENCY", Description = "Business that organizes and sells travel arrangements, tours, transportation, and accommodation.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 8, Name = "Tour Guide", Code = "TOUR_GUIDE", Description = "Professional service that provides guided tours and information about destinations and attractions.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 9, Name = "Car Rental", Code = "CAR_RENTAL", Description = "Business that provides vehicles for temporary rental to individuals or organizations.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 10, Name = "Auto Repair", Code = "AUTO_REPAIR", Description = "Business that provides maintenance, diagnostics, and repair services for vehicles.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 11, Name = "Car Dealership", Code = "CAR_DEALERSHIP", Description = "Business that sells new or used vehicles and may provide related automotive services.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 12, Name = "Taxi Service", Code = "TAXI_SERVICE", Description = "Transportation business that provides passenger transportation using taxis or similar vehicles.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 13, Name = "Moving Company", Code = "MOVING_COMPANY", Description = "Business that provides residential or commercial moving and relocation services.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 14, Name = "Construction Company", Code = "CONSTRUCTION_COMPANY", Description = "Business that provides construction, building, renovation, and related services.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 15, Name = "Architecture Studio", Code = "ARCHITECTURE_STUDIO", Description = "Professional business that provides architectural design, planning, and consulting services.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 16, Name = "Interior Design", Code = "INTERIOR_DESIGN", Description = "Business that provides interior planning, decoration, and design services for residential or commercial spaces.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 17, Name = "Real Estate Agency", Code = "REAL_ESTATE_AGENCY", Description = "Business that provides services for buying, selling, renting, and managing real estate properties.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 18, Name = "Law Firm", Code = "LAW_FIRM", Description = "Professional legal business that provides legal advice, representation, and related services.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 19, Name = "Accounting Firm", Code = "ACCOUNTING_FIRM", Description = "Professional business that provides accounting, bookkeeping, tax, and financial reporting services.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 20, Name = "Insurance Agency", Code = "INSURANCE_AGENCY", Description = "Business that provides insurance products, policies, advice, and related services.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 21, Name = "Bank", Code = "BANK", Description = "Financial institution that provides banking, payment, lending, savings, and other financial services.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 22, Name = "Financial Advisor", Code = "FINANCIAL_ADVISOR", Description = "Professional service that provides financial planning, investment advice, and wealth management guidance.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 23, Name = "Medical Clinic", Code = "MEDICAL_CLINIC", Description = "Healthcare facility that provides medical examinations, consultations, treatments, and related services.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 24, Name = "Dental Clinic", Code = "DENTAL_CLINIC", Description = "Healthcare business that provides dental examinations, treatments, and oral health services.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 25, Name = "Pharmacy", Code = "PHARMACY", Description = "Healthcare business that dispenses medicines and provides pharmaceutical products and services.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 26, Name = "Veterinary Clinic", Code = "VETERINARY_CLINIC", Description = "Healthcare facility that provides medical care, treatment, and preventive services for animals.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 27, Name = "Fitness Gym", Code = "FITNESS_GYM", Description = "Fitness facility that provides exercise equipment, workout programs, and fitness services.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 28, Name = "Personal Trainer", Code = "PERSONAL_TRAINER", Description = "Fitness professional who provides personalized exercise programs, training, and fitness guidance.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 29, Name = "Yoga Studio", Code = "YOGA_STUDIO", Description = "Fitness and wellness business that provides yoga classes, sessions, and related activities.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 30, Name = "Beauty Salon", Code = "BEAUTY_SALON", Description = "Beauty business that provides hair, skincare, makeup, and other personal care services.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 31, Name = "Barber Shop", Code = "BARBER_SHOP", Description = "Business that provides haircuts, beard grooming, shaving, and other men's grooming services.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 32, Name = "Spa", Code = "SPA", Description = "Wellness business that provides relaxation, beauty, massage, and personal care treatments.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 33, Name = "Tattoo Studio", Code = "TATTOO_STUDIO", Description = "Studio that provides tattoo design and body art services.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 34, Name = "Photographer", Code = "PHOTOGRAPHER", Description = "Professional service that provides photography for events, products, portraits, and other purposes.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 35, Name = "Videographer", Code = "VIDEOGRAPHER", Description = "Professional service that provides video production, filming, editing, and related services.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 36, Name = "Graphic Designer", Code = "GRAPHIC_DESIGNER", Description = "Professional service that creates visual designs, branding materials, illustrations, and digital graphics.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 37, Name = "Web Design Agency", Code = "WEB_DESIGN_AGENCY", Description = "Business that designs and develops websites and digital user experiences for clients.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 38, Name = "Software Company", Code = "SOFTWARE_COMPANY", Description = "Technology business that develops, sells, or maintains software products and applications.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 39, Name = "IT Services", Code = "IT_SERVICES", Description = "Technology business that provides information technology support, consulting, infrastructure, and related services.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 40, Name = "Cybersecurity Company", Code = "CYBERSECURITY_COMPANY", Description = "Technology business that provides cybersecurity products, assessments, protection, and security services.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 41, Name = "Marketing Agency", Code = "MARKETING_AGENCY", Description = "Business that provides marketing strategy, advertising, branding, and promotional services.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 42, Name = "SEO Agency", Code = "SEO_AGENCY", Description = "Digital marketing business that helps improve website visibility and rankings in search engines.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 43, Name = "Digital Agency", Code = "DIGITAL_AGENCY", Description = "Agency that provides digital services such as web development, marketing, design, and online strategy.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 44, Name = "Freelancer", Code = "FREELANCER", Description = "Independent professional who provides specialized services to clients on a project or contract basis.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 45, Name = "Portfolio", Code = "PORTFOLIO", Description = "Website or professional presence designed to showcase a person's work, projects, skills, and achievements.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 46, Name = "Personal Website", Code = "PERSONAL_WEBSITE", Description = "Website created to present personal information, interests, skills, experience, or professional activities.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 47, Name = "Blogger", Code = "BLOGGER", Description = "Individual or business that regularly creates and publishes written or multimedia blog content.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 48, Name = "Influencer", Code = "INFLUENCER", Description = "Individual who creates online content and engages an audience through social media or other digital platforms.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 49, Name = "Musician", Code = "MUSICIAN", Description = "Individual or business involved in creating, performing, recording, or promoting music.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new BusinessType { Id = 50, Name = "DJ", Code = "DJ", Description = "Professional who selects, mixes, and performs recorded music for events, venues, or audiences.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false }
            );

            modelBuilder.Entity<SocialMedia>().HasData(
                new SocialMedia { Id = 1, Name = "Facebook", Code = "FACEBOOK", Icon = "fa-brands fa-facebook", Color = "#1877F2", Description = "Social media platform used for connecting with people, sharing content, and promoting businesses.", DisplayOrder = 1, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new SocialMedia { Id = 2, Name = "Instagram", Code = "INSTAGRAM", Icon = "fa-brands fa-instagram", Color = "#E4405F", Description = "Visual social media platform focused on sharing photos, videos, stories, and other visual content.", DisplayOrder = 2, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new SocialMedia { Id = 3, Name = "LinkedIn", Code = "LINKEDIN", Icon = "fa-brands fa-linkedin", Color = "#0A66C2", Description = "Professional social network used for business networking, career development, and professional content.", DisplayOrder = 3, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new SocialMedia { Id = 4, Name = "X", Code = "X-TWITTER", Icon = "fa-brands fa-x-twitter", Color = "#000000", Description = "Social media platform used for sharing short posts, news, opinions, and real-time updates.", DisplayOrder = 4, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new SocialMedia { Id = 5, Name = "YouTube", Code = "YOUTUBE", Icon = "fa-brands fa-youtube", Color = "#FF0000", Description = "Video-sharing platform used to publish, watch, and share video content.", DisplayOrder = 5, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new SocialMedia { Id = 6, Name = "TikTok", Code = "TIKTOK", Icon = "fa-brands fa-tiktok", Color = "#000000", Description = "Short-form video platform focused on entertainment, trends, and user-generated content.", DisplayOrder = 6, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new SocialMedia { Id = 7, Name = "WhatsApp", Code = "WHATSAPP", Icon = "fa-brands fa-whatsapp", Color = "#25D366", Description = "Messaging platform used for instant messages, voice calls, video calls, and sharing media.", DisplayOrder = 7, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new SocialMedia { Id = 8, Name = "Telegram", Code = "TELEGRAM", Icon = "fa-brands fa-telegram", Color = "#26A5E4", Description = "Messaging platform that supports conversations, groups, channels, file sharing, and multimedia.", DisplayOrder = 8, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new SocialMedia { Id = 9, Name = "Discord", Code = "DISCORD", Icon = "fa-brands fa-discord", Color = "#5865F2", Description = "Communication platform focused on communities, messaging, voice communication, and online collaboration.", DisplayOrder = 9, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new SocialMedia { Id = 10, Name = "GitHub", Code = "GITHUB", Icon = "fa-brands fa-github", Color = "#181717", Description = "Development platform used for hosting, managing, collaborating on, and sharing source code.", DisplayOrder = 10, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new SocialMedia { Id = 11, Name = "GitLab", Code = "GITLAB", Icon = "fa-brands fa-gitlab", Color = "#FC6D26", Description = "DevOps and software development platform used for source code management and collaboration.", DisplayOrder = 11, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new SocialMedia { Id = 12, Name = "Pinterest", Code = "PINTEREST", Icon = "fa-brands fa-pinterest", Color = "#E60023", Description = "Visual discovery platform used to find, organize, and share ideas, images, and inspiration.", DisplayOrder = 12, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new SocialMedia { Id = 13, Name = "Snapchat", Code = "SNAPCHAT", Icon = "fa-brands fa-snapchat", Color = "#FFFC00", Description = "Social media and messaging platform focused on photos, videos, stories, and temporary content.", DisplayOrder = 13, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new SocialMedia { Id = 14, Name = "Dribbble", Code = "DRIBBBLE", Icon = "fa-brands fa-dribbble", Color = "#EA4C89", Description = "Online platform where designers showcase their creative work, designs, and portfolios.", DisplayOrder = 14, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new SocialMedia { Id = 15, Name = "Behance", Code = "BEHANCE", Icon = "fa-brands fa-behance", Color = "#1769FF", Description = "Creative platform used by designers and artists to showcase and discover creative projects.", DisplayOrder = 15, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new SocialMedia { Id = 16, Name = "Medium", Code = "MEDIUM", Icon = "fa-brands fa-medium", Color = "#000000", Description = "Online publishing platform used to write, publish, and discover articles and stories.", DisplayOrder = 16, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new SocialMedia { Id = 17, Name = "Reddit", Code = "REDDIT", Icon = "fa-brands fa-reddit", Color = "#FF4500", Description = "Community-based platform where users discuss topics, share content, and participate in online communities.", DisplayOrder = 17, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new SocialMedia { Id = 18, Name = "Twitch", Code = "TWITCH", Icon = "fa-brands fa-twitch", Color = "#9146FF", Description = "Live streaming platform primarily used for gaming, entertainment, creative content, and live interaction.", DisplayOrder = 18, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new SocialMedia { Id = 19, Name = "Spotify", Code = "SPOTIFY", Icon = "fa-brands fa-spotify", Color = "#1DB954", Description = "Digital music and audio streaming platform used to share and discover music, podcasts, and other audio content.", DisplayOrder = 19, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new SocialMedia { Id = 20, Name = "Threads", Code = "THREADS", Icon = "fa-brands fa-threads", Color = "#000000", Description = "Social media platform focused on text-based conversations, discussions, and sharing updates.", DisplayOrder = 20, CreatedDateTime = DateTime.Now, IsDeleted = false }
            );

            modelBuilder.Entity<MessageUsReason>().HasData(
                new MessageUsReason { Id = 1, Name = "Info", Code = "INFO", Description = "General information and inquiries.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new MessageUsReason { Id = 2, Name = "Order", Code = "ORDER", Description = "Questions or inquiries related to orders.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new MessageUsReason { Id = 3, Name = "Complain", Code = "COMPLAIN", Description = "Complaints about products, services, or orders.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new MessageUsReason { Id = 4, Name = "Suggest", Code = "SUGGEST", Description = "Suggestions, ideas, or feedback for improvement.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false }
            );

            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "Admin", Code = "ADMIN", Description = "Administrator with full access to the system.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new Role { Id = 2, Name = "User", Code = "USER", Description = "Standard user with access to regular system features.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false }
            );

            modelBuilder.Entity<Gender>().HasData(
                new Gender { Id = 1, Name = "Male", Code = "M", Description = "Male gender.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new Gender { Id = 2, Name = "Female", Code = "F", Description = "Female gender.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new Gender { Id = 3, Name = "Prefer not to say", Code = "PNTS", Description = "The user prefers not to disclose their gender.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false }
            );

            modelBuilder.Entity<ContactType>().HasData(
                new ContactType { Id = 1, Name = "Email", Code = "EMAIL", Description = "Email contact type.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new ContactType { Id = 2, Name = "Phone Number", Code = "PHONE_NUMBER", Description = "Phone number contact type.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false }
            );

            modelBuilder.Entity<Currency>().HasData(
                new Currency { Id = 1, Name = "Euro", Code = "EUR", Symbol = "€", Description = "Euro currency.", DecimalPlaces = 2, CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new Currency { Id = 2, Name = "Dollar", Code = "USD", Symbol = "$", Description = "US Dollar currency.", DecimalPlaces = 2, CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new Currency { Id = 3, Name = "Konvertibilna marka", Code = "BAM", Symbol = "KM", Description = "Bosnia and Herzegovina Convertible Mark currency.", DecimalPlaces = 2, CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new Currency { Id = 4, Name = "Srpski dinar", Code = "RSD", Symbol = "din.", Description = "Serbian Dinar currency.", DecimalPlaces = 2, CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false }
            );

            modelBuilder.Entity<Claim>().HasData(
                new Claim { Id = 1, Name = "Create", Code = "CREATE", Description = "Claim for creating entities.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new Claim { Id = 2, Name = "Read", Code = "READ", Description = "Claim for reading entities.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new Claim { Id = 3, Name = "Update", Code = "UPDATE", Description = "Claim for updating entities.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new Claim { Id = 4, Name = "Delete", Code = "DELETE", Description = "Claim for deleting entities.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false }
            );

            modelBuilder.Entity<RoleClaim>().HasData(
                new RoleClaim { Id = 1, RoleId = 1, ClaimId = 1, CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new RoleClaim { Id = 2, RoleId = 1, ClaimId = 2, CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new RoleClaim { Id = 3, RoleId = 1, ClaimId = 3, CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new RoleClaim { Id = 4, RoleId = 1, ClaimId = 4, CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new RoleClaim { Id = 5, RoleId = 2, ClaimId = 1, CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new RoleClaim { Id = 6, RoleId = 2, ClaimId = 2, CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new RoleClaim { Id = 7, RoleId = 2, ClaimId = 3, CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new RoleClaim { Id = 8, RoleId = 2, ClaimId = 4, CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false }
            );

            modelBuilder.Entity<City>().HasData(
    new City { Id = 1, Name = "Bihać", PttCode = "77000", RegionId = 1, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 2, Name = "Cazin", PttCode = "77220", RegionId = 1, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 3, Name = "Velika Kladuša", PttCode = "77230", RegionId = 1, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 4, Name = "Bosanska Krupa", PttCode = "77240", RegionId = 1, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 5, Name = "Bužim", PttCode = "77245", RegionId = 1, CreatedDateTime = new DateTime(2026, 1, 1) },

    new City { Id = 6, Name = "Orašje", PttCode = "76270", RegionId = 2, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 7, Name = "Odžak", PttCode = "76290", RegionId = 2, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 8, Name = "Domaljevac", PttCode = "76233", RegionId = 2, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 9, Name = "Tolisa", PttCode = "76273", RegionId = 2, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 10, Name = "Donja Mahala", PttCode = "76273", RegionId = 2, CreatedDateTime = new DateTime(2026, 1, 1) },

    new City { Id = 11, Name = "Tuzla", PttCode = "75000", RegionId = 3, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 12, Name = "Živinice", PttCode = "75270", RegionId = 3, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 13, Name = "Lukavac", PttCode = "75300", RegionId = 3, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 14, Name = "Gračanica", PttCode = "75320", RegionId = 3, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 15, Name = "Srebrenik", PttCode = "75350", RegionId = 3, CreatedDateTime = new DateTime(2026, 1, 1) },

    new City { Id = 16, Name = "Zenica", PttCode = "72000", RegionId = 4, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 17, Name = "Visoko", PttCode = "71300", RegionId = 4, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 18, Name = "Kakanj", PttCode = "72240", RegionId = 4, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 19, Name = "Tešanj", PttCode = "74260", RegionId = 4, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 20, Name = "Zavidovići", PttCode = "72220", RegionId = 4, CreatedDateTime = new DateTime(2026, 1, 1) },

    new City { Id = 21, Name = "Goražde", PttCode = "73000", RegionId = 5, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 22, Name = "Ustikolina", PttCode = "73290", RegionId = 5, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 23, Name = "Prača", PttCode = "73270", RegionId = 5, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 24, Name = "Osanica", PttCode = "73200", RegionId = 5, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 25, Name = "Vitkovići", PttCode = "73100", RegionId = 5, CreatedDateTime = new DateTime(2026, 1, 1) },

    new City { Id = 26, Name = "Travnik", PttCode = "72270", RegionId = 6, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 27, Name = "Bugojno", PttCode = "70230", RegionId = 6, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 28, Name = "Jajce", PttCode = "70101", RegionId = 6, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 29, Name = "Vitez", PttCode = "72250", RegionId = 6, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 30, Name = "Novi Travnik", PttCode = "72290", RegionId = 6, CreatedDateTime = new DateTime(2026, 1, 1) },

    new City { Id = 31, Name = "Mostar", PttCode = "88000", RegionId = 7, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 32, Name = "Čapljina", PttCode = "88300", RegionId = 7, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 33, Name = "Čitluk", PttCode = "88260", RegionId = 7, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 34, Name = "Konjic", PttCode = "88400", RegionId = 7, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 35, Name = "Jablanica", PttCode = "88420", RegionId = 7, CreatedDateTime = new DateTime(2026, 1, 1) },

    new City { Id = 36, Name = "Široki Brijeg", PttCode = "88220", RegionId = 8, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 37, Name = "Ljubuški", PttCode = "88320", RegionId = 8, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 38, Name = "Grude", PttCode = "88340", RegionId = 8, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 39, Name = "Posušje", PttCode = "88240", RegionId = 8, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 40, Name = "Ružici", PttCode = "88340", RegionId = 8, CreatedDateTime = new DateTime(2026, 1, 1) },

    new City { Id = 41, Name = "Sarajevo", PttCode = "71000", RegionId = 9, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 42, Name = "Ilidža", PttCode = "71210", RegionId = 9, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 43, Name = "Hadžići", PttCode = "71240", RegionId = 9, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 44, Name = "Vogošća", PttCode = "71320", RegionId = 9, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 45, Name = "Ilijaš", PttCode = "71380", RegionId = 9, CreatedDateTime = new DateTime(2026, 1, 1) },

    new City { Id = 46, Name = "Livno", PttCode = "80101", RegionId = 10, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 47, Name = "Tomislavgrad", PttCode = "80240", RegionId = 10, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 48, Name = "Glamoč", PttCode = "80230", RegionId = 10, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 49, Name = "Drvar", PttCode = "80260", RegionId = 10, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 50, Name = "Bosansko Grahovo", PttCode = "80270", RegionId = 10, CreatedDateTime = new DateTime(2026, 1, 1) },

    new City { Id = 51, Name = "Banja Luka", PttCode = "78000", RegionId = 11, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 52, Name = "Bijeljina", PttCode = "76300", RegionId = 11, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 53, Name = "Prijedor", PttCode = "79101", RegionId = 11, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 54, Name = "Doboj", PttCode = "74000", RegionId = 11, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 55, Name = "Trebinje", PttCode = "89101", RegionId = 11, CreatedDateTime = new DateTime(2026, 1, 1) },

    new City { Id = 56, Name = "Brčko", PttCode = "76100", RegionId = 12, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 57, Name = "Brezovo Polje", PttCode = "76210", RegionId = 12, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 58, Name = "Maoča", PttCode = "76208", RegionId = 12, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 59, Name = "Ražljevo", PttCode = "76206", RegionId = 12, CreatedDateTime = new DateTime(2026, 1, 1) },
    new City { Id = 60, Name = "Gornji Rahić", PttCode = "76108", RegionId = 12, CreatedDateTime = new DateTime(2026, 1, 1) }
);















            //test data, delete later

            modelBuilder.Entity<UserContact>().HasData(
                new UserContact { Id = 1, UserId = 1, ContactTypeId = 1, Value = "061123456", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new UserContact { Id = 2, UserId = 1, ContactTypeId = 2, Value = "amer.kasum@example.com", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new UserContact { Id = 3, UserId = 2, ContactTypeId = 1, Value = "062987654", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new UserContact { Id = 4, UserId = 2, ContactTypeId = 2, Value = "user2@example.com", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false }
            );


            modelBuilder.Entity<Feedback>().HasData(
                new Feedback { Id = 1, UserId = 1, Rating = 5, Message = "Excellent service!", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new Feedback { Id = 2, UserId = 2, Rating = 4, Message = "Good experience overall.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new Feedback { Id = 3, UserId = 1, Rating = 3, Message = "Average service.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new Feedback { Id = 4, UserId = 2, Rating = 2, Message = "Not satisfied with the service.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new Feedback { Id = 5, UserId = 1, Rating = 1, Message = "Very poor experience.", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new Feedback { Id = 6, UserId = 1, Message = "Odlična usluga, sve je bilo brzo i profesionalno.", Rating = 5, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new Feedback { Id = 7, UserId = 2, Message = "Veoma sam zadovoljan uslugom. Sve preporuke!", Rating = 5, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new Feedback { Id = 8, UserId = 1, Message = "Dobra usluga i ljubazno osoblje.", Rating = 4, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new Feedback { Id = 9, UserId = 1, Message = "Sve je prošlo kako treba, nemam zamjerki.", Rating = 4, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new Feedback { Id = 10, UserId = 2, Message = "Odlična komunikacija i veoma brzo riješena moja zahtjev.", Rating = 5, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new Feedback { Id = 11, UserId = 1, Message = "Usluga je bila korektna, ali može biti malo brža.", Rating = 3, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new Feedback { Id = 12, UserId = 2, Message = "Jako dobro iskustvo. Profesionalno i pouzdano.", Rating = 5, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new Feedback { Id = 13, UserId = 1, Message = "Sve je bilo u redu i prema dogovoru.", Rating = 4, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new Feedback { Id = 14, UserId = 2, Message = "Nisam potpuno zadovoljan iskustvom.", Rating = 2, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new Feedback { Id = 15, UserId = 2, Message = "Odličan odnos prema korisnicima. Sve preporuke.", Rating = 5, CreatedDateTime = DateTime.Now, IsDeleted = false }
            );


            modelBuilder.Entity<MessageUs>().HasData(
                new MessageUs { Id = 1, EmailSender = "amer.kasum@gmail.com", Message = "Imam pitanje u vezi vaše usluge.", MessageUsReasonId = 1, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new MessageUs { Id = 2, EmailSender = "test.user@gmail.com", Message = "Zanima me više informacija o vašim uslugama.", MessageUsReasonId = 2, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new MessageUs { Id = 3, EmailSender = "john.doe@gmail.com", Message = "Molim vas za dodatne informacije.", MessageUsReasonId = 3, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new MessageUs { Id = 4, EmailSender = "info@example.com", Message = "Želio bih prijaviti problem sa aplikacijom.", MessageUsReasonId = 4, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new MessageUs { Id = 5, EmailSender = "customer@gmail.com", Message = "Kada mogu očekivati odgovor na moj zahtjev?", MessageUsReasonId = 1, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new MessageUs { Id = 6, EmailSender = "contact@example.com", Message = "Imam prijedlog za poboljšanje vaše aplikacije.", MessageUsReasonId = 2, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new MessageUs { Id = 7, EmailSender = "user.test@gmail.com", Message = "Aplikacija mi prikazuje grešku prilikom prijave.", MessageUsReasonId = 4, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new MessageUs { Id = 8, EmailSender = "example.user@gmail.com", Message = "Želio bih saznati više o vašim mogućnostima.", MessageUsReasonId = 3, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new MessageUs { Id = 9, EmailSender = "test@example.com", Message = "Molim vas da me kontaktirate kada budete u mogućnosti.", MessageUsReasonId = 1, CreatedDateTime = DateTime.Now, IsDeleted = false },
                new MessageUs { Id = 10, EmailSender = "client@gmail.com", Message = "Imam nekoliko pitanja prije korištenja usluge.", MessageUsReasonId = 2, CreatedDateTime = DateTime.Now, IsDeleted = false }
            );

            //ADMIN
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    FirstName = "Admin",
                    LastName = "Admin",
                    Email = "admin@admin.com",
                    Username = "admin",
                    Password = "admin123", // In a real application, you should hash the password,
                    PasswordSalt = "salt",
                    GenderId = 1,
                    BirthDate = new DateTime(1990, 1, 1),
                    ImageUrl = null,
                    CreatedDateTime = DateTime.Now,
                    ModifiedDateTime = null,
                    DeletedDateTime = null,
                    IsDeleted = false,
                }
             );

            modelBuilder.Entity<UserRole>().HasData(
                new UserRole
                {
                    Id = 1,
                    UserId = 1,
                    RoleId = 1,
                    CreatedDateTime = DateTime.Now,
                    ModifiedDateTime = null,
                    DeletedDateTime = null,
                    IsDeleted = false,
                }
            );

            //USER
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 2,
                    FirstName = "User",
                    LastName = "User",
                    Email = "user@user.com",
                    Username = "user",
                    Password = "user123", // In a real application, you should hash the password,
                    PasswordSalt = "salt",
                    GenderId = 1,
                    BirthDate = new DateTime(1990, 1, 1),
                    ImageUrl = null,
                    CreatedDateTime = DateTime.Now,
                    ModifiedDateTime = null,
                    DeletedDateTime = null,
                    IsDeleted = false,
                }
             );

            modelBuilder.Entity<UserRole>().HasData(
                new UserRole
                {
                    Id = 2,
                    UserId = 2,
                    RoleId = 2,
                    CreatedDateTime = DateTime.Now,
                    ModifiedDateTime = null,
                    DeletedDateTime = null,
                    IsDeleted = false,
                }
            );

            modelBuilder.Entity<UserSocialMedia>().HasData(
                new UserSocialMedia { Id = 1, UserId = 1, SocialMediaId = 1, Link = "https://facebook.com/user1", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new UserSocialMedia { Id = 2, UserId = 1, SocialMediaId = 2, Link = "https://instagram.com/user1", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new UserSocialMedia { Id = 3, UserId = 1, SocialMediaId = 3, Link = "https://twitter.com/user1", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new UserSocialMedia { Id = 4, UserId = 1, SocialMediaId = 4, Link = "https://linkedin.com/in/user1", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new UserSocialMedia { Id = 5, UserId = 1, SocialMediaId = 5, Link = "https://github.com/user1", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new UserSocialMedia { Id = 6, UserId = 2, SocialMediaId = 1, Link = "https://facebook.com/user2", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new UserSocialMedia { Id = 7, UserId = 2, SocialMediaId = 2, Link = "https://instagram.com/user2", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new UserSocialMedia { Id = 8, UserId = 2, SocialMediaId = 6, Link = "https://youtube.com/user2", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new UserSocialMedia { Id = 9, UserId = 2, SocialMediaId = 7, Link = "https://tiktok.com/@user2", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false },
                new UserSocialMedia { Id = 10, UserId = 2, SocialMediaId = 8, Link = "https://x.com/user2", CreatedDateTime = DateTime.Now, ModifiedDateTime = null, DeletedDateTime = null, IsDeleted = false }
            );
        }
    }
}
