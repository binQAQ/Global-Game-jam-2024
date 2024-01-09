using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private void Awake()
    {
        //Singleton
        if (Instance == null) Instance = this;
        else Destroy(this.gameObject);
        
        //Other Scripts
        

    }
}
