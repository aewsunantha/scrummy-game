using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CtrlGame4 : MonoBehaviour
{
    public Vector2[] prePositonItem;
    public static CtrlGame4 Instance;
    public GameObject[] item2;
    public GameObject[] item3;
    public int scoreMini4;
    public bool[] check;
    public List<GameObject> keepItem = new List<GameObject> { };
    public string[] keepItemGrid;
    public GameObject[] item;
    public GameObject shapes;
    public GameObject bg4;
    public bool[] itemBool;    
    public int countItem = 0;
    public GameObject[] grid;
    public GameObject[] getItemSq;
    public string[] nameItem;
    public Vector3[] gridOfItem;
    public Vector3[] position;
    public Vector3[] prePosition;
    public int[] arrKeepC;
    public int[] arrKeepR;
    float x;
    float y;
    float z;
    public GameObject[,] Arr2D;
    public string[,] Arr2DGetGridAll;
    public string[] getNameItemPriority;
    public int[] getNumberItemPriority;
    public int row = 12;
    public int colunm = 36;
    public int[] arrR;
    public int[] arrC;
    public int[] arrPrioritySort;
    public string[] stringST;
    public int[] feature;
    public String [] getitem;
    public int[] getGridofItem;
    public int[] getColNumGridofItem;
    public int[] indexArr;
    public int[] indexArrP;
    public Button yourButton;
    public int o;
    public Text passmini4Text;
    public Text[] priorityText;
    public Text[] ErrText;
    public Text scoreMini4Text;
    public string[] pic1;
    public string[] pic11;
    public string[] pic2;
    public string[] pic22;
    public string[] pic3;
    public string[] pic33;
    public string[] pic4;
    public string[] pic44;
    public string[] pic5;
    public string[] pic55;
    public string[] pic6;
    public string[] pic66;
    public string[] textErr;
    public string[] saveArrResultGrid;
    public string[] arrResultGrid;

    public Image bgfade;
    public Image scrum;
    public Button okay;
    public bool chek;
    public Image[] heart;
    public int[] arrtempPri = { 0, 0, 0, 0, 0, 0 };
    public int[] indexArrPP = { 1, 2, 3, 4, 5, 6 };
    public string errorWeek;
    public string errorfeature;
    public string errorPri;
    public GameObject scrumhelp;



    public void nonehelp()
    {

        scrumhelp.SetActive(false);
    }

    public void sortGetNewPriority()
    {
        int n = arrtempPri.Length, i, j, tmp, tmp2;
        for (i = 0; i < n; i++)
        {
            for (j = i + 1; j < n; j++)
            {
                if (arrtempPri[j] < arrtempPri[i])
                {
                    tmp = arrtempPri[i];
                    arrtempPri[i] = arrtempPri[j];
                    arrtempPri[j] = tmp;

                    tmp2 = indexArrPP[i];
                    indexArrPP[i] = indexArrPP[j];
                    indexArrPP[j] = tmp2;
                }

            }
        }



    }
    void Start()
    {

        arrtempPri[0]= PlayerPrefs.GetInt("orderchat");
        arrtempPri[1]= PlayerPrefs.GetInt("orderpayment");
        arrtempPri[2]= PlayerPrefs.GetInt("orderproduct");
        arrtempPri[3]= PlayerPrefs.GetInt("orderaccount");
        arrtempPri[4]= PlayerPrefs.GetInt("orderregis");
        arrtempPri[5]= PlayerPrefs.GetInt("orderprofile");

        sortGetNewPriority();

        for(int i=0; i<arrtempPri.Length; i++)
        {
            getNumberItemPriority[i] = indexArrPP[i];
        }



        for(int i=0; i<prePosition.Length; i++)
        {
            prePositonItem[i] = item[i].transform.position;
            Debug.Log(prePositonItem[i]);
        }


        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        Button btn2 = okay.GetComponent<Button>();
        btn2.onClick.AddListener(Okay);
        countItem = 0;
        indexArr = new int[12];
        indexArrP = new int[6] {1,2,3,4,5,6};

        int[] indexArrTemp = new int[6];
        Arr2D = new GameObject[colunm, row];
        Arr2DGetGridAll = new string[colunm, row];

        for(int j=0; j< indexArrTemp.Length; j++)
        {
            indexArrTemp[j] = getNumberItemPriority[j];
        }

        sortGetPriority();


        for (int j = 0; j < indexArrTemp.Length; j++)
        {
            getNumberItemPriority[j]=indexArrTemp[j]  ;
        }

        int p = 0;


        for (int i = 0; i < colunm; i++)
        {       
            for (int j = 0; j < row; j++)
            {
                Arr2D[i, j] = grid[p];
                Arr2DGetGridAll[i, j] = "F";
                p++;
            }

        }
      
          for(int e=0; e < getNumberItemPriority.Length; e++)
            {

            priorityText[e].text = " " + indexArrP[e];
            }


    pic1=new string[9];
    pic11 = new string[4]; 
    pic2  = new string[7];
    pic22 = new string[5];
    pic3  = new string[5]; 
    pic33 = new string[6]; 
    pic4 = new string[4];
    pic44 = new string[4];
    pic5 = new string[3];
    pic55 = new string[5];
    pic6 = new string[4];
    pic66 = new string[3];
    keepItemGrid = new string[12];
    scoreMini4 = 5;
        bgfade.gameObject.SetActive(false);
        scrum.gameObject.SetActive(false);
        okay.gameObject.SetActive(false);
        ErrText[0].gameObject.SetActive(false);
        ErrText[1].gameObject.SetActive(false);
        ErrText[2].gameObject.SetActive(false);
        ErrText[3].gameObject.SetActive(false);
        passmini4Text.gameObject.SetActive(false);
        for (int i = 0; i < heart.Length; i++)
        {
            heart[0].gameObject.SetActive(true);
        }    
        DoNotDestroy.instance.GetComponent<AudioSource>().Pause();

    }

private void Awake()
    {
        Instance = this;
    }

    public void showErr(PointerEventData eventData)
    {

        for(int i =0; i<nameItem.Length; i++)
        {
            if(Equals(eventData.pointerDrag, item[i])==true)
            {
                
                    Debug.Log("showErr ........." + nameItem[i]);
            }
        }
       
    }

    public void gotoshape(PointerEventData eventData)
    {
        for (int y = 0; y < item.Length; y++)
        {
            if (Equals(item[y], eventData.pointerDrag) == true)
            {
                item[y].transform.position = prePositonItem[y];
            }
        }
    }

    public void snaptogrid(PointerEventData eventData)
    {
        for (int w = 0; w < getitem.Length; w++)
        {
            if (Equals(item[w], eventData.pointerDrag) == true)
            {
                getitem[w] = item[w].name;
                Debug.Log("test   |" + eventData.pointerEnter);

                if (Equals(eventData.pointerEnter, shapes) == true | Equals(eventData.pointerEnter, bg4) == true)
                {


                    for (int y = 0; y < item.Length; y++)
                    {
                        if (Equals(item[y], eventData.pointerDrag) == true)
                        {
                            item[y].transform.position = prePositonItem[y];
                        }

                    }

                }
                else
                {


                    for (int i = 0; i < item2.Length; i++) //เลขคู่
                    {
                        if (Equals(item2[i], eventData.pointerDrag) == true)
                        {
                            Debug.Log("trueคู่ " + item2[i]);
                            Debug.Log("true " + eventData.pointerDrag);

                            float xposgrid = eventData.pointerEnter.transform.position.x - 18f;
                            float yposgrid = eventData.pointerEnter.transform.position.y;
                            Vector3 pos = new Vector3(xposgrid, yposgrid, 0f);
                            gridOfItem[w] = pos;
                            item[w].transform.position = gridOfItem[w];
                            item[w].SetActive(false);
                            item[w].SetActive(true);
                        }

                    }


                    for (int t = 0; t < item3.Length; t++)  //เลขคี่
                    {
                        if (Equals(item3[t], eventData.pointerDrag) == true)
                        {
                            Debug.Log("trueคี่ " + item3[t]);
                            Debug.Log("true " + eventData.pointerDrag);
                            gridOfItem[w] = eventData.pointerEnter.transform.position;
                            item[w].transform.position = gridOfItem[w];
                            item[w].SetActive(false);
                            item[w].SetActive(true);
                        }

                    }



                }

                switch (w)
                {
                    case 0:

                        if (pic1[0] == null | pic1[pic1.Length - 1] == null)
                        {
                            Debug.Log("djifdsfjsdl");
                            gotoshape(eventData);
                        }

                        break;
                    case 1:
                        if (pic11[0] == null | pic11[pic11.Length - 1] == null)
                        {
                            gotoshape(eventData);
                        }
                        break;
                    case 2:
                        if (pic2[0] == null | pic2[pic2.Length - 1] == null)
                        {
                            gotoshape(eventData);
                        }
                        break;
                    case 3:
                        if (pic22[0] == null | pic22[pic22.Length - 1] == null)
                        {
                            gotoshape(eventData);
                        }
                        break;
                    case 4:
                        if (pic3[0] == null | pic3[pic3.Length - 1] == null)
                        {
                            gotoshape(eventData);
                        }
                        break;
                    case 5:
                        if (pic33[0] == null | pic33[pic33.Length - 1] == null)
                        {
                            gotoshape(eventData);
                        }
                        break;
                    case 6:
                        if (pic4[0] == null | pic4[pic44.Length - 1] == null)
                        {
                            gotoshape(eventData);
                        }
                        break;
                    case 7:
                        if (pic44[0] == null | pic44[pic44.Length - 1] == null)
                        {
                            gotoshape(eventData);
                        }
                        break;
                    case 8:
                        if (pic5[0] == null | pic5[pic5.Length - 1] == null)
                        {
                            gotoshape(eventData);
                        }
                        break;
                    case 9:
                        if (pic55[0] == null | pic55[pic55.Length - 1] == null)
                        {
                            gotoshape(eventData);
                        }
                        break;
                    case 10:
                        if (pic6[0] == null | pic6[pic6.Length - 1] == null)
                        {
                            gotoshape(eventData);
                        }
                        break;
                    case 11:
                        if (pic66[0] == null | pic66[pic66.Length - 1] == null)
                        {
                            gotoshape(eventData);
                        }
                        break;
                }


                int j = 0;
                switch (w)
                {
                    case 0:
                        keepItemGrid[0] = pic1[0];
                        keepgridofitem(w, keepItemGrid[0]);
                        break;
                    case 1:
                        keepItemGrid[1] = pic11[0];
                        keepgridofitem(w, keepItemGrid[1]);

                        break;
                    case 2:
                        keepItemGrid[2] = pic2[0];
                        keepgridofitem(w, keepItemGrid[2]);

                        break;
                    case 3:
                        keepItemGrid[3] = pic22[0];
                        keepgridofitem(w, keepItemGrid[3]);

                        break;
                    case 4:
                        keepItemGrid[4] = pic3[0];
                        keepgridofitem(w, keepItemGrid[4]);

                        break;
                    case 5:
                        keepItemGrid[5] = pic33[0];
                        keepgridofitem(w, keepItemGrid[5]);

                        break;
                    case 6:
                        keepItemGrid[6] = pic4[0];
                        keepgridofitem(w, keepItemGrid[6]);

                        break;
                    case 7:
                        keepItemGrid[7] = pic44[0];
                        keepgridofitem(w, keepItemGrid[7]);

                        break;
                    case 8:
                        keepItemGrid[8] = pic5[0];
                        keepgridofitem(w, keepItemGrid[8]);

                        break;
                    case 9:
                        keepItemGrid[9] = pic55[0];
                        keepgridofitem(w, keepItemGrid[9]);

                        break;
                    case 10:
                        keepItemGrid[10] = pic6[0];
                        keepgridofitem(w, keepItemGrid[10]);

                        break;
                    case 11:
                        for (j = 0; j < pic66.Length; j++)
                        {
                            keepItemGrid[11] = pic66[0];
                            keepgridofitem(w, keepItemGrid[11]);

                        }
                        break;

                }


            }

        }




    }

    public void sqtogrid(PointerEventData eventData, GameObject[] gridSq,int numdis)
    {
        showErr(eventData);
        for (int w = 0; w < getitem.Length; w++)
        {
            float distance;
            arrResultGrid = new string[gridSq.Length];
            Vector3 checkposition;
            for (int i = 0; i < gridSq.Length; i++) //loop grid of item 0-9 week
            {
                checkposition = gridSq[i].transform.position;
                for (int j = 0; j < grid.Length; j++) //loop Grid  (0-432)
                {
                    distance = Vector2.Distance(checkposition, grid[j].transform.position);
                    if (distance < numdis)
                    {
                        //Debug.Log(squareImage[i].name + " / " + grid[j].name);
                        arrResultGrid[i] = grid[j].name;
                    }
                }
            }

        }

        for (int i = 0; i < itemBool.Length; i++)
        {
            if (Equals(eventData.pointerEnter, shapes) == true)
            {
                itemBool[i] = false;
                if (keepItem.Contains(eventData.pointerDrag))
                {

                    keepItem.Remove(eventData.pointerDrag);
                    countItem--;
                }
                if (item[i] == eventData.pointerDrag)
                {
                    removekeepGridSq(i);
                }
            }
            else
            {
                if (!keepItem.Contains(eventData.pointerDrag))
                {
                    if (item[i] == eventData.pointerDrag)
                    {
                        itemBool[i] = true;
                        keepItem.Add(eventData.pointerDrag);
                        countItem++;
                        int j = 0;
                        switch (i)
                        {
                            case 0:
                                for (j = 0; j < pic1.Length; j++)
                                {
                                    pic1[j] = arrResultGrid[j];
                                }
                                break;
                            case 1:
                                for (j = 0; j < pic11.Length; j++)
                                {
                                    pic11[j] = arrResultGrid[j];
                                }
                                break;
                            case 2:
                                for (j = 0; j < pic2.Length; j++)
                                {
                                    pic2[j] = arrResultGrid[j];
                                }
                                break;
                            case 3:
                                for (j = 0; j < pic22.Length; j++)
                                {
                                    pic22[j] = arrResultGrid[j];
                                }
                                break;
                            case 4:
                                for (j = 0; j < pic3.Length; j++)
                                {
                                    pic3[j] = arrResultGrid[j];
                                }
                                break;
                            case 5:
                                for (j = 0; j < pic33.Length; j++)
                                {
                                    pic33[j] = arrResultGrid[j];

                                }
                                break;
                            case 6:
                                for (j = 0; j < pic4.Length; j++)
                                {
                                    pic4[j] = arrResultGrid[j];

                                }
                                break;
                            case 7:
                                for (j = 0; j < pic44.Length; j++)
                                {
                                    pic44[j] = arrResultGrid[j];

                                }
                                break;
                            case 8:
                                for (j = 0; j < pic5.Length; j++)
                                {
                                    pic5[j] = arrResultGrid[j];
                                }
                                break;
                            case 9:
                                for (j = 0; j < pic55.Length; j++)
                                {
                                    pic55[j] = arrResultGrid[j];
                                }
                                break;
                            case 10:
                                for (j = 0; j < pic6.Length; j++)
                                {
                                    pic6[j] = arrResultGrid[j];
                                }
                                break;
                            case 11:
                                for (j = 0; j < pic66.Length; j++)
                                {
                                    pic66[j] = arrResultGrid[j];
                                }
                                break;
                        }
                    }
                }
                else
                {
                    if (item[i] == eventData.pointerDrag)
                    {
                        int j = 0;
                        switch (i)
                        {
                            case 0:
                                for (j = 0; j < pic1.Length; j++)
                                {
                                    pic1[j] = arrResultGrid[j];
                                }
                                break;
                            case 1:
                                for (j = 0; j < pic11.Length; j++)
                                {
                                    pic11[j] = arrResultGrid[j];
                                }
                                break;
                            case 2:
                                for (j = 0; j < pic2.Length; j++)
                                {
                                    pic2[j] = arrResultGrid[j];
                                }
                                break;
                            case 3:
                                for (j = 0; j < pic22.Length; j++)
                                {
                                    pic22[j] = arrResultGrid[j];
                                }
                                break;
                            case 4:
                                for (j = 0; j < pic3.Length; j++)
                                {
                                    pic3[j] = arrResultGrid[j];
                                }
                                break;
                            case 5:
                                for (j = 0; j < pic33.Length; j++)
                                {
                                    pic33[j] = arrResultGrid[j];
                                }
                                break;
                            case 6:
                                for (j = 0; j < pic4.Length; j++)
                                {
                                    pic4[j] = arrResultGrid[j];
                                }
                                break;
                            case 7:
                                for (j = 0; j < pic44.Length; j++)
                                {
                                    pic44[j] = arrResultGrid[j];
                                }
                                break;
                            case 8:
                                for (j = 0; j < pic5.Length; j++)
                                {
                                    pic5[j] = arrResultGrid[j];
                                }
                                break;
                            case 9:
                                for (j = 0; j < pic55.Length; j++)
                                {
                                    pic55[j] = arrResultGrid[j];
                                }
                                break;
                            case 10:
                                for (j = 0; j < pic6.Length; j++)
                                {
                                    pic6[j] = arrResultGrid[j];
                                }
                                break;
                            case 11:
                                for (j = 0; j < pic66.Length; j++)
                                {
                                    pic66[j] = arrResultGrid[j];
                                }
                                break;
                        }

                    }

                }

            }

        }


    }


    public void test2(PointerEventData eventData, GameObject[] gridSq)
    {
        sqtogrid(eventData, gridSq,40);
        snaptogrid(eventData);
        sqtogrid(eventData, gridSq,15);
        //snaptogrid(eventData);
    }




    void keepgridofitem(int w, string keepItemgrid)
    {
        
                for (int i = 0; i < colunm; i++)
                {
                    for (int y = 0; y < row; y++)
                    {
                        if (Equals(Arr2D[i, y].name, keepItemgrid) == true) //แก้แค่บรรทัด
                        {
                            getGridofItem[w] = (y / 2) + 1;
                        }
                    }
                }
        
               

    }

    void forloop12sq()
    {   
        for(int i=0; i<pic1.Length; i++)
        {
            saveT(pic1, i);
        }
        for(int i=0; i<pic11.Length; i++)
        {
            saveT(pic11, i);

        }
        for (int i=0; i<pic2.Length; i++)
        {
            saveT(pic2, i);


        }
        for (int i=0; i<pic22.Length; i++)
        {
            saveT(pic22, i);

        }
        for (int i=0; i<pic3.Length; i++)
        {
            saveT(pic3, i);


        }
        for (int i=0; i<pic33.Length; i++)
        {
            saveT(pic33, i);

        }
        for (int i=0; i<pic4.Length; i++)
        {
            saveT(pic4, i);


        }
        for (int i=0; i<pic44.Length; i++)
        {
            saveT(pic44, i);

        }
        for (int i=0; i<pic5.Length; i++)
        {
            saveT(pic5, i);


        }
        for (int i=0; i<pic55.Length; i++)
        {
            saveT(pic55, i);


        }
        for (int i=0; i<pic6.Length; i++)
        {
            saveT(pic6, i);

        }  
        for (int i=0; i<pic66.Length; i++)
        {
            saveT(pic66, i);

        }
    }
    void forloop12sqF()
    {
        for (int i = 0; i < pic1.Length; i++)
        {
            saveF(pic1, i);
        }
        for (int i = 0; i < pic11.Length; i++)
        {
            saveF(pic11, i);

        }
        for (int i = 0; i < pic2.Length; i++)
        {
            saveF(pic2, i);


        }
        for (int i = 0; i < pic22.Length; i++)
        {
            saveF(pic22, i);

        }
        for (int i = 0; i < pic3.Length; i++)
        {
            saveF(pic3, i);


        }
        for (int i = 0; i < pic33.Length; i++)
        {
            saveF(pic33, i);

        }
        for (int i = 0; i < pic4.Length; i++)
        {
            saveF(pic4, i);


        }
        for (int i = 0; i < pic44.Length; i++)
        {
            saveF(pic44, i);

        }
        for (int i = 0; i < pic5.Length; i++)
        {
            saveF(pic5, i);


        }
        for (int i = 0; i < pic55.Length; i++)
        {
            saveF(pic55, i);


        }
        for (int i = 0; i < pic6.Length; i++)
        {
            saveF(pic6, i);

        }
        for (int i = 0; i < pic66.Length; i++)
        {
            saveF(pic66, i);

        }
    }

    void saveT(string[] getGridResult,int p)
    {
        for (int i = 0; i < colunm; i++)
        {
            for (int j = 0; j < row; j++)
            {
                if (getGridResult[p] == Arr2D[i, j].name)
                {
                   /*arrC[p] = i;
                    arrR[p] = j;
                    stringST[p] = getGridResult[p];*/
                    Arr2DGetGridAll[i, j] = "T";

                }
            }

        }
    }    
    void saveF(string[] getGridResult,int p)
    {
        for (int i = 0; i < colunm; i++)
        {
            for (int j = 0; j < row; j++)
            {
                if (getGridResult[p] == Arr2D[i, j].name)
                {
                    Arr2DGetGridAll[i, j] = "F";
                   
                }
            }

        }
    }
  
    void removekeepGridSq(int i)
    {
        int j = 0;
        switch (i)
        {
            case 0:
                for (j = 0; j < pic1.Length; j++)
                {
                    pic1[j] = null ;
                }
                break;
            case 1:
                for (j = 0; j < pic11.Length; j++)
                {
                    pic11[j] = null;
                }
                break;
            case 2:
                for (j = 0; j < pic2.Length; j++)
                {
                    pic2[j] = null;
                }
                break;
            case 3:
                for (j = 0; j < pic22.Length; j++)
                {
                    pic22[j] = null;
                }
                break;
            case 4:
                for (j = 0; j < pic3.Length; j++)
                {
                    pic3[j] = null;
                }
                break;
            case 5:
                for (j = 0; j < pic33.Length; j++)
                {
                    pic33[j] = null;
                }
                break;
            case 6:
                for (j = 0; j < pic4.Length; j++)
                {
                    pic4[j] = null;
                }
                break;
            case 7:
                for (j = 0; j < pic44.Length; j++)
                {
                    pic44[j] = null;
                }
                break;
            case 8:
                for (j = 0; j < pic5.Length; j++)
                {
                    pic5[j] = null;
                }
                break;
            case 9:
                for (j = 0; j < pic55.Length; j++)
                {
                    pic55[j] = null;
                }
                break;
            case 10:
                for (j = 0; j < pic6.Length; j++)
                {
                    pic6[j] = null;
                }
                break;
            case 11:
                for (j = 0; j < pic66.Length; j++)
                {
                    pic66[j] = null;
                }
                break;
        }


    }

    public void knowledge()
    {
        PlayerPrefs.SetInt("mini4", scoreMini4);
        PlayerPrefs.SetInt("scDisplay", scoreMini4);
        SceneManager.LoadScene("Mini 4 know");
    }



    void Okay()
    {
        bgfade.gameObject.SetActive(false);
        scrum.gameObject.SetActive(false);
        okay.gameObject.SetActive(false);
        ErrText[0].gameObject.SetActive(false);
        ErrText[1].gameObject.SetActive(false);
        ErrText[2].gameObject.SetActive(false);
        ErrText[3].gameObject.SetActive(false);
        passmini4Text.gameObject.SetActive(false);

        for (int t = 0; t < check.Length; t++)
        {
           
            
          ErrText[t].text = "";
         
        }
    passmini4Text.text = "";
        if(CheckAllTrue(check) == true)
        {
            //send score
            PlayerPrefs.SetInt("mini4", scoreMini4);
            PlayerPrefs.SetInt("scDisplay", scoreMini4);
            //load next scence mini5
            SceneManager.LoadScene("Mini 4 know");
        }
    }


    void TaskOnClick()
    {

        bgfade.gameObject.SetActive(true);
        scrum.gameObject.SetActive(true);
        okay.gameObject.SetActive(true);
        ErrText[0].gameObject.SetActive(true);
        ErrText[1].gameObject.SetActive(true);
        ErrText[2].gameObject.SetActive(true);
        ErrText[3].gameObject.SetActive(true);
        passmini4Text.gameObject.SetActive(true);

        forloop12sq();
        check = new bool[4] { false, false, false, false };
        o++;
        Debug.Log("click : " + o);

        if (countItem == 12)
        {
            Debug.Log("You12");  
            int[] arrk = new int[36];
        Debug.Log("................................You have clicked the button!...............................");
            
        Debug.Log("................................111111111111111...............................");

        check[0] = checkitemAndFeature();
            Debug.Log(check[0]);
        Debug.Log("................................222222222222222...............................");

        check[1] = CheckRowMoreThan2()[0];
            Debug.Log(check[1]);
            check[2] = CheckRowMoreThan2()[1];
            Debug.Log(check[2]);
            Debug.Log("................................333333333333333...............................");
        check[3] = checkPriority();
            Debug.Log(check[3]);
            Debug.Log("------------------------------END---------------------------");




            if (CheckAllTrue(check) == true)
            {
                Debug.Log("You Pass");
                if (scoreMini4 <= 1)
                {
                    scoreMini4 = 1;

                }

                passmini4Text.text = "ดีใจด้วย! ที่เล่นเกมผ่านซักที";
                
               

                for (int t = 0; t < check.Length; t++)
                {
                        ErrText[t].text = "";
                }
             
            }
            else
            {
                Debug.Log("You Fail");
                for(int t=0; t<check.Length; t++)
                {
                    if (check[t]== false)
                    {

                        if (t == 0)
                        {
                            ErrText[0].text += (errorfeature + "ยังไม่ Match กับ Feature หลัก\n");
                        }else if (t == 1)
                        {
                            ErrText[0].text += ("Week ที่ " +errorWeek + " " +textErr[t]+"\n");
                        }else if (t == 2){ErrText[0].text += textErr[t] + "\n"; }
                        else  if (t == 3){
                            ErrText[0].text +=  textErr[t] +" " +errorPri;
                        }
                       
                         
                    }
                    else
                    {
                        ErrText[0].text += "";
                    }
                }
                scoreMini4--;
               
                if (scoreMini4 <= 1)
                {
                    scoreMini4 = 1;
                    scrumhelp.SetActive(true);
                }
                heart[scoreMini4].gameObject.SetActive(false);

            }
        }
        else
        {
            passmini4Text.text = "ต้องลาก feature ย่อยทุก feature เข้าไปในตาราง";

            Debug.Log("You not12");

        }
        forloop12sqF();

    }

    public void sortGetPriority()
    {
        int n = getNumberItemPriority.Length, i, j, tmp, tmp2;
        for (i = 0; i < n; i++)
        {
            for (j = i + 1; j < n; j++)
            {
                if (getNumberItemPriority[j] < getNumberItemPriority[i])
                {
                    tmp = getNumberItemPriority[i];
                    getNumberItemPriority[i] = getNumberItemPriority[j];
                    getNumberItemPriority[j] = tmp;

                    tmp2 = indexArrP[i];
                    indexArrP[i] = indexArrP[j];
                    indexArrP[j] = tmp2;
                }

            }
        }



    }
        
    public void sortPriority()
    {
        int n = getColNumGridofItem.Length, i, j, tmp, tmp2;
        for (i = 0; i < n; i++)
        {
            for (j = i + 1; j < n; j++)
            {
                if (getColNumGridofItem[j] < getColNumGridofItem[i])
                {
                    tmp = getColNumGridofItem[i];
                    getColNumGridofItem[i] = getColNumGridofItem[j];
                    getColNumGridofItem[j] = tmp;

                    tmp2 = indexArr[i];
                    indexArr[i] = indexArr[j];
                    indexArr[j] = tmp2;
                }
            }
        }

        int p = 0;

        for (int k = 0; k < indexArr.Length; k+=2)
        {

            if (indexArr[k] > indexArr[k + 1])
            {
                arrPrioritySort[p] = (indexArr[k])/2;
                p++;
            }
            else
            {
                arrPrioritySort[p] = (indexArr[k+1])/2;
                p++;
            }

        }
       
    }

    public bool checkPriority()
    {

        for(int p=0; p< keepItemGrid.Length; p++)
        {
          for (int i = 0; i < colunm; i++)
        {
            for (int j = 0; j < row; j++)
            {
                if(Arr2D[i, j].name == keepItemGrid[p])
                    {
                        getColNumGridofItem[p] = i;
                        indexArr[p] = p+1;
                    }
            }

        }   
        }
        sortPriority();

        bool[] checkmatchPriority = { false, false, false, false, false, false };
        bool checkTrueMacth = false;
        errorPri = "";
        for (int g=0; g<arrPrioritySort.Length; g++)
        {
            if (arrPrioritySort[g] == getNumberItemPriority[g])
            {
              
                checkmatchPriority[g] = true;

            }
            else
            {
                checkmatchPriority[g] = false;
                Debug.Log("priority " + (g+1) + " :" + checkmatchPriority[g]);
                errorPri += " " + (g + 1);
            }
        }
        bool result = CheckAllTrue(checkmatchPriority);

        if (result == true)
        {
            Debug.Log("priority : Pass");
            checkTrueMacth = true;

        }
        else
        {
            Debug.Log("priority : fail");
            checkTrueMacth = false;

        }
        return checkTrueMacth;

    }


    public static bool CheckAllTrue(bool[] array)
    {
        foreach (bool element in array)
        {
            if (!element)
            {
                return false;
            }
        }
        return true;
    }
    

    public void checkCondition(string[] getGridResult)   
    {
       
        arrC = new int[getGridResult.Length];
        arrR = new int[getGridResult.Length];
        stringST = new string[getGridResult.Length];

        for (int p = 0; p < getGridResult.Length; p++)
            {
                        for (int i = 0; i < colunm; i++)
                        {
                            for (int j = 0; j < row; j++)
                            {
                              if (getGridResult[p]==Arr2D[i, j].name)
                                {
                    Arr2DGetGridAll[i, j] = "T";
                     
                                }
                            }

                        }
                    }

    }

    public string ReplaceSpacesWithCommas(string input)
    {
        string output = input;
        if (input.ToLower().Contains("spec"))
        {
            output = output.Replace(' ', ',');
        }
        return output;
    }
    public bool[] CheckRowMoreThan2()// เอาไปใช้ตอนเช็ครวม 
    { bool[] arrcheck2 = { true, false };
        int countTask = 0;
        arrKeepC = new int[colunm];
        arrKeepR = new int[row];
        int temp = 0;
      
        for (int i = 0; i < colunm; i++)
        {
            for (int j = 0; j < row; j++)
            {
                if (Arr2DGetGridAll[i, j] == "T")
                {
                    countTask++;
                    arrKeepR[j] = i+1;
                    
                }
            }
            arrKeepC[i] = countTask;
            countTask = 0;
        }

        errorWeek = "";
        for (int p = 0; p < arrKeepC.Length; p++)
        {
            if (arrKeepC[p] > 2)
            {
                temp = p + 1;
                Debug.Log(arrKeepC[p]);
                Debug.Log("week No. " + temp);


                errorWeek += " "+temp;
                
                Debug.Log("task more then 2 task in week");
                arrcheck2[0] = arrcheck2[0] && false;
            }
            else
            {
                arrcheck2[0] = arrcheck2[0] && true;
            }
           
        }
        string modifiedString = ReplaceSpacesWithCommas(errorWeek);
        errorWeek = modifiedString;
       int max = Mathf.Max(arrKeepR);
        Debug.Log("time :" + max + " week");
        if (max > 32)
        {
            arrcheck2[1] = false;

            Debug.Log("overtime (task must not over 8 month)");
        }
        else
        {
            arrcheck2[1] = true;
            Debug.Log("CheckTime: pass");

        }

        return arrcheck2;

    }
   
    public bool checkitemAndFeature()
    {
        errorfeature = "";
        bool saveAns = true;
        bool checkitemAndFeature = false;
        int[] getfail = new int[feature.Length];
        
        for(int i=0; i<feature.Length; i++)
        {
            if (feature[i] != getGridofItem[i])
            {
                saveAns = false;
                getfail[i] = 1;
               
            }
           
        }

        if(saveAns == false)
        {
            
            Debug.Log("item and Feature not match");
            checkitemAndFeature = false;
            for (int i =0; i<getfail.Length; i++)
            {
                if (getfail[i] == 1)
                {
                    errorfeature += (nameItem[i] + " , ");
                    Debug.Log( nameItem[i] + " ยังไม่ Match กับ Feature หลัก"); // reverseswift


                    item[i].transform.position = prePositonItem[i];
                    item[i].SetActive(false);
                    item[i].SetActive(true);

                }
            }
            string modifiedString = ReplaceSpacesWithCommas(errorfeature);
            errorfeature = modifiedString;
        }
        else
        {
            Debug.Log("item and Feature match");
            checkitemAndFeature = true;
        }

        return checkitemAndFeature;
    }

}


    

