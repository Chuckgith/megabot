using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormConsole
{
    public static class DataGridHelper
    {
        public static object GetCell(DataGridViewCellCollection CellCollection, string HeaderText)
        {
            return CellCollection.Cast<DataGridViewCell>().First(c => c.OwningColumn.HeaderText == HeaderText).Value;
        }

        public static void SetCell(this DataGridViewCellCollection CellCollection, string HeaderText, object value)
        {
            CellCollection.Cast<DataGridViewCell>().First(c => c.OwningColumn.HeaderText == HeaderText).Value = value;
        }
    }
}