using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    
    void Start()
    {
        WorldSingel.ins.player = new Obj_MainPlayer();
        WorldSingel.ins.player.Go = player;
    }

    void Update()
    {
        WorldSingel.ins.player.Update();
    }
}
