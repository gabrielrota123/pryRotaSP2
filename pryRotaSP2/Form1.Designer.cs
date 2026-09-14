namespace pryRotaSP2
{
    partial class ventasregistradas
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
            dtp = new DateTimePicker();
            txtnumero = new TextBox();
            cmblist = new ComboBox();
            btnregistrar = new Button();
            lstventas = new ListBox();
            lbl2 = new Label();
            lbl1 = new Label();
            lbl3 = new Label();
            lbl4 = new Label();
            SuspendLayout();
            // 
            // dtp
            // 
            dtp.CalendarMonthBackground = SystemColors.InactiveBorder;
            dtp.Location = new Point(12, 45);
            dtp.Name = "dtp";
            dtp.Size = new Size(210, 23);
            dtp.TabIndex = 0;
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(117, 74);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(100, 23);
            txtnumero.TabIndex = 1;
            txtnumero.TextChanged += txtnumero_TextChanged;
            // 
            // cmblist
            // 
            cmblist.FormattingEnabled = true;
            cmblist.Items.AddRange(new object[] { "Basico", "Estandar", "Premiun" });
            cmblist.Location = new Point(117, 107);
            cmblist.Name = "cmblist";
            cmblist.Size = new Size(100, 23);
            cmblist.TabIndex = 2;
            cmblist.SelectedIndexChanged += cmblist_SelectedIndexChanged;
            // 
            // btnregistrar
            // 
            btnregistrar.Location = new Point(117, 136);
            btnregistrar.Name = "btnregistrar";
            btnregistrar.Size = new Size(100, 23);
            btnregistrar.TabIndex = 3;
            btnregistrar.Text = "Registrar";
            btnregistrar.UseVisualStyleBackColor = true;
            btnregistrar.Click += button1_Click;
            // 
            // lstventas
            // 
            lstventas.FormattingEnabled = true;
            lstventas.Location = new Point(12, 165);
            lstventas.Name = "lstventas";
            lstventas.Size = new Size(141, 64);
            lstventas.TabIndex = 4;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(12, 82);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(99, 15);
            lbl2.TabIndex = 5;
            lbl2.Text = "Numero de ticket";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(273, 119);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(0, 15);
            lbl1.TabIndex = 6;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(12, 115);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(31, 15);
            lbl3.TabIndex = 7;
            lbl3.Text = "Tipo";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Location = new Point(12, 27);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(38, 15);
            lbl4.TabIndex = 8;
            lbl4.Text = "Fecha";
            lbl4.Click += lbl4_Click;
            // 
            // ventasregistradas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(256, 235);
            Controls.Add(lbl4);
            Controls.Add(lbl3);
            Controls.Add(lbl1);
            Controls.Add(lbl2);
            Controls.Add(lstventas);
            Controls.Add(btnregistrar);
            Controls.Add(cmblist);
            Controls.Add(txtnumero);
            Controls.Add(dtp);
            Name = "ventasregistradas";
            Text = "ventas";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtp;
        private TextBox txtnumero;
        private ComboBox cmblist;
        private Button btnregistrar;
        private ListBox lstventas;
        private Label lbl2;
        private Label lbl1;
        private Label lbl3;
        private Label lbl4;
    }
}
