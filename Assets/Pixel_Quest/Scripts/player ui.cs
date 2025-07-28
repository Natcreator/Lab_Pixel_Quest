using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class playerui : MonoBehaviour

{
    public Image HeartImage;
    public TextMeshProUGUI _text;
    
    // Start is called before the first frame update
    public void StartUI()
    {
        HeartImage = GameObject.Find("HeartImage").GetComponent<Image>();
        _text = GameObject.Find("CoinText").GetComponent<TextMeshProUGUI>();

    }

    // Update is called once per frame
    public void UpdateHealth(float currentHealth, float maxHealth)

    {

        HeartImage.fillAmount = currentHealth/maxHealth;    

    }
    public void UpdateText(string newText) { _text.text =newText; }
    

}
