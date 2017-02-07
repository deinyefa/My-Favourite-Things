using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour {

    private Animator anim;

	void Start () {
        anim = GetComponent<Animator>();
	}

    public void AnimateBooks ()
    {
        anim.SetBool("ViewingBooks", true);
    }

    public void AnimateSneakers ()
    {
        anim.SetBool("ViewingSneakers", true);
    }

    public void AnimateXbox ()
    {
        anim.SetBool("ViewingXbox", true);
    }

    public void AnimateCardboard()
    {
        anim.SetBool("ViewingCardboard", true);
    }

    public void DontAnimate()
    {
        anim.SetBool("ViewingBooks", false);
        anim.SetBool("ViewingSneakers", false);
        anim.SetBool("ViewingXbox", false);
        anim.SetBool("ViewingCardboard", false);
    }
}
