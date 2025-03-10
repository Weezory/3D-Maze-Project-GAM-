using UnityEngine;
using TMPro;

public class PlayerCollection : MonoBehaviour
{
    // Add a Scoring System here (HW)
    public int points;
    public TMP_Text scoreText;

    public void Score(int value)

    {
        points = points + value;
        scoreText.text = $"<b>Score</b> {points}";
    }
    
    private void OnTriggerEnter(Collider other)
    {
        // Only destroy if collectable
        if (other.CompareTag("Collectable"))
        {
            Destroy(other.gameObject);
            Score(1);
        }
    }
}
