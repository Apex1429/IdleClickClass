using TMPro;
using UnityEngine;
using BreakInfinity;

public class Controller : MonoBehaviour
{
public Data data;
public UpgradesManager upgradesManager;

public TMP_Text flasksText;
public TMP_Text flaskClickPowerText;

public BigDouble ClickPower()
{
    return 1 + data.clickUpgradeLevel;
}
private void Start()
{
    data = new Data();
    
    upgradesManager.StartUpgradeManager();
}


private void Update() 
    {
        flasksText.text = data.flasks +" Flasks";
        flaskClickPowerText.text = "+" + ClickPower() + " Flasks";

    }

public void GenerateFlasks()
    {
        data.flasks += ClickPower();
    }
    
}
