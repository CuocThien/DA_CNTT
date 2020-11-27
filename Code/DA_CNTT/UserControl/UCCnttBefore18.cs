using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_CNTT
{
    public partial class UCCnttBefore18 : UserControl
    {
        public UCCnttBefore18()
        {
            InitializeComponent();
            this.dgv_Content.ColumnHeadersDefaultCellStyle.BackColor = Color.LemonChiffon;
            this.dgv_Content.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            this.dgv_Content.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Khaki;
            this.dgv_Content.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Red;
        }

    }
}
