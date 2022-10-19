using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Avatar : MonoBehaviour
{
    public int AvatarIndex = 0;

    public List<AvatarAttributes> Avatars;
    public TMP_Text Name;
    public TMP_Text Sinopsis;
    public TMP_Text XP;

    // Update is called once per frame
    void Update()
    {
        Name.text = Avatars[AvatarIndex].name;
        Sinopsis.text = "Info" + Avatars[AvatarIndex].Description;
        XP.text = Avatars[AvatarIndex].XP.ToString() + "XP";
    }
}
