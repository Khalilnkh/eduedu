using EduMap.Models;
using Microsoft.EntityFrameworkCore;

namespace EduMap.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Settings> Settings { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<NoticeBoard> NoticeBoards { get; set; }
        public DbSet<ProTeacher> ProTeachers { get; set; }
        public DbSet<WhyChoose> WhyChooses { get; set; }
        public DbSet<FooterSlider> FooterSliders { get; set; }
    }
}
