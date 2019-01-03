namespace Models.Core {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("contract_customer_thuebao")]
    public partial class ContractCustomerThueBao {
        public long hdtb_id { get; set; }
        public long? hdtb_cha_id { get; set; }
        public long thuebao_id { get; set; }
        public long? thuebao_cha_id { get; set; }
        public long hdkh_id { get; set; }
        public long hdtt_id { get; set; }
        public string ma_tb { get; set; }
        public string ten_tb { get; set; }
        public string diachi_tb { get; set; }
        public string diachi_ld { get; set; }
        public int kieuld_id { get; set; }
        public int tthd_id { get; set; }
        public int loaitb_id { get; set; }
        public int doituong_id { get; set; }
        public int dichvuvt_id { get; set; }
        public int donvi_id { get; set; }
    }
}