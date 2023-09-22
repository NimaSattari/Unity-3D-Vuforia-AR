using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBTN : MonoBehaviour
{
    public Animator animator;
    public VirtualButtonBehaviour Vb;

    private void Start()
    {
        Vb.RegisterOnButtonPressed(OnButtonPressed);
        Vb.RegisterOnButtonReleased(OnButtonReleased);
    }

    public void OnButtonPressed(VirtualButtonBehaviour button)
    {
        animator.SetBool("attack", true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour button)
    {
        animator.SetBool("attack", false);
    }
}
