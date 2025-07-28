using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TankController
{
    private TankView tankView;
    private TankModel tankModel;
    private Rigidbody rb;
    public TankController(TankModel model, TankView view)
    {
        tankModel = model;
        tankView = GameObject.Instantiate<TankView>(view);

        rb = tankView.GetRigidBody();

        tankView.SetTankController(this);
        tankModel.SetTankController(this);
    }

    public void Move(float movement, float moveSpeed)
    {
        rb.velocity = movement * moveSpeed * tankView.transform.forward;
    }

    public void Rotate(float rotate, float rotateSpeed)
    {
        Vector3 vector = new Vector3(0, rotate * rotateSpeed, 0);
        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }

    public TankModel GetTankModel()
    {
        return tankModel;
    }
}
