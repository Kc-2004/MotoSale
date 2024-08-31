namespace MotorShopUI.forms
{
    partial class SalesBykeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesBykeForm));
            label1 = new Label();
            selectBykeLabel = new Label();
            selectBykeComboBox = new ComboBox();
            saleBykeButton = new Button();
            infoLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(295, 28);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(202, 32);
            label1.TabIndex = 0;
            label1.Text = "Vender Moto";
            // 
            // selectBykeLabel
            // 
            selectBykeLabel.AutoSize = true;
            selectBykeLabel.Location = new Point(295, 98);
            selectBykeLabel.Margin = new Padding(5, 0, 5, 0);
            selectBykeLabel.Name = "selectBykeLabel";
            selectBykeLabel.Size = new Size(186, 21);
            selectBykeLabel.TabIndex = 1;
            selectBykeLabel.Text = "Seleccionar Moto";
            // 
            // selectBykeComboBox
            // 
            selectBykeComboBox.BackColor = SystemColors.ScrollBar;
            selectBykeComboBox.FormattingEnabled = true;
            selectBykeComboBox.Location = new Point(279, 149);
            selectBykeComboBox.Margin = new Padding(5, 4, 5, 4);
            selectBykeComboBox.Name = "selectBykeComboBox";
            selectBykeComboBox.Size = new Size(218, 29);
            selectBykeComboBox.TabIndex = 2;
            selectBykeComboBox.SelectedIndexChanged += selectBykeComboBox_SelectedIndexChanged;
            // 
            // saleBykeButton
            // 
            saleBykeButton.BackColor = SystemColors.ActiveCaptionText;
            saleBykeButton.Location = new Point(295, 346);
            saleBykeButton.Margin = new Padding(5, 4, 5, 4);
            saleBykeButton.Name = "saleBykeButton";
            saleBykeButton.Size = new Size(186, 75);
            saleBykeButton.TabIndex = 3;
            saleBykeButton.Text = "Vender Moto";
            saleBykeButton.UseVisualStyleBackColor = false;
            saleBykeButton.Click += saleBykeButton_Click;
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Location = new Point(304, 205);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(0, 21);
            infoLabel.TabIndex = 4;
            // 
            // SalesBykeForm
            // 
            AutoScaleDimensions = new SizeF(12F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(762, 454);
            Controls.Add(infoLabel);
            Controls.Add(saleBykeButton);
            Controls.Add(selectBykeComboBox);
            Controls.Add(selectBykeLabel);
            Controls.Add(label1);
            Font = new Font("Algerian", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlLightLight;
            Margin = new Padding(5, 4, 5, 4);
            Name = "SalesBykeForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label selectBykeLabel;
        private ComboBox selectBykeComboBox;
        private Button saleBykeButton;
        private Label infoLabel;
    }
}