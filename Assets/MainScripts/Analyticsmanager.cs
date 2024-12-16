using UnityEngine;
using UnityEngine.Analytics;

public class AnalyticsManager : MonoBehaviour
{
    
    public void TrackLevelCompletion()
    {
        
        Analytics.CustomEvent("player_completed_level", new System.Collections.Generic.Dictionary<string, object>
        {
            { "status", "completed" }
        });

        Debug.Log("Level completion tracked.");
    }
}
