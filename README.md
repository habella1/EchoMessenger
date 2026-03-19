# 3주차 과제: (C# 코딩) Echo Messenger (데이터 입력 처리 및텍스트 문자열(String) 처리방법)
-이름: 하다현 (24018097)
-핵심기능: 

## 개요
- C# 프로그래밍 학습
- 1줄 소개: 사용자로부터 키보드 입력을 받아서 처리하는 프로그램
- 사용한 플랫폼: C#, .NET Windows Forms, Visual Studio, GitHub
- 사용한 컨트롤: Label, TextBox, ListBox, Button
- 사용한 기술과 구현한 기능:
  - Visual Studio를 이용하여 UI 디자인
  - string 클래스를 이용한 사용자 입력 데이터 처리
  - DateTime 클래스를 이용한 현재시간 정보 구하기

## 기능 설명
1단계 - 기본 UI 및 데이터 연동
  1. UI구성: Label로 Echo Messenger 만들기, 전송 Button 만들기, 입력할 TextBox 만들기, ListBox 대화창 만들기
  2. 전송 기능: 전송btn 누르면 TextBox의 텍스트를 ListBox 항목으로 추가함.
  3. 입력창 정리: ListBox에 추가한 내용을 비워 다음 입력을 준비함.

2단계 - 사용자 편의성(UX) 강화
  1. 전송이 끝나면 TextBox에 남겨진 기존 메시지 삭제
  2. 전송 후, 마우스로 TextBox를 다시 클릭하지 않아도 되도록 커서를 자동으로 입력창에 가도록 함.
  3. 마우스 클릭 대신 키보드 Enter 키 눌러도 메시지 전송되도록 함.
  4. 공백이 입력되면 메시지 전송되지 않도록 방지함.

3단계 - 데이터 가공 및 상태 표시
  1. 메시지 앞에 현재 시간( [HH:mm:ss] ) 붙여서 ListBox에 출력
     cf) < 날짜 데이터 출력 방법 >
      y: 년 (Year) / yy (26), yyyy (2026)
      M: 월 (Month) / MM (03), MMM (Mar), MMMM (March)
      d: 일 (Day) / dd (18), ddd (수), dddd (수요일)
      H: 시간(24시간) / h: 시간(12시간)
      m: 분 (Minute)
      s: 초 (Second)
      tt: 오전/오후 (AM/PM)

      ex) DateTime now = DateTime.Now;
          Console.WriteLine($"현재 시각: {now:yyyy-MM-dd HH:mm:ss}");
        
  3. 현재 ListBox에 쌓인 총 메시지 개수 count해 하단 Label에 실시간 업데이트하기( ex)현재 대화: n개 )
  4. 사용자가 입력한 메시지의 앞뒤 불필요한 공백을 Trim() 함수로 제거해 저장
     cf) Trim() 함수 사용 방법: string data = " 20260318 ";
                               string clean = data.Trim(); // *공백 제거
                               string year = clean.Substring(0, 4); // "2026" // +)특정 부분만 추출
     

## 실행 화면
- 1단계 코드의 실행 스크린샷
  <img width="804" height="504" alt="스크린샷 2026-03-19 122226" src="https://github.com/user-attachments/assets/c3a6b135-5885-43af-86f2-8d840ef32add" />

  1. Label, Button, ListBox, TextBox 적절히 배치하기
     cf) Label -> lbTitle
         Button -> btnSend
         ListBox -> lstChat
         TextBox -> txtMessage
  2. 전송 버튼 클릭 시 txtMessage에 입력된 텍스트를 lstChat의 항목(Items)으로 추가하기
  3. 추가 직후 TextMessage의 내용을 Clear() 메서드를 이용해 비운 후, 다음 입력 준비하기

- 2단계 코드의 실행 스크린

- 3단계 코드의 실행 스크린


     

## 참고
-Form: 프로그램 전체 윈도우창 

## 구현 시 어려웠던 점
- 버튼 클릭 시 랜덤 색상을 만드는 코드를 이해하는 것이 조금 어려웠지만, RGB 개념을 공부하며 해결했습니다.
