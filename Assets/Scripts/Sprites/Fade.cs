using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{
    public Animator[] childs;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (collision.transform.position.y > transform.position.y)
            {
                foreach (Animator anim in childs)
                {
                    anim.Play("Fading");
                }
            }
            else
            {
                foreach (Animator anim in childs)
                {
                    anim.Play("ReverseFading");
                }
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            foreach (Animator anim in childs)
            {
                anim.Play("ReverseFading");
            }
        }
    }
}
