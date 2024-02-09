using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            lst_series.Items.Add (txt_series.Text);
            lbl_indice.ForeColor = Color.BlueViolet;
            string nuevoElemento = txt_series.Text;
            txt_series.Text = "";


        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            lst_series.Items.Clear();
            lbl_indice.Text = "";

        }

        private void lst_series_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_indice.Text = lst_series.SelectedIndex.ToString();

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (lst_series.SelectedIndex != -1)
            {
                lst_series.Items.RemoveAt(lst_series.SelectedIndex);
            }   

        }
    }
}
