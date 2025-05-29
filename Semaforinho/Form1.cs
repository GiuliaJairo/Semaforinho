using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semaforinho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private enum EstadoSemaforo { Verde, Amarelo, Vermelho, Apagado }

        private EstadoSemaforo estadoAtual = EstadoSemaforo.Apagado;

        private int tempo_verde = 30000;
        private int tempo_amarelo = 30000;
        private int tempo_vermelho = 30000;



        private void btnLigar_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Stop();
                btnLigar.Text = "Iniciar";
                pibFoto.Image = Properties.Resources.apagado;
                estadoAtual = EstadoSemaforo.Apagado;
            }
            else
            {
                estadoAtual = EstadoSemaforo.Vermelho;
                pibFoto.Image= Properties.Resources.vermelho;
                timer.Interval = tempo_vermelho;
                timer.Start();
                btnLigar.Text = "Parar";
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            switch (estadoAtual)
            {
                case EstadoSemaforo.Vermelho:
                    estadoAtual = EstadoSemaforo.Verde;
                    pibFoto.Image = Properties.Resources.verde;
                    timer.Interval = tempo_verde;

                    break;

                case EstadoSemaforo.Verde:
                    estadoAtual = EstadoSemaforo.Amarelo;
                    pibFoto.Image = Properties.Resources.amarelo;
                    timer.Interval = tempo_amarelo;

                    break;

                case EstadoSemaforo.Amarelo:
                    estadoAtual = EstadoSemaforo.Amarelo;
                    pibFoto.Image = Properties.Resources.amarelo;
                    timer.Interval = tempo_vermelho;

                    break;

            }
        }
    }
}
