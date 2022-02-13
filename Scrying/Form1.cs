using System;
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
        private const string APP_NAME = "SCRYING";
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        // добавляем асинхронность
        private async void bPredict_Click(object sender, EventArgs e)
        {
            // цикл работает в отдельном потоке
            // ожидает выполнения кода ниже чтобы пойти дальше
            bPredict.Enabled = false; // выключаем кнопку, от двойных нажатий
            await Task.Run(() =>
             {
                 for (int i = 0; i <= 100; i++)
                 {
                     // с помощью делегатов через метод Invoke который работает с делегатом, лямдой помещаем код
                     this.Invoke(new Action(() =>
                     {
                         //progressBar1.Value = i;
                         UpdateProgessBar(i);
                         Text = $"{i}%";
                     }));

                     Thread.Sleep(20);
                 }
             }
            );

            // логика вывода предсказания
            MessageBox.Show("Prediction");

            progressBar1.Value = 0;
            Text = APP_NAME;
            bPredict.Enabled = true;


        }

        // убирает баг с появлением вывода раньше чем заканчивается бар
        private void UpdateProgessBar(int i)
        {
            if (i == progressBar1.Maximum)
            {
                progressBar1.Maximum = i + 1;
                progressBar1.Value = i + 1;
                progressBar1.Maximum = i;
            }
            else
            {
                progressBar1.Value = i + 1;
            }
            progressBar1.Value = i;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = APP_NAME;
        }
    }
}
