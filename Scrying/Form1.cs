﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Scrying
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void bPredict_Click(object sender, EventArgs e)
        {
            // цикл работает в отдельном потоке
            Task.Run(() =>
             {
                 for (int i = 0; i < 100; i++)
                 {
                     // с помощью делегатов через метод Invoke который работает с делегатом, лямдой помещаем код
                     this.Invoke(new Action(() =>
                     {
                         progressBar1.Value = i;
                     }));

                     Thread.Sleep(20);
                 }
             }
            );

            // логика вывода предсказания
            MessageBox.Show("Prediction");

        }
    }
}
