using UnityEngine;
using UnityEngine.EventSystems;
public class Node : MonoBehaviour
{
    public Color hoverColor;
    public Color notEnoughMoneyColer;
    public Vector3 positionOffset;

    [Header("Optional")]
    public GameObject turret;

   
    private Renderer rend;
    private Color startColor;
    

    BuildManager buildManager;

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;

        buildManager = BuildManager.instance;
    }

    public Vector3 GetBuildPosition()
    {
        return transform.position + positionOffset;
    }

    void OnMouseDown()
    {
        if (!buildManager.CanBuild)
            return;

        if (turret != null)
        {

            Debug.Log("Can't build there! - ToDo :Display on screen.");
            return;
        }
        //Build a turret

        buildManager.BuildTurretOn(this);

    }



    void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (!buildManager.CanBuild)            
            return;

        if (buildManager.HasMoney)
        {
            rend.material.color = hoverColor;
        }
        else
        {
            rend.material.color = notEnoughMoneyColer;
        }
    }

    void OnMouseExit()
    {
            rend.material.color = startColor;
    }



}
