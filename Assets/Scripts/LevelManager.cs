using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;
    public Transform[] position;
    public GameObject[] PkeepM;
    public GameObject[] PrevPkeepM;
    public List<GameObject> getRole = new List<GameObject>();
    public List<int> namePindex = new List<int>();
    public int tempnumbersCheck;
    public GameObject[] checkP;
    public Transform[] checkPP;
    public GameObject[] checkMMM;
    public Transform[] checkMM;
    public GameObject[] checkM;
    public int[] pay = { 52000, 37000, 38000, 25000, 25000, 30000, 51000, 36000, 50000 };
    public int[] exp = { 5, 4, 4, 3, 3, 4, 5, 4, 5 };
    public GameObject[] keepRole = {null,null,null,null,null,null,null,null,null};
    public GameObject[] keepMem = {null,null,null,null,null,null,null,null,null};
    public int countMem = 0;
    public List<int> numbers = new List<int>();
    public List<GameObject> numbersCheck = new List<GameObject>();
    [HideInInspector] public double callog=0;
    [HideInInspector] public float callog2=0;
    [HideInInspector] public double callog3=0;
    public float budget;
    public float budget2;
    [HideInInspector] public int totalCost = 0;
    [HideInInspector] public float cost = 0;
    [HideInInspector] public float month = 0;
    public double estimateTime = 16;

    public bool check22 = false;
    public bool check33 = false;
    public bool checkTime = false;
    public bool checkBudget = true;
    [HideInInspector] public int sumPay;
    [HideInInspector] public int sumExp;
    [HideInInspector] public Transform previousP;
    [HideInInspector] public Transform currentPP;
    public int[] p1;
    public int[] p2;
    public int[] p3;
    public int[] p4;
    public int[] p5;
    public int[] p6;
    public int[] p7;
    public int[] p8;
    public int[] p9;
    public string[] skill;
    public string[] skillCheck;

    public Text estimateTimetxt;
    public Text budgettxt;

    public Text[] selectedtxt;
    public Text[] nametext;
    public string[] nickname= { "Leo","Emma","Jacob","Alan","Grace","Irene","Morgan","Sarah","Oscar"};
    float getBudget;
    public GridLayoutGroup[] gridLayoutGroup;
    public int[] check333;
    public string[] check333text;

    public bool[] check;


    public void knowladge()
    {
        SceneManager.LoadScene("Mini 1 know");
    }




    void Start()
    {

        budget = 2800000;
        getBudget = budget;
        string formattedNumber = budget.ToString("n0");
        budgettxt.text = "Remaining Budget : " + formattedNumber + " ฿";
        Debug.Log(budget);

        for(int i=0; i<PkeepM.Length; i++)
        {
            position[i] = checkM[i].transform.parent;
            check333[i] = 2;
        }

        DoNotDestroy.instance.GetComponent<AudioSource>().Pause();


    }

    private void Awake()
    {
        Instance = this;   
    }
    public void movefirst()
    {

        for (int i = 0; i < position.Length; i++)
        {
            checkM[i].transform.position = position[i].transform.position;
        }

    }
    public void shownickname(PointerEventData eventData)
    {
        Debug.Log("shownickname");


        for (int i = 0; i < checkM.Length; i++)
        {
            if (Equals(eventData.pointerDrag, checkM[i]))
            {
                PrevPkeepM[i] = PkeepM[i];
                PkeepM[i] = keepRole[i];
            } 
        
        }
        

        for (int i = 0; i < keepRole.Length; i++)
        {
            for (int j = 0; j < checkP.Length; j++)
            {
                if (Equals(keepRole[j], checkP[i]) == true)
                {
                    keepMem[i] = checkM[j];
                    nametext[i].text = nickname[j];

                }

            }

        }



        for (int i = 0; i < checkM.Length; i++)
        {
            if (Equals(eventData.pointerDrag, checkM[i]) == true)
            {
                for (int j = 0; j < PrevPkeepM.Length; j++)
                {
                    if (Equals(PrevPkeepM[i], PkeepM[i]) == false)
                    {
                         if (Equals(PrevPkeepM[i], checkP[j]) == true)
                                            {
                                                Debug.Log("checkkkkkkkkkkkkk : " + PrevPkeepM[i] + " | " + j);
                                                keepMem[j] = null;
                            nametext[j].text = "";
                        }


                    }
                   


                }
            }

        }

              DoNotDestroy.instance.GetComponent<AudioSource>().Pause();
 

    }

    public void score(Transform previousP, Transform currentPP, PointerEventData eventData)
    {
      
        bool ansM;
        bool ansMMM;
        bool checkName;
        bool checkMember2;
   

        if (previousP == currentPP)    //check current Position กับ previous Positionว่า Member ที่เลือกนั้น ก่อนกันปัจจุบันอยู่ไหน
        {    //ถ้าอยู่ตำแหน่งเดียวกันไม่ทำอะไรเลย
          Debug.Log("score : nothing");
            for (int i = 0; i < checkMM.Length; i++)
            {
                ansMMM = Equals(eventData.pointerEnter, checkMM[i]);
                if (ansMMM == true)
                {
                    tempnumbersCheck = numbersCheck.Capacity;

                }
            }
        }
        else //ถ้าไม่อยู่ตำแหน่งเดียวกัน ให้ทำ sum Pay และ Sum exp
        {
            Debug.Log("score : DOsomething");

            for (int i = 0; i < checkM.Length; i++) //ทำการ sum ค่าต่างๆ ในกรณีที่ ลาก p ไปใส่ role position ต่างๆ 
            {
                ansM = Equals(eventData.pointerDrag, checkM[i]);

                checkMember2 = Equals(previousP, checkPP[i]);

                if (ansM == true)
                {
                    sumPay += pay[i];
                    sumExp += exp[i];
                    countMem++;
                    numbers.Add(exp[i]);
                    tempnumbersCheck = numbersCheck.Capacity;
                    numbersCheck.Add(eventData.pointerDrag);
                    getRole.Add(eventData.pointerEnter);
                    score3(eventData);

                    for (int j = 0; j < checkM.Length; j++)
                    {
                        checkName = Equals(eventData.pointerEnter, checkP[j]);
                      if (checkName == true)
                        {
                            //nametext[i].text = eventData.pointerDrag.name;
                           
                        }
                        
                    }

                }

                if (checkMember2 == true)//ลากไปใส่ role position จาก role ไป role
                {
                    for (int j = 0; j < checkM.Length; j++)
                    {
                        ansM = Equals(eventData.pointerDrag, checkM[j]);
                        if (ansM == true)
                        {

                            sumPay -= pay[j];
                            sumExp -= exp[j];
                            countMem--;
                            numbers.Remove(exp[j]);
                            tempnumbersCheck = numbersCheck.Capacity;
                            getRole.Remove(eventData.pointerEnter);

                            numbersCheck.Remove(eventData.pointerDrag);
                            score3(eventData);
                            //nametext[j].text = " ";

                        }
                    }

                }

            }

            for (int i = 0; i < checkMM.Length; i++) //ทำในกรณีที่ ลากกลับไปจุดเริ่มต้น
            {
                ansM = Equals(currentPP, checkMM[i]);
                if (ansM == true)
                {
                    sumPay -= pay[i];
                    sumExp -= exp[i];
                    countMem--;
                    numbers.Remove(exp[i]);
                    tempnumbersCheck = numbersCheck.Capacity;
                    getRole.Remove(eventData.pointerEnter);

                    numbersCheck.Remove(eventData.pointerDrag);
                    score3(eventData);
                   //nametext[i].text = " ";
                }
            }

            }
        

    }

    public void score2(List<int> numbers2 ,List<GameObject> numbersCheck2)
    {
        estimateTime = 16;

        float[] arrA = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
     
        if (countMem == 0)
        {
            totalCost = 0;
            estimateTime = 16;
            budget2 = getBudget;
        }
        else
        {

            if (sumExp == 0 && sumPay == 0)
            {
                totalCost = 0;
                estimateTime = 16;
            }
            else
            {
                for (int i = 0; i < (9 - countMem); i++)
                {
                    callog = Math.Log(2, 10) * (i+1);
                }

                callog2 = 0;
                for (int i = 0; i < countMem ; i++)
                {
                    arrA[i] = (float)Math.Log(numbers[i], 10);
                    callog2 += arrA[i];
                }
               
                estimateTime = 19 - (2.4 * (callog + callog2));
                month = (float)estimateTime;
                estimateTime = Math.Ceiling(estimateTime); 
                cost=(float)((sumPay + 60000) * estimateTime);
                budget2 = budget- cost;
               

                if (estimateTime > 8)
                {
                    checkTime = false;
                }
                else
                {
                    checkTime = true;
                }

                if(budget2 <= 0)
                {
                    checkBudget = false;
                }
                else
                {
                    checkBudget = true;
                }
                
            }
        }
        Debug.Log("budget2 : " + budget2);
        string formattedNumber = budget2.ToString("n0");
        budgettxt.text = "Remaining Budget : " + formattedNumber + " ฿";
        estimateTimetxt.text = "Estimated Time : " + estimateTime + " month";
    }
    public void score3(PointerEventData eventData)
    {
        bool ans; bool ans1; 
        check22 = false;
        Debug.Log("Score3");
        Debug.Log("member : " + eventData.pointerDrag);

        for(int i=0; i<check.Length; i++)
        {
            check[i] = false;
        }

        for (int i=0; i<checkM.Length; i++)
        {

            ans = Equals(eventData.pointerDrag, checkM[i]);
            if (ans == true)
            {
               
                keepRole[i] = eventData.pointerEnter;
            }

            ans1 = Equals(eventData.pointerEnter, checkMMM[i]);
            if (ans1 == true)
            {
                keepRole[i] = null;

            }

        }
       


        for (int i = 0; i < checkP.Length; i++)
        {
            for (int j = 0; j < keepRole.Length; j++)
            {
                if (checkP[i] == keepRole[j])
                {

                   // Debug.Log("role : " + skillCheck[i]);

                    switch (skillCheck[i])
                    {
                        case "Scrum" : check[0] =   true ; break;
                        case "Leader": check[1] =    true; break;
                        case "Programmer": check[2] = true; break;
                        case "Design": check[3] =    true; break;
                        case "Testing": check[4] =  true; break;  
                        default:  break;  
                    }


                }
               
              
            }      
        }



        if(check[0] == true && check[1] == true && check[2] == true && check[3] == true && check[4])
        {
            check22 = true;
        }
        else { check22 = false; }
        Debug.Log("test3333 : " + check22); //ตำแหน่งครบไหม
    }


    public void score4(PointerEventData eventData)
    {
        Debug.Log("Score444444444");
        bool ans1;
        check33 = true;
        
        string checkPositionNow=null;

        for (int i =0; i<keepRole.Length; i++)
        {
            if (keepRole[i] != null)
            {
                Debug.Log("keepRole : " + keepRole[i]);
                Debug.Log("member : " +eventData.pointerDrag.name);



                for(int j=0; j<checkP.Length; j++)
                {
                    ans1 = Equals(eventData.pointerEnter, checkP[j]);
                    if (ans1 == true)
                    {
                        Debug.Log("Role : " + eventData.pointerEnter.name);
                        switch (eventData.pointerEnter.name)
                        {
                            case "ScrumMaster"  : checkPositionNow = skillCheck[j]; break;
                            case "LeadDev"      : checkPositionNow = skillCheck[j]; break;
                            case "Dev"          : checkPositionNow = skillCheck[j]; break;
                            case "Designer"     : checkPositionNow = skillCheck[j]; break;
                            case "Tester"       : checkPositionNow = skillCheck[j]; break;
                            case "Dev2"         : checkPositionNow = skillCheck[j]; break;
                            case "Designer2"    : checkPositionNow = skillCheck[j]; break;
                            case "Tester2"      : checkPositionNow = skillCheck[j]; break;
                            case "Dev3"         : checkPositionNow = skillCheck[j]; break;
                            default:
                                Debug.Log("position : " + skillCheck[j]); checkPositionNow = skillCheck[j]; break;
                        }





                    }
                  

                    

                }

                //Debug.Log(checkPositionNow);




               //if(Equals(eventData.pointerEnter,checkMMM[i]))
                for (int j = 0; j < p1.Length; j++)
                {
                  
                    switch (eventData.pointerDrag.name)
                    {
                        case "p1": 
                            if (checkPositionNow == skill[j])
                            {
                                if (p1[j] >= 3){
                                    check333[0] = 1;
                                }
                                else { check333[0] = 0;}
                            }
                            break;
                        case "p2": 
                            if (checkPositionNow == skill[j])
                            {
                                if (p2[j] >= 3){
                                    check333[1] = 1;
                                }
                                else { check333[1] = 0; }

                            }

                            break;
                        case "p3":
                            if (checkPositionNow == skill[j])
                            {
                                if (p3[j] >= 3){ check333[2] = 1; }
                                else { check333[2] = 0; }

                            }
                            break;
                        case "p4":
                            if (checkPositionNow == skill[j])
                            {
                                if (p4[j] >= 3){
                                    check333[3] = 1;
                                }
                                else { check333[3] =0; }

                            }
                            break;
                        case "p5":
                            if (checkPositionNow == skill[j])
                            {
                                if (p5[j] >= 3) {
                                    check333[4] = 1;
                                }
                                else { check333[4] = 0; }
                            }
                            break;
                        case "p6":
                            if (checkPositionNow == skill[j])
                            {
                                if (p6[j] >= 3) {
                                    check333[5] = 1;
                                }
                                else { check333[5] = 0; }

                            }
                            break;
                        case "p7": 
                            if (checkPositionNow == skill[j])
                            {
                                if (p7[j] >= 3) {
                                    check333[6] = 1;
                                }
                                else  { check333[6] = 0; }

                            }
                            break;
                        case "p8": 
                            if (checkPositionNow == skill[j])
                            {
                                if (p8[j] >= 3)  {
                                    check333[7] = 1;
                                }
                                else { check333[7] = 0; }

                            }
                            break;
                        case "p9":
                            if (checkPositionNow == skill[j])
                            {
                                if (p9[j] >= 3) {
                                    check333[8] = 1;
                                }
                                else { check333[8] = 0; }

                            }

                            break;
                        default: break;
                    } 
                }  
                
               



            }
            else
            {
                check333[i] = 2;
            }  
        }

        
        for(int i=0; i<check333.Length; i++)
        {
            if (check333[i] == 2 ||check333[i] == 1) { check33 = check33 && true;}
            else if (check333[i] == 0) { check33 = check33&& false; }
            
        }
           Debug.Log("answer : " + check33);     //เหลือเช็คว่า ตำแหน่ง macth ไหม
        if (check33 == true)
        {
            Debug.Log("111chosen");
            Debug.Log(eventData.pointerDrag.name);

        }
        else
        {
            Debug.Log("0000chosen");

        }

    }

  
    }












