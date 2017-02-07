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

    public void DontAnimate ()
    {
        anim.SetBool("ViewingBooks", false);
        anim.SetBool("ViewingSneakers", false);
    }

    public void AnimateSneakers ()
    {
        anim.SetBool("ViewingSneakers", true);
    }
}
