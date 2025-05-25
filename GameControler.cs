using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControler : MonoBehaviour
{
    #region Dot
    private GameObject dot;
    private Dot dotScript;
    private int[] possiblePosition;
    private bool[] possiblePositionBool;
    private GameObject[] HighLightObjs;
    private GameObject[] HighLightButtonsObjs;
    private PositionReader positionReader;
    #endregion

    private GameObject MainCamera;
    private GameObject ZoomCamera;
    private Camera zoomCameraCode;

    void Start()
    {
        MainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        ZoomCamera = GameObject.FindGameObjectWithTag("Zoom");
        zoomCameraCode = ZoomCamera.GetComponent<Camera>();
        positionReader = gameObject.GetComponent<PositionReader>();
    }

    void Update()
    {
        
    }

    private void Seek()
    {
        zoomCameraCode.Position = new float[2];
        zoomCameraCode.Position[0] = dot.transform.position.x;
        zoomCameraCode.Position[1] = dot.transform.position.y;
        MainCamera.SetActive(false);
    }

    public void NewScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void CallDot(GameObject newDot)
    {
        dot = newDot;
        dotScript = dot.GetComponent<Dot>();
        Seek();
    }

    public void MoveDot()
    {
        #region BlackDot
        if (dotScript.type == Dot.Type.BlackDot)
        {
            positionReader.CallPosition(dot);
            possiblePosition = new int[2];
            possiblePosition[0] = dotScript.actualPosition + 7;
            possiblePosition[1] = dotScript.actualPosition + 9;
            if (dotScript.actualPosition > -1 && dotScript.actualPosition < 8)
            {
                possiblePositionBool = new bool[2];
                possiblePositionBool[0] = true;
                possiblePositionBool[1] = true;

                if (possiblePosition[0] > -1 && possiblePosition[0] < 8)
                {
                    possiblePositionBool[0] = false;
                }
                if (possiblePosition[1] > 15)
                {
                    possiblePositionBool[1] = false;
                }
            }
            else if (dotScript.actualPosition > 7 && dotScript.actualPosition < 16)
            {
                possiblePositionBool = new bool[2];
                possiblePositionBool[0] = true;
                possiblePositionBool[1] = true;

                if (possiblePosition[0] > 7 && possiblePosition[0] < 16)
                {
                    possiblePositionBool[0] = false;
                }
                if (possiblePosition[1] > 15)
                {
                    possiblePositionBool[1] = false;
                }
            }
            else if (dotScript.actualPosition > 15 && dotScript.actualPosition < 24)
            {
                possiblePositionBool = new bool[2];
                possiblePositionBool[0] = true;
                possiblePositionBool[1] = true;

                if (possiblePosition[0] > 15 && possiblePosition[0] < 24)
                {
                    possiblePositionBool[0] = false;
                }
                if (possiblePosition[1] > 23)
                {
                    possiblePositionBool[1] = false;
                }
            }
            else if (dotScript.actualPosition > 23 && dotScript.actualPosition < 32)
            {
                possiblePositionBool = new bool[2];
                possiblePositionBool[0] = true;
                possiblePositionBool[1] = true;

                if (possiblePosition[0] > 23 && possiblePosition[0] < 32)
                {
                    possiblePositionBool[0] = false;
                }
                if (possiblePosition[1] > 31)
                {
                    possiblePositionBool[1] = false;
                }
            }
            else if (dotScript.actualPosition > 31 && dotScript.actualPosition < 40)
            {
                possiblePositionBool = new bool[2];
                possiblePositionBool[0] = true;
                possiblePositionBool[1] = true;

                if (possiblePosition[0] > 31 && possiblePosition[0] < 40)
                {
                    possiblePositionBool[0] = false;
                }
                if (possiblePosition[1] > 39)
                {
                    possiblePositionBool[1] = false;
                }
            }
            else if (dotScript.actualPosition > 39 && dotScript.actualPosition < 48)
            {
                possiblePositionBool = new bool[2];
                possiblePositionBool[0] = true;
                possiblePositionBool[1] = true;

                if (possiblePosition[0] > 39 && possiblePosition[0] < 48)
                {
                    possiblePositionBool[0] = false;
                }
                if (possiblePosition[1] > 47)
                {
                    possiblePositionBool[1] = false;
                }
            }
            else if (dotScript.actualPosition > 47 && dotScript.actualPosition < 56)
            {
                possiblePositionBool = new bool[2];
                possiblePositionBool[0] = true;
                possiblePositionBool[1] = true;

                if (possiblePosition[0] > 47 && possiblePosition[0] < 56)
                {
                    possiblePositionBool[0] = false;
                }
                if (possiblePosition[1] > 55)
                {
                    possiblePositionBool[1] = false;
                }
            }
            else if (dotScript.actualPosition > 55 && dotScript.actualPosition < 64)
            {
                possiblePositionBool = new bool[2];
                possiblePositionBool[0] = true;
                possiblePositionBool[1] = true;

                if (possiblePosition[0] > 55 && possiblePosition[0] < 64)
                {
                    possiblePositionBool[0] = false;
                }
                if (possiblePosition[1] > 63)
                {
                    possiblePositionBool[1] = false;
                }
            }

        }
        #endregion
        #region WhiteDot
        else if (dotScript.type == Dot.Type.WhiteDot)
        {
            positionReader.CallPosition(dot);
            possiblePosition = new int[2];
            possiblePosition[0] = dotScript.actualPosition - 7;
            possiblePosition[1] = dotScript.actualPosition - 9;
            if (dotScript.actualPosition > 55 && dotScript.actualPosition < 64)
            {
                possiblePositionBool = new bool[2];
                possiblePositionBool[0] = true;
                possiblePositionBool[1] = true;

                if (possiblePosition[0] > 55 && possiblePosition[0] < 64)
                {
                    possiblePositionBool[0] = false;
                }
                if (possiblePosition[1] < 48)
                {
                    possiblePositionBool[1] = false;
                }
            }
            else if (dotScript.actualPosition > 47 && dotScript.actualPosition < 55)
            {
                possiblePositionBool = new bool[2];
                possiblePositionBool[0] = true;
                possiblePositionBool[1] = true;

                if (possiblePosition[0] > 47 && possiblePosition[0] < 55)
                {
                    possiblePositionBool[0] = false;
                }
                if (possiblePosition[1] < 40)
                {
                    possiblePositionBool[1] = false;
                }
            }
            else if (dotScript.actualPosition > 39 && dotScript.actualPosition < 47)
            {
                possiblePositionBool = new bool[2];
                possiblePositionBool[0] = true;
                possiblePositionBool[1] = true;

                if (possiblePosition[0] > 39 && possiblePosition[0] < 47)
                {
                    possiblePositionBool[0] = false;
                }
                if (possiblePosition[1] < 32)
                {
                    possiblePositionBool[1] = false;
                }
            }
            else if (dotScript.actualPosition > 31 && dotScript.actualPosition < 39)
            {
                possiblePositionBool = new bool[2];
                possiblePositionBool[0] = true;
                possiblePositionBool[1] = true;

                if (possiblePosition[0] > 31 && possiblePosition[0] < 39)
                {
                    possiblePositionBool[0] = false;
                }
                if (possiblePosition[1] < 24)
                {
                    possiblePositionBool[1] = false;
                }
            }
            else if (dotScript.actualPosition > 23 && dotScript.actualPosition < 31)
            {
                possiblePositionBool = new bool[2];
                possiblePositionBool[0] = true;
                possiblePositionBool[1] = true;

                if (possiblePosition[0] > 23 && possiblePosition[0] < 31)
                {
                    possiblePositionBool[0] = false;
                }
                if (possiblePosition[1] < 16)
                {
                    possiblePositionBool[1] = false;
                }
            }
            else if (dotScript.actualPosition > 15 && dotScript.actualPosition < 23)
            {
                possiblePositionBool = new bool[2];
                possiblePositionBool[0] = true;
                possiblePositionBool[1] = true;

                if (possiblePosition[0] > 15 && possiblePosition[0] < 23)
                {
                    possiblePositionBool[0] = false;
                }
                if (possiblePosition[1] < 8)
                {
                    possiblePositionBool[1] = false;
                }
            }
            else if (dotScript.actualPosition > 7 && dotScript.actualPosition < 15)
            {
                possiblePositionBool = new bool[2];
                possiblePositionBool[0] = true;
                possiblePositionBool[1] = true;

                if (possiblePosition[0] > 7 && possiblePosition[0] < 15)
                {
                    possiblePositionBool[0] = false;
                }
                if (possiblePosition[1] < 0)
                {
                    possiblePositionBool[1] = false;
                }
            }
            else if (dotScript.actualPosition > -1 && dotScript.actualPosition < 7)
            {
                possiblePositionBool = new bool[2];
                possiblePositionBool[0] = true;
                possiblePositionBool[1] = true;

                if (possiblePosition[0] > -1 && possiblePosition[0] < 7)
                {
                    possiblePositionBool[0] = false;
                }
                possiblePositionBool[1] = false;
            }

        }
        #endregion
        SeeTheMoves();
    }

    public void SeeTheMoves()
    {
        if (possiblePositionBool[0])
        {
            HighLightObjs[possiblePosition[0]].SetActive(true);
            HighLightButtonsObjs[possiblePosition[0]].SetActive(true);
        }
        if (possiblePositionBool[1])
        {
            HighLightObjs[possiblePosition[1]].SetActive(true);
            HighLightButtonsObjs[possiblePosition[1]].SetActive(true);
        }
    }
}
