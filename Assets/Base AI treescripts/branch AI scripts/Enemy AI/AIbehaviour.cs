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




    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    //-----------------------------decision making-----------------------------------

    public void ThoughtProcess()
    {
        if (CheckTimer() == true)
        {
            if (CheckOffensiveCard() == true)
            {
                if (CheckBurnerCard() == true)
                {
                    PlayOffensive();
                }
                else
                {
                    if (CheckSpecialCard() == true)
                    {
                        PlaySpecialCrad();
                    }
                }
            }
            else
            {
                if (CheckSpecialCard() == true)
                {
                    if (CheckSpecialCost() == true)
                    {
                        PlaySpecialCrad();
                    }
                }
            }
            
            
            if (CheckDefensiveCard() == true)
            {
                if (CheckBoardSpace() == true)
                {
                    PlayDefensiveCard();
                }
            }
            
        }
        else
        {
            if (CheckDefensiveCard() == true)
            {
                if (CheckBoardSpace() == true)
                {
                    PlayDefensiveCard();
                }
            }
        }
    }

    //-----------------------------checks---------------------------------------------

    public void CheckTimer()
    {

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
