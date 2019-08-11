using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class talk01 : MonoBehaviour
{
    int talkCnt = 15;       // 대화의 총 갯수를 설정해줍니다.
    int strCnt = 0;         // 이 변수가 하나씩 커져가면서 대화를 진행합니다.
    string[] talk;          // 대화 내용을 저장할 공간입니다.
    public Text txt;        // Text 오브젝트에 접근하기
    public Image[] charactors;
    public Image showText;
    int[] showCnt;
    // Use this for initialization
    void Start()
    {
        talk = new string[talkCnt]; // 대화 저장 공간을 초기화해줍니다.
        showCnt = new int[talkCnt];
        txt = GameObject.Find("Text").GetComponent<Text>();
        // 캔버스 오브젝트 아래 자식 오브젝트로 있는 Text를 호출합니다.
        showText = GameObject.Find("talkscreen").GetComponent<Image>();
        // 캔버스 오브젝트 아래 자식 오브젝트로 있는 talkScreen을 호출합니다.

        charactors = new Image[1];  // 이미지 호출할 배열을 만듭니다.
        charactors[0] = GameObject.Find("동구라").GetComponent<Image>();  //동구라미
        // 각 배열에 오브젝트를 연결합니다.
        // 등장 인물이 많다면 여러개를 생성해야 합니다.

        initialized();      // 대화를 설정하는 함수입니다.

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Submit") || Input.GetButtonDown("Jump"))
        {
            strCnt++;
            // '엔터'나 '스페이스바'를 누르면 카운트가 올라갑니다.
        }
        showAll();  // 화면에 나오게 하는 함수로 연결
    }
    void showAll()
    {
        showText.gameObject.SetActive(true);
        for (int i = 0; i < 1; i++)      // 등장인물의 수만큼을 써줍니다. 여기는 3명이 등장합니다.
        {
            charactors[i].gameObject.SetActive(false);      // 모든 오브젝트를 비활성화합니다.(사람 이미지)
        }
        charactors[showCnt[strCnt]].gameObject.SetActive(true);
        // 캐릭터의 showCnt라는 배열의 숫자에 대한 오브젝트만을 활성화합니다.
        txt.text = talk[strCnt];
        // strCnt의 차례에 맞춰 대화를 출력합니다.
    }

    void initialized()
    {
        // 대화 내용을 하나하나 추가합니다.
        talk[0] = "안녕??";
        talk[1] = "안녕!";
        talk[2] = "오늘 날씨 좋지?";
        talk[3] = "그러네..";
        talk[4] = "여기 자주 와??";
        talk[5] = "아니 오늘 처음와봤어 너는?";
        talk[6] = "나는 자주 운동하러 와";
        talk[7] = "그렇구나! ";
        talk[8] = "나중에 나랑 같이 운동하자";
        talk[9] = "그럴까??";
        talk[10] = "웅 정신도 맑아지고 좋아";
        talk[11] = "근데 요즘 너 나 피하는 거 같다..?";
        talk[12] = "에이 내가 그럴리가 있어??";
        talk[13] = "아님말고 그냥 궁금했어 이제 가볼께 안녕";
        talk[14] = "잘가";
        ////////////////////////////////////////

        // 캐릭터의 등장 순서를 설정합니다.
        showCnt[0] = 0;     // 동구라미
        showCnt[1] = 0;   
        showCnt[2] = 0;  
        showCnt[3] = 0;   
        showCnt[4] = 0;   
        showCnt[5] = 0;  
        showCnt[6] = 0;    
        showCnt[7] = 0;    
        showCnt[8] = 0;    
        showCnt[9] = 0;     
        // 순서로 이루어지는 대화
    }
}
