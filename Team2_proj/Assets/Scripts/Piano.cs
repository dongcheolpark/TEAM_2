using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piano : grabObject
{
    public bool isClicked;
    private GameObject piano;
    // Start is called before the first frame update
    void Start()
    {
        isGrabing = false;
        isGrabable = false;
        playerPos = GameObject.FindWithTag("Player").transform;
        piano = GameObject.FindWithTag("PianoUI");
    }

    // Update is called once per frame
    void Update()
    {
        RayCollide();
        HighlightObj();
        ShowPiano();
    }

    
    void ShowPiano() //피아노가 클릭됐을 때 피아노 건반을 띄움
    {
        if(isClicked)
        {
            Debug.Log(piano.name);
            piano.GetComponent<PianoUI>().gameObject.SetActive(true);
            Debug.Log("피아노가 클릭됨");
            isClicked = false;
        }
        
    }
}
