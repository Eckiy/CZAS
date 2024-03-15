using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chodzenie : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D gracz;
    Vector2 tuptanie;



    void Update()
    {
        tuptanie.x = Input.GetAxisRaw("Horizontal");
        tuptanie.y = Input.GetAxisRaw("Vertical");

    }

    void FixedUpdate()
    {
        gracz.MovePosition(gracz.position + tuptanie * speed * Time.fixedDeltaTime);
    }
}
