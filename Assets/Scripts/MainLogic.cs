using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainLogic : MonoBehaviour
{
    [Tooltip("当前回合数")]
    public int roundNumber;
    [Tooltip("场上的角色数量")]
    public int roleNumber = 3;
    [Tooltip("当前行动序数默认从角色1开始行动，不要修改")]
    public int turnNumber = 1;




    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;

        int roleSpeed = FindObjectOfType<PlayerBoy>().roleInfo.roleSpeed;


        Debug.Log("游戏开始");
    }

    // Update is called once per frame
    void Update()
    {
        GameObject button1 = GameObject.Find("Button1");
        GameObject button2 = GameObject.Find("Button2");
        GameObject button3 = GameObject.Find("Button3");
        GameObject button4 = GameObject.Find("Button4");
        GameObject button5 = GameObject.Find("Button5");
        GameObject button6 = GameObject.Find("Button6");
        GameObject button7 = GameObject.Find("Button7");
        GameObject button8 = GameObject.Find("Button8");

        //回合轮换机制
        if (button1||button2||button3||button4||button5||button6||button7||button8)
        {
            //按钮禁用
            button1.SetActive(false);
            button2.SetActive(false);
            button3.SetActive(false);
            button4.SetActive(false);
            button5.SetActive(false);
            button6.SetActive(false);
            button7.SetActive(false);
            button8.SetActive(false);
            
            //回合数轮换
            turnNumber += 1;
            if(turnNumber > roleNumber)
            {
                turnNumber = 1;
            }

            //增加一个防止连按的机制，监测玩家代码中已结束本回合并已准备好下一回合
        }
    }
}
