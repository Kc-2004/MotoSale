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
    public partial class RegisterBykeForm : Form
    {
        private MotoManager motoManager;

        public RegisterBykeForm(MotoManager manager)
        {
            InitializeComponent();
            motoManager = manager;
            motoManager.MotoAgregada += OnMotoAgregada;
        }

        private void OnMotoAgregada(object sender, Moto moto)
        {
            MessageBox.Show($"Moto {moto.Marca} {moto.Modelo} agregada correctamente.");
        }

        private void addBykeButtonClick(object sender, EventArgs e)
        {
            var moto = new Moto
            {
                Marca = BrandTextBox.Text,
                Modelo = ModelTextBox.Text,
                Precio = priceNumericUpDown.Value
            };

            motoManager.AgregarMoto(moto);
            DialogResult result = MessageBox.Show("¿Desea agregar otra motocicleta?",
                                        "Agregar Nueva Motocicleta",
                                        MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                this.Close();
            }
            else
            {
                BrandTextBox.Text = string.Empty;
                ModelTextBox.Text = string.Empty;
                priceNumericUpDown.Value = 0;
            }
        }

        private void priceNumericUpDown_Validating(object sender, CancelEventArgs e)
        {
            if (priceNumericUpDown.Value <= 1000)
            {
                errorProvider.SetError(priceNumericUpDown, "La moto debe ser de $1,000 en adelante");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(priceNumericUpDown, string.Empty);
            }
        }

        private void ModelTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (ModelTextBox != null)
            {
                if (string.IsNullOrEmpty(ModelTextBox.Text))
                {
                    // Establecer el mensaje de error si el TextBox está vacío
                    errorProvider.SetError(ModelTextBox, "Este campo no puede estar vacío.");
                    e.Cancel = true; // Evitar que el control pierda el foco
                }
                else
                {
                    // Limpiar el mensaje de error si el TextBox tiene contenido
                    errorProvider.SetError(ModelTextBox, string.Empty);
                }
            }
        }

        private void BrandTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (BrandTextBox != null)
            {
                if (string.IsNullOrEmpty(BrandTextBox.Text))
                {
                    // Establecer el mensaje de error si el TextBox está vacío
                    errorProvider.SetError(BrandTextBox, "Este campo no puede estar vacío.");
                    e.Cancel = true; // Evitar que el control pierda el foco
                }
                else
                {
                    // Limpiar el mensaje de error si el TextBox tiene contenido
                    errorProvider.SetError(BrandTextBox, string.Empty);
                }
            }
        }
    }
}
