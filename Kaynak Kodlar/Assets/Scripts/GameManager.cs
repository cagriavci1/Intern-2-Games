using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void GameExit()
    {
        SaveManager.savemanagerInstance.SaveGame(); // Verileri kaydet
        Application.Quit(); // Oyundan çýk
    }
}
