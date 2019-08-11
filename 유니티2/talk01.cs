using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class talk01 : MonoBehaviour {
    int talkCnt = 10;       // 대화의 총 갯수를 설정해줍니다.
    int strCnt = 0;         // 이 변수가 하나씩 커져가면서 대화를 진행합니다.
    string[] talk;          // 대화 내용을 저장할 공간입니다.
    public Text txt;        // Text 오브젝트에 접근하기
    public Image []charactors;
    public Image showText;
    int []showCnt;
	// Use this for initialization
	void Start () {
        talk = new string[talkCnt]; // 대화 저장 공간을 초기화해줍니다.
        showCnt = new int[talkCnt];
        txt = GameObject.Find("Canvas").transform.FindChild("text").GetComponent<Text>();
        // 캔버스 오브젝트 아래 자식 오브젝트로 있는 Text를 호출합니다.(이제 부모오브젝트로 연결해서 하지말고 직접 find에서 자식오브젝트를 찾ㅇ르수있다.)
        showText = GameObject.Find("Canvas").transform.FindChild("talk screen").GetComponent<Image>();
        // 캔버스 오브젝트 아래 자식 오브젝트로 있는 talkScreen을 호출합니다.

        charactors = new Image[3];  // 이미지 호출할 배열을 만듭니다.
        charactors[0] = GameObject.Find("Canvas").transform.FindChild("동구라").GetComponent<Image>();  
        charactors[1] = GameObject.Find("Canvas").transform.FindChild("무룩").GetComponent<Image>();  
        // 각 배열에 오브젝트를 연결합니다.
        // 등장 인물이 많다면 여러개를 생성해야 합니다.

        initialized();      // 대화를 설정하는 함수입니다.
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Submit") || Input.GetButtonDown("Jump"))
        {
            strCnt++;
            // '엔터'나 '스페이스바'를 누르면 카운트가 올라갑니다.
        }
        showAll();  // 화면에 나오게 하는 함수로 연ㅋ결ㅋ
    }
    void showAll()
    {
        showText.gameObject.SetActive(true);
        for (int i = 0; i < 2; i++)      // 등장인물의 수만큼을 써줍니다. 여기는 3명이 등장합니다.
        {
            charactors[i].gameObject.SetActive(false);      // 모든 오브젝트를 비활성화합니다.(사람 이미지)
        }
        NewMethod();
        // 캐릭터의 showCnt라는 배열의 숫자에 대한 오브젝트만을 활성화합니다.
        txt.text = talk[strCnt];
        // strCnt의 차례에 맞춰 대화를 출력합니다.
    }

    private void NewMethod()
    {
        charactors[showCnt[strCnt]].gameObject.SetActive(true);
    }

    void initialized()
    {
        // 대화 내용을 하나하나 추가합니다.
        talk[0] = "안녕? 만나서 반가워";                    
        talk[1] = "그래. 안녕!";
        talk[2] = "오늘 점심은 뭔가요?";
        talk[3] = "오늘의 메뉴는 고양이가 만든 그라탕입니다.";
        talk[4] = "냐옹?";
        talk[5] = "그라탕으로 하시겠습니까?";
        talk[6] = "아뇨, 그냥 스파게티 주세요";
        talk[7] = "네니요?";
        talk[8] = "스.파.게.티 주세요";
        talk[9] = "냥무룩";
        ////////////////////////////////////////

        // 캐릭터의 등장 순서를 설정합니다.
        showCnt[0] = 0;     
        showCnt[1] = 1;   
        showCnt[2] = 0;   
        showCnt[3] = 1;  
        showCnt[4] = 0; 
        showCnt[5] = 1;  
        showCnt[6] = 0;     
        showCnt[7] = 1;   
        showCnt[8] = 0;   
        showCnt[9] = 0;     
        // 순서로 이루어지는 대화
    }
}
