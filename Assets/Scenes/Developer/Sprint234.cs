using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sprint234 : MonoBehaviour
{
    public GameObject video1, video2;
    public void gotoFinal()
    {
        SceneManager.LoadScene("FinalSprint");
    }
    // Start is called before the first frame update
    void Start()
    {
        Invoke("gotoFinal", 14f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}