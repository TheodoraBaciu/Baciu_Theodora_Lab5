using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Baciu__Lab5.PhoneNumbersDataSetTableAdapters
{
    public partial class PhoneNumbersTableAdapter
    {
        private bool ClearBeforeFill;
        private SqlConnection Connection;

        public PhoneNumbersTableAdapter(String connectionString)
        {
            this.ClearBeforeFill = true;
            this.Connection = new
           System.Data.SqlClient.SqlConnection(connectionString);
        }
    }
}
