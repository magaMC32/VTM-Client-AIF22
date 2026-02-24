using System.Windows.Forms;

namespace VTM_Client_AIF22
{
    internal interface IModel
    {
        IView View { set; }
        IController Controller { set; }

    }
}