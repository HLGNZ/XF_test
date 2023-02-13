using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace XF_144310_AhmadAlhrthi
{
    public class NumberCode
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Number { get; set; }
        public string Code { get; set; }
    }
}
