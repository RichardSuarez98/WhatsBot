using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Forms;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WhatssappFlash
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public static WebDriverWait wait;
        public static ChromeDriver driver;
        public static DataTable datat;
        public static DataTable dataVariables;
        public static DataTable dataEmojis;
        // public static string filePathPrincipal;
        public static List<string> filePathPrincipal;
        //int o = 0;
        //string[] vari = new string[6];
        //object[] values = new object[6];

        int o = 1;
        string[] vari = new string[6];
        object[] values = new object[6];
        //string[] vari = new string[6];
        //object[] values = new object[6];
        private delegate void SafeCallDelegate(string text);
        private delegate void SafeCallDelegateToEnable(bool status);
        private bool bStopSendingMessage = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            //this.WindowState = FormWindowState.Maximized;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var options =  new ChromeOptions();
                options.AddArguments("--start-maximized");
                options.AddExcludedArgument("enable-automation");

       /*var*/  driver = new ChromeDriver(options);
                driver.Navigate().GoToUrl("https://web.whatsapp.com/");

                wait = new WebDriverWait(driver, TimeSpan.FromMinutes(15));//,TimeSpan.FromSeconds(7)            
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                //driver.Quit();
            }
         }



        Thread threadMessages = null;
        private async void button2_Click(object sender, EventArgs e)
        {
            threadMessages = new Thread(new ThreadStart(SendMessages));
            threadMessages.Start();
      
            ///html/body/div[1]/div[1]/div[1]/div[2]/div[2]/span/div[1]/span/div[1]/div/div[2]/div/div[1]/div[3]/div/div/div[2]/div[1]/div[2]
        }

      //  int mensajeEnviadoN = 0;
       private async void SendMessages()
        {
            bStopSendingMessage = false;
            EnableSendButton(false);
            try
            {
                for (int i = 0; i < datat.Rows.Count; i++)
                {
                    var search = wait.Until(drv => drv.FindElement(By.XPath("/html/body/div[1]/div/div/div[3]/div/div[1]/div/label/div/div[2]")));
                    string numero = Convert.ToString(dgvListaCliente.Rows[i].Cells[0].Value);
                    search.SendKeys($"593{numero}" + OpenQA.Selenium.Keys.Enter);

                    int num = Convert.ToInt32(nmrTNumero.Value * 1000);
                    await Task.Delay(num);

                    wait.Until(drv => drv.FindElement(By.XPath("/html/body/div[1]/div/div/div[4]/div/footer/div[1]/div/span[2]/div/div[1]/div[2]/div/div/span"))).Click();

                    var image = wait.Until(drv => drv.FindElement(By.XPath("/html/body/div[1]/div/div/div[4]/div/footer/div[1]/div/span[2]/div/div[1]/div[2]/div/span/div/div/ul/li[1]/button/input")));
                    // "C:\\Users\\Windows\\Desktop\\maquina.jpg"
                    for (int o = 0; o < filePathPrincipal.Count; o++)
                    {
                        image.SendKeys(filePathPrincipal[o]);

                        int ima = Convert.ToInt32(nmrTImagen.Value * 1000);
                        await Task.Delay(ima);
                    }

                    var txt = wait.Until(drv => drv.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div[2]/div[2]/span/div/span/div/div/div[2]/div/div[1]/div[3]/div/div/div[2]/div[1]/div[2]")));

                    int r = 0;

                    // if (r<datat.Columns.Count)
                    while (r < dgvListaCliente.Columns.Count)
                    {
                        string columna = dgvListaCliente.Rows[i].Cells[r].Value.ToString();
                        vari[r] = columna;
                        vari.CopyTo(values, 0);
                        r++;
                    }

                    int men = Convert.ToInt32(nmrTMensaje.Value * 1000);
                    // txt.sendKeysWithEmojis();
                    txt.SendKeys(String.Format(txtMensajePrevisualizacion.Text, values) + OpenQA.Selenium.Keys.Enter);
                   // txt.SendKeys(OpenQA.Selenium.Keys.Enter);
                    await Task.Delay(men);

                    
                    //await Task.Delay(men);

                   // wait.Until(drv => drv.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div[2]/div[2]/span/div/span/div/div/div[2]/div/div[2]/div[2]/div/div"))).Click();


                    if (bStopSendingMessage == true)
                    {
                        EnableSendButton(true);
                        return;
                    }

                    //mensajeEnviadoN++;
                   // lblMensajeEnviado.Text = mensajeEnviadoN.ToString();
                }
               
            }
            ///html/body/div[1]/div/div/div[4]/div/footer/div[1]/div/span[2]/div/div[1]/div[2]/div/span/div/div/ul/li[1]/button/input
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                // driver.Quit();
            }

            EnableSendButton(true);

        }


        private void button3_Click(object sender, EventArgs e)
        {
            //   --------------------------------------- <span class="l7jjieqr cfzgl7ar ei5e7seu h0viaqh7 tpmajp1w c0uhu3dl riy2oczp dsh4tgtl sy6s5v3r gz7w46tb lyutrhe2 qfejxiq4 fewfhwl7 ovhn1urg ap18qm3b ikwl5qvt j90th5db aumms1qt" aria-label="2 mensajes no leídos">2</span>
            //wait.Until(drv => drv.FindElement(By.XPath("//span[contains(@aria-label, 'mensaje no leído') or contains(@aria-label, 'mensajes no leídos')]")));
            //driver.FindElement(By.XPath("//span[contains(@aria-label, 'mensaje no leído') or contains(@aria-label, 'mensajes no leídos')]//ancestor::div[@class='_3OvU8']")).Click();

            //var write_msg = wait.Until(drv => drv.FindElement(By.XPath("/html/body/div[1]/div/div/div[4]/div/footer/div[1]/div/span[2]/div/div[2]/div[1]/div/div[2]")));
            //write_msg.SendKeys("Hola que tal, esto es una prueba" + Keys.Enter);
            bool band=true;

            do {
                // brain();//driver,wait
                try
                {                                                                                                                                             // ")));//                    
                   var d= wait.Until(drv => drv.FindElement(By.XPath("//span[contains(@aria-label, 'mensaje no leído') or contains(@aria-label, 'mensajes no leídos')] | //div[contains(@aria-label, 'Lista de chats')]//div[last()][contains(@class, 'message-in')]")));
                    driver.FindElement(By.XPath("//span[contains(@aria-label, 'mensaje no leído') or contains(@aria-label, 'mensajes no leídos')]//ancestor::div[@class='_3OvU8']")).Click();
                

                    var write_msg = wait.Until(drv => drv.FindElement(By.XPath("/html/body/div[1]/div/div/div[4]/div/footer/div[1]/div/span[2]/div/div[2]/div[1]/div/div[2]")));
                    write_msg.SendKeys(mensaje_bienvenida() + OpenQA.Selenium.Keys.Enter); //wait

                if (d==null)
                {
                        band = false;
                }

                }
                catch { }

            } while (band);

        }





        static void brain()//IWebDriver driver, WebDriverWait wait
        {
           // wait.Until(drv => drv.FindElement(By.XPath("/span[contains(@aria-label, 'mensaje no leído') or contains(@aria-label, 'mensajes no leídos')] | //div[contains(@aria-label, 'Lista de mensajes')]//div[last()][contains(@class, 'message-in')]")));
           // wait.Until(drv => drv.FindElement(By.XPath("//span[contains(@aria-label, 'mensaje no leído') or contains(@aria-label, 'mensajes no leídos')]")));
           
            wait.Until(drv => drv.FindElement(By.XPath("//span[contains(@aria-label, 'mensaje no leído') or contains(@aria-label, 'mensajes no leídos')]")));//                 | //div[contains(@aria-label, 'Lista de chats')]//div[last()][contains(@class, 'message-in')]
            try
            {
                driver.FindElement(By.XPath("//span[contains(@aria-label, 'mensaje no leído') or contains(@aria-label, 'mensajes no leídos')]//ancestor::div[@class='_3OvU8']")).Click();
            }
            catch { }


        }

        public string mensaje_bienvenida()//WebDriverWait wait
        {
            var user_name = wait.Until(drv => drv.FindElement(By.XPath("//header[@class='_23P3O']//div[@class='_21nHd']")).Text);
            return $"Bienvenido, {user_name} ¿En qué podría ayudarlo?";
        }



        private void button4_Click(object sender, EventArgs e)
        {
            OleDbConnection conn;
            OleDbDataAdapter MyDataAdapter;
            //DataTable dt;

            var fileContent = string.Empty;
            var filePath = string.Empty;
            string hoja = "Hoja1";
            using (System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Excel Files |*.xlsx"; //txt files (*.txt)|*.txt|All files (*.*)|*.*
                openFileDialog.Title="Seleccione el archivo de Excel";               
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }

                conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + filePath + ";Extended Properties='Excel 8.0;HDR=YES;';");// "\\Registros.xlsx" +
                OleDbCommand cmd = new OleDbCommand("Select * From [" + hoja + "$]", conn);
                try
                {
                    //Conectarse al archivo de Excel
                    conn.Open();

                    OleDbDataAdapter sda = new OleDbDataAdapter(cmd);
                    DataTable data = new DataTable();

                    //Cargar los datos
                    sda.Fill(data);

                    //Cargar la grilla

                  //  if (tabControl1.SelectedIndex == 0)
                   // {
                        dgvListaCliente.DataSource = data;
                        datat = data;
                  //  }else if (tabControl1.SelectedIndex == 1)
                  //  {
                  //      dgvListaVariables.DataSource = data;
                        //MessageBox.Show("soy las variables");
                   // }
                  //  else if (tabControl1.SelectedIndex == 2)
                  //  {
                  //      dgvEmojis.DataSource = data;
                        //MessageBox.Show("soy los emojis");
                  //  }


                    //for (int i = 0; i < data.Rows.Count; i++)
                    //{
                    //    //  MessageBox.Show(dataGridView1.CurrentRow.Cells[i].Value.ToString());
                    // //   for (int o = 0; o < dataGridView1.Columns.Count; o++)
                    // //   {
                    //        // MessageBox.Show(dataGridView1.Rows[i].Cells[o].Value.ToString());
                    //        MessageBox.Show(dataGridView1.Rows[i].Cells[0].Value.ToString());
                    // //   }
                    //    //MessageBox.Show(dataGridView1.CurrentRow.Cells[i].Value.ToString());
                    //}

                }
                catch
                {
                    //Error leyendo excel
                    MessageBox.Show("Ocurrió un error en la lectura del archivo");
                }
                finally
                {
                    //Funcione o no, cerramos la cadena de conexión
                    conn.Close();
                }
            }

           
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<string> vs = new List<string>();
            using (System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                //openFileDialog.Filter = "Excel Files |*.xlsx"; //txt files (*.txt)|*.txt|All files (*.*)|*.*
                openFileDialog.Title = "Seleccione su imagen";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    int od = Convert.ToInt32(openFileDialog.FileNames.Count());
                    for (int i=0; i< od; i++)
                    {
                        vs.Add(openFileDialog.FileNames[i]);
                    }
                    // filePath = openFileDialog.FileNames[1];
                    //filePathPrincipal = filePath;
                    filePathPrincipal = vs;
                    //string imagen = openFileDialog1.FileName;
                    pictureBox1.Image = Image.FromFile(vs[0]);//filePath
                }
            }
        }


   
       // List<object> v = new List<object>();

        private void btnPrevisualizacion_Click(object sender, EventArgs e)
        {
            //   MessageBox.Show(txtMensajePrevisualizacion.Text, "Previsualización de su campaña", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // MessageBox.Show(txtMensajePrevisualizacion.Text);
            MessageBox.Show(mensajePersonalizado());

            //    MessageBox.Show(String.Format(txtMensajePrevisualizacion.Text,values));
        }



        private void btnPersonalizado_Click(object sender, EventArgs e)
        {
            //txtMensajePrevisualizacion.Text += dgvListaCliente.Rows[0].Cells[i].Value + Environment.NewLine;
            //  i++;
            //string personalizado = $"<Word_{bandi}>";
            if (o<datat.Columns.Count){
                txtMensajePrevisualizacion.Text += "{" + $"{o}" + "} ";
                o++;
            }
            
        }
      
        
        public  string  mensajePersonalizado()
        {
            try
            {
                for (int r = 0; r < dgvListaCliente.Columns.Count; r++)
                {
                  string columna = dgvListaCliente.Rows[0].Cells[r].Value.ToString();
                  if (columna.FirstOrDefault() == ':')
                  {
                     columna= dgvListaCliente.Rows[0].Cells[r+1].Value.ToString();
                  }
                     vari[r] = columna;
                     vari.CopyTo(values, 0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return  string.Format(txtMensajePrevisualizacion.Text, values);
        }



        /*
            andom rnd = new Random();
            int[]  numbers = new int[4];
            int total = 0;
            for (int ctr = 0; ctr <= 2; ctr++) {
               int number = rnd.Next(1001);
               numbers[ctr] = number;
               total += number;
            }   
            numbers[3] = total;
            object[] values = new object[numbers.Length];
            numbers.CopyTo(values, 0);
            Console.WriteLine("{0} + {1} + {2} = {3}", values);
         */


        //public string mensaje_bienvenida()
        //{
        //    var user_name = wait.Until(drv => drv.FindElement(By.XPath("//header[@class='_23P3O']//div[@class='_21nHd']")).Text);
        //    return $"Bienvenido, {user_name} ¿En qué podría ayudarlo?";
        //}




        private void EnableSendButton(bool status)
        {
            if (btnSendMessage.InvokeRequired)
            {
                var d = new SafeCallDelegateToEnable(EnableSendButton);
                btnSendMessage.Invoke(d, new object[] { status });
            }
            else
            {
                btnSendMessage.Enabled = status;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bStopSendingMessage = true;

        }

    }
}//   //*[@id="pane-side"]/div[2]/div/div/div[9]/div/div/div[2]/div[2]/div[2]/span[1]/div/span
 //        <span class="l7jjieqr cfzgl7ar ei5e7seu h0viaqh7 tpmajp1w c0uhu3dl riy2oczp dsh4tgtl sy6s5v3r gz7w46tb lyutrhe2 qfejxiq4 fewfhwl7 ovhn1urg ap18qm3b ikwl5qvt j90th5db aumms1qt" aria-label="2 mensajes no leídos">2</span>