using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject WinPanel;
    int score = 0;
    

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScoreUp()
    {
        score++;
        if(score >= 4)
        {
            Win();
        }
    }
    void Win ()
    {
        WinPanel.SetActive(true);
    }

}
