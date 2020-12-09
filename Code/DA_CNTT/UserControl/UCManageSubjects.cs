﻿using System;
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
    public partial class UCManageSubjects : UserControl
    {
        private string Sub_id;
        public UCManageSubjects(string Subject_ID)

        {
            InitializeComponent();
            Sub_id = Subject_ID;
        }

        private void btn_Chapter_Click(object sender, EventArgs e)
        {
            UCChapters uCChapters = new UCChapters(pnl_container, Sub_id);
            cMain.loadUC(pnl_container, uCChapters);
        }

        private void btn_CourseGoals_Click(object sender, EventArgs e)
        {
            UCCourseGoals uCCourseGoals = new UCCourseGoals(pnl_container, Sub_id);
            cMain.loadUC(pnl_container, uCCourseGoals);
        }
    }
}
