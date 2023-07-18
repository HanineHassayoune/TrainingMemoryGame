using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    bool isPressed = false;
    public Animator myAnimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayFlipAnimation()
    {
        if (isPressed) return;
        myAnimator.Play("CardFlip");
        isPressed = true;
       
    }
}
