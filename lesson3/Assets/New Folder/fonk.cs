using System;
using System.Collections;
using UnityEngine;

public class fonk : MonoBehaviour
{
    public void b�lenleribul(int a, int b)
    {
        int i = a;

        ArrayList s�ralisayilar1 = new ArrayList();
        ArrayList �iftsayilar = new ArrayList();
        ArrayList uceblunensayilar = new ArrayList();

        for (; a < b; a++)
        {
            s�ralisayilar1.Add(a);
            if (a % 2 == 0)
            {
                �iftsayilar.Add(a);
            }
            if (a % 3 == 0)
            {
                uceblunensayilar.Add(a);
            }
        }

        string result = "S�ral� Say�lar: ";
        for (int k = 0; k < s�ralisayilar1.Count; k++)
        {
            result += s�ralisayilar1[k] + " ";
        }
        result += "\n��e B�l�nen Say�lar: ";
        for (int k = 0; k < uceblunensayilar.Count; k++)
        {
            result += uceblunensayilar[k] + " ";
        }
        result += "\n�ift Say�lar: ";
        for (int k = 0; k < �iftsayilar.Count; k++)
        {
            result += �iftsayilar[k] + " ";
        }

      

        print(result);
    }

    void Start()
    {
        b�lenleribul(10, 20);
    }
}
