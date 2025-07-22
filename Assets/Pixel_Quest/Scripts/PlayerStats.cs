
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerStats : MonoBehaviour
{
    public int CoinCounter = 0;
    public string nextlevel = "Geolevel_2";
    private int _health = 3;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.tag);
        switch (collision.tag)
        {
            case "Death":
                {
                    string thislevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thislevel);
                    break;

                }
            case "Finish":
                {
                    SceneManager.LoadScene(nextlevel);
                    break;

                  

                }
            case "Coin":

                {
                    CoinCounter++;
                    Destroy(collision.gameObject);
                    break;

            
                }
        }    case "Health":
        // //
    }
}





