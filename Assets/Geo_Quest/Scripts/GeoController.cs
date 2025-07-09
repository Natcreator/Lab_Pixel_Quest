using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int varTwo = 3;
    int varOne = 1;
        
    
       
    
    string bear = "how are you";
    // Start is called before the first frame update
    void Start()
    {
       
        Debug.Log("Hello World");
        string goat = "im good how about you";
        Debug.Log(bear + goat);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(varTwo);
        varTwo++;
    }
}
// notes 