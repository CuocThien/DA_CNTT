using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DA_CNTT.Controllers;

namespace DA_CNTT
{
    public partial class UCChapters : UserControl
    {
        public UCChapters(string sub_id)
        {
            InitializeComponent();
            this.dgv_Chapters.ColumnHeadersDefaultCellStyle.BackColor = Color.LemonChiffon;
            this.dgv_Chapters.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            this.dgv_Chapters.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Khaki;
            this.dgv_Chapters.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Red;
            var controller = new testController();
            
            var chapters = controller.loadchapters(sub_id).Chapter;
            foreach(var c in chapters)
            {
                var detail = c.Detail.ToList();
                string details="";
                foreach(var d in detail)
                {
                    details += d.ToString() + " \n ";
                }
                this.dgv_Chapters.Rows.Add(c.ID, c.Name, details);
            }    
        }
    }
}
