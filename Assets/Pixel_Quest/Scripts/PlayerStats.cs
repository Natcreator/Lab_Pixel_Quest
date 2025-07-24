
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerStats : MonoBehaviour
{
    public int CoinCounter = 0;

    private int Health = 3;
    private int _maxHealth = 3;
    public Transform RespwanPoint;
    private playerui _playerui;


    private void start()

    {
        _playerui = GetComponent<playerui>();
        _playerui.UpdateHealth(Health, _maxHealth);



    }







    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.tag);

        switch (collision.tag)
        {
            case "Death":
                {
                    Health--;
                    _playerui.UpdateHealth(Health, _maxHealth);


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
                    string nextlevel = collision.GetComponent<LevelGoal>().nextlevel;
                    SceneManager.LoadScene(nextlevel);
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
                    _playerui.UpdateHealth(Health, _maxHealth);
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
    






