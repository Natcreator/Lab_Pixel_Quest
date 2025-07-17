using UnityEngine;

public class HW2PlayerDie : MonoBehaviour
{
    public string Enemy;
    public GameObject endPanel;
    


    private void OnCollisionEnter2D(Collision2D collision)

    {

        if(collision .gameObject.tag == Enemy)

        {

            endPanel.SetActive(true);
            gameObject.SetActive(false);

        }


    }


    //

}
