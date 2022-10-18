using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTest : MonoBehaviour
{

    public GameObject Goal;
    public Texture Portal1, Portal2, Portal3, Portal4, Portal5, Portal6, Portal7, Portal8, Portal9, Portal10, Portal11, Portal12, Portal13, Portal14, Portal15;
    Renderer m_renderer;
    public float delay;
    public float delayleft;
    public int LoopNumber;
    // Start is called before the first frame update
    void Start()
    {
        m_renderer = GetComponent<Renderer>();
        m_renderer.material.mainTexture = Portal1;
        
        LoopNumber = 1;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Goal.GetComponent<TestCollision>().HasCollided == true)
        {

            if (delayleft == 0)
            {
                LoopNumber++;
                if (LoopNumber > 15) LoopNumber = 10;
                delayleft = delay;
            }
            else
            {
                delayleft--;
            }
            


            switch (LoopNumber)
            {
                case 1:
                    m_renderer.material.mainTexture = Portal1;
                    return;


                case 2:
                    m_renderer.material.mainTexture = Portal2;
                    return;

                case 3:
                    m_renderer.material.mainTexture = Portal3;
                    return;

                case 4:
                    m_renderer.material.mainTexture = Portal4;
                    return;

                case 5:
                    m_renderer.material.mainTexture = Portal5;
                    return;

                case 6:
                    m_renderer.material.mainTexture = Portal6;
                    return;

                case 7:
                    m_renderer.material.mainTexture = Portal7;
                    return;

                case 8:
                    m_renderer.material.mainTexture = Portal8;
                    return;

                case 9:
                    m_renderer.material.mainTexture = Portal9;
                    return;

                case 10:
                    m_renderer.material.mainTexture = Portal10;
                    return;

                case 11:
                    m_renderer.material.mainTexture = Portal11;
                    return;

                case 12:
                    m_renderer.material.mainTexture = Portal12;
                    return;

                case 13:
                    m_renderer.material.mainTexture = Portal13;
                    return;

                case 14:
                    m_renderer.material.mainTexture = Portal14;
                    return;

                case 15:
                    m_renderer.material.mainTexture = Portal15;
                    return;

                default:
                    m_renderer.material.mainTexture = Portal1;
                    return;
            }
            




        }
    }
    

    

    
}
