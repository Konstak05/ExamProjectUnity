using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class currencymanager : MonoBehaviour
{
    public int coins,health,MaxHealth;

    //lifeBar
    public Slider HPslider;
    public TextMeshProUGUI HPtext,Ctext;

    // Start is called before the first frame update
    void Start()
    {
        coins = 0;
        health = MaxHealth;
        HPslider.value = health;
        HPtext.text = health.ToString() + "/100";
    }

    // Update is called once per frame
    void Update()
    {
        HPslider.value = health;
        HPtext.text = health.ToString() + "/100";
        Ctext.text = "Coins: " + coins.ToString();
        if(health <= 0){RestartCurrentScene();}
    }
    public void RestartCurrentScene()
    {
        // Get the active scene's name
        string currentSceneName = SceneManager.GetActiveScene().name;

        // Reload the scene
        SceneManager.LoadScene(currentSceneName);
    }
}
