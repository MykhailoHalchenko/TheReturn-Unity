using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Actions/Help")]
public class func_help : Action
{
    public override void RespondToInput(GameController controller, string verb)
    {
        controller.currentText.text = "Type a verb followed by noun.";
        controller.currentText.text += "\nAllowed verbs:\nGo, Examine, Get, Use, Inventory, TalkTo, Say, Help";
    }
}
