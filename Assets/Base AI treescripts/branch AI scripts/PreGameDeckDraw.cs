using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreGameDeckDraw : MonoBehaviour
{
    

    


    public void Start()
    {

        //GeneratePlayerDeck();
        //GenerateEnemyDeck();

        //InstantiateDecks();

        //Setup();
        //GeneratePlayerDeck();


        //GameObject card = GetFirstPlayerCard();
        //StorePlayerCard( card );

//        GameManager.gm.Test();

    }

    void Update()
    {
    }

    void Setup()
    {
    }


    /*


    void GeneratePlayerDeck()
    {


        


        int num;

        for (int i = 0; i < 64; i++)
        {
            num = Random.Range(0, 11); // check this gives a num between 0 and 11
            switch (num)
            {
                case 0:
                    playerDeckArray[i] = angel;
                    break;

                case 1:
                    playerDeckArray[i] = defensiveMirror;
                    break;

                case 2:
                    playerDeckArray[i] = doubleEdgedSword;
                    break;

                case 3:
                    playerDeckArray[i] = graveRobber;
                    break;

                case 4:
                    playerDeckArray[i] = hailMary;
                    break;

                case 5:
                    playerDeckArray[i] = hellFire;
                    break;

                case 6:
                    playerDeckArray[i] = hourHandLance;
                    break;

                case 7:
                    playerDeckArray[i] = lastLeg;
                    break;

                case 8:
                    playerDeckArray[i] = multiSecondJab;
                    break;

                case 9:
                    playerDeckArray[i] = timeLeech;
                    break;

                case 10:
                    playerDeckArray[i] = timerDiversion;
                    break;

                case 11:
                    playerDeckArray[i] = frontlineDefense;
                    break;

                

                default:
                    playerDeckArray[i] = hourHandLance;
                break;

            }
        }

        

    }


    void GenerateEnemyDeck()
    {

        int num;

        

        for (int i = 0; i < 64; i++)
        {
            num = Random.Range(0, 11); // check this gives a num between 0 and 11
            switch (num)
            {
                case 0:
                    enemyDeckArray[i] = angel;
                    break;

                case 1:
                    enemyDeckArray[i] = defensiveMirror;
                    break;

                case 2:
                    enemyDeckArray[i] = doubleEdgedSword;
                    break;

                case 3:
                    enemyDeckArray[i] = graveRobber;
                    break;

                case 4:
                    enemyDeckArray[i] = hailMary;
                    break;

                case 5:
                    enemyDeckArray[i] = hellFire;
                    break;

                case 6:
                    enemyDeckArray[i] = hourHandLance;
                    break;

                case 7:
                    enemyDeckArray[i] = lastLeg;
                    break;

                case 8:
                    enemyDeckArray[i] = multiSecondJab;
                    break;

                case 9:
                    enemyDeckArray[i] = timeLeech;
                    break;

                case 10:
                    enemyDeckArray[i] = timerDiversion;
                    break;

                case 11:
                    enemyDeckArray[i] = frontlineDefense;
                    break;



                default:
                    enemyDeckArray[i] = hourHandLance;
                    break;

            }
        }


    }

    void InstantiateDecks()
    {
        
        for (int i = 0; i < 64; i++)
        {
            Instantiate(playerDeckArray[UnityEngine.Random.Range(0, 11)], playerDeckSpawnLocation.position, playerDeckSpawnLocation.rotation);
            playerHand.Add(i);

            Instantiate(enemyDeckArray[UnityEngine.Random.Range(0, 11)], enemyDeckSpawnLocation.position, enemyDeckSpawnLocation.rotation);


        }


    }

    */
}
