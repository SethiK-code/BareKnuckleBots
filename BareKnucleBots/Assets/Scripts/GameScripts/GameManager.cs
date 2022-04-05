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
    private float p1Health;
    public Slider p1Slider;

    //PlayerTwo
    [Header("Player Two Settings")]
    private float p2Health;
    public Slider p2Slider;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //PlayerOne
        PlayerOneHealthUpDate();

        //PlayerTwo
        PlayerTwoHealthUpDate();
    }

    public void PlayerOneHealthUpDate()
    {
        p1Health = GameObject.FindWithTag("PlayerOneHealth").GetComponent<PlayerHealth>().health;
        p1Slider.value = p1Health;

        if (p1Health <= 0)
        {
            Debug.Log("Player One Loses");
        }
    }
    public void PlayerTwoHealthUpDate()
    {
        p2Health = GameObject.FindWithTag("PlayerTwoHealth").GetComponent<PlayerHealth>().health;
        p2Slider.value = p2Health;

        if (p2Health <= 0)
        {
            Debug.Log("Player Two Loses");
        }
    }
}
