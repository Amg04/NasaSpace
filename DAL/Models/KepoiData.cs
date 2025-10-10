namespace DAL.Models
{
    public class KepoiData
    {
        public Guid Id { get; set; }
        public long kepid { get; set; }
        public string? kepoi_name { get; set; }
        public double koi_score { get; set; }
        public double koi_period { get; set; }
        public double koi_duration { get; set; }
        public double koi_depth { get; set; }
        public double koi_time0bk { get; set; }
        public double koi_prad { get; set; }
        public double koi_ror { get; set; }
        public double koi_dor { get; set; }
        public double koi_impact { get; set; }
        public double koi_incl { get; set; }
        public double koi_srad { get; set; }
        public double koi_smass { get; set; }
        public double koi_steff { get; set; }
        public double koi_slogg { get; set; }
        public double koi_smet { get; set; }
        public double koi_kepmag { get; set; }
        public int koi_fpflag_nt { get; set; }
        public int koi_fpflag_ss { get; set; }
        public int koi_fpflag_co { get; set; }
        public int koi_fpflag_ec { get; set; }
        public double koi_period_err1 { get; set; }
        public double koi_period_err2 { get; set; }
        public double koi_duration_err1 { get; set; }
        public double koi_duration_err2 { get; set; }
        public double koi_depth_err1 { get; set; }
        public double koi_depth_err2 { get; set; }
        public double koi_prad_err1 { get; set; }
        public double koi_prad_err2 { get; set; }
        public double koi_steff_err1 { get; set; }
        public double koi_steff_err2 { get; set; }
        public string? FileHash { get; set; } 
        public string? AppUserId { get; set; }
        public AppUser AppUser { get; set; }    
    }

}
