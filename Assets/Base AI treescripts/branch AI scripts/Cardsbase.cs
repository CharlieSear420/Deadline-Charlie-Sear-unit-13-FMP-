using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Cardsbase : MonoBehaviour
{
    public int cardsInPlayersHand = 0;

    public float drawTimer = 5f;

    public int burnerCards = 25;

    public float burnerTimer = 3f;

    public float playerTimer = 120f;

    public float enemyTimer = 120f;

    public int boardSpace = 5;

    public int playingDeck = 64;

    public Text playerTimeText;

    public Text enemyTimeText;

    public Text burnerCardsText;

    public GameObject victoryText;

    public GameObject failureText;

    void Update()
    {

    }

    public void PlayerCountDown()
    {
        if (playerTimer > 0)
        {
            playerTimer -= Time.deltaTime;
        }

        if (enemyTimer <= 0)
        {
            Time.timeScale = 0f;
            victoryText.SetActive(true);
            print("VICTORY");
        }
    }

    public void EnemyCountDown()
    {
        if (enemyTimer > 0)
        {
            enemyTimer -= Time.deltaTime;
        }

        if (playerTimer <= 0)
        {
            Time.timeScale = 0f;
            failureText.SetActive(true);
            print("YOU LOOSE");
        }
    }





    public void BurnCount()
    {
        if (burnerTimer > 0)
        {
            burnerTimer -= Time.deltaTime;
        }

        if (burnerTimer <= 0)
        {
            burnerCards += 1;
            burnerTimer = 3f;
        }
    }

    public void DrawCard()
    {
        if (drawTimer > 0)
        {
            drawTimer -= Time.deltaTime;
        }

        if (drawTimer <= 0)
        {
            playingDeck -= 1;
            cardsInPlayersHand += 1;
            drawTimer = 5f;
        }
    }



}
