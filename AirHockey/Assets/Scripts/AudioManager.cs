using UnityEngine;
using FMODUnity;

public class AirHockeyAudioManager : MonoBehaviour
{

    public EventReference goalFanfareA; // e.g., "event:/GoalFanfareA"
    public EventReference goalFanfareB; // e.g., "event:/GoalFanfareB"
    public EventReference gameOverFanfareA; // e.g., "event:/GameOverFanfareA"
    public EventReference gameOverFanfareB; // e.g., "event:/GameOverFanfareB"


    public EventReference malletHit; // e.g., "event:/MalletHit"
    public EventReference puckImpact; // e.g., "event:/PuckImpact"


    public EventReference goalGentle; // e.g., "event:/GoalGentle"
    public EventReference goalImpact; // e.g., "event:/GoalImpact"

    public EventReference clickSound; // e.g., "event:/UIClick"

    void Start()
    {
        RuntimeManager.LoadBank("Master", true);
    }

    // --- Simple playback ---
    // MANUAL: Position should be the world position of the sound source (e.g., puck, mallet, goal).
    public void PlayEvent(EventReference evt, Vector3 position)
    {
        RuntimeManager.PlayOneShot(evt, position);
    }

    // --- Layered goal playback ---
    // MANUAL: Adjust timing if you want gentle and impact tracks to play with a delay.
    public void PlayLayeredGoal(Vector3 position)
    {
        RuntimeManager.PlayOneShot(goalGentle, position);
        RuntimeManager.PlayOneShot(goalImpact, position);
    }

    public void PlayClick()
    {
        RuntimeManager.PlayOneShot(clickSound);
    }

    public void SetMasterVolume(float volume)
    {
        RuntimeManager.GetBus("bus:/").setVolume(volume);
    }
}
