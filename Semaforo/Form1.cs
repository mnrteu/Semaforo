using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semaforo
{
    public partial class Semáforo : Form
    {
        private int estado = 1;
        private bool semaforoLigado;
        public Semáforo()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            semaforoLigado = true;
            estado = 1;
            Tempo.Start();
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            pibSemaforo.Image = Properties.Resources.Erased;
            Tempo.Stop();
        }

        private void Tempo_Tick(object sender, EventArgs e)
        {
            switch (estado)
            {
                case 1:
                    pibSemaforo.Image = Properties.Resources.Green;
                    Tempo.Interval = 4000; // 4 segundos para verde
                    estado = 2;
                    break;
                case 2:
                    pibSemaforo.Image = Properties.Resources.Yellow;
                    Tempo.Interval = 4000; // 2 segundos para Yellow
                    estado = 3;
                    break;
                case 3:
                    pibSemaforo.Image = Properties.Resources.Red;
                    Tempo.Interval = 4000; // 5 segundos para Red
                    estado = 1;
                    break;

            }
        }
    }
}
