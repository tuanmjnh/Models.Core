namespace Models.Core
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    public partial class Paging
    {
        public int offset { get; set; }
        public string limmit { get; set; }
        public string order { get; set; }
    }
}