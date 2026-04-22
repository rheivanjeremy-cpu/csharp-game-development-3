using UnityEngine;

public class Latihan1_IFStatement_Rheivan : MonoBehaviour
{
    public int nilai = 85;

    void Start()
    {
        // Kelulusan
        if (nilai > 75)
        {
            Debug.Log("Selamat Anda Lulus");
        }
        else
        {
            Debug.Log("Mohon Maaf Anda Remedi");
        }

        // Grade
        if (nilai > 90)
        {
            Debug.Log("Grade A");
        }
        else if (nilai > 80)
        {
            Debug.Log("Grade B");
        }
        else if (nilai > 70)
        {
            Debug.Log("Grade C");
        }
        else
        {
            Debug.Log("Grade D");
        }
    }
}