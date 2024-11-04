using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player pl1=new Player();
        Player pl2=new Player();
        pl1.InitializePlayer("hadeel",100);
        pl2.InitializePlayer("aseel",95);
        pl2.Heal(2);
        pl2.Heal(true);
        Debug.Log(pl2.health);
        Player.ShowPlayerCount();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
