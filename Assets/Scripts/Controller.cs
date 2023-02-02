using TMPro;
using UnityEngine;

public class Controller : MonoBehaviour
{
public Data data;

public TMP_Text flasksText;

public void Start()
{
    data = new Data();
}


public void Update() 
    {
        flasksText.text = data.flasks +" Flasks";
    }

public void GenerateFlasks()
    {
        data.flasks += 1;
    }
    
}
