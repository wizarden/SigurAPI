using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SigurAPI.Models
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Device> Devices { get; set; } = null!;
        public virtual DbSet<Log> Logs { get; set; } = null!;
        public virtual DbSet<Personal> Personals { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("server=192.168.1.164;Port=3305;user=root;password=392576;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Device>(entity =>
            {
                entity.ToTable("devices", "tc-db-main");

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

            modelBuilder.Entity<Log>(entity =>
            {
                entity.ToTable("logs", "tc-db-log");

                entity.HasIndex(e => e.Devhint, "DEVHINT");

                entity.HasIndex(e => e.Emphint, "EMPHINT");

                entity.HasIndex(e => e.Logtime, "LOGTIME");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.Area)
                    .HasColumnType("int(11)")
                    .HasColumnName("AREA")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Devhint)
                    .HasColumnType("int(11)")
                    .HasColumnName("DEVHINT")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Emphint)
                    .HasColumnType("int(11)")
                    .HasColumnName("EMPHINT")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Framets)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("FRAMETS");

                entity.Property(e => e.Logdata)
                    .HasColumnType("tinyblob")
                    .HasColumnName("LOGDATA")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Logtime)
                    .HasColumnType("datetime")
                    .HasColumnName("LOGTIME")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Personal>(entity =>
            {
                entity.ToTable("personal", "tc-db-main");

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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
