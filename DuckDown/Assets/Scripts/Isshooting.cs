using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Isshooting : MonoBehaviour
{

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            anim.SetBool("justshot", true);
        }
        else
        {
            anim.SetBool("justshot", false);
        }
    }
}
