using System;
using System.Collections;
using UnityEngine;

public class fonk : MonoBehaviour
{
    public void bölenleribul(int a, int b)
    {
        int i = a;

        ArrayList sıralisayilar1 = new ArrayList();
        ArrayList çiftsayilar = new ArrayList();
        ArrayList uceblunensayilar = new ArrayList();

        for (; a < b; a++)
        {
            sıralisayilar1.Add(a);
            if (a % 2 == 0)
            {
                çiftsayilar.Add(a);
            }
            if (a % 3 == 0)
            {
                uceblunensayilar.Add(a);
            }
        }

        string result = "Sıralı Sayılar: ";
        for (int k = 0; k < sıralisayilar1.Count; k++)
        {
            result += sıralisayilar1[k] + " ";
        }
        result += "\nÜçe Bölünen Sayılar: ";
        for (int k = 0; k < uceblunensayilar.Count; k++)
        {
            result += uceblunensayilar[k] + " ";
        }
        result += "\nÇift Sayılar: ";
        for (int k = 0; k < çiftsayilar.Count; k++)
        {
            result += çiftsayilar[k] + " ";
        }

      

        print(result);
    }

    void Start()
    {
        bölenleribul(10, 20);
    }
}
