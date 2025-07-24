using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerui : MonoBehaviour

{
    public Image HeartImage;


    // Start is called before the first frame update
    public void Start()
    {
        HeartImage = GameObject.Find("HeartImage").GetComponent<Image>();


    }

    // Update is called once per frame
    public void UpdateHealth(float currentHealth, float maxHealth)

    {

        HeartImage.fillAmount = currentHealth/maxHealth;    

    }
}
