using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MatrixCalc
{
    public static class DataGridViewHandler
    {
        public static void Fill(this DataGridView View)
        {
            foreach(DataGridViewRow row in View.Rows)
            {
                row.Height = (View.Size.Height / View.Rows.Count) - 1;
            }
            View.Font = new System.Drawing.Font(View.Font.FontFamily, 0.11f * View.Size.Height / (View.Rows.Count == 0 ? 1 : View.Rows.Count), FontStyle.Regular);
        }

        public static void Init(this DataGridView View, int defR = 3, int defC = 3)
        {
            for (int i = 0; i < defC; i++)
            {
                View.Columns.Add("","");
            }
            View.Rows.Add(defR);
            for(int x = 0; x < View.ColumnCount; x++)
            {
                for(int y = 0; y < View.RowCount; y++)
                {
                    View[x, y].Value = 0;
                }
            }
        }

        public static void ClearMatrix(this DataGridView View)
        {
            View.Rows.Clear();
            View.Columns.Clear();
        }
    }
}
