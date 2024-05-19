using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogIn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string id = ID.Text;
            string pw = PW.Text;

            if (id.Equals("user") && PW.Equals("userpassword"))
            {
                MessageBox.Show("로그인 성공", "로그인");
            }
            else
            {
                MessageBox.Show("로그인 실패", "로그인");
            }
        }

        // 1. ID와 PW를 입력받음
        // -> TEXTBOX를 이용하여 사용자에게 입력받기
        // 2. 아이디와 패스워드 확인
        // -> 조건문과 .Eauals 이용하여 아이디와 패스워드를 각각 확인
        // 3. 성공 혹은 실패
        // -> messagebox를 이용하여 로그인 성공 혹은 로그인 실패를 사용자에게 알려줌

        // messagebox
        // 사용자에게 보여줄 메시지 창을 표시함
        // 사용자가 닫을 때까지 앱의 다른 동작 차단
        // 사용자에게 필요한 정보를 제공하는 텍스트, 기호 등을 포함
        // MessageBox.Show("message", "caption",
        //                  MessageBoxButtons.YesNo,
        //                  MessageBoxIcon.Question);

        // .Show: 사용자에게 messagebox출력
        // .message: 사용자에게 보여줄 메시지

        // 생략 가능한 파라미터
        // .caption: 사용자에게 보여줄 메시지의 타이틀
        // MessageBoxButtons: 사용자에게 보여줄 대화상자의 종류
        // MessageBoxIcon: 사용자에게 보여줄 아이콘

        // OK: 메시지박스에 확인 버튼
        // Cancel: 메시지박스에 취소버튼
        // YesNo: 메시지박스에 예, 아니오 단추 포함
        // Cancel: 예, 아니오, 취소버튼
        // Retry: 다시 시도
        // Abort: 중단
        // Ignore: 무시

    }
}
