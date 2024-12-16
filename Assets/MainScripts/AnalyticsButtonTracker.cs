using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Analytics;

public class AnalyticsButtonTracker : MonoBehaviour
{
    public Button completeLevelButton;  
    public AnalyticsManager analyticsManager;  

    void Start()
    {
        
        if (completeLevelButton != null)
        {
            completeLevelButton.onClick.AddListener(OnCompleteLevelClicked);
        }
    }

    void OnCompleteLevelClicked()
    {
        
        analyticsManager.TrackLevelCompletion();

        Debug.Log("Player completed the level tracked.");
    }
}
