using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Echo_Messenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string typed_msg = txtMessage.Text;

            // 전송 버튼 클릭 시 TextBox 내용 ListBoxf에 추가
            listBox1.Items.Add(typed_msg);  

            // 입력창 비우기
            txtMessage.Clear();

        }
    }
}
