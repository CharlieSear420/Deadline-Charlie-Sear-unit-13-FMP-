using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreGameDeckDraw : MonoBehaviour
{
    public GameObject angel;
    public GameObject defensiveMirror;
    public GameObject doubleEdgedSword;
    public GameObject frontlineDefense;
    public GameObject graveRobber;
    public GameObject hailMary;
    public GameObject hellFire;
    public GameObject hourHandLance;
    public GameObject lastLeg;
    public GameObject multiSecondJab;
    public GameObject timeLeech;
    public GameObject timerDiversion;


    GameObject[] playerDeckArray = new GameObject[64];
    //creates array
    GameObject[] enemyDeckArray = new GameObject[64];

    

    public Transform playerDeckSpawnLocation;
    public Transform enemyDeckSpawnLocation;


    


    void Start()
    {
        GeneratePlayerDeck();
        Instantiate(playerDeckArray[UnityEngine.Random.Range(0, 11)], playerDeckSpawnLocation.position, playerDeckSpawnLocation.rotation);
        GenerateEnemyDeck();
        Instantiate(enemyDeckArray[UnityEngine.Random.Range(0, 11)], enemyDeckSpawnLocation.position, enemyDeckSpawnLocation.rotation);
    }

    


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


}
