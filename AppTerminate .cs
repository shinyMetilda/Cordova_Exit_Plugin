using System.Windows;

namespace WPCordovaClassLib.Cordova.Commands
{
    class AppTerminate : BaseCommand
    {
        public void execute(string options)
        {
            Application.Current.Terminate();
        }
    }
}
