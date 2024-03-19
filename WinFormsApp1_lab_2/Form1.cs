namespace WinFormsApp1_lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Ставим положение формы по центру при запуске
            this.StartPosition = FormStartPosition.CenterScreen;
            // считывем значения из настроек
            txtBoxMoney.Text = Properties.Settings.Default.money_in.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int money_in = 0;
            try
            { // оборачиваем кусок кода склонный к падению
                money_in = int.Parse(this.txtBoxMoney.Text);
            }
            catch (FormatException)
            {
                txtBoxMoney.Text = "";
                MessageBox.Show("Неверно введены данные", "Результат");
                returnFocus();
                return;
            }
            string msg = Logic.GetOutput(money_in);
            // выведем сообщение
            MessageBox.Show(msg, "Результат");
            returnFocus();

            //  передаем введенные значения в параметры
            Properties.Settings.Default.money_in = money_in;
            // сохраняем переданные значения, чтобы они восстановились пре очередном запуске
            Properties.Settings.Default.Save();
        }

        private void returnFocus()
        {
            // Устанавливаем фокус обратно на текстовое поле
            txtBoxMoney.Focus(); 
        }

        private void txtBoxMoney_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //button1_Click(this, e);
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txtBoxMoney.Text = "";
        }
    }
    public class Logic
    {
        public static string GetOutput(int money)
        {
            // НАЧАЛО логики

            string outmessage = "";
            if (money < 1 || money > 9999)
                outmessage = "Неверно введены данные";
            else
            {
                int rub, kop = 0;
                rub = money / 100;
                kop = money % 100;
                if (rub % 10 == 1 && rub != 11)
                    outmessage = rub + " Рубль ";
                else if ((rub % 10 == 2 || rub % 10 == 3 || rub % 10 == 4) && (rub < 10 || rub > 20))
                    outmessage = rub + " Рубля ";
                else if (rub == 0)
                    outmessage = "";
                else
                    outmessage = rub + " Рублей ";

                if ((kop % 10 == 2 || kop % 10 == 3 || kop % 10 == 4) && kop > 20)
                    outmessage += kop + " Копейки";
                else if (kop % 10 == 1 && kop != 11)
                    outmessage += kop + " Копейка";
                else if (kop == 0)
                    outmessage += "ровно";
                else
                    outmessage += kop + " Копеек";
            }
            // КОНЕЦ логики
            return outmessage;
        }
    }


}
