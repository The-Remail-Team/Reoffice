﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace Reoffice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InitBrowser();
        }

        public ChromiumWebBrowser browser;
        public void InitBrowser()
        {
            Cef.Initialize(new CefSettings());
            browser = new ChromiumWebBrowser("https://sites.google.com/view/reofficeservicepicker/home");
            this.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }

    }
}
