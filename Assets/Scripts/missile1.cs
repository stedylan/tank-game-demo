﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missile1 : MonoBehaviour {

    public GameObject guidedMissile;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision collision)
    {
        // 销毁当前游戏物体

        if (collision.collider.tag == "tank2")
        {
            GameObject.Find("Tank2").GetComponent<Tank2>().life -= 20;
            Destroy(this.gameObject);
            GameObject.Find("Tank1").GetComponent<Tank1>().tools[3] = false;

        }
    }
}
