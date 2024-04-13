using UnityEngine;
using TMPro;

public class WrestlingRule : MonoBehaviour
{
    public float pinTime = 3.0f;
    public float pinTimeWin = 3.0f;
    public bool floored = false;
    public bool flooredWin = false;
    private float timer = 0.0f; 
    private float timerWin = 0.0f;
    public int winCount = 0;
    public int loseCount = 0;
    public TextMeshProUGUI winText;
    public TextMeshProUGUI loseText;
    
    // Update is called once per frame
    void Update()
    {
        if (floored)
        {
            timer += Time.deltaTime;
            
            if (timer >= pinTime)
            {
                winCount++; 
                winText.text = "Wins: " + winCount;
                timer = 0.0f;
                floored = false;
            }
        }

      
        else if (floored == false)
        {
            timer = 0.0f;
        }
        
        if (flooredWin)
        {
            timerWin += Time.deltaTime;
            
            if (timerWin >= pinTimeWin)
            {
                loseCount++; 
                loseText.text = "Wins: " + loseCount;
                timerWin = 0.0f;
                flooredWin = false;
            }
        }

      
        else if (flooredWin == false)
        {
            timerWin = 0.0f;
        }
        
        
    }
    
}