using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class btnSpinKick : MonoBehaviour
{
    public GameObject vbtn;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        vbtn = GameObject.Find("SpinKick");
        vbtn.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vbtn.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonRelese);
        anim = GameObject.Find("Girl").GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        anim.Play("Spinkick");
        Debug.Log("pressed");
    }

    public void OnButtonRelese(VirtualButtonBehaviour vb)
    {
        //anim.Play("Hikick");
        Debug.Log("released");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
