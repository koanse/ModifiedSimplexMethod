﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ModifiedSimplexMethod
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
            webBrowser1.DocumentText = Properties.Resources.Help;
        }
    }
}