namespace Administrador_de_Ventas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            codigoClienteG = new TextBox();
            button1 = new Button();
            codigoG = new TextBox();
            totalG = new TextBox();
            edadG = new TextBox();
            idG = new TextBox();
            label1 = new Label();
            nombreG = new TextBox();
            panel2 = new Panel();
            idCliC = new TextBox();
            dateC = new TextBox();
            button3 = new Button();
            codVentC = new TextBox();
            label2 = new Label();
            totalC = new TextBox();
            nombreC = new TextBox();
            idC = new TextBox();
            edadC = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateBlue;
            panel1.Controls.Add(codigoClienteG);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(codigoG);
            panel1.Controls.Add(totalG);
            panel1.Controls.Add(edadG);
            panel1.Controls.Add(idG);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(nombreG);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 240);
            panel1.TabIndex = 0;
            // 
            // codigoClienteG
            // 
            codigoClienteG.Location = new Point(119, 93);
            codigoClienteG.Name = "codigoClienteG";
            codigoClienteG.PlaceholderText = "ID de Cliente";
            codigoClienteG.Size = new Size(95, 23);
            codigoClienteG.TabIndex = 8;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.DimGray;
            button1.FlatAppearance.BorderSize = 5;
            button1.Location = new Point(139, 164);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // codigoG
            // 
            codigoG.Location = new Point(13, 193);
            codigoG.Name = "codigoG";
            codigoG.PlaceholderText = "Código de Venta";
            codigoG.Size = new Size(153, 23);
            codigoG.TabIndex = 5;
            // 
            // totalG
            // 
            totalG.Location = new Point(13, 164);
            totalG.Name = "totalG";
            totalG.PlaceholderText = "Total";
            totalG.Size = new Size(120, 23);
            totalG.TabIndex = 4;
            // 
            // edadG
            // 
            edadG.Location = new Point(172, 64);
            edadG.Name = "edadG";
            edadG.PlaceholderText = "Edad";
            edadG.Size = new Size(42, 23);
            edadG.TabIndex = 3;
            // 
            // idG
            // 
            idG.Location = new Point(13, 93);
            idG.Name = "idG";
            idG.PlaceholderText = "ID";
            idG.Size = new Size(100, 23);
            idG.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(31, 12);
            label1.Name = "label1";
            label1.Size = new Size(158, 30);
            label1.TabIndex = 1;
            label1.Text = "Registrar venta";
            // 
            // nombreG
            // 
            nombreG.Location = new Point(13, 64);
            nombreG.Name = "nombreG";
            nombreG.PlaceholderText = "Nombre";
            nombreG.Size = new Size(153, 23);
            nombreG.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateBlue;
            panel2.Controls.Add(idCliC);
            panel2.Controls.Add(dateC);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(codVentC);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(totalC);
            panel2.Controls.Add(nombreC);
            panel2.Controls.Add(idC);
            panel2.Controls.Add(edadC);
            panel2.Location = new Point(12, 258);
            panel2.Name = "panel2";
            panel2.Size = new Size(232, 258);
            panel2.TabIndex = 1;
            // 
            // idCliC
            // 
            idCliC.Location = new Point(118, 188);
            idCliC.Name = "idCliC";
            idCliC.PlaceholderText = "ID de Cliente";
            idCliC.Size = new Size(95, 23);
            idCliC.TabIndex = 9;
            // 
            // dateC
            // 
            dateC.Enabled = false;
            dateC.Location = new Point(18, 217);
            dateC.Name = "dateC";
            dateC.PlaceholderText = "Fecha";
            dateC.Size = new Size(200, 23);
            dateC.TabIndex = 6;
            // 
            // button3
            // 
            button3.Location = new Point(133, 64);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "Consultar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // codVentC
            // 
            codVentC.Location = new Point(17, 64);
            codVentC.Name = "codVentC";
            codVentC.PlaceholderText = "Código de venta";
            codVentC.Size = new Size(110, 23);
            codVentC.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(29, 12);
            label2.Name = "label2";
            label2.Size = new Size(166, 30);
            label2.TabIndex = 2;
            label2.Text = "Consultar Venta";
            // 
            // totalC
            // 
            totalC.Enabled = false;
            totalC.Location = new Point(17, 189);
            totalC.Name = "totalC";
            totalC.PlaceholderText = "Total";
            totalC.Size = new Size(95, 23);
            totalC.TabIndex = 4;
            // 
            // nombreC
            // 
            nombreC.Enabled = false;
            nombreC.Location = new Point(17, 118);
            nombreC.Name = "nombreC";
            nombreC.PlaceholderText = "Nombre";
            nombreC.Size = new Size(153, 23);
            nombreC.TabIndex = 0;
            // 
            // idC
            // 
            idC.Enabled = false;
            idC.Location = new Point(17, 147);
            idC.Name = "idC";
            idC.PlaceholderText = "ID";
            idC.Size = new Size(100, 23);
            idC.TabIndex = 2;
            // 
            // edadC
            // 
            edadC.Enabled = false;
            edadC.Location = new Point(176, 118);
            edadC.Name = "edadC";
            edadC.PlaceholderText = "Edad";
            edadC.Size = new Size(42, 23);
            edadC.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            ClientSize = new Size(256, 532);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox nombreG;
        private TextBox totalG;
        private TextBox edadG;
        private TextBox idG;
        private TextBox codigoG;
        private Button button1;
        private Button button3;
        private TextBox codVentC;
        private Label label2;
        private TextBox dateC;
        private TextBox totalC;
        private TextBox nombreC;
        private TextBox idC;
        private TextBox edadC;
        private TextBox codigoClienteG;
        private TextBox idCliC;
    }
}
