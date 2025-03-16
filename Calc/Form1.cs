namespace Calc
{
    public partial class Form1 : Form
    {

        double plus, minus, mnozh, delit, modul, b;


        public Form1()
        {
            InitializeComponent();
            label1.Text = " ";

            //label1.FlatAppearance.BorderSize = 0; // Убираем границы

            // Настройка кнопки
            button1.FlatStyle = FlatStyle.Flat; // Убираем стандартный стиль
            button1.BackColor = Color.Transparent; // Делаем фон кнопки прозрачным
            button1.ForeColor = Color.Transparent; // Делаем текст кнопки прозрачным
            button1.FlatAppearance.BorderSize = 0; // Убираем границы
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent; // Убираем эффект наведения
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent; // Убираем эффект нажатия

            // Настройка кнопки
            button2.FlatStyle = FlatStyle.Flat; // Убираем стандартный стиль
            button2.BackColor = Color.Transparent; // Делаем фон кнопки прозрачным
            button2.ForeColor = Color.Transparent; // Делаем текст кнопки прозрачным
            button2.FlatAppearance.BorderSize = 0; // Убираем границы
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent; // Убираем эффект наведения
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent; // Убираем эффект нажатия

            // Настройка кнопки
            button3.FlatStyle = FlatStyle.Flat; // Убираем стандартный стиль
            button3.BackColor = Color.Transparent; // Делаем фон кнопки прозрачным
            button3.ForeColor = Color.Transparent; // Делаем текст кнопки прозрачным
            button3.FlatAppearance.BorderSize = 0; // Убираем границы
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent; // Убираем эффект наведения
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent; // Убираем эффект нажатия

            // Настройка кнопки
            button4.FlatStyle = FlatStyle.Flat; // Убираем стандартный стиль
            button4.BackColor = Color.Transparent; // Делаем фон кнопки прозрачным
            button4.ForeColor = Color.Transparent; // Делаем текст кнопки прозрачным
            button4.FlatAppearance.BorderSize = 0; // Убираем границы
            button4.FlatAppearance.MouseOverBackColor = Color.Transparent; // Убираем эффект наведения
            button4.FlatAppearance.MouseDownBackColor = Color.Transparent; // Убираем эффект нажатия

            // Настройка кнопки
            button5.FlatStyle = FlatStyle.Flat; // Убираем стандартный стиль
            button5.BackColor = Color.Transparent; // Делаем фон кнопки прозрачным
            button5.ForeColor = Color.Transparent; // Делаем текст кнопки прозрачным
            button5.FlatAppearance.BorderSize = 0; // Убираем границы
            button5.FlatAppearance.MouseOverBackColor = Color.Transparent; // Убираем эффект наведения
            button5.FlatAppearance.MouseDownBackColor = Color.Transparent; // Убираем эффект нажатия

            // Настройка кнопки
            button6.FlatStyle = FlatStyle.Flat; // Убираем стандартный стиль
            button6.BackColor = Color.Transparent; // Делаем фон кнопки прозрачным
            button6.ForeColor = Color.Transparent; // Делаем текст кнопки прозрачным
            button6.FlatAppearance.BorderSize = 0; // Убираем границы
            button6.FlatAppearance.MouseOverBackColor = Color.Transparent; // Убираем эффект наведения
            button6.FlatAppearance.MouseDownBackColor = Color.Transparent; // Убираем эффект нажатия// Настройка кнопки

            // Настройка кнопки
            button7.FlatStyle = FlatStyle.Flat; // Убираем стандартный стиль
            button7.BackColor = Color.Transparent; // Делаем фон кнопки прозрачным
            button7.ForeColor = Color.Transparent; // Делаем текст кнопки прозрачным
            button7.FlatAppearance.BorderSize = 0; // Убираем границы
            button7.FlatAppearance.MouseOverBackColor = Color.Transparent; // Убираем эффект наведения
            button7.FlatAppearance.MouseDownBackColor = Color.Transparent; // Убираем эффект нажатия

            // Настройка кнопки
            button8.FlatStyle = FlatStyle.Flat; // Убираем стандартный стиль
            button8.BackColor = Color.Transparent; // Делаем фон кнопки прозрачным
            button8.ForeColor = Color.Transparent; // Делаем текст кнопки прозрачным
            button8.FlatAppearance.BorderSize = 0; // Убираем границы
            button8.FlatAppearance.MouseOverBackColor = Color.Transparent; // Убираем эффект наведения
            button8.FlatAppearance.MouseDownBackColor = Color.Transparent; // Убираем эффект нажатия

            // Настройка кнопки
            button9.FlatStyle = FlatStyle.Flat; // Убираем стандартный стиль
            button9.BackColor = Color.Transparent; // Делаем фон кнопки прозрачным
            button9.ForeColor = Color.Transparent; // Делаем текст кнопки прозрачным
            button9.FlatAppearance.BorderSize = 0; // Убираем границы
            button9.FlatAppearance.MouseOverBackColor = Color.Transparent; // Убираем эффект наведения
            button9.FlatAppearance.MouseDownBackColor = Color.Transparent; // Убираем эффект нажатия


            // ЗНАКИ
            // Настройка кнопки
            button10.FlatStyle = FlatStyle.Flat; // Убираем стандартный стиль
            button10.BackColor = Color.Transparent; // Делаем фон кнопки прозрачным
            button10.ForeColor = Color.Transparent; // Делаем текст кнопки прозрачным
            button10.FlatAppearance.BorderSize = 0; // Убираем границы
            button10.FlatAppearance.MouseOverBackColor = Color.Transparent; // Убираем эффект наведения
            button10.FlatAppearance.MouseDownBackColor = Color.Transparent; // Убираем эффект нажатия

            // Настройка кнопки
            button11.FlatStyle = FlatStyle.Flat; // Убираем стандартный стиль
            button11.BackColor = Color.Transparent; // Делаем фон кнопки прозрачным
            button11.ForeColor = Color.Transparent; // Делаем текст кнопки прозрачным
            button11.FlatAppearance.BorderSize = 0; // Убираем границы
            button11.FlatAppearance.MouseOverBackColor = Color.Transparent; // Убираем эффект наведения
            button11.FlatAppearance.MouseDownBackColor = Color.Transparent; // Убираем эффект нажатия

            // Настройка кнопки
            button12.FlatStyle = FlatStyle.Flat; // Убираем стандартный стиль
            button12.BackColor = Color.Transparent; // Делаем фон кнопки прозрачным
            button12.ForeColor = Color.Transparent; // Делаем текст кнопки прозрачным
            button12.FlatAppearance.BorderSize = 0; // Убираем границы
            button12.FlatAppearance.MouseOverBackColor = Color.Transparent; // Убираем эффект наведения
            button12.FlatAppearance.MouseDownBackColor = Color.Transparent; // Убираем эффект нажатия

            // Настройка кнопки
            button13_delit.FlatStyle = FlatStyle.Flat; // Убираем стандартный стиль
            button13_delit.BackColor = Color.Transparent; // Делаем фон кнопки прозрачным
            button13_delit.ForeColor = Color.Transparent; // Делаем текст кнопки прозрачным
            button13_delit.FlatAppearance.BorderSize = 0; // Убираем границы
            button13_delit.FlatAppearance.MouseOverBackColor = Color.Transparent; // Убираем эффект наведения
            button13_delit.FlatAppearance.MouseDownBackColor = Color.Transparent; // Убираем эффект нажатия


            // Настройка кнопки
            button14_result.FlatStyle = FlatStyle.Flat; // Убираем стандартный стиль
            button14_result.BackColor = Color.Transparent; // Делаем фон кнопки прозрачным
            button14_result.ForeColor = Color.Transparent; // Делаем текст кнопки прозрачным
            button14_result.FlatAppearance.BorderSize = 0; // Убираем границы
            button14_result.FlatAppearance.MouseOverBackColor = Color.Transparent; // Убираем эффект наведения
            button14_result.FlatAppearance.MouseDownBackColor = Color.Transparent; // Убираем эффект нажатия

            // Настройка кнопки
            button17_zero.FlatStyle = FlatStyle.Flat; // Убираем стандартный стиль
            button17_zero.BackColor = Color.Transparent; // Делаем фон кнопки прозрачным
            button17_zero.ForeColor = Color.Transparent; // Делаем текст кнопки прозрачным
            button17_zero.FlatAppearance.BorderSize = 0; // Убираем границы
            button17_zero.FlatAppearance.MouseOverBackColor = Color.Transparent; // Убираем эффект наведения
            button17_zero.FlatAppearance.MouseDownBackColor = Color.Transparent; // Убираем эффект нажатия

            // Настройка кнопки
            button13_float.FlatStyle = FlatStyle.Flat; // Убираем стандартный стиль
            button13_float.BackColor = Color.Transparent; // Делаем фон кнопки прозрачным
            button13_float.ForeColor = Color.Transparent; // Делаем текст кнопки прозрачным
            button13_float.FlatAppearance.BorderSize = 0; // Убираем границы
            button13_float.FlatAppearance.MouseOverBackColor = Color.Transparent; // Убираем эффект наведения
            button13_float.FlatAppearance.MouseDownBackColor = Color.Transparent; // Убираем эффект нажатия



            // Настройка кнопки
            button15_clean.FlatStyle = FlatStyle.Flat; // Убираем стандартный стиль
            //button15_clean.BackColor = Color.Transparent; // Делаем фон кнопки прозрачным
            button15_clean.ForeColor = Color.Transparent; // Делаем текст кнопки прозрачным
            button15_clean.FlatAppearance.BorderSize = 0; // Убираем границы
            button15_clean.FlatAppearance.MouseOverBackColor = Color.Transparent; // Убираем эффект наведения
            button15_clean.FlatAppearance.MouseDownBackColor = Color.Transparent; // Убираем эффект нажатия





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
            // Очищаем дисплей
            label1.Text = " ";

            // Сбрасываем все переменные
            //plus = 0;
            //minus = 0;
            //mnozh = 0;
            //delit = 0;
        }







        // ЗНАКИ
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
