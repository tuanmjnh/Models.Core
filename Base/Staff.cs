namespace Models.Core {
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("staff")]
    public partial class Staff {
        public Guid id { get; set; }

        public Guid? user_id { get; set; }

        [StringLength(255)]
        public string title { get; set; }
    }
}