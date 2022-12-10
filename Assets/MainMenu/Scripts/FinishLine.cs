﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public int levelToUnlock;
    int numberOfUnlockedLevels;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            numberOfUnlockedLevels = PlayerPrefs.GetInt("levelsUnlocked");

            if (numberOfUnlockedLevels <= levelToUnlock)
            {
                PlayerPrefs.SetInt("levelsUnlocked",numberOfUnlockedLevels+1);
            }
        }
    }
    public void UnlockLevel()
    {
        numberOfUnlockedLevels = PlayerPrefs.GetInt("levelsUnlocked");

        if (numberOfUnlockedLevels <= levelToUnlock)
        {
            PlayerPrefs.SetInt("levelsUnlocked", numberOfUnlockedLevels + 1);
        }
    }
}
