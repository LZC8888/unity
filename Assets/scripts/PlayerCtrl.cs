using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    public float MoveForce = 100.0f;
    public float MaxSpeed = 5;
    private Rigidbody2D HeroBody;
    void Start()
    {
        HeroBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        if (Mathf.Abs(HeroBody.velocity.x)<MaxSpeed)
        {
            HeroBody.AddForce(Vector2.right * h * MoveForce);
        }
    }
}
