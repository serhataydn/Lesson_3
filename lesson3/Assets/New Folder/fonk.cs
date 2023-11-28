using System;
using System.Collections;
using UnityEngine;

public class fonk : MonoBehaviour
{
    public void bölenleribul(int a, int b)
    {
        int i = a;

        ArrayList sýralisayilar1 = new ArrayList();
        ArrayList çiftsayilar = new ArrayList();
        ArrayList uceblunensayilar = new ArrayList();

        for (; a < b; a++)
        {
            sýralisayilar1.Add(a);
            if (a % 2 == 0)
            {
                çiftsayilar.Add(a);
            }
            if (a % 3 == 0)
            {
                uceblunensayilar.Add(a);
            }
        }

        string result = "Sýralý Sayýlar: ";
        for (int k = 0; k < sýralisayilar1.Count; k++)
        {
            result += sýralisayilar1[k] + " ";
        }
        result += "\nÜçe Bölünen Sayýlar: ";
        for (int k = 0; k < uceblunensayilar.Count; k++)
        {
            result += uceblunensayilar[k] + " ";
        }
        result += "\nÇift Sayýlar: ";
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
