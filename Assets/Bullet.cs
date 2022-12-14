using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 20f;
    public Rigidbody2D rb;
    Vector2 lookDirection;
    float lookAngle;

    public GameObject Weapon;

    // Start is called before the first frame update
    void Start()
    {
        lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;

        Weapon = GameObject.Find("FirePoint");
        Weapon.transform.rotation = Quaternion.Euler(0, 0, lookAngle);
    }

}
