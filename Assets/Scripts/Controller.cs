using TMPro;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public TMP_Text flasksText;

    public double flasks;

    public void Update() 
        {
            flasksText.text = flasks +" Flasks";
        }

    public void GenerateFlasks()
    {
        flasks += 1;
    }
    
}
