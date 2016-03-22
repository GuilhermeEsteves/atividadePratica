using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePraticaWebApi
{
    [RunInstaller(true)]
    public partial class AtividadePraticaWebApi : System.Configuration.Install.Installer
    {
        public AtividadePraticaWebApi()
        {
            InitializeComponent();
        }

        private void serviceInstaller1_AfterInstall(object sender, InstallEventArgs e)
        {

        }

        private void serviceAtividadePratica_AfterInstall(object sender, InstallEventArgs e)
        {

        }
    }
}
