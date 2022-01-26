using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace DotNetCoreWeb.DBContext
{
    public class DAO : DbContext
    {
        private static readonly bool[] s_migrated = { false };

        public DAO()
        {
            this.Database.EnsureCreated();
        }

        public DAO(DbContextOptions<DAO> options) : base(options)
        {
            if (options == null)
            {
                options = Init.DbContextOptions;
            }

            if (!s_migrated[0])
            {
                lock (s_migrated)
                {
                    if (!s_migrated[0])
                    {
                        this.Database.Migrate();
                        s_migrated[0] = true;
                    }
                }
            }
        }
        // yoshoxy : 20190603 之後這裡要改成config設定
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Init.ConnectionString);
        }

        public virtual DbSet<sysSecurity> sysSecurity { get; set; }
        public virtual DbSet<sysUserInfo> sysUserInfo { get; set; }
        public virtual DbSet<sysGroup> sysGroup { get; set; }
        public virtual DbSet<sysGroupMapping> sysGroupMapping { get; set; }
    }
}
