namespace WinFormsApp2
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
            this.btncalcular = new System.Windows.Forms.Button();
            this.LBLN1 = new System.Windows.Forms.Label();
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblalerta = new System.Windows.Forms.Label();
            this.LBLN2 = new System.Windows.Forms.Label();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.CMBOP = new System.Windows.Forms.ComboBox();
            this.LISTADVANCE = new System.Windows.Forms.ListBox();
            this.RBTN1 = new System.Windows.Forms.RadioButton();
            this.RBTN2 = new System.Windows.Forms.RadioButton();
            this.LBLRESULT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncalcular.Location = new System.Drawing.Point(161, 240);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(132, 46);
            this.btncalcular.TabIndex = 0;
            this.btncalcular.Text = "CALCULAR";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            this.btncalcular.MouseLeave += new System.EventHandler(this.btncalcular_MouseLeave);
            // 
            // LBLN1
            // 
            this.LBLN1.AutoSize = true;
            this.LBLN1.Location = new System.Drawing.Point(108, 106);
            this.LBLN1.Name = "LBLN1";
            this.LBLN1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LBLN1.Size = new System.Drawing.Size(28, 20);
            this.LBLN1.TabIndex = 1;
            this.LBLN1.Text = "N1";
            this.LBLN1.Click += new System.EventHandler(this.lblmensaje_Click);
            // 
            // txtn1
            // 
            this.txtn1.Location = new System.Drawing.Point(238, 106);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(125, 27);
            this.txtn1.TabIndex = 2;
            this.txtn1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtn1_KeyPress);
            this.txtn1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtn1_KeyUp);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(349, 240);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 46);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            this.btnSalir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnSalir_MouseMove);
            // 
            // lblalerta
            // 
            this.lblalerta.AutoSize = true;
            this.lblalerta.Location = new System.Drawing.Point(271, 289);
            this.lblalerta.Name = "lblalerta";
            this.lblalerta.Size = new System.Drawing.Size(0, 20);
            this.lblalerta.TabIndex = 4;
            // 
            // LBLN2
            // 
            this.LBLN2.AutoSize = true;
            this.LBLN2.Location = new System.Drawing.Point(108, 143);
            this.LBLN2.Name = "LBLN2";
            this.LBLN2.Size = new System.Drawing.Size(28, 20);
            this.LBLN2.TabIndex = 5;
            this.LBLN2.Text = "N2";
            // 
            // txtn2
            // 
            this.txtn2.Location = new System.Drawing.Point(238, 143);
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(125, 27);
            this.txtn2.TabIndex = 6;
            // 
            // CMBOP
            // 
            this.CMBOP.FormattingEnabled = true;
            this.CMBOP.Location = new System.Drawing.Point(420, 108);
            this.CMBOP.Name = "CMBOP";
            this.CMBOP.Size = new System.Drawing.Size(151, 28);
            this.CMBOP.TabIndex = 7;
            // 
            // LISTADVANCE
            // 
            this.LISTADVANCE.FormattingEnabled = true;
            this.LISTADVANCE.ItemHeight = 20;
            this.LISTADVANCE.Location = new System.Drawing.Point(572, 157);
            this.LISTADVANCE.Name = "LISTADVANCE";
            this.LISTADVANCE.Size = new System.Drawing.Size(150, 104);
            this.LISTADVANCE.TabIndex = 8;
            // 
            // RBTN1
            // 
            this.RBTN1.AutoSize = true;
            this.RBTN1.Location = new System.Drawing.Point(423, 53);
            this.RBTN1.Name = "RBTN1";
            this.RBTN1.Size = new System.Drawing.Size(78, 24);
            this.RBTN1.TabIndex = 9;
            this.RBTN1.TabStop = true;
            this.RBTN1.Text = "Basicas";
            this.RBTN1.UseVisualStyleBackColor = true;
            this.RBTN1.CheckedChanged += new System.EventHandler(this.RBTN1_CheckedChanged);
            // 
            // RBTN2
            // 
            this.RBTN2.AutoSize = true;
            this.RBTN2.Location = new System.Drawing.Point(599, 56);
            this.RBTN2.Name = "RBTN2";
            this.RBTN2.Size = new System.Drawing.Size(101, 24);
            this.RBTN2.TabIndex = 10;
            this.RBTN2.TabStop = true;
            this.RBTN2.Text = "Avanzadas";
            this.RBTN2.UseVisualStyleBackColor = true;
            // 
            // LBLRESULT
            // 
            this.LBLRESULT.AutoSize = true;
            this.LBLRESULT.Location = new System.Drawing.Point(461, 333);
            this.LBLRESULT.Name = "LBLRESULT";
            this.LBLRESULT.Size = new System.Drawing.Size(50, 20);
            this.LBLRESULT.TabIndex = 11;
            this.LBLRESULT.Text = "label1";
            this.LBLRESULT.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBLRESULT);
            this.Controls.Add(this.RBTN2);
            this.Controls.Add(this.RBTN1);
            this.Controls.Add(this.LISTADVANCE);
            this.Controls.Add(this.CMBOP);
            this.Controls.Add(this.txtn2);
            this.Controls.Add(this.LBLN2);
            this.Controls.Add(this.lblalerta);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtn1);
            this.Controls.Add(this.LBLN1);
            this.Controls.Add(this.btncalcular);
            this.Name = "Form1";
            this.Text = "Mi primer formulario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btncalcular;
        private Label LBLN1;
        private TextBox txtn1;
        private Button btnSalir;
        private Label lblalerta;
        private Label LBLN2;
        private TextBox txtn2;
        private ComboBox CMBOP;
        private ListBox LISTADVANCE;
        private RadioButton RBTN1;
        private RadioButton RBTN2;
        private Label LBLRESULT;
    }
}