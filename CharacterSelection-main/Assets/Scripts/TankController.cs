using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController
{
    private TankView tankView;
    private TankModel tankModel;

    public TankController(TankModel tankModel, TankView tankView)
    {
        this.tankModel = tankModel;
        this.tankView = tankView;

        tankView.SetTankController(this);
        tankModel.SetTankController(this);

        GameObject.Instantiate(tankView.gameObject);
    }
}
