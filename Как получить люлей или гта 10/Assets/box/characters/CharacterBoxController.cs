using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SpatialTracking;

public class CharacterBoxController : MonoBehaviour
{
    public float speed;
    Animator anim;
     void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward *  hor * speed * Time.deltaTime);
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            anim.SetBool("move", true);
            if (Input.GetKey(KeyCode.A))
            {
                anim.SetBool("mirror", true);
            }
            else
            {
                anim.SetBool("mirror", false);
            }
        }
        else
        {
            anim.SetBool("move", false);
        }
        if (Input.GetKey(KeyCode.Keypad2))
        {
            anim.SetBool("BlockUp", true);
        }
        else
        {
            anim.SetBool("BlockUp", false);
        }
        if (Input.GetKey(KeyCode.Keypad5))
        {
            anim.SetBool("BlockDown", true);
        }
        else
        {
            anim.SetBool("BlockDown", false);
        }
        if (Input.GetKey(KeyCode.Keypad8))
        {
            anim.SetBool("dodg", true);
        }
        else
        {
            anim.SetBool("dodg", false);
        }
        if (Input.GetKey(KeyCode.W))
        {
            if ( Input.GetKey(KeyCode.Keypad1))
            {
                anim.SetInteger("leftUp", 1);
            }
            else if (Input.GetKey(KeyCode.Keypad4))
            {
                anim.SetInteger("leftUp", 4);
            }
            else if (Input.GetKey(KeyCode.Keypad7))
            {
                anim.SetInteger("leftUp", 7);
            }
            else
            {
                anim.SetInteger("leftUp", 0);
            }
            if (Input.GetKey(KeyCode.Keypad3))
            {
                anim.SetInteger("rightUp", 3);
            }
            else if (Input.GetKey(KeyCode.Keypad6))
            {
                anim.SetInteger("rightUp", 6);
            }
            else if (Input.GetKey(KeyCode.Keypad9))
            {
                anim.SetInteger("rightUp", 9);
            }
            else
            {
                anim.SetInteger("rightUp", 0);
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (Input.GetKey(KeyCode.Keypad1))
            {
                anim.SetInteger("LeftDown", 1);
            }

            else if (Input.GetKey(KeyCode.Keypad4))
            {
                anim.SetInteger("LeftDown", 4);
            }

            else if (Input.GetKey(KeyCode.Keypad7))
            {
                anim.SetInteger("LeftDown", 7);
            }
            else
            {
                anim.SetInteger("LeftDown", 0);
            }
            if (Input.GetKey(KeyCode.Keypad3))
            {
                anim.SetInteger("rightDown", 3);
            }else if (Input.GetKey(KeyCode.Keypad6))
            {
                anim.SetInteger("rightDown", 6);
            }else if (Input.GetKey(KeyCode.Keypad9))
            {
                anim.SetInteger("rightDown", 9);
            }
            else
            {
                anim.SetInteger("rightDown", 0);
            }
        }



    }
}
