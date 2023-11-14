using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dapper.SQL
{
    public class DapperContextOptions:IOptions<DapperContextOptions>
    {
        public string ConnectionString { get; set; }

        DapperContextOptions IOptions<DapperContextOptions>.Value
        {
            get { return this; }
        }
    }
}
