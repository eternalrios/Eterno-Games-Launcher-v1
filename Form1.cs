using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Ionic.Zip;
using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;

namespace alexander
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private const bool V = true;
        private ZipFile zip;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
            //Progreso de la descarga y anulamos el boton jugar mientras
            backgroundWorker1.RunWorkerAsync();

            strtGameBtn.Enabled = false;
        }
        //Eliminamos el archivo
        static bool deleteFile(string f)
        {
            try
            {
                File.Delete(f);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + Environment.NewLine + e.InnerException.Message);
                return false;
            }
        }


        //Descargando y actualizando el cliente
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //URL donde se encuentran los archivos a descargar y leer para comparar versiones
            string Server = "http://midofus.com/data/update/";

            //Definiendo root de la aplicación para leer el archivo de version
            string Root = AppDomain.CurrentDomain.BaseDirectory;

            //Muestra si el archivo de version existe, de lo contrario lo crea con v0.00.0
            FileStream fs = null;
            if (!File.Exists("version"))
            {
                using (fs = File.Create("version"))
                {

                }

                using (StreamWriter sw = new StreamWriter("version"))
                {
                    sw.Write("0.00.0");
                }
            }
            //Chequeamos la version del cliente
            string lclVersion;
            using (StreamReader reader = new StreamReader("version"))
            {
                lclVersion = reader.ReadLine();
            }
            Version localVersion = new Version(lclVersion);


            //Ahora listamos los archivos a actualizar ya editados en el Updates.xml
            XDocument serverXml = XDocument.Load(@Server + "Updates.xml");

            //Comparamos versiones si son distintas empieza la actualización
            foreach (XElement update in serverXml.Descendants("update"))
            {
                string version = update.Element("version").Value;
                string file = update.Element("file").Value;

                Version serverVersion = new Version(version);


                string sUrlToReadFileFrom = Server + file;

                string sFilePathToWriteFileTo = Root + file;

                if (serverVersion > localVersion)
                {
                    Uri url = new Uri(sUrlToReadFileFrom);
                    System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(url);
                    System.Net.HttpWebResponse response = (System.Net.HttpWebResponse)request.GetResponse();
                    response.Close();

                    Int64 iSize = response.ContentLength;

                    Int64 iRunningByteTotal = 0;

                    using (System.Net.WebClient client = new System.Net.WebClient())
                    {
                        using (System.IO.Stream streamRemote = client.OpenRead(new Uri(sUrlToReadFileFrom)))
                        {
                            using (Stream streamLocal = new FileStream(sFilePathToWriteFileTo, FileMode.Create, FileAccess.Write, FileShare.None))
                            {
                                int iByteSize = 0;
                                byte[] byteBuffer = new byte[iSize];
                                while ((iByteSize = streamRemote.Read(byteBuffer, 0, byteBuffer.Length)) > 0)
                                {
                                    streamLocal.Write(byteBuffer, 0, iByteSize);
                                    iRunningByteTotal += iByteSize;

                                    double dIndex = (double)(iRunningByteTotal);
                                    double dTotal = (double)byteBuffer.Length;
                                    double dProgressPercentage = (dIndex / dTotal);
                                    int iProgressPercentage = (int)(dProgressPercentage * 100);

                                    backgroundWorker1.ReportProgress(iProgressPercentage);
                                }

                                streamLocal.Close();
                            }

                            streamRemote.Close();
                        }
                    }
                    //Descomprimir el ZIP
                   // using (ZipFile zip = ZipFile.Read(file))
                   // {
                       // foreach (ZipEntry zipFiles in zip)
                       // {
                           // zipFiles.Extract(Root + "\\", true);
                       // }
                   // }

                    //Descargamos la nueva versión y editamos el archivo version a su última descarga
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile(Server + "version.txt", @Root + "version");

                    //Eliminamos los archivos ZIP
                    deleteFile(file);
                }
            }
        }
        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string Server = "http://lucalyt.com/hardfus/dofus/l/dofus/updates/";
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            downloadLbl.ForeColor = System.Drawing.Color.Silver;
            downloadLbl.Text = "Descargando actualizaciones";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            strtGameBtn.Enabled = true;
            this.downloadLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(203)))));
            downloadLbl.Text = "El cliente esta actualizado";
        }

        private void strtGameBtn_Click(object sender, EventArgs e)
        {
            Process.Start("Dofus.exe");
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Process.Start("vaciarcache.exe");
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://hardfus.com/");
        }
        public void DescomprimirZIP(string rutaini, string rutafin)
        {
            ZipFile.ExtractToDirectory(rutaini, rutafin);
        }
    }
}
