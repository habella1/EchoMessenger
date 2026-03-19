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
            //문자열 정제 (양쪽 공백 제거)
            string typed_msg = txtMessage.Text.Trim();

            // 빈 문자열 입력 방지
            if (string.IsNullOrWhiteSpace(typed_msg))
                return;

            // 타임스탬프에서 출력
            // 전송 버튼 클릭 시 TextBox 내용 ListBoxf에 추가
            //lstChat.Items.Add(typed_msg);



            // 타임스탬프 추가
            string time = DateTime.Now.ToString("HH:mm:ss");
            string result = $"[{time}] {typed_msg}";

            // 글자 수 제한
            if (typed_msg.Length > 50)
            {
                MessageBox.Show("50자 이하로 입력하세요!");
                return;
            }

            lstChat.Items.Add(result);  //리스트에 추가 

            //메시지 개수 표시
            lbCount.Text = "현재 대화: " + lstChat.Items.Count + "개";

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

        private void lbCount_Click(object sender, EventArgs e)
        {

        }

        //선택한 메시지 삭제하기
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 선택 안 했을 때 발생하는 에러 예외 처리
            if (lstChat.SelectedIndex == -1)
            {
                MessageBox.Show("삭제할 메시지를 선택하세요!");
                return;
            }

            lstChat.Items.RemoveAt(lstChat.SelectedIndex);

            // 개수 업데이트
            lbCount.Text = "현재 대화: " + lstChat.Items.Count + "개";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstChat.Items.Clear();

            // 개수 초기화
            lbCount.Text = "현재 대화: 0개";
        }
    }
}
