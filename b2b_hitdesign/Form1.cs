using System;
using System.Windows.Forms;

namespace b2b_hitdesign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string[] array = this.textBox1.Text.Split(new string[1]
                {
          "\r\n"
                }, StringSplitOptions.None);
                int num1 = Array.IndexOf<string>(array, "쇼핑몰주문번호");
                int num2 = Array.IndexOf<string>(array, "수취인");
                int num3 = Array.IndexOf<string>(array, "주소");
                int num4 = Array.IndexOf<string>(array, "[주문상품 정보]");
                string[] brray = new string[array.Length - 1];
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (i != num3)
                    {
                        brray[i] = array[i];
                    }
                }
                int num5 = Array.IndexOf<string>(brray, "주소");
                string[] strArray = brray[num5 + 1].Split(' ');
                this.textBox6.Text = "▶배송비 선불로 변경 부탁드립니다!\r\n" + array[num1 + 1] + "\r\n[" + array[num2 + 1] + "/" + strArray[1] + " " + strArray[2] + "/" + array[num4 + 2] + " " + array[num4 + 3] + "]\r\n > ";
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string str = textBox2.Text;
                string str1 = str.Substring(str.IndexOf("주문번호 : ") + 7, 16);
                string str2 = str.Substring(str.IndexOf("주문자명(ID)\t") + 9);
                string[] str3 = str2.Split(' ');
                string str4 = str.Substring(str.IndexOf("수령자명\t") + 5, 3);

                textBox6.Text = "▶배송비세금계산서요청입니다!" + "\r\n" + str1 + "\r\n" + str3[0] + "" + str3[1] + "/" + "빈칸" + "/" + str4;

            }
            catch (ArgumentOutOfRangeException argumentOutOfRangeException)
            {
                System.Console.WriteLine($"Error: {argumentOutOfRangeException.Message}");

            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string str = textBox3.Text;
                string str1 = str.Substring(str.IndexOf("주문번호 : ") + 7, 16);
                string month = str1.Substring(4, 2);
                string day = str1.Substring(6, 2);
                string str2 = str.Substring(str.IndexOf("주문자명(ID)\t") + 9);
                string[] str3 = str2.Split(' ');
                string str4 = str.Substring(str.IndexOf("수령자명\t") + 5, 3);
                string str5 = str.Substring(str.IndexOf("환불금액\t") + 5, str.IndexOf("환불 금액 상세\t") - (str.IndexOf("환불금액\t") + 5) - 1);

                textBox6.Text = "▶취소건예치금환불입니다!" + "\r\n" + month + "/" + day + "일결제/" + str3[0] + " " + str3[1] + "/" + str5 + "원/" + str4 + " 고객 취소건예치금환불입니다!";

            }
            catch (ArgumentOutOfRangeException argumentOutOfRangeException)
            {
                System.Console.WriteLine($"Error: {argumentOutOfRangeException.Message}");

            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string[] array = this.textBox1.Text.Split(new string[1]
                {
          "\r\n"
                }, StringSplitOptions.None);
                int num1 = Array.IndexOf<string>(array, "쇼핑몰주문번호");
                int num2 = Array.IndexOf<string>(array, "수취인");
                int num3 = Array.IndexOf<string>(array, "주소");
                int num4 = Array.IndexOf<string>(array, "[주문상품 정보]");
                string[] brray = new string[array.Length - 1];
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (i != num3)
                    {
                        brray[i] = array[i];
                    }
                }
                int num5 = Array.IndexOf<string>(brray, "주소");
                string[] strArray = brray[num5 + 1].Split(' ');
                this.textBox6.Text = "▶금일 발주건 취소로 삭제 부탁드립니다!\r\n" + array[num1 + 1] + "\r\n[" + array[num2 + 1] + "/" + strArray[1] + " " + strArray[2] + "/" + array[num4 + 2] + " " + array[num4 + 3] + "]\r\n > ";
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string[] array = this.textBox1.Text.Split(new string[1]
                {
          "\r\n"
                }, StringSplitOptions.None);
                int num1 = Array.IndexOf<string>(array, "쇼핑몰주문번호");
                int num2 = Array.IndexOf<string>(array, "수취인");
                int num3 = Array.IndexOf<string>(array, "주소");
                int num4 = Array.IndexOf<string>(array, "[주문상품 정보]");
                string[] brray = new string[array.Length - 1];
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (i != num3)
                    {
                        brray[i] = array[i];
                    }
                }
                int num5 = Array.IndexOf<string>(brray, "주소");
                string[] strArray = brray[num5 + 1].Split(' ');
                this.textBox6.Text = "▶금일 발주건 메모 추가 부탁드립니다!\r\n" + array[num1 + 1] + "\r\n[" + array[num2 + 1] + "/" + strArray[1] + " " + strArray[2] + "/" + array[num4 + 2] + " " + array[num4 + 3] + "]\r\n > ";
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
    }
}
