using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PracticaEventos : MonoBehaviour
{

    public TMP_Text Notification;
    public int Counter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlusPoint();
    }

   public void PlusPoint()
    {
        Counter++;
        CheckPoints();
    }

    public void CheckPoints()
    {
        if(Counter >= 100)
        {
            Notification.text = "Logro desbloqueado: 100 puntos";
        }

        else{

            return;
        }
    }
      
}
