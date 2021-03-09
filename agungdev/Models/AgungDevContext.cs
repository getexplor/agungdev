using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace agungdev.Models
{
    public partial class AgungDevContext : DbContext
    {
        public AgungDevContext()
        {
        }

        public AgungDevContext(DbContextOptions<AgungDevContext> options)
            : base(options)
        {
        }

        public virtual DbSet<About> Abouts { get; set; }
        public virtual DbSet<Category> Categorys { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Portfolio> Portfolios { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=AgungDev;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<About>(entity =>
            {
                entity.HasKey(e => e.IdAbout);

                entity.ToTable("abouts");

                entity.Property(e => e.IdAbout).HasColumnName("id_about");

                entity.Property(e => e.AboutMe).HasColumnName("about_me");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Birthday)
                    .HasColumnType("date")
                    .HasColumnName("birthday");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("country");

                entity.Property(e => e.CurrentPosition)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("current_position");

                entity.Property(e => e.Degree)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("degree");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.IdCategory);

                entity.ToTable("categorys");

                entity.Property(e => e.IdCategory).HasColumnName("id_category");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("category_name");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasKey(e => e.IdContact);

                entity.ToTable("contacts");

                entity.Property(e => e.IdContact).HasColumnName("id_contact");

                entity.Property(e => e.Address).HasColumnName("address");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Facebook)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("facebook");

                entity.Property(e => e.Github)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("github");

                entity.Property(e => e.Instagram)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("instagram");

                entity.Property(e => e.Linkedin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("linkedin");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.Twitter)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("twitter");
            });

            modelBuilder.Entity<Portfolio>(entity =>
            {
                entity.HasKey(e => e.IdPortfolio);

                entity.ToTable("portfolios");

                entity.Property(e => e.IdPortfolio).HasColumnName("id_portfolio");

                entity.Property(e => e.IdCategory).HasColumnName("id_category");

                entity.Property(e => e.ImageByte)
                    .HasColumnType("image")
                    .HasColumnName("image_byte");

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("image_path");

                entity.Property(e => e.ImageTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("image_title");

                entity.Property(e => e.PortfoName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("portfo_name");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.IdRole);

                entity.ToTable("roles");

                entity.Property(e => e.IdRole).HasColumnName("id_role");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("role_name");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.HasKey(e => e.IdService);

                entity.ToTable("services");

                entity.Property(e => e.IdService).HasColumnName("id_service");

                entity.Property(e => e.ServiceContent).HasColumnName("service_content");

                entity.Property(e => e.ServiceName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("service_name");
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.HasKey(e => e.IdSkill);

                entity.ToTable("skills");

                entity.Property(e => e.IdSkill).HasColumnName("id_skill");

                entity.Property(e => e.SkillName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("skill_name");

                entity.Property(e => e.SkillValue).HasColumnName("skill_value");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUser);

                entity.ToTable("users");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.IdRole).HasColumnName("id_role");

                entity.Property(e => e.ImageByte)
                    .HasColumnType("image")
                    .HasColumnName("image_byte");

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("image_path");

                entity.Property(e => e.ImageTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("image_title");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
