using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel
{
    private TankController controller;

    public TankModel()
    {

    }

    public void SetTankController(TankController tankController)
    {
        this.controller = tankController;
    }
}
