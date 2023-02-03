using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BreakInfinity;

public class UpgradesManager : MonoBehaviour
{
    
    public Controller controller;
    public Upgrades clickUpgrade;
    public string clickUpgradeName;

    public BigDouble clickUpgradeBaseCost;
    public BigDouble clickUpgradeCostMult;

    public void StartUpgradeManager()
    {
        clickUpgradeName = "Flasks Per Click";
        clickUpgradeBaseCost = 10;
        clickUpgradeCostMult = 1.5;
        UpdateClickUpgradeUI();
    }



    public void UpdateClickUpgradeUI()
    {
        clickUpgrade.LevelText.text = controller.data.clickUpgradeLevel.ToString();
        clickUpgrade.CostText.text = "Cost: " + Cost().ToString("F2") + " Flasks";
        clickUpgrade.NameText.text = "+1 " + clickUpgradeName;
    }

    public BigDouble Cost()
    {
        return clickUpgradeBaseCost * BigDouble.Pow(clickUpgradeCostMult, controller.data.clickUpgradeLevel);
    }

    public void BuyUpgrade()
    {
        if (controller.data.flasks >= Cost())
        {
            controller.data.flasks -= Cost();
            controller.data.clickUpgradeLevel += 1;
        }
        UpdateClickUpgradeUI();
    }
}
