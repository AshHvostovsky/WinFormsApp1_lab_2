namespace WinFormsApp1_lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // ������ ��������� ����� �� ������ ��� �������
            this.StartPosition = FormStartPosition.CenterScreen;
            // �������� �������� �� ��������
            txtBoxMoney.Text = Properties.Settings.Default.money_in.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int money_in = 0;
            try
            { // ����������� ����� ���� �������� � �������
                money_in = int.Parse(this.txtBoxMoney.Text);
            }
            catch (FormatException)
            {
                txtBoxMoney.Text = "";
                MessageBox.Show("������� ������� ������", "���������");
                returnFocus();
                return;
            }
            string msg = Logic.GetOutput(money_in);
            // ������� ���������
            MessageBox.Show(msg, "���������");
            returnFocus();

            //  �������� ��������� �������� � ���������
            Properties.Settings.Default.money_in = money_in;
            // ��������� ���������� ��������, ����� ��� �������������� ��� ��������� �������
            Properties.Settings.Default.Save();
        }

        private void returnFocus()
        {
            // ������������� ����� ������� �� ��������� ����
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
            // ������ ������

            string outmessage = "";
            if (money < 1 || money > 9999)
                outmessage = "������� ������� ������";
            else
            {
                int rub, kop = 0;
                rub = money / 100;
                kop = money % 100;
                if (rub % 10 == 1 && rub != 11)
                    outmessage = rub + " ����� ";
                else if ((rub % 10 == 2 || rub % 10 == 3 || rub % 10 == 4) && (rub < 10 || rub > 20))
                    outmessage = rub + " ����� ";
                else if (rub == 0)
                    outmessage = "";
                else
                    outmessage = rub + " ������ ";

                if ((kop % 10 == 2 || kop % 10 == 3 || kop % 10 == 4) && kop > 20)
                    outmessage += kop + " �������";
                else if (kop % 10 == 1 && kop != 11)
                    outmessage += kop + " �������";
                else if (kop == 0)
                    outmessage += "�����";
                else
                    outmessage += kop + " ������";
            }
            // ����� ������
            return outmessage;
        }
    }


}
