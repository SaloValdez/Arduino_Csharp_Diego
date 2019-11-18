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

namespace ARDUINO_CSHARP
{
    public partial class Form1 : Form
    {
        System.IO.Ports.SerialPort Arduino; //Utilizar libreria para puerto serial
        bool IsClosed = false;
        
        public Form1()
        {
            InitializeComponent();

            Arduino = new System.IO.Ports.SerialPort(); //constructor  de formulario: inicializar el objeto
            Arduino.PortName = "COM7";
            Arduino.BaudRate = 9600;//9600 bits por segundo (baudios)
            Arduino.Open(); // Abriendo el puerto

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Arduino.IsOpen)
            {
                Arduino.Close();
            }
        }

        private void btnOnFoco_Click(object sender, EventArgs e)
        {
            Arduino.Write("b");
        }

        private void btnOffFoco_Click(object sender, EventArgs e)
        {
            Arduino.Write("a");
        }


        //crear un hilo para escuchar al arduino
        private void EscucharSerial() {
            while (!IsClosed) {
                try {

                    string cadena = Arduino.ReadLine();  //leer lo que escribe el arduino
                    txtTemperatura.Invoke(new MethodInvoker(
                        delegate
                        {
                            txtTemperatura.Text = cadena;
                        }
                        ));
                    
                } catch {
                    
                }
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread Hilo = new Thread(EscucharSerial);
            Hilo.Start();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Arduino.Write("j");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Arduino.Write("i");
        }

        private void btnEncenderFocoALTERNA_Click(object sender, EventArgs e)
        {
            Arduino.Write("0");
        }

        private void btnApagarFocoALTERNA_Click(object sender, EventArgs e)
        {
            Arduino.Write("1");
        }
    }
}
