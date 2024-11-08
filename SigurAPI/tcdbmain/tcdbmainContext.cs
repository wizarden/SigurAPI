using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SigurAPI.tcdbmain
{
    public partial class tcdbmainContext : DbContext
    {
        public tcdbmainContext()
        {
        }

        public tcdbmainContext(DbContextOptions<tcdbmainContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Accessrule> Accessrules { get; set; } = null!;
        public virtual DbSet<Deprulebinding> Deprulebindings { get; set; } = null!;
        public virtual DbSet<Devbinding> Devbindings { get; set; } = null!;
        public virtual DbSet<Device> Devices { get; set; } = null!;
        public virtual DbSet<Devrulebinding> Devrulebindings { get; set; } = null!;
        public virtual DbSet<Personal> Personals { get; set; } = null!;
        public virtual DbSet<PersonalKey> PersonalKeys { get; set; } = null!;
        public virtual DbSet<PositionsList> PositionsLists { get; set; } = null!;
        public virtual DbSet<Rulebinding> Rulebindings { get; set; } = null!;
        public virtual DbSet<Ruledep> Ruledeps { get; set; } = null!;
        public virtual DbSet<Sideparamtype> Sideparamtypes { get; set; } = null!;
        public virtual DbSet<Sideparamvalue> Sideparamvalues { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("server=192.168.1.164;Port=3305;user=root;password=392576;database=tc-db-main;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accessrule>(entity =>
            {
                entity.ToTable("accessrules");

                entity.HasIndex(e => e.Id, "ID");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.AlertTempA)
                    .HasColumnType("int(11)")
                    .HasColumnName("ALERT_TEMP_A")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AlertTempB)
                    .HasColumnType("int(11)")
                    .HasColumnName("ALERT_TEMP_B")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AlkoAllowdrunka)
                    .HasColumnName("ALKO_ALLOWDRUNKA")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AlkoAllowdrunkb)
                    .HasColumnName("ALKO_ALLOWDRUNKB")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AlkoProba)
                    .HasColumnType("int(11)")
                    .HasColumnName("ALKO_PROBA")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AlkoProbb)
                    .HasColumnType("int(11)")
                    .HasColumnName("ALKO_PROBB")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AlkoThr)
                    .HasColumnType("int(11)")
                    .HasColumnName("ALKO_THR")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Boolparam1)
                    .HasColumnName("BOOLPARAM1")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Boolparam2)
                    .HasColumnName("BOOLPARAM2")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Boolparam3)
                    .HasColumnName("BOOLPARAM3")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Boolparam4)
                    .HasColumnName("BOOLPARAM4")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BreakType)
                    .HasMaxLength(32)
                    .HasColumnName("BREAK_TYPE")
                    .HasDefaultValueSql("'''FIXED'''");

                entity.Property(e => e.CondSearchFor)
                    .HasMaxLength(1000)
                    .HasColumnName("COND_SEARCH_FOR")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CondSearchWhere)
                    .HasMaxLength(1000)
                    .HasColumnName("COND_SEARCH_WHERE")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CondType)
                    .HasMaxLength(32)
                    .HasColumnName("COND_TYPE")
                    .HasDefaultValueSql("'''ALWAYS'''");

                entity.Property(e => e.Createdtime)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDTIME")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Deletedtime)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETEDTIME")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DeploymentId)
                    .HasMaxLength(255)
                    .HasColumnName("DEPLOYMENT_ID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Description)
                    .HasColumnType("blob")
                    .HasColumnName("DESCRIPTION")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Enddate)
                    .HasColumnType("date")
                    .HasColumnName("ENDDATE")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Extid)
                    .HasMaxLength(128)
                    .HasColumnName("EXTID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Extsourceid)
                    .HasColumnType("int(11)")
                    .HasColumnName("EXTSOURCEID");

                entity.Property(e => e.FaceiA)
                    .HasMaxLength(32)
                    .HasColumnName("FACEI_A")
                    .HasDefaultValueSql("'''ON'''");

                entity.Property(e => e.FaceiB)
                    .HasMaxLength(32)
                    .HasColumnName("FACEI_B")
                    .HasDefaultValueSql("'''ON'''");

                entity.Property(e => e.FacevA)
                    .HasColumnType("enum('OFF','SOFT','HARD','SOFT_GROUP','HARD_GROUP')")
                    .HasColumnName("FACEV_A")
                    .HasDefaultValueSql("'''OFF'''");

                entity.Property(e => e.FacevB)
                    .HasColumnType("enum('OFF','SOFT','HARD','SOFT_GROUP','HARD_GROUP')")
                    .HasColumnName("FACEV_B")
                    .HasDefaultValueSql("'''OFF'''");

                entity.Property(e => e.Guest)
                    .HasColumnName("GUEST")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.LprpolicyA)
                    .HasMaxLength(32)
                    .HasColumnName("LPRPOLICY_A")
                    .HasDefaultValueSql("'''LP_ONLY'''");

                entity.Property(e => e.LprpolicyB)
                    .HasMaxLength(32)
                    .HasColumnName("LPRPOLICY_B")
                    .HasDefaultValueSql("'''LP_ONLY'''");

                entity.Property(e => e.MaskvA)
                    .HasColumnType("enum('OFF','HARD','SOFT')")
                    .HasColumnName("MASKV_A")
                    .HasDefaultValueSql("'''OFF'''");

                entity.Property(e => e.MaskvB)
                    .HasColumnType("enum('OFF','HARD','SOFT')")
                    .HasColumnName("MASKV_B")
                    .HasDefaultValueSql("'''OFF'''");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .HasColumnName("NAME")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Nrules)
                    .HasColumnType("int(11)")
                    .HasColumnName("NRULES")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Nspecrules)
                    .HasColumnType("int(11)")
                    .HasColumnName("NSPECRULES")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OverrideWt)
                    .HasColumnName("OVERRIDE_WT")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ParkingTariffId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PARKING_TARIFF_ID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Poweridx)
                    .HasColumnType("int(11)")
                    .HasColumnName("POWERIDX")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Rule0)
                    .HasColumnType("blob")
                    .HasColumnName("RULE0")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Rule1)
                    .HasColumnType("blob")
                    .HasColumnName("RULE1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Rule10)
                    .HasColumnType("blob")
                    .HasColumnName("RULE10")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Rule11)
                    .HasColumnType("blob")
                    .HasColumnName("RULE11")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Rule12)
                    .HasColumnType("blob")
                    .HasColumnName("RULE12")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Rule13)
                    .HasColumnType("blob")
                    .HasColumnName("RULE13")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Rule14)
                    .HasColumnType("blob")
                    .HasColumnName("RULE14")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Rule15)
                    .HasColumnType("blob")
                    .HasColumnName("RULE15")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Rule16)
                    .HasColumnType("blob")
                    .HasColumnName("RULE16")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Rule17)
                    .HasColumnType("blob")
                    .HasColumnName("RULE17")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Rule18)
                    .HasColumnType("blob")
                    .HasColumnName("RULE18")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Rule19)
                    .HasColumnType("blob")
                    .HasColumnName("RULE19")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Rule2)
                    .HasColumnType("blob")
                    .HasColumnName("RULE2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Rule20)
                    .HasColumnType("blob")
                    .HasColumnName("RULE20")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Rule21)
                    .HasColumnType("blob")
                    .HasColumnName("RULE21")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Rule22)
                    .HasColumnType("blob")
                    .HasColumnName("RULE22")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Rule23)
                    .HasColumnType("blob")
                    .HasColumnName("RULE23")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Rule24)
                    .HasColumnType("blob")
                    .HasColumnName("RULE24")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Rule25)
                    .HasColumnType("blob")
                    .HasColumnName("RULE25")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Rule26)
                    .HasColumnType("blob")
                    .HasColumnName("RULE26")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Rule27)
                    .HasColumnType("blob")
                    .HasColumnName("RULE27")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Rule28)
                    .HasColumnType("blob")
                    .HasColumnName("RULE28")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Rule29)
                    .HasColumnType("blob")
                    .HasColumnName("RULE29")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Rule3)
                    .HasColumnType("blob")
                    .HasColumnName("RULE3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Rule30)
                    .HasColumnType("blob")
                    .HasColumnName("RULE30")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Rule31)
                    .HasColumnType("blob")
                    .HasColumnName("RULE31")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Rule4)
                    .HasColumnType("blob")
                    .HasColumnName("RULE4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Rule5)
                    .HasColumnType("blob")
                    .HasColumnName("RULE5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Rule6)
                    .HasColumnType("blob")
                    .HasColumnName("RULE6")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Rule7)
                    .HasColumnType("blob")
                    .HasColumnName("RULE7")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Rule8)
                    .HasColumnType("blob")
                    .HasColumnName("RULE8")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Rule9)
                    .HasColumnType("blob")
                    .HasColumnName("RULE9")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Ruletype)
                    .HasColumnType("enum('NORMAL','ESCORT_GROUP','EXTERNAL','MNGSTATE')")
                    .HasColumnName("RULETYPE")
                    .HasDefaultValueSql("'''NORMAL'''");

                entity.Property(e => e.ServsyncExported)
                    .HasColumnName("SERVSYNC_EXPORTED")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Sideparam0)
                    .HasMaxLength(255)
                    .HasColumnName("SIDEPARAM0")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SpecDpassa)
                    .HasColumnName("SPEC_DPASSA")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SpecDpassb)
                    .HasColumnName("SPEC_DPASSB")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SpecDreadAction)
                    .HasColumnType("enum('NO_ACTION','NORMAL_UNLOCKED','NORMAL_LOCKED','LOCKED_UNLOCKED')")
                    .HasColumnName("SPEC_DREAD_ACTION")
                    .HasDefaultValueSql("'''NO_ACTION'''");

                entity.Property(e => e.SpecEscortProb)
                    .HasColumnType("int(11)")
                    .HasColumnName("SPEC_ESCORT_PROB")
                    .HasDefaultValueSql("'100'");

                entity.Property(e => e.SpecEscortRuleid)
                    .HasColumnType("int(11)")
                    .HasColumnName("SPEC_ESCORT_RULEID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SpecEscorta)
                    .HasColumnName("SPEC_ESCORTA")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SpecEscortb)
                    .HasColumnName("SPEC_ESCORTB")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SpecExptimecollect)
                    .HasColumnName("SPEC_EXPTIMECOLLECT")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SpecExtreadera)
                    .HasColumnType("enum('DEFAULT','GUESTREADER','REGISTRATOR','PRIMARYONLY')")
                    .HasColumnName("SPEC_EXTREADERA")
                    .HasDefaultValueSql("'''DEFAULT'''");

                entity.Property(e => e.SpecExtreaderb)
                    .HasColumnType("enum('DEFAULT','GUESTREADER','REGISTRATOR','PRIMARYONLY')")
                    .HasColumnName("SPEC_EXTREADERB")
                    .HasDefaultValueSql("'''DEFAULT'''");

                entity.Property(e => e.SpecOpreqa)
                    .HasColumnName("SPEC_OPREQA")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SpecOpreqb)
                    .HasColumnName("SPEC_OPREQB")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SpecPayitema)
                    .HasColumnType("int(11)")
                    .HasColumnName("SPEC_PAYITEMA")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SpecPayitemb)
                    .HasColumnType("int(11)")
                    .HasColumnName("SPEC_PAYITEMB")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SpecReqpina)
                    .HasColumnName("SPEC_REQPINA")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SpecReqpinb)
                    .HasColumnName("SPEC_REQPINB")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Specdate0)
                    .HasColumnType("date")
                    .HasColumnName("SPECDATE0")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specdate1)
                    .HasColumnType("date")
                    .HasColumnName("SPECDATE1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specdate10)
                    .HasColumnType("date")
                    .HasColumnName("SPECDATE10")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specdate11)
                    .HasColumnType("date")
                    .HasColumnName("SPECDATE11")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specdate12)
                    .HasColumnType("date")
                    .HasColumnName("SPECDATE12")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specdate13)
                    .HasColumnType("date")
                    .HasColumnName("SPECDATE13")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specdate14)
                    .HasColumnType("date")
                    .HasColumnName("SPECDATE14")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specdate15)
                    .HasColumnType("date")
                    .HasColumnName("SPECDATE15")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specdate16)
                    .HasColumnType("date")
                    .HasColumnName("SPECDATE16")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specdate17)
                    .HasColumnType("date")
                    .HasColumnName("SPECDATE17")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specdate18)
                    .HasColumnType("date")
                    .HasColumnName("SPECDATE18")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specdate19)
                    .HasColumnType("date")
                    .HasColumnName("SPECDATE19")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specdate2)
                    .HasColumnType("date")
                    .HasColumnName("SPECDATE2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specdate20)
                    .HasColumnType("date")
                    .HasColumnName("SPECDATE20")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specdate21)
                    .HasColumnType("date")
                    .HasColumnName("SPECDATE21")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specdate22)
                    .HasColumnType("date")
                    .HasColumnName("SPECDATE22")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specdate23)
                    .HasColumnType("date")
                    .HasColumnName("SPECDATE23")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specdate24)
                    .HasColumnType("date")
                    .HasColumnName("SPECDATE24")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specdate25)
                    .HasColumnType("date")
                    .HasColumnName("SPECDATE25")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specdate26)
                    .HasColumnType("date")
                    .HasColumnName("SPECDATE26")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specdate27)
                    .HasColumnType("date")
                    .HasColumnName("SPECDATE27")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specdate28)
                    .HasColumnType("date")
                    .HasColumnName("SPECDATE28")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specdate29)
                    .HasColumnType("date")
                    .HasColumnName("SPECDATE29")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specdate3)
                    .HasColumnType("date")
                    .HasColumnName("SPECDATE3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specdate30)
                    .HasColumnType("date")
                    .HasColumnName("SPECDATE30")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specdate31)
                    .HasColumnType("date")
                    .HasColumnName("SPECDATE31")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specdate4)
                    .HasColumnType("date")
                    .HasColumnName("SPECDATE4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specdate5)
                    .HasColumnType("date")
                    .HasColumnName("SPECDATE5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specdate6)
                    .HasColumnType("date")
                    .HasColumnName("SPECDATE6")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specdate7)
                    .HasColumnType("date")
                    .HasColumnName("SPECDATE7")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specdate8)
                    .HasColumnType("date")
                    .HasColumnName("SPECDATE8")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specdate9)
                    .HasColumnType("date")
                    .HasColumnName("SPECDATE9")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specrule0)
                    .HasColumnType("blob")
                    .HasColumnName("SPECRULE0")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specrule1)
                    .HasColumnType("blob")
                    .HasColumnName("SPECRULE1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specrule10)
                    .HasColumnType("blob")
                    .HasColumnName("SPECRULE10")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specrule11)
                    .HasColumnType("blob")
                    .HasColumnName("SPECRULE11")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specrule12)
                    .HasColumnType("blob")
                    .HasColumnName("SPECRULE12")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specrule13)
                    .HasColumnType("blob")
                    .HasColumnName("SPECRULE13")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specrule14)
                    .HasColumnType("blob")
                    .HasColumnName("SPECRULE14")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specrule15)
                    .HasColumnType("blob")
                    .HasColumnName("SPECRULE15")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specrule16)
                    .HasColumnType("blob")
                    .HasColumnName("SPECRULE16")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specrule17)
                    .HasColumnType("blob")
                    .HasColumnName("SPECRULE17")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specrule18)
                    .HasColumnType("blob")
                    .HasColumnName("SPECRULE18")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specrule19)
                    .HasColumnType("blob")
                    .HasColumnName("SPECRULE19")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specrule2)
                    .HasColumnType("blob")
                    .HasColumnName("SPECRULE2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specrule20)
                    .HasColumnType("blob")
                    .HasColumnName("SPECRULE20")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specrule21)
                    .HasColumnType("blob")
                    .HasColumnName("SPECRULE21")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specrule22)
                    .HasColumnType("blob")
                    .HasColumnName("SPECRULE22")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specrule23)
                    .HasColumnType("blob")
                    .HasColumnName("SPECRULE23")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specrule24)
                    .HasColumnType("blob")
                    .HasColumnName("SPECRULE24")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specrule25)
                    .HasColumnType("blob")
                    .HasColumnName("SPECRULE25")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specrule26)
                    .HasColumnType("blob")
                    .HasColumnName("SPECRULE26")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specrule27)
                    .HasColumnType("blob")
                    .HasColumnName("SPECRULE27")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specrule28)
                    .HasColumnType("blob")
                    .HasColumnName("SPECRULE28")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specrule29)
                    .HasColumnType("blob")
                    .HasColumnName("SPECRULE29")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specrule3)
                    .HasColumnType("blob")
                    .HasColumnName("SPECRULE3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specrule30)
                    .HasColumnType("blob")
                    .HasColumnName("SPECRULE30")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specrule31)
                    .HasColumnType("blob")
                    .HasColumnName("SPECRULE31")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specrule4)
                    .HasColumnType("blob")
                    .HasColumnName("SPECRULE4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specrule5)
                    .HasColumnType("blob")
                    .HasColumnName("SPECRULE5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specrule6)
                    .HasColumnType("blob")
                    .HasColumnName("SPECRULE6")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specrule7)
                    .HasColumnType("blob")
                    .HasColumnName("SPECRULE7")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specrule8)
                    .HasColumnType("blob")
                    .HasColumnName("SPECRULE8")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specrule9)
                    .HasColumnType("blob")
                    .HasColumnName("SPECRULE9")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Startdate)
                    .HasColumnType("date")
                    .HasColumnName("STARTDATE")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Status)
                    .HasColumnType("enum('AVAILABLE','DELETED')")
                    .HasColumnName("STATUS")
                    .HasDefaultValueSql("'''AVAILABLE'''");

                entity.Property(e => e.Stdweekmode)
                    .HasColumnName("STDWEEKMODE")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.WarnTempA)
                    .HasColumnType("int(11)")
                    .HasColumnName("WARN_TEMP_A")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.WarnTempB)
                    .HasColumnType("int(11)")
                    .HasColumnName("WARN_TEMP_B")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Wtmode)
                    .HasColumnType("enum('PERIM','ZONE')")
                    .HasColumnName("WTMODE")
                    .HasDefaultValueSql("'''PERIM'''");
            });

            modelBuilder.Entity<Deprulebinding>(entity =>
            {
                entity.HasKey(e => e.RuleId)
                    .HasName("PRIMARY");

                entity.ToTable("deprulebindings");

                entity.HasIndex(e => e.DepId, "DEP_ID");

                entity.HasIndex(e => e.RuleId, "RULE_ID");

                entity.Property(e => e.RuleId)
                    .HasColumnType("int(11)")
                    .HasColumnName("RULE_ID");

                entity.Property(e => e.DepId)
                    .HasColumnType("int(11)")
                    .HasColumnName("DEP_ID")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Devbinding>(entity =>
            {
                entity.HasKey(e => new { e.EmpId, e.DevId })
                    .HasName("PRIMARY");

                entity.ToTable("devbindings");

                entity.HasIndex(e => e.DevId, "DEV_ID");

                entity.HasIndex(e => e.EmpId, "EMP_ID");

                entity.Property(e => e.EmpId)
                    .HasColumnType("int(11)")
                    .HasColumnName("EMP_ID");

                entity.Property(e => e.DevId)
                    .HasColumnType("int(11)")
                    .HasColumnName("DEV_ID");
            });

            modelBuilder.Entity<Device>(entity =>
            {
                entity.ToTable("devices");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.AplOn)
                    .HasColumnName("APL_ON")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AplTarget)
                    .HasColumnName("APL_TARGET")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Area)
                    .HasColumnType("int(11)")
                    .HasColumnName("AREA")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BioaIp)
                    .HasMaxLength(128)
                    .HasColumnName("BIOA_IP")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BioaParam1)
                    .HasMaxLength(128)
                    .HasColumnName("BIOA_PARAM1")
                    .HasDefaultValueSql("''''''");

                entity.Property(e => e.BioaParam2)
                    .HasMaxLength(128)
                    .HasColumnName("BIOA_PARAM2")
                    .HasDefaultValueSql("''''''");

                entity.Property(e => e.BioaParam3)
                    .HasMaxLength(128)
                    .HasColumnName("BIOA_PARAM3")
                    .HasDefaultValueSql("''''''");

                entity.Property(e => e.BioaParam4)
                    .HasMaxLength(128)
                    .HasColumnName("BIOA_PARAM4")
                    .HasDefaultValueSql("''''''");

                entity.Property(e => e.BioaPort)
                    .HasColumnType("int(11)")
                    .HasColumnName("BIOA_PORT")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BioaType)
                    .HasMaxLength(32)
                    .HasColumnName("BIOA_TYPE")
                    .HasDefaultValueSql("'''NOT_USED'''");

                entity.Property(e => e.BiobIp)
                    .HasMaxLength(128)
                    .HasColumnName("BIOB_IP")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BiobParam1)
                    .HasMaxLength(128)
                    .HasColumnName("BIOB_PARAM1")
                    .HasDefaultValueSql("''''''");

                entity.Property(e => e.BiobParam2)
                    .HasMaxLength(128)
                    .HasColumnName("BIOB_PARAM2")
                    .HasDefaultValueSql("''''''");

                entity.Property(e => e.BiobParam3)
                    .HasMaxLength(128)
                    .HasColumnName("BIOB_PARAM3")
                    .HasDefaultValueSql("''''''");

                entity.Property(e => e.BiobParam4)
                    .HasMaxLength(128)
                    .HasColumnName("BIOB_PARAM4")
                    .HasDefaultValueSql("''''''");

                entity.Property(e => e.BiobPort)
                    .HasColumnType("int(11)")
                    .HasColumnName("BIOB_PORT")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BiobType)
                    .HasMaxLength(32)
                    .HasColumnName("BIOB_TYPE")
                    .HasDefaultValueSql("'''NOT_USED'''");

                entity.Property(e => e.CamaFaceiEnabled).HasColumnName("CAMA_FACEI_ENABLED");

                entity.Property(e => e.CamaFacevEnabled).HasColumnName("CAMA_FACEV_ENABLED");

                entity.Property(e => e.CamaLpr)
                    .HasColumnName("CAMA_LPR")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CamaParam1)
                    .HasMaxLength(1000)
                    .HasColumnName("CAMA_PARAM1")
                    .HasDefaultValueSql("''''''");

                entity.Property(e => e.CamaParam2)
                    .HasMaxLength(1000)
                    .HasColumnName("CAMA_PARAM2")
                    .HasDefaultValueSql("''''''");

                entity.Property(e => e.CamaParam3)
                    .HasMaxLength(100)
                    .HasColumnName("CAMA_PARAM3")
                    .HasDefaultValueSql("''''''");

                entity.Property(e => e.CamaParam4)
                    .HasMaxLength(100)
                    .HasColumnName("CAMA_PARAM4")
                    .HasDefaultValueSql("''''''");

                entity.Property(e => e.CamaServerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CAMA_SERVER_ID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CamaThermAlert)
                    .HasColumnType("int(11)")
                    .HasColumnName("CAMA_THERM_ALERT");

                entity.Property(e => e.CamaThermEnabled).HasColumnName("CAMA_THERM_ENABLED");

                entity.Property(e => e.CamaThermWarn)
                    .HasColumnType("int(11)")
                    .HasColumnName("CAMA_THERM_WARN");

                entity.Property(e => e.CambFaceiEnabled).HasColumnName("CAMB_FACEI_ENABLED");

                entity.Property(e => e.CambFacevEnabled).HasColumnName("CAMB_FACEV_ENABLED");

                entity.Property(e => e.CambLpr)
                    .HasColumnName("CAMB_LPR")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CambParam1)
                    .HasMaxLength(1000)
                    .HasColumnName("CAMB_PARAM1")
                    .HasDefaultValueSql("''''''");

                entity.Property(e => e.CambParam2)
                    .HasMaxLength(1000)
                    .HasColumnName("CAMB_PARAM2")
                    .HasDefaultValueSql("''''''");

                entity.Property(e => e.CambParam3)
                    .HasMaxLength(100)
                    .HasColumnName("CAMB_PARAM3")
                    .HasDefaultValueSql("''''''");

                entity.Property(e => e.CambParam4)
                    .HasMaxLength(100)
                    .HasColumnName("CAMB_PARAM4")
                    .HasDefaultValueSql("''''''");

                entity.Property(e => e.CambServerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CAMB_SERVER_ID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CambThermAlert)
                    .HasColumnType("int(11)")
                    .HasColumnName("CAMB_THERM_ALERT");

                entity.Property(e => e.CambThermEnabled).HasColumnName("CAMB_THERM_ENABLED");

                entity.Property(e => e.CambThermWarn)
                    .HasColumnType("int(11)")
                    .HasColumnName("CAMB_THERM_WARN");

                entity.Property(e => e.Controlsperimeter)
                    .HasColumnName("CONTROLSPERIMETER")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Disabled)
                    .HasColumnName("DISABLED")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Extid)
                    .HasMaxLength(128)
                    .HasColumnName("EXTID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Extsourceid)
                    .HasColumnType("int(11)")
                    .HasColumnName("EXTSOURCEID");

                entity.Property(e => e.Gatesm)
                    .HasColumnType("int(11)")
                    .HasColumnName("GATESM")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.GuestCloseonexit)
                    .HasColumnName("GUEST_CLOSEONEXIT")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Hwconf)
                    .HasColumnType("enum('UNKNOWN','TURNSTILE','DOOR','GATE','REG')")
                    .HasColumnName("HWCONF")
                    .HasDefaultValueSql("'''UNKNOWN'''");

                entity.Property(e => e.Linkparam1)
                    .HasMaxLength(100)
                    .HasColumnName("LINKPARAM1")
                    .HasDefaultValueSql("'''0'''");

                entity.Property(e => e.Linkparam2)
                    .HasMaxLength(100)
                    .HasColumnName("LINKPARAM2")
                    .HasDefaultValueSql("'''0'''");

                entity.Property(e => e.Linkparam3)
                    .HasMaxLength(100)
                    .HasColumnName("LINKPARAM3")
                    .HasDefaultValueSql("''''''");

                entity.Property(e => e.Linkparam4)
                    .HasMaxLength(100)
                    .HasColumnName("LINKPARAM4")
                    .HasDefaultValueSql("''''''");

                entity.Property(e => e.Linkparam5)
                    .HasMaxLength(100)
                    .HasColumnName("LINKPARAM5")
                    .HasDefaultValueSql("''''''");

                entity.Property(e => e.Linktype)
                    .HasMaxLength(32)
                    .HasColumnName("LINKTYPE")
                    .HasDefaultValueSql("'''FT'''");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("NAME")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NfcExptimeCheck)
                    .HasColumnType("int(11)")
                    .HasColumnName("NFC_EXPTIME_CHECK");

                entity.Property(e => e.NfcSanctionTime)
                    .HasColumnType("int(11)")
                    .HasColumnName("NFC_SANCTION_TIME")
                    .HasDefaultValueSql("'3000'");

                entity.Property(e => e.OrderIdx)
                    .HasColumnType("int(11)")
                    .HasColumnName("ORDER_IDX")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PARENT_ID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Pinmagica)
                    .HasColumnType("enum('OFF','ON')")
                    .HasColumnName("PINMAGICA")
                    .HasDefaultValueSql("'''OFF'''");

                entity.Property(e => e.Pinmagicb)
                    .HasColumnType("enum('OFF','ON')")
                    .HasColumnName("PINMAGICB")
                    .HasDefaultValueSql("'''OFF'''");

                entity.Property(e => e.Sms)
                    .HasColumnName("SMS")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.TimezoneId)
                    .HasColumnType("int(11)")
                    .HasColumnName("TIMEZONE_ID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TrueipLasteventId)
                    .HasColumnType("int(11)")
                    .HasColumnName("TRUEIP_LASTEVENT_ID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Type)
                    .HasColumnType("enum('DEVICE','GROUP')")
                    .HasColumnName("TYPE")
                    .HasDefaultValueSql("'''DEVICE'''");

                entity.Property(e => e.Zonea)
                    .HasColumnType("int(11)")
                    .HasColumnName("ZONEA")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Zoneb)
                    .HasColumnType("int(11)")
                    .HasColumnName("ZONEB")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Devrulebinding>(entity =>
            {
                entity.HasKey(e => new { e.DevId, e.RuleId })
                    .HasName("PRIMARY");

                entity.ToTable("devrulebindings");

                entity.HasIndex(e => e.DevId, "DEV_ID");

                entity.HasIndex(e => e.RuleId, "RULE_ID");

                entity.Property(e => e.DevId)
                    .HasColumnType("int(11)")
                    .HasColumnName("DEV_ID");

                entity.Property(e => e.RuleId)
                    .HasColumnType("int(11)")
                    .HasColumnName("RULE_ID");
            });

            modelBuilder.Entity<Personal>(entity =>
            {
                entity.ToTable("personal");

                entity.HasIndex(e => e.Codekey, "CODEKEY");

                entity.HasIndex(e => e.Extid, "EXTID");

                entity.HasIndex(e => e.Id, "ID");

                entity.HasIndex(e => e.ParentId, "PARENT_ID");

                entity.HasIndex(e => e.Status, "STATUS");

                entity.HasIndex(e => e.UserEnabled, "USER_ENABLED");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.AdDomainId)
                    .HasColumnType("int(11)")
                    .HasColumnName("AD_DOMAIN_ID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AdEnabled)
                    .HasColumnName("AD_ENABLED")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AdSyncPending)
                    .HasColumnType("int(11)")
                    .HasColumnName("AD_SYNC_PENDING")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AdUserDn)
                    .HasMaxLength(4000)
                    .HasColumnName("AD_USER_DN")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ApbOn)
                    .HasColumnName("APB_ON")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.AplExptime)
                    .HasColumnType("datetime")
                    .HasColumnName("APL_EXPTIME")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AplOn)
                    .HasColumnName("APL_ON")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Badge)
                    .HasColumnType("int(11)")
                    .HasColumnName("BADGE")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Badgeb)
                    .HasColumnType("int(11)")
                    .HasColumnName("BADGEB")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Boolparam1)
                    .HasColumnName("BOOLPARAM1")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Boolparam2)
                    .HasColumnName("BOOLPARAM2")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Boolparam3)
                    .HasColumnName("BOOLPARAM3")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Boolparam4)
                    .HasColumnName("BOOLPARAM4")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Codekey)
                    .HasMaxLength(8)
                    .HasColumnName("CODEKEY")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CodekeyDesc)
                    .HasMaxLength(255)
                    .HasColumnName("CODEKEY_DESC")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CodekeyDispFormat)
                    .HasMaxLength(32)
                    .HasColumnName("CODEKEY_DISP_FORMAT")
                    .HasDefaultValueSql("'''W26'''");

                entity.Property(e => e.Codekeytime)
                    .HasColumnType("datetime")
                    .HasColumnName("CODEKEYTIME")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Createdtime)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDTIME")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DeploymentId)
                    .HasMaxLength(255)
                    .HasColumnName("DEPLOYMENT_ID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Description)
                    .HasColumnType("mediumtext")
                    .HasColumnName("DESCRIPTION")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Email)
                    .HasMaxLength(1000)
                    .HasColumnName("EMAIL")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EmailSubject)
                    .HasMaxLength(1000)
                    .HasColumnName("EMAIL_SUBJECT")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EmpType)
                    .HasColumnType("enum('EMP','GUEST','AUTO_PERSONAL','AUTO_OFFICIAL')")
                    .HasColumnName("EMP_TYPE")
                    .HasDefaultValueSql("'''EMP'''");

                entity.Property(e => e.Exptime)
                    .HasColumnType("datetime")
                    .HasColumnName("EXPTIME")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Extid)
                    .HasMaxLength(128)
                    .HasColumnName("EXTID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Extsourceid)
                    .HasColumnType("int(11)")
                    .HasColumnName("EXTSOURCEID");

                entity.Property(e => e.Firedtime)
                    .HasColumnType("datetime")
                    .HasColumnName("FIREDTIME")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.GuestId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("GUEST_ID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdleLastntfy)
                    .HasColumnType("datetime")
                    .HasColumnName("IDLE_LASTNTFY")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LastlprAp)
                    .HasColumnType("int(11)")
                    .HasColumnName("LASTLPR_AP")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.LastlprDir)
                    .HasColumnType("int(11)")
                    .HasColumnName("LASTLPR_DIR")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.LastlprTime)
                    .HasColumnType("datetime")
                    .HasColumnName("LASTLPR_TIME")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LastpassAp)
                    .HasColumnType("int(11)")
                    .HasColumnName("LASTPASS_AP")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Locationact)
                    .HasColumnType("datetime")
                    .HasColumnName("LOCATIONACT")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Locationzone)
                    .HasColumnType("int(11)")
                    .HasColumnName("LOCATIONZONE")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MfUid)
                    .HasMaxLength(10)
                    .HasColumnName("MF_UID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .HasColumnName("NAME")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NtfyEnddate)
                    .HasColumnType("date")
                    .HasColumnName("NTFY_ENDDATE")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NtfyGstapplEnabled)
                    .HasColumnName("NTFY_GSTAPPL_ENABLED")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NtfyGstapplText)
                    .HasMaxLength(1000)
                    .HasColumnName("NTFY_GSTAPPL_TEXT")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NtfyLastAp)
                    .HasColumnType("int(11)")
                    .HasColumnName("NTFY_LAST_AP")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NtfyLastDir)
                    .HasColumnType("int(11)")
                    .HasColumnName("NTFY_LAST_DIR")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NtfyLastSent)
                    .HasColumnName("NTFY_LAST_SENT")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.NtfyLastTime)
                    .HasColumnType("datetime")
                    .HasColumnName("NTFY_LAST_TIME")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NtfyPassEnabled)
                    .HasColumnName("NTFY_PASS_ENABLED")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NtfyPassText)
                    .HasMaxLength(1000)
                    .HasColumnName("NTFY_PASS_TEXT")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NtfyPayDecEnabled)
                    .HasColumnName("NTFY_PAY_DEC_ENABLED")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NtfyPayDecText)
                    .HasMaxLength(1000)
                    .HasColumnName("NTFY_PAY_DEC_TEXT")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NtfyPayDecThr)
                    .HasColumnName("NTFY_PAY_DEC_THR")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NtfyPayEnabled)
                    .HasColumnName("NTFY_PAY_ENABLED")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NtfyPayText)
                    .HasMaxLength(1000)
                    .HasColumnName("NTFY_PAY_TEXT")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NtfyStartdate)
                    .HasColumnType("date")
                    .HasColumnName("NTFY_STARTDATE")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NtfyType)
                    .HasMaxLength(32)
                    .HasColumnName("NTFY_TYPE")
                    .HasDefaultValueSql("'''SMS'''");

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PARENT_ID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Pos)
                    .HasMaxLength(255)
                    .HasColumnName("POS")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Sideparam0)
                    .HasColumnType("mediumtext")
                    .HasColumnName("SIDEPARAM0")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Sideparam1)
                    .HasColumnType("mediumtext")
                    .HasColumnName("SIDEPARAM1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Sideparam2)
                    .HasColumnType("mediumtext")
                    .HasColumnName("SIDEPARAM2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Sideparam3)
                    .HasColumnType("mediumtext")
                    .HasColumnName("SIDEPARAM3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Sideparam4)
                    .HasColumnType("mediumtext")
                    .HasColumnName("SIDEPARAM4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Sideparam5)
                    .HasColumnType("mediumtext")
                    .HasColumnName("SIDEPARAM5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SmsTargetnumber)
                    .HasMaxLength(1000)
                    .HasColumnName("SMS_TARGETNUMBER")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SoaaKeyStatus)
                    .HasColumnType("enum('UPDATE_REQUIRED','UPDATE_NOT_REQUIRED')")
                    .HasColumnName("SOAA_KEY_STATUS")
                    .HasDefaultValueSql("'''UPDATE_REQUIRED'''");

                entity.Property(e => e.SoaaUid)
                    .HasMaxLength(255)
                    .HasColumnName("SOAA_UID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Status)
                    .HasColumnType("enum('AVAILABLE','FIRED','INTERNAL')")
                    .HasColumnName("STATUS")
                    .HasDefaultValueSql("'''AVAILABLE'''");

                entity.Property(e => e.Tabid)
                    .HasColumnType("mediumtext")
                    .HasColumnName("TABID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TelegramChatid)
                    .HasMaxLength(1000)
                    .HasColumnName("TELEGRAM_CHATID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Type)
                    .HasColumnType("enum('DEP','EMP')")
                    .HasColumnName("TYPE")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserAlmrestriction)
                    .HasColumnName("USER_ALMRESTRICTION")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserApplsEditAll)
                    .HasColumnName("USER_APPLS_EDIT_ALL")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserApplsEditCurrent)
                    .HasColumnName("USER_APPLS_EDIT_CURRENT")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserApplsSeeAll)
                    .HasColumnName("USER_APPLS_SEE_ALL")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserApplsSeeCurrent)
                    .HasColumnName("USER_APPLS_SEE_CURRENT")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserAprestriction)
                    .HasColumnName("USER_APRESTRICTION")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserChownpass)
                    .HasColumnName("USER_CHOWNPASS")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserCntlmodules)
                    .HasColumnName("USER_CNTLMODULES")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserDepsrestriction)
                    .HasColumnName("USER_DEPSRESTRICTION")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserEnabled)
                    .HasColumnName("USER_ENABLED")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserExitpassword)
                    .HasMaxLength(40)
                    .HasColumnName("USER_EXITPASSWORD")
                    .HasDefaultValueSql("''''''");

                entity.Property(e => e.UserExitpasswordUsed)
                    .HasColumnName("USER_EXITPASSWORD_USED")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserFloorsrestriction)
                    .HasColumnName("USER_FLOORSRESTRICTION")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserGstapplCreate)
                    .HasColumnName("USER_GSTAPPL_CREATE")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserGstapplModify)
                    .HasColumnName("USER_GSTAPPL_MODIFY")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserGstapplRange)
                    .HasColumnType("enum('ALL','OWN')")
                    .HasColumnName("USER_GSTAPPL_RANGE")
                    .HasDefaultValueSql("'''ALL'''");

                entity.Property(e => e.UserLocalsettings)
                    .HasColumnName("USER_LOCALSETTINGS")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserLogin)
                    .HasMaxLength(255)
                    .HasColumnName("USER_LOGIN")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserMonviewPolicy)
                    .HasColumnType("enum('FULL_ACCESS','RO_ACCESS','RESTRICTED_ACCESS')")
                    .HasColumnName("USER_MONVIEW_POLICY")
                    .HasDefaultValueSql("'''FULL_ACCESS'''");

                entity.Property(e => e.UserOif)
                    .HasColumnName("USER_OIF")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserPassword)
                    .HasColumnType("mediumtext")
                    .HasColumnName("USER_PASSWORD")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserReprestriction)
                    .HasColumnName("USER_REPRESTRICTION")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserRuledepseditingrestriction)
                    .HasColumnName("USER_RULEDEPSEDITINGRESTRICTION")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserRuledepsrestriction)
                    .HasColumnName("USER_RULEDEPSRESTRICTION")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserRuleseditingrestriction)
                    .HasColumnName("USER_RULESEDITINGRESTRICTION")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserRulesrestriction)
                    .HasColumnName("USER_RULESRESTRICTION")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserTAlarm)
                    .HasColumnName("USER_T_ALARM")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTAlarmCmd)
                    .HasColumnName("USER_T_ALARM_CMD")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTAlarmEditconf)
                    .HasColumnName("USER_T_ALARM_EDITCONF")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTArchive)
                    .HasColumnName("USER_T_ARCHIVE")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTAutopark)
                    .HasColumnName("USER_T_AUTOPARK")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTCardlogin)
                    .HasColumnName("USER_T_CARDLOGIN")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTEditMolockersSettings)
                    .HasColumnName("USER_T_EDIT_MOLOCKERS_SETTINGS")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTEditplans)
                    .HasColumnName("USER_T_EDITPLANS")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTEvents)
                    .HasColumnName("USER_T_EVENTS")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTFace)
                    .HasColumnName("USER_T_FACE")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTGuests)
                    .HasColumnName("USER_T_GUESTS")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTGuestsDeletepd)
                    .HasColumnName("USER_T_GUESTS_DELETEPD")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTGuestsEdit)
                    .HasColumnName("USER_T_GUESTS_EDIT")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTHw)
                    .HasColumnName("USER_T_HW")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTHwAdd)
                    .HasColumnName("USER_T_HW_ADD")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTHwDel)
                    .HasColumnName("USER_T_HW_DEL")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTHwEdit)
                    .HasColumnName("USER_T_HW_EDIT")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTHwMode)
                    .HasColumnName("USER_T_HW_MODE")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTKeyguard)
                    .HasColumnName("USER_T_KEYGUARD")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTMolockers)
                    .HasColumnName("USER_T_MOLOCKERS")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTMon)
                    .HasColumnName("USER_T_MON")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTMonAllowanonpass)
                    .HasColumnName("USER_T_MON_ALLOWANONPASS")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTMonAllowauthpass)
                    .HasColumnName("USER_T_MON_ALLOWAUTHPASS")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTMonAllowpass)
                    .HasColumnName("USER_T_MON_ALLOWPASS")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTMonCntlalm)
                    .HasColumnName("USER_T_MON_CNTLALM")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTMonCntlap)
                    .HasColumnName("USER_T_MON_CNTLAP")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTNfcterminal)
                    .HasColumnName("USER_T_NFCTERMINAL")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserTNfcterminalRegAuto)
                    .HasColumnName("USER_T_NFCTERMINAL_REG_AUTO")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserTNfcterminalRegIn)
                    .HasColumnName("USER_T_NFCTERMINAL_REG_IN")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserTNfcterminalRegOut)
                    .HasColumnName("USER_T_NFCTERMINAL_REG_OUT")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserTNfcterminalSanctionsPossibility)
                    .HasColumnName("USER_T_NFCTERMINAL_SANCTIONS_POSSIBILITY")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserTOd)
                    .HasColumnName("USER_T_OD")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTParkingpay)
                    .HasColumnName("USER_T_PARKINGPAY")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTParkingtariffs)
                    .HasColumnName("USER_T_PARKINGTARIFFS")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTPayacc)
                    .HasColumnName("USER_T_PAYACC")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTPayaccmng)
                    .HasColumnName("USER_T_PAYACCMNG")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserTPaydesk)
                    .HasColumnName("USER_T_PAYDESK")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTPaydeskAccinc)
                    .HasColumnName("USER_T_PAYDESK_ACCINC")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTPaydeskFixoverlimit)
                    .HasColumnName("USER_T_PAYDESK_FIXOVERLIMIT")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTPaydeskManualselect)
                    .HasColumnName("USER_T_PAYDESK_MANUALSELECT")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserTPaydesklite)
                    .HasColumnName("USER_T_PAYDESKLITE")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserTPaydeskliteManualsel)
                    .HasColumnName("USER_T_PAYDESKLITE_MANUALSEL")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserTPayinc)
                    .HasColumnName("USER_T_PAYINC")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTPaymenu)
                    .HasColumnName("USER_T_PAYMENU")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTPersonal)
                    .HasColumnName("USER_T_PERSONAL")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTPersonalAcc)
                    .HasColumnName("USER_T_PERSONAL_ACC")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTPersonalAccess)
                    .HasColumnName("USER_T_PERSONAL_ACCESS")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTPersonalAd)
                    .HasColumnName("USER_T_PERSONAL_AD")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTPersonalAdd)
                    .HasColumnName("USER_T_PERSONAL_ADD")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTPersonalBadges)
                    .HasColumnName("USER_T_PERSONAL_BADGES")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTPersonalDel)
                    .HasColumnName("USER_T_PERSONAL_DEL")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTPersonalEdit)
                    .HasColumnName("USER_T_PERSONAL_EDIT")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTPersonalPos)
                    .HasColumnName("USER_T_PERSONAL_POS")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTPersonalSetzone)
                    .HasColumnName("USER_T_PERSONAL_SETZONE")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTPersonalSms)
                    .HasColumnName("USER_T_PERSONAL_SMS")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTPlans)
                    .HasColumnName("USER_T_PLANS")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTReports)
                    .HasColumnName("USER_T_REPORTS")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTReportsDrags)
                    .HasColumnName("USER_T_REPORTS_DRAGS")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTReportsExplosives)
                    .HasColumnName("USER_T_REPORTS_EXPLOSIVES")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTRules)
                    .HasColumnName("USER_T_RULES")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTSspilogin)
                    .HasColumnName("USER_T_SSPILOGIN")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTUnlockMolockers)
                    .HasColumnName("USER_T_UNLOCK_MOLOCKERS")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserTUsers)
                    .HasColumnName("USER_T_USERS")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserWritedb)
                    .HasColumnName("USER_WRITEDB")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<PersonalKey>(entity =>
            {
                entity.ToTable("personal_keys");

                entity.HasIndex(e => e.Codekey, "CODEKEY");

                entity.HasIndex(e => e.EmpId, "EMP_ID");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.Codekey)
                    .HasMaxLength(8)
                    .HasColumnName("CODEKEY")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CodekeyDesc)
                    .HasMaxLength(255)
                    .HasColumnName("CODEKEY_DESC")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CodekeyDispFormat)
                    .HasMaxLength(32)
                    .HasColumnName("CODEKEY_DISP_FORMAT")
                    .HasDefaultValueSql("'''W26'''");

                entity.Property(e => e.Codekeytime)
                    .HasColumnType("datetime")
                    .HasColumnName("CODEKEYTIME")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EmpId)
                    .HasColumnType("int(11)")
                    .HasColumnName("EMP_ID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Exptime)
                    .HasColumnType("datetime")
                    .HasColumnName("EXPTIME")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MfUid)
                    .HasMaxLength(10)
                    .HasColumnName("MF_UID")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<PositionsList>(entity =>
            {
                entity.ToTable("positions_list");

                entity.HasIndex(e => e.Position, "POSITION")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.Position)
                    .HasColumnName("POSITION")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Rulebinding>(entity =>
            {
                entity.HasKey(e => new { e.PersonalId, e.RuleId })
                    .HasName("PRIMARY");

                entity.ToTable("rulebindings");

                entity.HasIndex(e => e.PersonalId, "PERSONAL_ID");

                entity.HasIndex(e => e.RuleId, "RULE_ID");

                entity.Property(e => e.PersonalId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PERSONAL_ID");

                entity.Property(e => e.RuleId)
                    .HasColumnType("int(11)")
                    .HasColumnName("RULE_ID");
            });

            modelBuilder.Entity<Ruledep>(entity =>
            {
                entity.ToTable("ruledeps");

                entity.HasIndex(e => e.Id, "ID");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("NAME")
                    .HasDefaultValueSql("'NULL'")
                    .IsFixedLength();

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PARENT_ID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Poweridx)
                    .HasColumnType("int(11)")
                    .HasColumnName("POWERIDX")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Sideparamtype>(entity =>
            {
                entity.ToTable("sideparamtypes");

                entity.HasIndex(e => e.ParamIdx, "PARAM_IDX");

                entity.HasIndex(e => e.TableId, "TABLE_ID");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("NAME")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OrderIdx)
                    .HasColumnType("int(11)")
                    .HasColumnName("ORDER_IDX")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ParamIdx)
                    .HasColumnType("int(11)")
                    .HasColumnName("PARAM_IDX")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Params)
                    .HasColumnType("mediumtext")
                    .HasColumnName("PARAMS")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PersonalCarRelated)
                    .HasColumnName("PERSONAL_CAR_RELATED")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PersonalEmpRelated)
                    .HasColumnName("PERSONAL_EMP_RELATED")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PersonalGuestRelated)
                    .HasColumnName("PERSONAL_GUEST_RELATED")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Readonly)
                    .HasColumnName("READONLY")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TableId)
                    .HasColumnType("int(11)")
                    .HasColumnName("TABLE_ID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Type)
                    .HasColumnType("enum('STRING','BOOL','ENUM','TIME_HHMM','DATE','REF_TO_DEP','DATETIME','REF_TO_EMP')")
                    .HasColumnName("TYPE")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Sideparamvalue>(entity =>
            {
                entity.HasKey(e => new { e.TableId, e.ObjId, e.ParamIdx })
                    .HasName("PRIMARY");

                entity.ToTable("sideparamvalues");

                entity.HasIndex(e => new { e.TableId, e.ObjId }, "TABLE_ID");

                entity.Property(e => e.TableId)
                    .HasColumnType("int(11)")
                    .HasColumnName("TABLE_ID");

                entity.Property(e => e.ObjId)
                    .HasColumnType("int(11)")
                    .HasColumnName("OBJ_ID");

                entity.Property(e => e.ParamIdx)
                    .HasColumnType("int(11)")
                    .HasColumnName("PARAM_IDX");

                entity.Property(e => e.Value)
                    .HasColumnType("mediumtext")
                    .HasColumnName("VALUE")
                    .HasDefaultValueSql("'NULL'");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
