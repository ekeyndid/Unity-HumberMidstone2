using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainBase : MonoBehaviour
{
    public GameObject[] Combatants;


    void StartUp()
    {
        for (int i = 0; i < Combatants.Length; i++)
        {
            if(Combatants[i].tag == "Player")
            {

            }
            else if(Combatants[i].tag == "Enemy")
            {

            }
        }
    }

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
