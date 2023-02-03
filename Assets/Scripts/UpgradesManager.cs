using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BreakInfinity;

public class UpgradesManager : MonoBehaviour
{
    
    public Controller controller;

    public BigDouble clickUpgradeBaseCost;
    public BigDouble clickUpgradeCostMult;

    public void Start()
    {
        
        clickUpgradeBaseCost = 10;
        clickUpgradeCostMult = 1.5;
    }

    public BigDouble Cost()
    {
        return clickUpgradeBaseCost * BigDouble.Pow(clickUpgradeCostMult, controller.data.clickUpgradeLevel);
    }
}
