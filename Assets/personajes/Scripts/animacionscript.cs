using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animacionscript : MonoBehaviour
{
    public float RunSpeed = 7;
    public float RotationSpeed = 250;

    public Animator animator;

    private float x, y;

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");


        transform.Rotate(0, x * Time.deltaTime * RotationSpeed, 0);

        transform.Translate(0, 0, y * Time.deltaTime * RunSpeed);

        animator.SetFloat("Velx", x);
        animator.SetFloat("Vely", y);
    }
}
