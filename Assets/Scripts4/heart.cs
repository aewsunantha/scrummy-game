using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class heart : MonoBehaviour
{
    public Image[] heartImg;
    public Button yourButton;
    public int score;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        score = 5;
    }
    void TaskOnClick() //ถ้ากดคะแนนจะลด หัวใจจะหาย
    {
        score--;

        if (score <= 1)
        {
            score = 1;
        }
        heartImg[score].gameObject.SetActive(false);
    }

}
