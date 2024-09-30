using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;
using System;

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }

        private void boton_Click(object sender, EventArgs e)
        {
            try
            {
                
            //Creo el socket de conexion con la balanza
            Socket con = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipEnd = new IPEndPoint(IPAddress.Parse("10.10.100.254"), 502);
            con.Connect(ipEnd);
            //Declaracion de variables
            int i = 0;
            decimal[] comp = new decimal[3];
            comp[0] = 0;
            comp[1] = 0;
            int bandera = 0;
            //int bandera2 = 0;
            decimal tolerancia1 = Convert.ToDecimal(refer.Text) + Convert.ToDecimal(toler.Text);
            decimal tolerancia2 = Convert.ToDecimal(refer.Text) - Convert.ToDecimal(toler.Text);
                while (true)
                //do
                {
                    //Recibir y decodificar informacion de la balanza
                    byte[] buf = new byte[1024];
                    int rec = con.Receive(buf);
                    string msg = Encoding.Default.GetString(buf, 0, rec);
                    //Solo mensajes que tengan 16 de longitud entran a operar, estos se generan cuando el peso es estable
                    if (msg.Length == 16 && i < 2)
                    {
                        //de datos que llegan selecciono solamente los que traen el peso y los convierto en decimal
                        string data = msg[9].ToString() + msg[10].ToString() + msg[11].ToString() + msg[12].ToString() + msg[13].ToString() + msg[14].ToString() + msg[15].ToString();
                        decimal num = Convert.ToDecimal(data);
                        // este arreglo va a comparar dos valores para ver si existe o no un cambio en la lectura
                        comp[i] = comp[i + 1];
                        comp[i + 1] = num;
                        //Si existe el cambio verifico si esta dentro o fuera del rango de tolerancia
                        if (comp[i] != comp[i + 1])
                        {
                            if (tolerancia1 >= comp[i + 1] && tolerancia2 <= comp[i + 1])
                            {
                                //bandera me permite tomar solo un dato de los 3 que se envian hasta que se estabilice
                                if (bandera == 1)
                                {
                                    DataGridViewRow fila = new DataGridViewRow();
                                    fila.CreateCells(tabla1);
                                    fila.Cells[0].Value = num;
                                    fila.Cells[1].Value = DateTime.Now.ToShortDateString();
                                    fila.Cells[2].Value = DateTime.Now.ToShortTimeString();

                                    tabla1.Rows.Add(fila);
                                    tabla1.Refresh();

                                    //Guardar todo en archivo .csv
                                    string archivo = "pesos_aprobados.csv";
                                    string linea = num + "," + DateTime.Now.ToShortDateString() + "," + DateTime.Now.ToShortTimeString() + "," + refer.Text + "," + toler.Text;

                                    StreamWriter escribir;

                                    escribir = File.AppendText(archivo);
                                    escribir.WriteLine(linea);
                                    escribir.Close();

                                    Console.WriteLine(num + "   Peso dentro del rango");
                                }
                                bandera++;
                                //Console.WriteLine("las veces contadas fueron: "+bandera+ " el valor de a es: "+a);
                            }
                            else
                            {
                                //Console.WriteLine(tolerancia1 + " tampoco entra "+ tolerancia2 + " num: "+comp[i+1]);
                                if (bandera == 1)
                                {
                                    if (num != 0)
                                    {
                                        string archivo1 = "pesos_no_aprobados.csv";
                                        string linea2 = num + "," + DateTime.Now.ToShortDateString() + "," + DateTime.Now.ToShortTimeString() + "," + refer.Text + "," + toler.Text;

                                        StreamWriter escribir1;

                                        escribir1 = File.AppendText(archivo1);
                                        escribir1.WriteLine(linea2);
                                        escribir1.Close();
                                        Console.WriteLine(num + "   Peso fuera del rango");
                                    }
                                }
                                bandera++;

                            }
                        }
                        else
                        {
                            //Console.WriteLine(tolerancia1 + " no entra "+ tolerancia2 + " num: " + comp[i + 1]);
                            Console.WriteLine(num + "   No ha variado el peso");
                            bandera = 0;
                        }
                        i++;
                    }
                    else
                    {
                        i = 0;
                    }
                }
            } //while (bandera2 ==0);
            catch (Exception ex)
            {
                MessageBox.Show("REVISAR ESTAR EN LA RED DEL EQUIPO"+"\n"+"INGRESAR PESO REFERENCIAL Y TOLERANCIA");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}