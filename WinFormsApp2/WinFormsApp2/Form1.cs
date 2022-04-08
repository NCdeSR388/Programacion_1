namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblmensaje_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CMBOP.Items.Clear();
            CMBOP.Items.Add("Sumar");
            CMBOP.Items.Add("Restar");
            LISTADVANCE.Items.Clear();
            LISTADVANCE.Items.Add("Multiplicacion");
            LISTADVANCE.Items.Add("Division");
            CMBOP.Enabled = false;
            LISTADVANCE.Enabled = false;
        }


        private void RBTN1_CheckedChanged(object sender, EventArgs e)
        {
            if(RBTN1.Checked)
            {
                CMBOP.Enabled=true;
                CMBOP.Text = "";
                LISTADVANCE.Enabled = false;
            }
            else
            {
                CMBOP.Enabled=false;
                CMBOP.Text = "";
                LISTADVANCE.Enabled = true;
            }
        }

      

        private void btnSalir_MouseMove(object sender, MouseEventArgs e)
        {
            btnSalir.BackColor = Color.YellowGreen;
            btnSalir.ForeColor = Color.Red;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.White;
            btnSalir.ForeColor = Color.Red;
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.Aqua;
            btnSalir.ForeColor = Color.Red;
        }

        private void btncalcular_MouseLeave(object sender, EventArgs e)
        {
            btncalcular.BackColor = Color.Blue;
            btncalcular.ForeColor = Color.Red;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
           // btncalcular.BackColor = Color.White;
           // btnSalir.BackColor = Color.White;
        }
        //valida primer cuadro de texto
        private void txtn1_KeyPress(object sender, KeyPressEventArgs e)
        {
           if(e.KeyChar<48 || e.KeyChar >57)
            {
                txtn1.BackColor = Color.Red;
                txtn1.Text = "";
            }
            else
            {

                txtn1.BackColor = Color.White;
            }

        }
        //valida primer cuadro de texto
        private void txtn1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue < 48 || e.KeyValue > 57)
            {
                txtn1.BackColor = Color.Red;
                txtn1.Text = "";
            }
            else
            {

                txtn1.BackColor = Color.White;
            }
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            
            if (txtn1.Text!="" &&txtn2.Text!="" &&LISTADVANCE.SelectedItem!="" )
            {
                int n1 = int.Parse(txtn1.Text);
                int n2 = int.Parse(txtn2.Text);

                if (RBTN1.Checked && CMBOP.Text!="" && CMBOP.Text=="Sumar")
                {  int res = n1+ n2;
                    LBLRESULT.Text=res.ToString();
                    LBLRESULT.Visible = true;
                    LBLRESULT.ForeColor=Color.Red;
                }
                if (RBTN1.Checked && CMBOP.Text != "" && CMBOP.Text == "Restar")
                {
                    int res = n1 - n2;
                    LBLRESULT.Text = res.ToString();
                    LBLRESULT.Visible = true;
                    LBLRESULT.ForeColor = Color.Red;
                }
                if (LISTADVANCE.SelectedItem == "Multiplicacion")
                {
                    int mult = n1 * n2;
                    LBLRESULT.Text = mult.ToString();
                    LBLRESULT.Visible = true;
                    LBLRESULT.ForeColor = Color.Blue;
                }
                if (LISTADVANCE.SelectedItem == "Division")
                {
                    float div = n1 / n2;
                    LBLRESULT.Text = div.ToString();
                    LBLRESULT.Visible = true;
                    LBLRESULT.ForeColor = Color.Blue;
                }

            }
        }

       
    }
}