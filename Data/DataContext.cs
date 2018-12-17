using System;
using coouncil.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Coun.Data
{
    public class DataContext : IdentityDbContext
    {

        public DataContext(DbContextOptions<DataContext> options) :
            base(options)
        {

        }
        public DbSet<LinkModel> LinkModels { get; set; }
        DbSet<BussinesModel> BussinesModels { get; set; }
        public DbSet<GalleryModel> GalleryModels { get; set; }
        public DbSet<CafeyModel> CafeyModels { get; set; }
        DbSet<HistoryLocationModel> HistoryLocationModels { get; set; }
        public DbSet<SliderModel> SliderModels { get; set; }
        DbSet<FormsModel> FormsModels { get; set; }
        public DbSet<NewsModel> NewsModels { get; set; }

        public DbSet<AnouncementsModel> anouncementsModels { get; set; }

        public DbSet<CouncilModel> CouncilModels { get; set; }

        public DbSet<GuestHousesModel> GuestHousesModels { get; set; }

        public DbSet<ImportantLocationModel> ImportantLocationModels { get; set; }
        public DbSet<CalenderModel> CalenderModels { get; set; }
        public DbSet<JobModel> JobModels { get; set; }
        public DbSet<BussinessModel> BussinessModels { get; set; }

    }
}