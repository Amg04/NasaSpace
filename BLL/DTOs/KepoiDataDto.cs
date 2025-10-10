using DAL.Models;

namespace BLL.DTOs
{
    public class KepoiDataDto
    {
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

        #region Mapping

        public static explicit operator KepoiDataDto(KepoiData obj)
        {
            return new KepoiDataDto
            {
                kepid = obj.kepid,
                kepoi_name = obj.kepoi_name,
                koi_score = obj.koi_score,
                koi_period = obj.koi_period,
                koi_duration = obj.koi_duration,
                koi_depth = obj.koi_depth,
                koi_time0bk = obj.koi_time0bk,
                koi_prad = obj.koi_prad,
                koi_ror = obj.koi_ror,
                koi_dor = obj.koi_dor,
                koi_impact = obj.koi_impact,
                koi_incl = obj.koi_incl,
                koi_srad = obj.koi_srad,
                koi_smass = obj.koi_smass,
                koi_steff = obj.koi_steff,
                koi_slogg = obj.koi_slogg,
                koi_smet = obj.koi_smet,
                koi_kepmag = obj.koi_kepmag,
                koi_fpflag_nt = obj.koi_fpflag_nt,
                koi_fpflag_ss = obj.koi_fpflag_ss,
                koi_fpflag_co = obj.koi_fpflag_co,
                koi_fpflag_ec = obj.koi_fpflag_ec,
                koi_period_err1 = obj.koi_period_err1,
                koi_period_err2 = obj.koi_period_err2,
                koi_duration_err1 = obj.koi_duration_err1,
                koi_duration_err2 = obj.koi_duration_err2,
                koi_depth_err1 = obj.koi_depth_err1,
                koi_depth_err2 = obj.koi_depth_err2,
                koi_prad_err1 = obj.koi_prad_err1,
                koi_prad_err2 = obj.koi_prad_err2,
                koi_steff_err1  = obj.koi_steff_err1,
                koi_steff_err2 = obj.koi_steff_err2
            };
        }

        public static explicit operator KepoiData(KepoiDataDto dto)
        {
            return new KepoiData
            {
                kepid = dto.kepid,
                kepoi_name = dto.kepoi_name,
                koi_score = dto.koi_score,
                koi_period = dto.koi_period,
                koi_duration = dto.koi_duration,
                koi_depth = dto.koi_depth,
                koi_time0bk = dto.koi_time0bk,
                koi_prad = dto.koi_prad,
                koi_ror = dto.koi_ror,
                koi_dor = dto.koi_dor,
                koi_impact = dto.koi_impact,
                koi_incl = dto.koi_incl,
                koi_srad = dto.koi_srad,
                koi_smass = dto.koi_smass,
                koi_steff = dto.koi_steff,
                koi_slogg = dto.koi_slogg,
                koi_smet = dto.koi_smet,
                koi_kepmag = dto.koi_kepmag,
                koi_fpflag_nt = dto.koi_fpflag_nt,
                koi_fpflag_ss = dto.koi_fpflag_ss,
                koi_fpflag_co = dto.koi_fpflag_co,
                koi_fpflag_ec = dto.koi_fpflag_ec,
                koi_period_err1 = dto.koi_period_err1,
                koi_period_err2 = dto.koi_period_err2,
                koi_duration_err1 = dto.koi_duration_err1,
                koi_duration_err2 = dto.koi_duration_err2,
                koi_depth_err1 = dto.koi_depth_err1,
                koi_depth_err2 = dto.koi_depth_err2,
                koi_prad_err1 = dto.koi_prad_err1,
                koi_prad_err2 = dto.koi_prad_err2,
                koi_steff_err1 = dto.koi_steff_err1,
                koi_steff_err2 = dto.koi_steff_err2
            };
        }

        #endregion
    }
}
