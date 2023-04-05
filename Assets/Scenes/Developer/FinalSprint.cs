using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalSprint : MonoBehaviour
{
    public GameObject video1, video2;
    public void Final()
    {
        SceneManager.LoadScene("1DayPart2");
    }
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Final", 5.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}