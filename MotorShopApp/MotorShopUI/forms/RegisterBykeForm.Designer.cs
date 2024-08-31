namespace MotorShopUI.forms
{
    partial class RegisterBykeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterBykeForm));
            label1 = new Label();
            BrandLabel = new Label();
            BrandTextBox = new TextBox();
            ModelTextBox = new TextBox();
            ModelLabel = new Label();
            priceLabel = new Label();
            priceNumericUpDown = new NumericUpDown();
            addBykeButton = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)priceNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(236, 42);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(262, 24);
            label1.TabIndex = 0;
            label1.Text = "REGISTRAR MOTOCICLETA";
            // 
            // BrandLabel
            // 
            BrandLabel.AutoSize = true;
            BrandLabel.Location = new Point(328, 95);
            BrandLabel.Margin = new Padding(6, 0, 6, 0);
            BrandLabel.Name = "BrandLabel";
            BrandLabel.Size = new Size(82, 24);
            BrandLabel.TabIndex = 1;
            BrandLabel.Text = "Marca";
            // 
            // BrandTextBox
            // 
            BrandTextBox.Location = new Point(236, 124);
            BrandTextBox.Margin = new Padding(6, 5, 6, 5);
            BrandTextBox.Multiline = true;
            BrandTextBox.Name = "BrandTextBox";
            BrandTextBox.Size = new Size(251, 36);
            BrandTextBox.TabIndex = 2;
            BrandTextBox.Validating += BrandTextBox_Validating;
            // 
            // ModelTextBox
            // 
            ModelTextBox.Location = new Point(236, 239);
            ModelTextBox.Margin = new Padding(6, 5, 6, 5);
            ModelTextBox.Multiline = true;
            ModelTextBox.Name = "ModelTextBox";
            ModelTextBox.Size = new Size(251, 33);
            ModelTextBox.TabIndex = 3;
            ModelTextBox.Validating += ModelTextBox_Validating;
            // 
            // ModelLabel
            // 
            ModelLabel.AutoSize = true;
            ModelLabel.Location = new Point(328, 189);
            ModelLabel.Margin = new Padding(6, 0, 6, 0);
            ModelLabel.Name = "ModelLabel";
            ModelLabel.Size = new Size(88, 24);
            ModelLabel.TabIndex = 4;
            ModelLabel.Text = "Modelo";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(331, 290);
            priceLabel.Margin = new Padding(6, 0, 6, 0);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(79, 24);
            priceLabel.TabIndex = 6;
            priceLabel.Text = "Precio";
            // 
            // priceNumericUpDown
            // 
            priceNumericUpDown.Location = new Point(253, 339);
            priceNumericUpDown.Margin = new Padding(6, 5, 6, 5);
            priceNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            priceNumericUpDown.Name = "priceNumericUpDown";
            priceNumericUpDown.Size = new Size(223, 35);
            priceNumericUpDown.TabIndex = 7;
            priceNumericUpDown.Validating += priceNumericUpDown_Validating;
            // 
            // addBykeButton
            // 
            addBykeButton.Location = new Point(236, 435);
            addBykeButton.Margin = new Padding(6, 5, 6, 5);
            addBykeButton.Name = "addBykeButton";
            addBykeButton.Size = new Size(249, 64);
            addBykeButton.TabIndex = 8;
            addBykeButton.Text = "Agregar Moto";
            addBykeButton.UseVisualStyleBackColor = true;
            addBykeButton.Click += addBykeButtonClick;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // RegisterBykeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(748, 526);
            Controls.Add(addBykeButton);
            Controls.Add(priceNumericUpDown);
            Controls.Add(priceLabel);
            Controls.Add(ModelLabel);
            Controls.Add(ModelTextBox);
            Controls.Add(BrandTextBox);
            Controls.Add(BrandLabel);
            Controls.Add(label1);
            Font = new Font("Algerian", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "RegisterBykeForm";
            Text = "RegisterBykeForm";
            ((System.ComponentModel.ISupportInitialize)priceNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label BrandLabel;
        private TextBox BrandTextBox;
        private TextBox ModelTextBox;
        private Label ModelLabel;
        private Label priceLabel;
        private NumericUpDown priceNumericUpDown;
        private Button addBykeButton;
        private ErrorProvider errorProvider;
    }
}