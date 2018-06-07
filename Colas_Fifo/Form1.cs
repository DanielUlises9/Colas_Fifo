using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colas_Fifo
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Resolviendo();
        }

        private string Resolviendo()
        {
            int rapido=0,agregado=0,pvacios=0,patendido=0,ppendiente=0,continua=0;
            ClaseBase nuevo;
            RandomGenerator r = new RandomGenerator();
            Colas folleto = new Colas();
            Random rto = new Random(DateTime.Now.Second);

            for(int i = 300;i>1;i--)
            {
                rapido = 0;
                rapido = rto.Next(1, 101);
                if(rapido < 36)
                {
                    nuevo = new ClaseBase( r.elrandom());
                    folleto.agrega(nuevo);
                    agregado++;
                }

                if(folleto.ver() == 0)
                {
                    pvacios++;
                }
                else
                {
                    continua++;
                    if(folleto.ver() == continua)
                    {
                        patendido++;
                        continua = 0;
                        folleto.desencolar();
                    }
                }

            }
            ppendiente = agregado - patendido;
            return "Ciclos Por Cola vacia: " + pvacios +"\r\n"+ 
                "Procesos atendidos: "+ patendido+ "\r\n"+
                "Procesos pendientes: " + ppendiente +"\r\n"+
                "Suma de ciclos restantes: " + folleto.contador();  
        }
    }
}
