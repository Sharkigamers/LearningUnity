using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BonusScore : MonoBehaviour
{
    public Text playerScoreText;

    public void HideBonusScore()
    {
        playerScoreText.gameObject.SetActive(false);
    }
}
