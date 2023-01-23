using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    [SerializeField] private PlayerData _data;

    private PlayerData _localPlayerData;

    private const string SAVE_DATA_KEY = "PlayerData";

    [ContextMenu("Save")]
    private void Save()
    {

    }

    [ContextMenu("Load")]
    private void Load()
    {

    }
}
