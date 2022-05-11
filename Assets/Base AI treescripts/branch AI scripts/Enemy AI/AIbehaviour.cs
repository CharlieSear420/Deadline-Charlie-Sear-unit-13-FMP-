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

    public bool checkTimerBool;
    public bool checkOffensiveCardBool;
    public bool checkBurnerCardBool;
    public bool checkSpecialCardBool;
    public bool checkSpecialCostBool;
    public bool checkDefensiveBool;
    public bool checkBoardSpaceBool;

    void Start()
    {
        
    }

    
    void Update()
    {
        ThoughtProcess();
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
        //if (GameObject.FindWithTag("GameObject").GetComponent<Cards>().enemyTimer >= GameObject.FindWithTag("GameObject").GetComponent<Cards>().playerTimer)
        {
           // checkTimerBool = true;
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
