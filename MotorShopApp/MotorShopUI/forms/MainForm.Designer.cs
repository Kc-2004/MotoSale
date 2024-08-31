namespace MotorShopUI.forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            welcomeTitleLabel = new Label();
            introductionLabel = new Label();
            registrerBykeButton = new Button();
            sellButton = new Button();
            SuspendLayout();
            // 
            // welcomeTitleLabel
            // 
            welcomeTitleLabel.AutoSize = true;
            welcomeTitleLabel.BackColor = SystemColors.ButtonShadow;
            welcomeTitleLabel.Font = new Font("Algerian", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeTitleLabel.ForeColor = SystemColors.ControlLightLight;
            welcomeTitleLabel.Location = new Point(342, 57);
            welcomeTitleLabel.Margin = new Padding(6, 0, 6, 0);
            welcomeTitleLabel.Name = "welcomeTitleLabel";
            welcomeTitleLabel.Size = new Size(203, 35);
            welcomeTitleLabel.TabIndex = 0;
            welcomeTitleLabel.Text = "Bienvenido";
            // 
            // introductionLabel
            // 
            introductionLabel.AutoSize = true;
            introductionLabel.Font = new Font("Algerian", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            introductionLabel.Location = new Point(311, 117);
            introductionLabel.Margin = new Padding(6, 0, 6, 0);
            introductionLabel.Name = "introductionLabel";
            introductionLabel.Size = new Size(283, 26);
            introductionLabel.TabIndex = 1;
            introductionLabel.Text = "Ejecutivo de Ventas";
            // 
            // registrerBykeButton
            // 
            registrerBykeButton.BackColor = SystemColors.ControlDark;
            registrerBykeButton.ForeColor = SystemColors.ControlLightLight;
            registrerBykeButton.Location = new Point(292, 171);
            registrerBykeButton.Margin = new Padding(6, 4, 6, 4);
            registrerBykeButton.Name = "registrerBykeButton";
            registrerBykeButton.Size = new Size(337, 97);
            registrerBykeButton.TabIndex = 2;
            registrerBykeButton.Text = "Registrar Nueva Motocicleta";
            registrerBykeButton.UseVisualStyleBackColor = false;
            registrerBykeButton.Click += registrerBykeButton_Click;
            // 
            // sellButton
            // 
            sellButton.BackColor = SystemColors.AppWorkspace;
            sellButton.ForeColor = SystemColors.ControlLightLight;
            sellButton.Location = new Point(292, 313);
            sellButton.Margin = new Padding(6, 4, 6, 4);
            sellButton.Name = "sellButton";
            sellButton.Size = new Size(337, 98);
            sellButton.TabIndex = 3;
            sellButton.Text = "Vender Motocicleta";
            sellButton.UseVisualStyleBackColor = false;
            sellButton.Click += sellButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(960, 508);
            Controls.Add(sellButton);
            Controls.Add(registrerBykeButton);
            Controls.Add(introductionLabel);
            Controls.Add(welcomeTitleLabel);
            Font = new Font("Algerian", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 4, 6, 4);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeTitleLabel;
        private Label introductionLabel;
        private Button registrerBykeButton;
        private Button sellButton;
    }
}