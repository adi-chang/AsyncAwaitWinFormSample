using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwaitWinFormSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblInfo.Text = string.Empty;
        }

        private async void btnClickMe_Click(object sender, EventArgs e)
        {
            // this code will blocking ui code
            //lblInfo.Text = BigLongImportantMethod("Donal Duck");


            // this code will not blocking your ui code
            //Task.Factory.StartNew(() => BigLongImportantMethod("Mickey Mouse"))
            //    .ContinueWith(t => lblInfo.Text = t.Result, TaskScheduler.FromCurrentSynchronizationContext());

            // calling async void method [2]
            //CallingBigLongImportantMethodAsync("Sakura");
            //lblInfo.Text = "Waiting ...";

            btnClickMe.Enabled = false;
            lblInfo.Text = "Waiting ...";
            lblInfo.Text = await BigLongImportantMethodAsync("Naruto");
            btnClickMe.Enabled = true;

        }

        // [2]
        //private async void CallingBigLongImportantMethodAsync(string name)
        //{
        //    string result = await BigLongImportantMethodTask(name);
        //    lblInfo.Text = result;
        //}

        // [2]
        //private Task<string> BigLongImportantMethodTask(string name)
        //{
        //    return Task.Factory.StartNew(() => BigLongImportantMethod(name));
        //}

        public async Task<string> BigLongImportantMethodAsync(string name)
        {
            return await Task.Factory.StartNew(() => BigLongImportantMethod(name));
        }

        private string BigLongImportantMethod(string name)
        {
            Thread.Sleep(3000);
            return $"Hello, {name}";
        }


    }
}
