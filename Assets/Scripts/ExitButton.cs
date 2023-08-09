using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ExitButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(OnClick);
    }

    // Update is called once per frame
    void Update()
    {

    }

    /*点击时触发*/
    private void OnClick()
    {
        /*将状态设置false才能退出游戏*/
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
