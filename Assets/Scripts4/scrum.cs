using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scrum : MonoBehaviour
{
    public Text showtext;
    public Image bgfade;
    public Image scrumpic;
    public Button okay;
    public Button yourButton;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        Button btn2 = okay.GetComponent<Button>();
        btn2.onClick.AddListener(Okay);

        bgfade.gameObject.SetActive(false);
        scrumpic.gameObject.SetActive(false);
        okay.gameObject.SetActive(false);
        showtext.gameObject.SetActive(false);
        
    }

    void Okay()
    {
        bgfade.gameObject.SetActive(false);
        scrumpic.gameObject.SetActive(false);
        okay.gameObject.SetActive(false);
        showtext.gameObject.SetActive(false);

    }


    void TaskOnClick()
    {
        bgfade.gameObject.SetActive(true);
        scrumpic.gameObject.SetActive(true);
        okay.gameObject.SetActive(true);
        showtext.gameObject.SetActive(true);
        showtext.text = "Good Job";
    }


}
