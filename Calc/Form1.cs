namespace Calc
{
    public partial class Form1 : Form
    {

        double plus, minus, mnozh, delit, modul, b;


        public Form1()
        {
            InitializeComponent();
            label1.Text = " ";

            //label1.FlatAppearance.BorderSize = 0; // ������� �������

            // ��������� ������
            button1.FlatStyle = FlatStyle.Flat; // ������� ����������� �����
            button1.BackColor = Color.Transparent; // ������ ��� ������ ����������
            button1.ForeColor = Color.Transparent; // ������ ����� ������ ����������
            button1.FlatAppearance.BorderSize = 0; // ������� �������
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent; // ������� ������ ���������
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent; // ������� ������ �������

            // ��������� ������
            button2.FlatStyle = FlatStyle.Flat; // ������� ����������� �����
            button2.BackColor = Color.Transparent; // ������ ��� ������ ����������
            button2.ForeColor = Color.Transparent; // ������ ����� ������ ����������
            button2.FlatAppearance.BorderSize = 0; // ������� �������
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent; // ������� ������ ���������
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent; // ������� ������ �������

            // ��������� ������
            button3.FlatStyle = FlatStyle.Flat; // ������� ����������� �����
            button3.BackColor = Color.Transparent; // ������ ��� ������ ����������
            button3.ForeColor = Color.Transparent; // ������ ����� ������ ����������
            button3.FlatAppearance.BorderSize = 0; // ������� �������
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent; // ������� ������ ���������
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent; // ������� ������ �������

            // ��������� ������
            button4.FlatStyle = FlatStyle.Flat; // ������� ����������� �����
            button4.BackColor = Color.Transparent; // ������ ��� ������ ����������
            button4.ForeColor = Color.Transparent; // ������ ����� ������ ����������
            button4.FlatAppearance.BorderSize = 0; // ������� �������
            button4.FlatAppearance.MouseOverBackColor = Color.Transparent; // ������� ������ ���������
            button4.FlatAppearance.MouseDownBackColor = Color.Transparent; // ������� ������ �������

            // ��������� ������
            button5.FlatStyle = FlatStyle.Flat; // ������� ����������� �����
            button5.BackColor = Color.Transparent; // ������ ��� ������ ����������
            button5.ForeColor = Color.Transparent; // ������ ����� ������ ����������
            button5.FlatAppearance.BorderSize = 0; // ������� �������
            button5.FlatAppearance.MouseOverBackColor = Color.Transparent; // ������� ������ ���������
            button5.FlatAppearance.MouseDownBackColor = Color.Transparent; // ������� ������ �������

            // ��������� ������
            button6.FlatStyle = FlatStyle.Flat; // ������� ����������� �����
            button6.BackColor = Color.Transparent; // ������ ��� ������ ����������
            button6.ForeColor = Color.Transparent; // ������ ����� ������ ����������
            button6.FlatAppearance.BorderSize = 0; // ������� �������
            button6.FlatAppearance.MouseOverBackColor = Color.Transparent; // ������� ������ ���������
            button6.FlatAppearance.MouseDownBackColor = Color.Transparent; // ������� ������ �������// ��������� ������

            // ��������� ������
            button7.FlatStyle = FlatStyle.Flat; // ������� ����������� �����
            button7.BackColor = Color.Transparent; // ������ ��� ������ ����������
            button7.ForeColor = Color.Transparent; // ������ ����� ������ ����������
            button7.FlatAppearance.BorderSize = 0; // ������� �������
            button7.FlatAppearance.MouseOverBackColor = Color.Transparent; // ������� ������ ���������
            button7.FlatAppearance.MouseDownBackColor = Color.Transparent; // ������� ������ �������

            // ��������� ������
            button8.FlatStyle = FlatStyle.Flat; // ������� ����������� �����
            button8.BackColor = Color.Transparent; // ������ ��� ������ ����������
            button8.ForeColor = Color.Transparent; // ������ ����� ������ ����������
            button8.FlatAppearance.BorderSize = 0; // ������� �������
            button8.FlatAppearance.MouseOverBackColor = Color.Transparent; // ������� ������ ���������
            button8.FlatAppearance.MouseDownBackColor = Color.Transparent; // ������� ������ �������

            // ��������� ������
            button9.FlatStyle = FlatStyle.Flat; // ������� ����������� �����
            button9.BackColor = Color.Transparent; // ������ ��� ������ ����������
            button9.ForeColor = Color.Transparent; // ������ ����� ������ ����������
            button9.FlatAppearance.BorderSize = 0; // ������� �������
            button9.FlatAppearance.MouseOverBackColor = Color.Transparent; // ������� ������ ���������
            button9.FlatAppearance.MouseDownBackColor = Color.Transparent; // ������� ������ �������


            // �����
            // ��������� ������
            button10.FlatStyle = FlatStyle.Flat; // ������� ����������� �����
            button10.BackColor = Color.Transparent; // ������ ��� ������ ����������
            button10.ForeColor = Color.Transparent; // ������ ����� ������ ����������
            button10.FlatAppearance.BorderSize = 0; // ������� �������
            button10.FlatAppearance.MouseOverBackColor = Color.Transparent; // ������� ������ ���������
            button10.FlatAppearance.MouseDownBackColor = Color.Transparent; // ������� ������ �������

            // ��������� ������
            button11.FlatStyle = FlatStyle.Flat; // ������� ����������� �����
            button11.BackColor = Color.Transparent; // ������ ��� ������ ����������
            button11.ForeColor = Color.Transparent; // ������ ����� ������ ����������
            button11.FlatAppearance.BorderSize = 0; // ������� �������
            button11.FlatAppearance.MouseOverBackColor = Color.Transparent; // ������� ������ ���������
            button11.FlatAppearance.MouseDownBackColor = Color.Transparent; // ������� ������ �������

            // ��������� ������
            button12.FlatStyle = FlatStyle.Flat; // ������� ����������� �����
            button12.BackColor = Color.Transparent; // ������ ��� ������ ����������
            button12.ForeColor = Color.Transparent; // ������ ����� ������ ����������
            button12.FlatAppearance.BorderSize = 0; // ������� �������
            button12.FlatAppearance.MouseOverBackColor = Color.Transparent; // ������� ������ ���������
            button12.FlatAppearance.MouseDownBackColor = Color.Transparent; // ������� ������ �������

            // ��������� ������
            button13_delit.FlatStyle = FlatStyle.Flat; // ������� ����������� �����
            button13_delit.BackColor = Color.Transparent; // ������ ��� ������ ����������
            button13_delit.ForeColor = Color.Transparent; // ������ ����� ������ ����������
            button13_delit.FlatAppearance.BorderSize = 0; // ������� �������
            button13_delit.FlatAppearance.MouseOverBackColor = Color.Transparent; // ������� ������ ���������
            button13_delit.FlatAppearance.MouseDownBackColor = Color.Transparent; // ������� ������ �������


            // ��������� ������
            button14_result.FlatStyle = FlatStyle.Flat; // ������� ����������� �����
            button14_result.BackColor = Color.Transparent; // ������ ��� ������ ����������
            button14_result.ForeColor = Color.Transparent; // ������ ����� ������ ����������
            button14_result.FlatAppearance.BorderSize = 0; // ������� �������
            button14_result.FlatAppearance.MouseOverBackColor = Color.Transparent; // ������� ������ ���������
            button14_result.FlatAppearance.MouseDownBackColor = Color.Transparent; // ������� ������ �������

            // ��������� ������
            button17_zero.FlatStyle = FlatStyle.Flat; // ������� ����������� �����
            button17_zero.BackColor = Color.Transparent; // ������ ��� ������ ����������
            button17_zero.ForeColor = Color.Transparent; // ������ ����� ������ ����������
            button17_zero.FlatAppearance.BorderSize = 0; // ������� �������
            button17_zero.FlatAppearance.MouseOverBackColor = Color.Transparent; // ������� ������ ���������
            button17_zero.FlatAppearance.MouseDownBackColor = Color.Transparent; // ������� ������ �������

            // ��������� ������
            button13_float.FlatStyle = FlatStyle.Flat; // ������� ����������� �����
            button13_float.BackColor = Color.Transparent; // ������ ��� ������ ����������
            button13_float.ForeColor = Color.Transparent; // ������ ����� ������ ����������
            button13_float.FlatAppearance.BorderSize = 0; // ������� �������
            button13_float.FlatAppearance.MouseOverBackColor = Color.Transparent; // ������� ������ ���������
            button13_float.FlatAppearance.MouseDownBackColor = Color.Transparent; // ������� ������ �������



            // ��������� ������
            button15_clean.FlatStyle = FlatStyle.Flat; // ������� ����������� �����
            //button15_clean.BackColor = Color.Transparent; // ������ ��� ������ ����������
            button15_clean.ForeColor = Color.Transparent; // ������ ����� ������ ����������
            button15_clean.FlatAppearance.BorderSize = 0; // ������� �������
            button15_clean.FlatAppearance.MouseOverBackColor = Color.Transparent; // ������� ������ ���������
            button15_clean.FlatAppearance.MouseDownBackColor = Color.Transparent; // ������� ������ �������





        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += this.button1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text += this.button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text += this.button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text += this.button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text += this.button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text += this.button6.Text;
        }

        private void button17_zero_Click(object sender, EventArgs e)
        {
            label1.Text += this.button17_zero.Text;
        }


        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text += this.button13_float.Text;
        }


        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text += this.button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text += this.button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text += this.button9.Text;
        }





        private void button15_clean_Click(object sender, EventArgs e)
        {
            //label1.Text = "";
            // ������� �������
            label1.Text = " ";

            // ���������� ��� ����������
            //plus = 0;
            //minus = 0;
            //mnozh = 0;
            //delit = 0;
        }







        // �����
        private void button10_Click(object sender, EventArgs e)
        {
            plus = Convert.ToDouble(label1.Text);
            label1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            minus = Convert.ToDouble(label1.Text);
            label1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            mnozh = Convert.ToDouble(label1.Text);
            label1.Text = "";
        }

        private void button13_delit_Click(object sender, EventArgs e)
        {
            delit = Convert.ToDouble(label1.Text);
            label1.Text = "";
        }

        private void button16_mod_Click(object sender, EventArgs e)
        {
            modul = Convert.ToDouble(label1.Text);
            label1.Text = "";
        }







        private void button14_result_Click(object sender, EventArgs e)
        {
            if (plus != 0)
            {
                b = Convert.ToDouble(label1.Text);
                label1.Text = Convert.ToString(plus + b);
            }

            else if (minus != 0)
            {
                b = Convert.ToDouble(label1.Text);
                label1.Text = Convert.ToString(minus - b);
            }
            else if (mnozh != 0)
            {
                b = Convert.ToDouble(label1.Text);
                label1.Text = Convert.ToString(mnozh * b);
            }
            else if (delit != 0)
            {
                b = Convert.ToDouble(label1.Text);
                label1.Text = Convert.ToString(delit / b);
            }
            else if (modul != 0)
            {
                b = Convert.ToDouble(label1.Text);
                label1.Text = Convert.ToString(modul % b);
            }


        }

        
    }
}
