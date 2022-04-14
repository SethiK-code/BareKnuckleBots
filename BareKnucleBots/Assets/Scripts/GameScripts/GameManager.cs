using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //MatchSettings
    [Header("Match Settings")]
    [SerializeField]
    private float matchTimer;

    //Player One
    [Header("Player One Settings")]
    private PlayerHealth p1HealthScript;
    private float p1maxHealthValue;
    private float p1currentHealthValue;
    public Slider p1Slider;

    //PlayerTwo
    [Header("Player Two Settings")]
    private PlayerHealth p2HealthScript;
    private float p2maxHealthValue;
    private float p2currentHealthValue;
    public Slider p2Slider;


    public void Start()
    {
        GetBothPlayersHealthFromScript();//1)

        SetPlayersHealth();//2)

        SetSlidersToMaxValue();//3)
    }

    // Update is called once per frame
    public void Update()
    {
        //PlayerOne
        PlayerOneHealthSlider();

        //PlayerTwo
        PlayerTwoHealthSlider();
    }

    public void PlayerOneHealthSlider()
    {        
        
            p1currentHealthValue = p1HealthScript.currentHealth;
            p1Slider.value = p1currentHealthValue;

            if (p1maxHealthValue <= 0)
            {
                Debug.Log("Player One Loses");
            }

            p1HealthScript.hit = false;
        

        
    }
    public void PlayerTwoHealthSlider()
    {
        
            p2currentHealthValue = p2HealthScript.currentHealth;
            p2Slider.value = p2currentHealthValue;

            if (p2currentHealthValue <= 0)
            {
            Debug.Log("Player Two Loses");
            }
            p2HealthScript.hit = false;
        
    }

    public void GetBothPlayersHealthFromScript()
    {
        p1HealthScript = GameObject.FindWithTag("PlayerOneHealth").GetComponent<PlayerHealth>();
        p2HealthScript = GameObject.FindWithTag("PlayerTwoHealth").GetComponent<PlayerHealth>();
    }
    public void SetPlayersHealth()
    {
        p1maxHealthValue = p1HealthScript.maxHealth;
        p2maxHealthValue = p2HealthScript.maxHealth;
    }
    public void SetSlidersToMaxValue()
    {
        p1Slider.value = p1maxHealthValue;
        p2Slider.value = p2maxHealthValue;
    }
}
