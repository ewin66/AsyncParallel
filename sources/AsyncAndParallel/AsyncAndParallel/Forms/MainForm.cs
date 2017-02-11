﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AsyncAndParallel.DownloadPDF;
using AsyncAndParallel.Forms;
using AsyncAndParallel.Forms.Threads;

namespace AsyncAndParallel
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowForm<F>() where F : Form, new()
        {
            using (F form = new F())
            {
                form.ShowDialog();
            }
        }

        private void btnJoinThread_Click(object sender, EventArgs e)
        {
            ShowForm<JoinThreadForm>();
        }

        private void btnAbortThreads_Click(object sender, EventArgs e)
        {
            ShowForm<AbortThreadForm>();
        }

        private void btnThreadCallback_Click(object sender, EventArgs e)
        {
            ShowForm<ThreadCallbackForm>();
        }

        private void btnUsingTasks_Click(object sender, EventArgs e)
        {
            ShowForm<UsingTasksForm>();
        }

        private void btnUsingTasksContinueWith_Click(object sender, EventArgs e)
        {
            ShowForm<UsingTasksContinueWithForm>();
        }
    }
}