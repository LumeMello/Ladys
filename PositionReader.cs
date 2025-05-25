using System.Runtime.CompilerServices;
using UnityEngine;

public class PositionReader : MonoBehaviour
{
    #region data
    public Vector3[] transformMapeamento;
    private int k;
    #endregion

    private Dot dotScript;

    void Awake()
    {
        transformMapeamento = new Vector3[64];
        // ele vai de 0 a 63

        for (int i = 1; i < 65; i++)
        {
            k = i - 1;
            if( i < 9)
            {
                transformMapeamento[k] = new Vector3(-0.0088f + k*0.1892f,-1.32f + k*0.203f, transform.position.z);
            }
            else if (i < 17)
            {
                transformMapeamento[k] = new Vector3(-0.1982f + k * 0.1892f, -1.119f + k * 0.203f, transform.position.z);
            }
            else if (i < 25)
            {
                transformMapeamento[k] = new Vector3(-0.3871f + k * 0.1892f, -0.925f + k * 0.203f, transform.position.z);
            }
            else if (i < 33)
            {
                transformMapeamento[k] = new Vector3(-0.5761f + k * 0.1892f, -0.737f + k * 0.203f, transform.position.z);
            }
            else if (i < 41)
            {
                transformMapeamento[k] = new Vector3(-0.767f + k * 0.1892f, -0.553f + k * 0.203f, transform.position.z);
            }
            else if (i < 49)
            {
                transformMapeamento[k] = new Vector3(-0.9591f + k * 0.1892f, -0.356f + k * 0.203f, transform.position.z);
            }
            else if (i < 57)
            {
                transformMapeamento[k] = new Vector3(-1.1479f + k * 0.1892f, -0.1619f + k * 0.203f, transform.position.z);
            }
            else
            {
                transformMapeamento[k] = new Vector3(-1.3353f + k * 0.1892f, 0.029f + k * 0.203f, transform.position.z);
            }
        }
    }

    void Update()
    {
        
    }

    public void CallPosition(GameObject dot) 
    {
        dotScript = dot.GetComponent<Dot>();
        if(dotScript.transform.position == transformMapeamento[0])
        {
            dotScript.actualPosition = 0;
        }
        else if (dotScript.transform.position == transformMapeamento[1])
        {
            dotScript.actualPosition = 1;
        }
        else if (dotScript.transform.position == transformMapeamento[2])
        {
            dotScript.actualPosition = 2;
        }
        else if (dotScript.transform.position == transformMapeamento[3])
        {
            dotScript.actualPosition = 3;
        }
        else if (dotScript.transform.position == transformMapeamento[4])
        {
            dotScript.actualPosition = 4;
        }
        else if (dotScript.transform.position == transformMapeamento[5])
        {
            dotScript.actualPosition = 5;
        }
        else if (dotScript.transform.position == transformMapeamento[6])
        {
            dotScript.actualPosition = 6;
        }
        else if (dotScript.transform.position == transformMapeamento[7])
        {
            dotScript.actualPosition = 7;
        }
        else if (dotScript.transform.position == transformMapeamento[8])
        {
            dotScript.actualPosition = 8;
        }
        else if (dotScript.transform.position == transformMapeamento[9])
        {
            dotScript.actualPosition = 9;
        }
        else if (dotScript.transform.position == transformMapeamento[10])
        {
            dotScript.actualPosition = 10;
        }
        else if (dotScript.transform.position == transformMapeamento[11])
        {
            dotScript.actualPosition = 11;
        }
        else if (dotScript.transform.position == transformMapeamento[12])
        {
            dotScript.actualPosition = 12;
        }
        else if (dotScript.transform.position == transformMapeamento[13])
        {
            dotScript.actualPosition = 13;
        }
        else if (dotScript.transform.position == transformMapeamento[14])
        {
            dotScript.actualPosition = 14;
        }
        else if (dotScript.transform.position == transformMapeamento[15])
        {
            dotScript.actualPosition = 15;
        }
        else if (dotScript.transform.position == transformMapeamento[16])
        {
            dotScript.actualPosition = 16;
        }
        else if (dotScript.transform.position == transformMapeamento[17])
        {
            dotScript.actualPosition = 17;
        }
        else if (dotScript.transform.position == transformMapeamento[18])
        {
            dotScript.actualPosition = 18;
        }
        else if (dotScript.transform.position == transformMapeamento[19])
        {
            dotScript.actualPosition = 19;
        }
        else if (dotScript.transform.position == transformMapeamento[20])
        {
            dotScript.actualPosition = 20;
        }
        else if (dotScript.transform.position == transformMapeamento[21])
        {
            dotScript.actualPosition = 21;
        }
        else if (dotScript.transform.position == transformMapeamento[22])
        {
            dotScript.actualPosition = 22;
        }
        else if (dotScript.transform.position == transformMapeamento[23])
        {
            dotScript.actualPosition = 23;
        }
        else if (dotScript.transform.position == transformMapeamento[24])
        {
            dotScript.actualPosition = 24;
        }
        else if (dotScript.transform.position == transformMapeamento[25])
        {
            dotScript.actualPosition = 25;
        }
        else if (dotScript.transform.position == transformMapeamento[26])
        {
            dotScript.actualPosition = 26;
        }
        else if (dotScript.transform.position == transformMapeamento[27])
        {
            dotScript.actualPosition = 27;
        }
        else if (dotScript.transform.position == transformMapeamento[28])
        {
            dotScript.actualPosition = 28;
        }
        else if (dotScript.transform.position == transformMapeamento[29])
        {
            dotScript.actualPosition = 29;
        }
        else if (dotScript.transform.position == transformMapeamento[30])
        {
            dotScript.actualPosition = 30;
        }
        else if (dotScript.transform.position == transformMapeamento[31])
        {
            dotScript.actualPosition = 31;
        }
        else if (dotScript.transform.position == transformMapeamento[32])
        {
            dotScript.actualPosition = 32;
        }
        else if (dotScript.transform.position == transformMapeamento[33])
        {
            dotScript.actualPosition = 33;
        }
        else if (dotScript.transform.position == transformMapeamento[34])
        {
            dotScript.actualPosition = 34;
        }
        else if (dotScript.transform.position == transformMapeamento[35])
        {
            dotScript.actualPosition = 35;
        }
        else if (dotScript.transform.position == transformMapeamento[36])
        {
            dotScript.actualPosition = 36;
        }
        else if (dotScript.transform.position == transformMapeamento[37])
        {
            dotScript.actualPosition = 37;
        }
        else if (dotScript.transform.position == transformMapeamento[38])
        {
            dotScript.actualPosition = 38;
        }
        else if (dotScript.transform.position == transformMapeamento[39])
        {
            dotScript.actualPosition = 39;
        }
        else if (dotScript.transform.position == transformMapeamento[40])
        {
            dotScript.actualPosition = 40;
        }
        else if (dotScript.transform.position == transformMapeamento[41])
        {
            dotScript.actualPosition = 41;
        }
        else if (dotScript.transform.position == transformMapeamento[42])
        {
            dotScript.actualPosition = 42;
        }
        else if (dotScript.transform.position == transformMapeamento[43])
        {
            dotScript.actualPosition = 43;
        }
        else if (dotScript.transform.position == transformMapeamento[44])
        {
            dotScript.actualPosition = 44;
        }
        else if (dotScript.transform.position == transformMapeamento[45])
        {
            dotScript.actualPosition = 45;
        }
        else if (dotScript.transform.position == transformMapeamento[46])
        {
            dotScript.actualPosition = 46;
        }
        else if (dotScript.transform.position == transformMapeamento[47])
        {
            dotScript.actualPosition = 47;
        }
        else if (dotScript.transform.position == transformMapeamento[48])
        {
            dotScript.actualPosition = 48;
        }
        else if (dotScript.transform.position == transformMapeamento[49])
        {
            dotScript.actualPosition = 49;
        }
        else if (dotScript.transform.position == transformMapeamento[50])
        {
            dotScript.actualPosition = 50;
        }
        else if (dotScript.transform.position == transformMapeamento[51])
        {
            dotScript.actualPosition = 51;
        }
        else if (dotScript.transform.position == transformMapeamento[52])
        {
            dotScript.actualPosition = 52;
        }
        else if (dotScript.transform.position == transformMapeamento[53])
        {
            dotScript.actualPosition = 53;
        }
        else if (dotScript.transform.position == transformMapeamento[54])
        {
            dotScript.actualPosition = 54;
        }
        else if (dotScript.transform.position == transformMapeamento[55])
        {
            dotScript.actualPosition = 55;
        }
        else if (dotScript.transform.position == transformMapeamento[56])
        {
            dotScript.actualPosition = 56;
        }
        else if (dotScript.transform.position == transformMapeamento[57])
        {
            dotScript.actualPosition = 57;
        }
        else if (dotScript.transform.position == transformMapeamento[58])
        {
            dotScript.actualPosition = 58;
        }
        else if (dotScript.transform.position == transformMapeamento[59])
        {
            dotScript.actualPosition = 59;
        }
        else if (dotScript.transform.position == transformMapeamento[60])
        {
            dotScript.actualPosition = 60;
        }
        else if (dotScript.transform.position == transformMapeamento[61])
        {
            dotScript.actualPosition = 61;
        }
        else if (dotScript.transform.position == transformMapeamento[62])
        {
            dotScript.actualPosition = 62;
        }
        else if (dotScript.transform.position == transformMapeamento[63])
        {
            dotScript.actualPosition = 63;
        }
    }
    
}
