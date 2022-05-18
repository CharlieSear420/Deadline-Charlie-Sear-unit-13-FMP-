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

    public float eloopAmount = 0f;
    

    void Start()
    {
        
    }

    
    void Update()
    {
        ThoughtProcess();
        CheckTimer();
    }

    public void RandomCardPlay()
    {

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
        tDivert = true;
    }

    public void PlayerHourHandLance()
    {
        enemyTimer -= 5f;
        print ("Hour Hand Lance waas played");
    }

    public void DoubleEdgedSword()
    {
        enemyTimer -= 7.5f;
        //wait
        
        playerTimer -= cardsInPlayersHand;
    }

    public IEnumerator MultiSecondJab()
    {
        while (runLoop)
        {
            if (loopAmount == 10)
            {
                runLoop = false;
                break;
            }
            else
            {
                enemyTimer -= 1.5f;
            }

            loopAmount++;

            yield return new WaitForSeconds(1);
        }

        print ("Multisecond Jab was played");

    }

    public void JabMulti()
    {
        StartCoroutine(MultiSecondJab());
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
