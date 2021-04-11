using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint standarTurret;
    public TurretBlueprint missileTurret;

    BuildManager buildManager;
       

    void Start ()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectStandardTurret()
    {

        Debug.Log("Standard Turret Selected");

        buildManager.SelectTurretToBuild(standarTurret);

    }



    public void SelectMissileLauncher()
    {
        Debug.Log("Missile Launcher Selected");
        buildManager.SelectTurretToBuild(missileTurret);


    }

}
