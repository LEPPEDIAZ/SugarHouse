using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MesadeOlla : MonoBehaviour {

    public GameObject pot1;
    int spawnNum = 8;

    void spawn()
    {
        for(int i = 0; i < spawnNum; i++)
        {
            Instantiate(pot1);
        }
    }
    void Start()
    {
        spawn();
    }
}
