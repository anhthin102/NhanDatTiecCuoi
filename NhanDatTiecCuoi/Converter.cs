using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhanDatTiecCuoi
{
    public class Converter
    {
        public Converter()
        {

        }
        public int StringToInt(TextBox textBox, ErrorProvider ep)
        {
            int _StringToInt = 0;
            try
            {
                _StringToInt = int.Parse(textBox.Text);
            }
            // Ngoại lệ ArgumentNullException xảy ra khi người dùng không nhập dữ liệu
            catch (Exception ex)
            {
                if (ex is ArgumentNullException)
                    ep.SetError(textBox, "Your string is null, " + ex.ToString());
                else if (ex is ArgumentNullException)
                    ep.SetError(textBox, "Your string is not in the correct format. , " + ex.ToString());
                else if (ex is OverflowException)
                    ep.SetError(textBox, "Your string represents a number less than MinValue or greater than MaxValue. , " + ex.ToString());
                else
                    ep.SetError(textBox, "Your string is invalid, " + ex.ToString());
            }
            return _StringToInt;
        }
        public DataTable AutoNumberedTable(DataTable SourceTable)

        {

            DataTable ResultTable = new DataTable();

            DataColumn AutoNumberColumn = new DataColumn();

            AutoNumberColumn.ColumnName = "STT";

            AutoNumberColumn.DataType = typeof(int);

            AutoNumberColumn.AutoIncrement = true;

            AutoNumberColumn.AutoIncrementSeed = 1;

            AutoNumberColumn.AutoIncrementStep = 1;

            ResultTable.Columns.Add(AutoNumberColumn);

            ResultTable.Merge(SourceTable);

            return ResultTable;

        }
        public DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }
    }
}
