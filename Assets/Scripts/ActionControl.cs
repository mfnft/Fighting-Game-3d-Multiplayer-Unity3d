﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ActionControl : NetworkBehaviour
{
    Player oponent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    [Command]
    public void CmdDamage(string id, int damage)
    {
        //if (oponent == null)
        //    oponent = GameObject.Find("oponent").GetComponent<Player>();
        //Debug.Log("Oponent is hit");
        //oponent.TakeDamage(damage);
        Debug.Log("id: " + id + " has been attacked");
    }

}
