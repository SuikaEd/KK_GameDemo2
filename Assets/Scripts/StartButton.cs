using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*
        GameObject StartButton = GameObject.Find("StartButton");
        Button stBtn = StartButton.GetComponent<Button>();
        stBtn.onClick.AddListener(delegate ()
        {
            this.GoNextScene(StartButton);
        });
        */
        this.GetComponent<Button>().onClick.AddListener(OnClick);
        
    }

    void OnClick()
    {
        SceneManager.LoadScene("SampleScene");//切换到战斗场景
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    /*
    public void GoNextScene(GameObject NScene)
    {
        //SceneManager.LoadScene("SampleScene");//切换到战斗场景
    }
    */
}
