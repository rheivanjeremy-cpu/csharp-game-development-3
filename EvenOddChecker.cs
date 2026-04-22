using UnityEngine;

public class Latihan2_IFStatement_Rheivan : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Tanggal Genap:");
        for (int i = 1; i <= 31; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log(i);
            }
        }

        Debug.Log("Tanggal Ganjil:");
        for (int i = 1; i <= 31; i++)
        {
            if (i % 2 != 0)
            {
                Debug.Log(i);
            }
        }
    }
}