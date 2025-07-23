
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerStats : MonoBehaviour
{
    public int CoinCounter = 0;

    private int Health = 3;

    public Transform RespwanPoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.tag);

        switch (collision.tag)
        {
            case "Death":
                {
                    Health--;
                    if (Health <= 0)
                    {

                        string thislevel = SceneManager.GetActiveScene().name;
                        SceneManager.LoadScene(thislevel);


                    }
                    else
                    {
                        transform.position = RespwanPoint.position;

                    }
                    break;

                }
            case "Finish":
                {
                    string nextLevel = collision.Getcomponent<LevelGoal>().nextLevel;
                    SceneManager.LoadScene(nectLevel);
                    break;



                }
            case "Coin":

                {
                    CoinCounter++;
                    Destroy(collision.gameObject);
                    break;
                }


            case "Health":
                {
                    Health++;
                    Destroy(collision.gameObject);
                    break;
                }

            case "Respawn":

                {

                    RespwanPoint.position= collision.transform.Find("Point").position;


                }
                break;
                
                
                
               

        }






    }
}
        
        // //
    






