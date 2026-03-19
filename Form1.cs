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

            // 빈 문자열 입력 방지
            if (string.IsNullOrWhiteSpace(typed_msg))
                return;


            // 전송 버튼 클릭 시 TextBox 내용 ListBoxf에 추가
            lstChat.Items.Add(typed_msg);

            // 입력창 비우기 Clear()메서드 사용
            txtMessage.Clear();

            //입력창에 포커스 갖다 놓기
            txtMessage.Focus();




        }

        private void lbTitle_Click(object sender, EventArgs e)
        {

        }

        // 엔터키로 메시지 전송하기 ( 마우스 클릭 대신 )
        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend_Click(null, null); // 버튼 기능 실행
                e.SuppressKeyPress = true; // 줄바꿈 방지
            }
        }
    }
}
