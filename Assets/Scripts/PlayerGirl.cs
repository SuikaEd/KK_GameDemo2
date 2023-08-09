using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGirl : MonoBehaviour
{
    [Tooltip("预期物体走到的初始位置的z坐标")]
    public float startZAxis = -0.50f;
    [Tooltip("预期角色进场的速度")]
    public float startSpeed = 1.0f;

    //角色默认数值
    public RoleInfo roleInfo;
    [System.Serializable]
    public class RoleInfo
    {
        [Tooltip("角色名称|string")]
        public string roleName;
        [Tooltip("角色等级|整数|1-100")]
        public int roleLevel;
        [Tooltip("角色初始血量|小数|1-10000")]
        public float roleHP;
        [Tooltip("角色初始魔法值|小数|1-500")]
        public float roleMP;
        [Tooltip("角色默认力量|整数|1-10")]
        public int rolePower;
        [Tooltip("角色默认速度2|整数|0-4")]
        public int roleSpeed = 2;
        [Tooltip("角色物理防御值|百分数|-1，1")]
        public float rolePscDef;
        [Tooltip("角色魔法防御值|百分数|-1，1")]
        public float roleMgcDef;
        [Tooltip("角色武器种类|整数|1-10")]
        public int WpnCls = 1;
        [Tooltip("角色武器加成|小数|0-10")]
        public float WpnPwr;
        [Tooltip("角色理智默认10|整数|0-10")]
        public int roleSns = 10;
        [Tooltip("角色AP初始0|整数|0-20")]
        public int roleAP;
    }

    

    // Start is called before the first frame update
    void Start()
    {
        int turnNumber = FindObjectOfType<MainLogic>().turnNumber;
        int roleNumber = FindObjectOfType<MainLogic>().roleNumber;
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

        //面向敌人
        GameObject enemyobj = GameObject.Find("Fox");
        this.transform.LookAt(enemyobj.transform);


        //缺少：加入血条开始显示
        */
    }
}
