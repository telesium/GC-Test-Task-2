using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SetupGrid();
        }

        private void SetupGrid()
        {
            c1TrueDBGrid1.DataSource = GetDataTable();
            
            c1TrueDBGrid1.Splits[0].DisplayColumns[0].DataColumn.FilterOperator = "IN";
            c1TrueDBGrid1.Columns[0].FilterDropdown = true;
        }

        private DataTable GetDataTable()
        {
            DataTable dt = new DataTable();

            DataColumn dc = new DataColumn("Differencia", typeof(decimal));
            dt.Columns.Add(dc);

            decimal dDiferencia = 0.00m;
            for (var i = 0; i < 1000; i++)
            {
                dt.Rows.Add(dDiferencia);
                dDiferencia += 0.01m;
            }

            return dt;
        }
    }
}
