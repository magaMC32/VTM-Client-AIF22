using System.Windows.Forms;

namespace VTM_Client_AIF22
{
    internal interface IModel
    {
        IView View { set; }
        IController Controller { set; }

        void DatenSenden(bool out1, bool out2);

        void DatenEmpfangen(bool in1, bool in2);

    }

}