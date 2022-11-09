using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnFire : MonoBehaviour
{
    
    public Texture Burn1, Burn2, Burn3, Burn4, Burn5, Burn6;
    Renderer m_renderer;
    public float delay;
    public float delayleft;
    public int LoopNumber;
    // Start is called before the first frame update
    void Start()
    {
        m_renderer = GetComponent<Renderer>();
        m_renderer.material.mainTexture = Burn1;

        LoopNumber = 1;
    }

    // Update is called once per frame
    void Update()
    {


        

            if (delayleft == 0)
            {
                LoopNumber++;
                if (LoopNumber > 6) LoopNumber = 1;
                delayleft = delay;
            }
            else
            {
                delayleft--;
            }



            switch (LoopNumber)
            {
                case 1:
                    m_renderer.material.mainTexture = Burn1;
                    return;

                case 2:
                    m_renderer.material.mainTexture = Burn2;
                    return;

                case 3:
                    m_renderer.material.mainTexture = Burn3;
                    return;

                case 4:
                    m_renderer.material.mainTexture = Burn4;
                    return;

                case 5:
                    m_renderer.material.mainTexture = Burn5;
                    return;

                case 6:
                    m_renderer.material.mainTexture = Burn6;
                    return;


                default:
                    m_renderer.material.mainTexture = Burn1;
                    return;
            }



        
    }
}
