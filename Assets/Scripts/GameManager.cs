using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum PERSONALITY_TRAIT {
        Intimacy,
        Social,
        Demeanor
    };

    [System.Serializable]
    private class Client {
        [SerializeField]
        public PERSONALITY_TRAIT PrimaryTrait;

        [SerializeField]
        public int PrimaryTraitPreferredValue;

        [SerializeField]
        public PERSONALITY_TRAIT SecondaryTrait;

        [SerializeField]
        public int SecondaryTraitPreferredValue;

        [SerializeField]
        public PERSONALITY_TRAIT TertiaryTrait;

        [SerializeField]
        public int TertiaryTraitPreferredValue;
    }

    [SerializeField]
    private Client[] Clients;

    [SerializeField]
    private Soundboard Soundboard;

    [SerializeField]
    private Client CurrentClient;

    [SerializeField]
    private int DEBUG_CurrentClient = -1;

    public void FixedUpdate() {
        if (DEBUG_CurrentClient >= 0) {
            CurrentClient = Clients[DEBUG_CurrentClient];
        }
    }

    public bool GetClientSuccess() {
        Dictionary<GameManager.PERSONALITY_TRAIT, int> SoundboardSettings = Soundboard.GetSettings();

        return SoundboardSettings[CurrentClient.PrimaryTrait] == CurrentClient.PrimaryTraitPreferredValue;
    }

    public void DEBUG_CheckSubmission() {
        Debug.Log("Success: " + (GetClientSuccess() ? "true" : "false"));
    }
}
