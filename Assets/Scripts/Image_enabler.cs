using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Image_enabler : MonoBehaviour {
	public GameObject beanImg;
	public GameObject lacisImg;
	public GameObject omeImg;
	public GameObject masinaImg;
    public GameObject SusImg;
    public GameObject paKreisiPoga;
    public GameObject paLabiPoga;
    public GameObject VariableImg;
    public Sprite[] ImgMas;
	private bool vertiba;

    public void dropdown(int skaitlis)
    {
        switch(skaitlis)
        {
            case 0:
                VariableImg.GetComponent<Image>().sprite = ImgMas[0];
                break;

            case 1:
                VariableImg.GetComponent<Image>().sprite = ImgMas[1];
                break;

            case 2:
                VariableImg.GetComponent<Image>().sprite = ImgMas[2];
                break;

            default:
                VariableImg.GetComponent<Image>().sprite = ImgMas[skaitlis];
                break;
        }
    }
	
	public void BeanImgOnOff(bool vertiba)
	{
		beanImg.SetActive(vertiba);
        paKreisiPoga.GetComponent<Toggle>().interactable= vertiba;
        paLabiPoga.GetComponent <Toggle>().interactable= vertiba;
	}

    public void paKreisiBean()
    {
        beanImg.transform.localScale =new Vector2(2, 2);
    }

    public void paLabiBean()
    {
        beanImg.transform.localScale=new Vector2(-2, 2);
    }
    public void LacisImgOnOff(bool vertiba)
    {
        lacisImg.SetActive(vertiba);
    }
    public void OmeImgOnOff(bool vertiba)
    {
        omeImg.SetActive(vertiba);
    }
    public void MasinaImgOnOff(bool vertiba)
    {
        masinaImg.SetActive(vertiba);
    }
    public void SusImgOnOff(bool vertiba)
    {
        SusImg.SetActive(vertiba);
    }
}
