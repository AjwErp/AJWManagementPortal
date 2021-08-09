using AJWManagementPortal.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AJWManagementPortal.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        //Model clases for DB Talbe these are not use are useless tables
        public DbSet<Noticb> Noticb { get; set; }
        public DbSet<DailyPlanIn> DailyPlanIn { get; set; }
        public DbSet<DailyPlanOut> DailyPlanOut { get; set; }
        public DbSet<DailyPlanInAccounts> DailyPlanInAccountss { get; set; }
        public DbSet<DailyPlanOutAccounts> DailyPlanOutAccountss { get; set; }
        public DbSet<Img> Img { get; set; }
        public DbSet<AccountDailyContinueSheetM> DailyContinueSheetMs { get; set; }
        //public DbSet<DailyTransactionReportM> DailyTransactionReportMs { get; set; }
        public DbSet<UserModel> UserTable { get; set; }
        public DbSet<aDailyCash> aDailyCashes { get; set; }
        public DbSet<BankBalane> bankBalane { get; set; }
        public DbSet<MeezanBankIEReport> MeezanBankIEReports { get; set; }
        public DbSet<MeezanBankIEVoucher> MeezanBankIEVouchers { get; set; }
        public DbSet<NoticBoard> NoticBoard{ get; set; }
        public DbSet<DailyPlanInOutModel> DailyPlanInOutModels { get; set; }
        //model classes and DB Table--------------
        public DbSet<AJWDailyPlanIO> AJWDailyPlanIOs { get; set; }
        public DbSet<AJWNoticeBoardHrm> AJWNoticeBoardHrms { get; set; }
    }
}
