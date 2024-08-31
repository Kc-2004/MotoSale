using MotoShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MotorShopUI.forms
{
    public partial class SalesBykeForm : Form
    {
        private MotoManager motoManager;

        public SalesBykeForm(MotoManager manager)
        {
            InitializeComponent();
            motoManager = manager;
            motoManager.VentaRegistrada += OnVentaRegistrada;
            CargarMotos();
        }

        private void OnVentaRegistrada(object sender, Venta venta)
        {
            MessageBox.Show($"Venta registrada: {venta.MotoVendida.Marca} {venta.MotoVendida.Modelo}.");
        }

        private void CargarMotos()
        {
            selectBykeComboBox.DataSource = motoManager.ObtenerMotos().ToList();
            selectBykeComboBox.DisplayMember = "Modelo";
            selectBykeComboBox.ValueMember = "Marca";
        }


        private void saleBykeButton_Click(object sender, EventArgs e)
        {
            var moto = (Moto)selectBykeComboBox.SelectedItem;
            motoManager.RegistrarVenta(moto);

       
     
            DialogResult result = MessageBox.Show("¿Desea vender otra motocicleta?",
                                        "Vender Motocicleta",
                                        MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                this.Close();
            }
        }

        private void selectBykeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var moto = (Moto)selectBykeComboBox.SelectedItem;

            if (moto != null)
            {
                infoLabel.Text = $"Marca: {moto.Marca} \n Modelo: {moto.Modelo} \n  Precio: ${moto.Precio}";
            }
            else
            {
                infoLabel.Text = "Selecciona una moto.";
            }
        }
    }
}
