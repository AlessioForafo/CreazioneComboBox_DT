#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.UI;
using FTOptix.NativeUI;
using FTOptix.HMIProject;
using FTOptix.Retentivity;
using FTOptix.CoreBase;
using FTOptix.Core;
using FTOptix.NetLogic;
#endregion

public class CreaComboBox : BaseNetLogic
{
    [ExportMethod]
    public void CreaComboMainWindow()
    {
        // Insert code to be executed by the method
        var miaCombo = InformationModel.Make<ComboBox>("Combobox1");
        miaCombo.Model = Project.Current.Get("Model").NodeId;
        miaCombo.DisplayValuePathVariable.SetDynamicLink(miaCombo.ModelVariable, DynamicLinkMode.ReadWrite);
        miaCombo.Width = 100;
        miaCombo.DisplayValuePathVariable.GetVariable("DynamicLink").Value = "{Item}@BrowseName";
        Project.Current.Get("UI/MainWindow").Add(miaCombo);
    }
}
