using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PracticaBitsYBytes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void cmd_Procesar_Click(object sender, EventArgs e)
        {
            Int32 entrada = Convert.ToInt32(txtEntrada.Text);
            byte s1 = 128;
            byte s2 = 64;
            byte n1 = 48;
            byte d1 = 14;

            byte s = (byte)(entrada & s1);
            if (s == 128)
            {
                sensor1.Image = Image.FromFile(@"D:\Imagenes\encendido.png");
            }
            else
            {
                sensor1.Image = Image.FromFile(@"D:\Imagenes\apagado.png");
            }

            byte ss = (byte)(entrada & s2);
            if (ss == 64)
            {
                sensor2.Image = Image.FromFile(@"D:\Imagenes\encendido.png");
            }
            else
            {
                sensor2.Image = Image.FromFile(@"D:\Imagenes\apagado.png");
            }

            byte n = (byte)(entrada & n1);
            if (n == 48)
            {
                nivel.Image = Image.FromFile(@"D:\Imagenes\cargando.png");
            }
            else if (n == 32)
            {
                nivel.Image = Image.FromFile(@"D:\Imagenes\lleno.png");
            }
            else if (n == 16)
            {
                nivel.Image = Image.FromFile(@"D:\Imagenes\medio.png");
            }
            else
            {
                nivel.Image = Image.FromFile(@"D:\Imagenes\vacio.png");
            }

            byte d = (byte)(entrada & d1);
            if (d == 14)
            {
                direccion.Image = Image.FromFile(@"D:\Imagenes\norte.png");
            }else if (d == 12)
            {
                direccion.Image = Image.FromFile(@"D:\Imagenes\noreste.png");
            }
            else if (d == 10)
            {
                direccion.Image = Image.FromFile(@"D:\Imagenes\este.png");
            }
            else if (d == 8)
            {
                direccion.Image = Image.FromFile(@"D:\Imagenes\sureste.png");
            }
            else if (d == 6)
            {
                direccion.Image = Image.FromFile(@"D:\Imagenes\sur.png");
            }
            else if (d == 4)
            {
                direccion.Image = Image.FromFile(@"D:\Imagenes\suroeste.png");
            }
            else if (d == 2)
            {
                direccion.Image = Image.FromFile(@"D:\Imagenes\oeste.png");
            }
            else
            {
                direccion.Image = Image.FromFile(@"D:\Imagenes\noroeste.png");
            }

            lblFecha.Text = fecha(entrada).ToString();
        }

        public string fecha(Int32 entrada)
        {
            byte dd = 31;
            byte mm = 15;
            int aa = 1900;
            entrada = entrada >> 8;
            dd = (byte)(entrada & dd);
            entrada = entrada >> 5;
            mm = (byte)(entrada & mm);
            entrada = entrada >> 4;
            aa =1900 + entrada;
           
            return "Fecha de lectura "+ dd + "/" + mm + "/" + aa;
        }
        private void cmd_AjustarF_Click(object sender, EventArgs e)
        {
            int dia = dateTimePicker1.Value.Day;
            int mes = dateTimePicker1.Value.Month;
            int year = dateTimePicker1.Value.Year;

            txtFechaA.Text = fechaProsesada(dia, mes, year).ToString();

        }

        public int fechaProsesada(int dia, int mes, int year)
        {
            int fechaA = 0;
            fechaA = dia;
            mes = mes << 5;
            fechaA += mes;
            year -= 1900;
            year = year << 9;
            fechaA += year;
            return fechaA;
        }

        
    }
}
