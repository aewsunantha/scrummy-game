using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEditor;

public class test2 : MonoBehaviour
{
    public GameObject accountManagement, chat, payment, product, registeration, userProfile;
    public GameObject[] choiceArray = new GameObject[6];
    public Vector2[] Pos = new Vector2[6];
    public Vector2 initpos;
   

    public void DragChoice(GameObject Choicex)
    {
        Choicex.transform.position = Input.mousePosition;
        Choicex.transform.SetAsLastSibling();
        

    }

    public void DropChoiceAccount(GameObject accountManagement)
    {
        switchCalculator3(accountManagement ,choiceArray, Pos);
        
    }

    public void DropChoiceProduct()
    {
        switchCalculator3(product, choiceArray, Pos);
    }

    public void DropChoicePayment()
    {
        switchCalculator3(payment, choiceArray, Pos);
    }

    public void DropChoiceUserProfile()
    {
        switchCalculator3(userProfile, choiceArray, Pos);
    }

    public void DropChoiceRegister()
    {
        switchCalculator3(registeration, choiceArray, Pos);
    }

    public void DropChoiceChat()
    {
        switchCalculator3(chat, choiceArray, Pos);
    }


    
    public static int findIndex(GameObject[] array ,GameObject item)
        {
            return Array.IndexOf(array, item);
        }
    



    public void switchCalculator3(GameObject a, GameObject[] choice, Vector2[] b)
    {
        
        int dragingIndex = findIndex(choice,a);
       // Debug.Log(dragingIndex);

        for (int i = 5; i >= 0; i--)
        {

            
            float Distance = Vector2.Distance(choice[i].transform.position, a.transform.position);

            if (Distance < 50)
            {

                Vector2 Position1 = b[dragingIndex];
                

                a.transform.position = b[i];
                choice[i].transform.position = Position1;

                
                b[i] = Position1;
                b[dragingIndex] = a.transform.position;
                Debug.Log("internal "+i);

                
            }

            else { 
                a.transform.position = b[dragingIndex];
                Debug.Log("external"+i);
                }
        }
        

    }


    public void switchCalculator(GameObject[] choice, Vector2[] b)
    {
        Vector2 Position1, Position2;


        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                float Distance = Vector2.Distance(choice[i].transform.position, choice[j].transform.position);

                if (Distance < 100)
                {

                    Position1 = b[i];
                    Position2 = b[j];

                    choice[j].transform.position = Position1;
                    choice[i].transform.position = Position2;

                    b[i] = Position2;
                    b[j] = Position1;


                }

                else
                    choice[i].transform.position = b[i];

            }


            Debug.Log(choice[i]);
            Debug.Log(b[i]);
        }


    }










    void Start()
    {

        for (int i = 5; i >= 0; i--)
        {
            Pos[i] = choiceArray[i].transform.position;
        }


    }

    







}
