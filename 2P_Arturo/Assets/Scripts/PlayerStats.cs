using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerStats : MonoBehaviour
{

    public TMP_Text Kills;
    public TMP_Text Damage;
    public TMP_Text Wins;
    private TMP_Text Achievements;

    public int PlayerKills = 4765;
    public int PlayerDamage = 348759;
    public int PlayerWins = 563;
    private string LastAchievement;



    // Start is called before the first frame update
    void Start()
    {
        PlayerKills = PlayerPrefs.GetInt("PlayerKills");
        LastAchievement = PlayerPrefs.GetString("LastAchievement");

        Kills.text = PlayerKills.ToString();
        Achievements.text = LastAchievement;
    }


}
