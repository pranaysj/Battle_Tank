using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel
{
    private TankController controller;
    public float movementSpeed;
    public float rotationSpeed;
    public TankType tankType;
    public Material color;

    public TankModel(float movement, float rotation, TankType type, Material color)
    {
        movementSpeed = movement;  
        rotationSpeed = rotation;
        tankType = type;
        this.color = color;
    }

    public void SetTankController(TankController tankController)
    {
        this.controller = tankController;
    }
}
