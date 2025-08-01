using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [Serializable]
    public class Tank
    {
        public float movementSpeed;
        public float rotationSpeed;
        public TankType type;
        public Material color;
    }

    public List<Tank> tankList;
    public TankView tankView;

    void Start() 
    {
        CreateTank();
    }

    public void CreateTank()
    {
        TankModel tankModel = new TankModel(tankList[1].movementSpeed, tankList[1].rotationSpeed, tankList[1].type, tankList[1].color);
        TankController controller = new TankController(tankModel,tankView);
    }

}
