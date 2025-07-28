using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController controller;
    private float movement;
    private float rotation;
    public Rigidbody rb;

    void Start() {
        GameObject cam = GameObject.Find("Main Camera");
        cam.transform.SetParent(transform);
        cam.transform.position = new Vector3(0, 3f, -5f);
    }

    void Update()
    {
        Movement();

        if(movement != 0)
        {
            controller.Move(movement, controller.GetTankModel().movementSpeed);
        }

        if(rotation != 0)
        {
            controller.Rotate(rotation, controller.GetTankModel().rotationSpeed);
        }
    }

    public void SetTankController(TankController tankController)
    {
        this.controller = tankController;
    }

    public Rigidbody GetRigidBody()
    {
        return rb;
    }

    public void Movement()
    {
        movement = Input.GetAxis("Vertical");
        rotation = Input.GetAxis("Horizontal");
    }
}
