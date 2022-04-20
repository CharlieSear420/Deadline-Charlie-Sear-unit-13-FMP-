using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BehaviourTree;

public class Cardsbase : MonoBehaviour
{
    public int cardsInHand = 0;

    public float drawTimer = 5f;

    public int burnerCards = 25;

    public float burnerTimer = 3f;

    public float playerTimer = 120f;

    public float enemyTimer = 120f;

    public int boardSpace = 5;

    public int playingDeck = 64;

    void Update()
    {

    }

    public void PlayerCountDown()
    {
        if (playerTimer > 0)
        {
            playerTimer -= Time.deltaTime;
        }
        print("player count down");
    }

    public void EnemyCountDown()
    {
        if (enemyTimer > 0)
        {
            enemyTimer -= Time.deltaTime;
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
            cardsInHand += 1;
            drawTimer = 5f;
        }
    }



}
