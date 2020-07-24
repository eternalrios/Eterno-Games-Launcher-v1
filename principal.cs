///lanzador y actualizador y  con seccion de noticias y chat ademas se agg el reguistro desde el lanzador
///
///creado por mi desde cero  si ves que pueds  optimizar el proyecto adelante haslo pero no olvides compartir las mejoras
///
/// te invito a ver http://www.dofuseterno.com
// NOTA EN ESTE FORM NO TOCAR NADA ACLARO ACA NO SE TOCA NADA

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace alexander
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void principal_Load(object sender, EventArgs e)
        {
            guna2Button3_Click(null, e);
        }

        //codigo para el llamado de fomr en panel contedor
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.container1.Controls.Count > 0)
                this.container1.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.container1.Controls.Add(fh);
            this.container1.Tag = fh;
            fh.Show();
        }
        //aca finalizar el llamado del form enpanel contenedor4

        //Boton minimizar
        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Boton cerrar 
        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //boton que llama el form donde esta las  funciones de actualizar
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Form1());
        }
        //boton que llama  la seccio n de noticias 
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new prnoticias());
        }
        //boton que llama el fomr de  chat 
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new prchat());
        }

       
    }

}
// fin del coigo por el momneto 