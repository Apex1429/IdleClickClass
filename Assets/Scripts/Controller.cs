using TMPro;
using UnityEngine;

public class Controller : MonoBehaviour
{
public Data data;

public TMP_Text flasksText;

private void Start()
{
    data = new Data();
}


private void Update() 
    {
        flasksText.text = data.flasks +" Flasks";
    }

public void GenerateFlasks()
    {
        data.flasks += 1;
    }
    
}
