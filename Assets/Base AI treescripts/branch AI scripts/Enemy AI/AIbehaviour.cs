using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIbehaviour : MonoBehaviour
{
    /*
    * 
    * In here I want the AI to check wether or not its timer has more time than the players 
    * if it does have more time than the players it will then check its hand
    * if it can play an attack card then it will
    * then if not it will check to see if it can play a special card
    * then if not it will see if it can play a defense card
    * then if not it will have drawn a new card and it will repeat the thought process 
    * 
    */

//-------------------------------<<<Bools>>>-------------------------------

    public bool eRunLoop = true;
    public bool etDivert = false;
    public bool checkTimerBool;
    public bool checkOffensiveCardBool;
    public bool checkBurnerCardBool;
    public bool checkSpecialCardBool;
    public bool checkSpecialCostBool;
    public bool checkDefensiveBool;
    public bool checkBoardSpaceBool;

//-------------------------------<<<Card Floats (For timers)>>>-------------------------------

    public float eLeechCounter = 0f;
    public float eLeechCounterTwo = 0f;
    public float eHellCounter = 0f;
    //public float eJabCounter = 0f;
    public float etDiversion = 20f;
    public float randomCardTimer = 2f;

    public float eloopAmount = 0f;
    
//---------------------------------------------------------------------------------------

    public int k;
    public int i;

    void Start()
    {
        StartCoroutine(RandomCardPlay());
    }

    
    void Update()
    {
        ThoughtProcess();
        CheckTimer();
        
        
        
        EnemyTimeLeech();
        EnemyHellFire();
        EnemyTimerDiversion();
    }

    public IEnumerator RandomCardPlay()
    {
        
        bool playCard=true;

        while( playCard == true )
        {
            k = Random.Range(1, 10);

            if (k == 1)
            {
                EnemyLeechTimer();
            }
            if (k == 2)
            {
                EnemyHellFireTimer();
            }
            if (k == 3)
            {
                TimerDiversionActivate();
            }
            if (k == 4)
            {
                EnemyHourHandLance();
            }
            if (k == 5)
            {
                EnemyDoubleEdgedSword();
            }
            if (k == 6)
            {
                EnemyJabMulti();
            }
            if (k == 7)
            {
                EnemyDoubleEdgedSword();
            }
            if (k == 8)
            {
                EnemyJabMulti();
            }
            if (k == 9)
            {
                EnemyHourHandLance();
            }
            if (k == 10)
            {
                EnemyHellFireTimer();
            }

            yield return new WaitForSeconds(5);
        }
        
    }

    public void RandomCardPlayActivator()
    {
        StartCoroutine(RandomCardPlay());
        
    }

    //-------------------------------<<<Card stuff>>>-------------------------------

     public void EnemyLeechTimer()
    {
        eLeechCounter = 30f;
    }
    
    public void EnemyTimeLeech()
    {
        

        if( eLeechCounter > 0 )
        {
            GameObject.FindWithTag("Game Manager").GetComponent<GameManager>().enemyTimer += Time.deltaTime / 50f;
            GameObject.FindWithTag("Game Manager").GetComponent<GameManager>().playerTimer -= Time.deltaTime * 2;

            eLeechCounter -= Time.deltaTime;
            print ("Enemy Time Leech was played");
        }


        
    }

    public void EnemyHellFireTimer()
    {
        eHellCounter = 10f;
    }

    public void EnemyHellFire()
    {
        
        if (eHellCounter > 0)
        {
            eHellCounter -= Time.deltaTime;
            GameObject.FindWithTag("Game Manager").GetComponent<GameManager>().enemyBurnerTimer -= Time.deltaTime * 5;
            //burnerTimer -= Time.deltaTime * 5;
        }

       //print ("Hell Fire was played");

    }

    public void LastLeg()
    {
        // front line defense count +2, burner cards *2, board space +2 > -2
    }

    public void EnemyTimerDiversion()
    {
        

        if (etDivert == true)
        {
            etDiversion -= Time.deltaTime;
            GameObject.FindWithTag("Game Manager").GetComponent<GameManager>().enemyTimer += Time.deltaTime;
            
            if (etDiversion <= 0)
            {
                etDiversion = 20f;
                etDivert = false;
            }
        }
 
    }

    public void TimerDiversionActivate()
    {
        etDivert = true;
    }

    public void EnemyHourHandLance()
    {
        GameObject.FindWithTag("Game Manager").GetComponent<GameManager>().playerTimer -= 5f;
        print ("Enemy Hour Hand Lance waas played");
    }

    public void EnemyDoubleEdgedSword()
    {
        GameObject.FindWithTag("Game Manager").GetComponent<GameManager>().playerTimer -= 7.5f;
        //wait
        
        GameObject.FindWithTag("Game Manager").GetComponent<GameManager>().enemyTimer -= GameObject.FindWithTag("Game Manager").GetComponent<GameManager>().cardsInPlayersHand;
    }

    public IEnumerator EnemyMultiSecondJab()
    {
        while (eRunLoop)
        {
            if (eloopAmount == 10)
            {
                eRunLoop = false;
                break;
            }
            else
            {
                GameObject.FindWithTag("Game Manager").GetComponent<GameManager>().enemyTimer -= 1.5f;
            }

            eloopAmount++;

            yield return new WaitForSeconds(1);
        }

        print ("Enemy Multisecond Jab was played");

    }

    public void EnemyJabMulti()
    {
        StartCoroutine(EnemyMultiSecondJab());
    }

    //-----------------------------decision making-----------------------------------

    public void ThoughtProcess()
    {
        if (checkTimerBool == true)
        {
            if (checkOffensiveCardBool == true)
            {
                if (checkBurnerCardBool == true)
                {
                    PlayOffensive();
                }
                else
                {
                    if (checkSpecialCardBool == true)
                    {
                        PlaySpecialCrad();
                    }
                }
            }
            else
            {
                if (checkSpecialCardBool == true)
                {
                    if (checkSpecialCostBool == true)
                    {
                        PlaySpecialCrad();
                    }
                }
            }
            
            
            if (checkDefensiveBool == true)
            {
                if (checkBoardSpaceBool == true)
                {
                    PlayDefensiveCard();
                }
            }
            
        }
        else
        {
            if (checkDefensiveBool == true)
            {
                if (checkBoardSpaceBool == true)
                {
                    PlayDefensiveCard();
                }
            }
        }
    }

    //-----------------------------checks---------------------------------------------

    public void CheckTimer()
    {
        if (GameObject.FindWithTag("Game Manager").GetComponent<GameManager>().enemyTimer >= GameObject.FindWithTag("Game Manager").GetComponent<GameManager>().playerTimer)
        {
           checkTimerBool = true;
        }
        else
        {
            checkTimerBool = false;
        }
    }
    public void CheckOffensiveCard()
    {
        
    }
    public void CheckBurnerCard()
    {

    }
    public void CheckSpecialCard()
    {

    }
    public void CheckSpecialCost()
    {

    }
    public void CheckDefensiveCard()
    {

    }
    public void CheckBoardSpace()
    {

    }

    //---------------------------play cards------------------------------------------

    public void PlayOffensive()
    {

    }
    public void PlaySpecialCrad()
    {

    }
    public void PlayDefensiveCard()
    {

    }



}
