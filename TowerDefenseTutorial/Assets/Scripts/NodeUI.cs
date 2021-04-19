using UnityEngine;
using UnityEngine.UI;
public class NodeUI : MonoBehaviour
{
    public GameObject ui;

    public Text upgradeCost;
    public Text sellAmount;
    public Button upgradeButton;
    public Button sellButton;

    private Node target;

    public void SetTarget(Node _target)
    {
        target = _target;

        transform.position = target.GetBuildPosition();

        if (!target.isUpgraded)
        {
            upgradeCost.text = "$" + target.turretBlueprint.upgradeCost;
            sellAmount.text = "$" + target.turretBlueprint.GetCostAmount();
            upgradeButton.interactable = true;
        }else
        {
            upgradeCost.text = "MAX";
            sellAmount.text = "$" + target.turretBlueprint.GetCostAmountUpgraded();
            upgradeButton.interactable = false;
        }



        ui.SetActive(true);
    }


    public void Hide()
    {
        ui.SetActive(false);

    }

    public void Upgrade()
    {
        target.UpgradeTurret();
        BuildManager.instance.DeselectNode();
    }

    public void Sell()
    {
        target.SellTurret();
        BuildManager.instance.DeselectNode();
    }


}
