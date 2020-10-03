using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FIRE : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletpre;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount>0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {

            shoot();
        }

    }


    void shoot()
    {
        Instantiate(bulletpre, firePoint.position, firePoint.rotation);
    }
}
