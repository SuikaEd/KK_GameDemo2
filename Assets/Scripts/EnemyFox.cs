using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFox : MonoBehaviour
{
    [Tooltip("预期物体走到的初始位置的z坐标")]
    public float startZAxis = -1.9f;
    [Tooltip("预期角色进场的速度")]
    public float startSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        //面向场中
        GameObject ctrobj = GameObject.Find("OHS03");
        this.transform.LookAt(ctrobj.transform);

        //角色进场
        Vector3 ctrDistance = this.transform.position;
        for (; ctrDistance.z > startZAxis;)
        {
            this.transform.Translate(0, 0, (1.0f / 60.0f) * startSpeed, Space.Self);
            Debug.Log("角色正在进场");
        }
        */
    }
}
