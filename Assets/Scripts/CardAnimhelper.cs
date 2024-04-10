using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardAnimhelper : MonoBehaviour
{
    [SerializeField]
    Animator anim;
    public void Prev() {
        //anim.ResetTrigger("Close");
        anim.SetBool("Open",true);
    }
    public void Clos()
    {
        //anim.ResetTrigger("Open");
        anim.SetBool("Open", false);
    }
}
